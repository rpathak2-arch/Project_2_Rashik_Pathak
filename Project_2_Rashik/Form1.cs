namespace Project_2_Rashik
{
    public partial class Form1 : Form
    {
       
       
        private readonly string menuPath = Path.Combine(AppContext.BaseDirectory, "Menu.txt");
        private readonly string historyPath = Path.Combine(AppContext.BaseDirectory, "OrderHistory.txt");

       
        private Dictionary<string, MenuProduct> menu = new Dictionary<string, MenuProduct>();

        private List<OrderLine> currentOrder = new List<OrderLine>();

        private List<string> orderHistory = new List<string>();

        //  total sales per category this session (disc)
        private Dictionary<Category, decimal> salesByCategory = new Dictionary<Category, decimal>();

       //only when custgomer puts name 
       //right now empty names
        private string customerName = "";


        private readonly MenuProduct[] defaultMenu =
        {
            new MenuProduct("Espresso", Category.Coffee, 3.00m),
            new MenuProduct("Latte", Category.Coffee, 4.25m),
            new MenuProduct("Green Tea", Category.Tea, 2.75m),
            new MenuProduct("Croissant", Category.Pastry, 3.25m),
            new MenuProduct("Turkey Sandwich", Category.Sandwich, 6.50m)
        };

        private const decimal ExtraShotPrice = 0.75m;
        private const decimal WhippedCreamPrice = 0.50m;
        private const decimal OatMilkPrice = 0.60m;

        public Form1()
        {
            InitializeComponent();
        }

//FILE HANDLING

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start every category at $0 using the enum values
            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                salesByCategory[category] = 0m;
            }

            LoadMenu();
            LoadHistory();
            UpdateRunningTotal();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                File.WriteAllLines(historyPath, orderHistory);
            }
            catch (IOException)
            {
                MessageBox.Show("Could not save the order history.", "Save Error");
            }
        }

        // Reads Menu.txt (Name,Category,Price) into the dictionary and combo box
        private void LoadMenu()
        {
            menu.Clear();
            cboMenu.Items.Clear();

            if (!File.Exists(menuPath))
            {
                MessageBox.Show(
                    "Menu.txt was not found. Using the default menu.",
                    "File Not Found");

                foreach (MenuProduct product in defaultMenu)
                {
                    AddMenuProduct(product);
                }
                return;
            }

            foreach (string line in File.ReadAllLines(menuPath))
            {
                string[] parts = line.Split(',');

                if (parts.Length != 3)
                    continue;   // skip blank or malformed lines

                if (Enum.TryParse(parts[1].Trim(), out Category category) &&
                    decimal.TryParse(parts[2].Trim(), out decimal price))
                {
                    try
                    {
                       
                        AddMenuProduct(new MenuProduct(parts[0].Trim(), category, price));
                    }
                    catch (ArgumentException)
                    {
                        // Bad line in the file (empty name or negative price): skip it..
                    }
                }
            }
        }

        private void AddMenuProduct(MenuProduct product)
        {
            if (menu.ContainsKey(product.Name))
                return;   // avoid duplicate names

            menu[product.Name] = product;
            cboMenu.Items.Add(product.Name);
        }

        private void LoadHistory()
        {
            if (!File.Exists(historyPath))
                return;

            foreach (string line in File.ReadAllLines(historyPath))
            {
                if (line.Trim() != "")
                {
                    orderHistory.Add(line);
                    lstHistory.Items.Add(line);
                }
            }
        }

        private void btnDisplayName_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            if (firstName == "" || lastName == "")
            {
                MessageBox.Show("Please enter a first and last name.", "Missing Name");
                return;
            }

            customerName = firstName + " " + lastName;
            lblCustomerName.Text = "Customer: " + customerName;
        }

        private void cboMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true;
            btnAddItem.PerformClick();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cboMenu.SelectedItem == null)
            {
                MessageBox.Show("Please select a menu item first.", "No Item Selected");
                return;
            }

            string itemName = cboMenu.SelectedItem.ToString() ?? "";
            MenuProduct product = menu[itemName];
            CupSize size = GetSelectedSize();
            int quantity = (int)nudQuantity.Value;

          
            currentOrder.Add(new OrderLine(product, size, quantity));

            RefreshOrderList();
            nudQuantity.Value = 1;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to remove.", "No Item Selected");
                return;
            }

            currentOrder.RemoveAt(lstOrder.SelectedIndex);
            RefreshOrderList();
        }

        private CupSize GetSelectedSize()
        {
            if (rdoSmall.Checked) return CupSize.Small;
            if (rdoLarge.Checked) return CupSize.Large;
            return CupSize.Medium;
        }

        // Rebuilds the ListBox from the List
        private void RefreshOrderList()
        {
            lstOrder.Items.Clear();

            foreach (OrderLine line in currentOrder)
            {
                lstOrder.Items.Add(line.ToString());
            }

            UpdateRunningTotal();
        }

        private decimal GetItemsTotal()
        {
            decimal total = 0m;

            foreach (OrderLine line in currentOrder)
            {
                total += line.LineTotal;
            }

            return total;
        }

        private void UpdateRunningTotal()
        {
            lblRunningTotal.Text = $"Items Total: ${GetItemsTotal():F2}";
        }

        // Submit (checkout)

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (customerName == "")
            {
                MessageBox.Show("Please enter and display the customer name first.", "Missing Name");
                return;
            }

            if (currentOrder.Count == 0)
            {
                MessageBox.Show("Your order is empty.", "Empty Order");
                return;
            }

            decimal itemsTotal = GetItemsTotal();

            // Extras
            decimal extrasTotal = 0m;
            string extras = "";

            if (chkExtraShot.Checked)
            {
                extrasTotal += ExtraShotPrice;
                extras += "Extra Shot - $0.75\n";
            }
            if (chkWhippedCream.Checked)
            {
                extrasTotal += WhippedCreamPrice;
                extras += "Whipped Cream - $0.50\n";
            }
            if (chkOatMilk.Checked)
            {
                extrasTotal += OatMilkPrice;
                extras += "Oat Milk - $0.60\n";
            }

            // Service type / delivery fee
            decimal beforeFee = itemsTotal + extrasTotal;
            decimal deliveryFee = 0m;
            string serviceType = "Dine In";

            if (rdoDelivery.Checked)
            {
                serviceType = "Delivery";
                deliveryFee = 3.00m;
            }
            else if (rdoFreeDelivery.Checked)
            {
                if (beforeFee > 20.00m)
                {
                    serviceType = "Free Delivery";
                }
                else
                {
                    MessageBox.Show(
                        "Free delivery is only available for orders over $20.",
                        "Delivery");
                    return;
                }
            }

            // Promo code
            decimal subtotal = beforeFee + deliveryFee;
            decimal discount = 0m;

            if (txtPromo.Text.Trim().ToUpper() == "PROJECT2")
            {
                discount = subtotal * 0.10m;
            }

            decimal total = subtotal - discount;

           //the confirmation summary
            string summary = "ORDER SUMMARY\n========================\n\n";
            summary += "Customer: " + customerName + "\n\nItems:\n";

            foreach (OrderLine line in currentOrder)
            {
                summary += line + "\n";
            }

            summary += "\nExtras:\n" + (extras == "" ? "None\n" : extras);
            summary += "\nService: " + serviceType + "\n";
            summary += "\n------------------------\n";
            summary += $"Items Total: ${itemsTotal:F2}\n";
            summary += $"Extras Total: ${extrasTotal:F2}\n";
            summary += $"Delivery: ${deliveryFee:F2}\n";
            summary += $"Promo Discount: -${discount:F2}\n";
            summary += $"Total Cost: ${total:F2}\n\n";
            summary += "Is this your final order?";

            DialogResult result = MessageBox.Show(
                summary,
                "Order Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //dd each line's total to its category
                foreach (OrderLine line in currentOrder)
                {
                    salesByCategory[line.Item.Category] += line.LineTotal;
                }

                string historyLine = $"{DateTime.Now:g} | {customerName} | ${total:F2}";
                orderHistory.Add(historyLine);
                lstHistory.Items.Add(historyLine);

                ResetForm();
                MessageBox.Show("Thank you for your order!", "Order Complete");
            }
        }

        //Sales report and About

        private void btnShowSales_Click(object sender, EventArgs e)
        {
            string report = "SALES BY CATEGORY (this session)\n\n";

            foreach (KeyValuePair<Category, decimal> pair in salesByCategory)
            {
                report += $"{pair.Key}: ${pair.Value:F2}\n";
            }

            MessageBox.Show(report, "Sales Report");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "UCO Caf\u00e9 serves fresh coffee, tea, pastries, and sandwiches. " +
                "Use promo code PROJECT2 for 10% off your order.",
                "About Us");
        }


        private void ResetForm()
        {
            currentOrder.Clear();
            RefreshOrderList();

            customerName = "";
            txtFirstName.Clear();
            txtLastName.Clear();
            lblCustomerName.Text = "Customer: (not set)";

            cboMenu.SelectedIndex = -1;
            nudQuantity.Value = 1;
            rdoMedium.Checked = true;

            chkExtraShot.Checked = false;
            chkWhippedCream.Checked = false;
            chkOatMilk.Checked = false;

            rdoDineIn.Checked = true;
            txtPromo.Clear();
        }
    }
}