#nullable disable
namespace Project_2_Rashik
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            btnDisplayName = new Button();
            lblCustomerName = new Label();
            lblMenu = new Label();
            cboMenu = new ComboBox();
            lblQty = new Label();
            nudQuantity = new NumericUpDown();
            btnAddItem = new Button();
            grpSize = new GroupBox();
            rdoSmall = new RadioButton();
            rdoMedium = new RadioButton();
            rdoLarge = new RadioButton();
            grpExtras = new GroupBox();
            chkExtraShot = new CheckBox();
            chkWhippedCream = new CheckBox();
            chkOatMilk = new CheckBox();
            grpService = new GroupBox();
            rdoDineIn = new RadioButton();
            rdoDelivery = new RadioButton();
            rdoFreeDelivery = new RadioButton();
            lblPromo = new Label();
            txtPromo = new TextBox();
            lblOrder = new Label();
            lstOrder = new ListBox();
            btnRemoveItem = new Button();
            lblRunningTotal = new Label();
            lblHistory = new Label();
            lstHistory = new ListBox();
            btnSubmit = new Button();
            btnShowSales = new Button();
            btnAbout = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            grpSize.SuspendLayout();
            grpExtras.SuspendLayout();
            grpService.SuspendLayout();
            SuspendLayout();
            //
            // lblFirstName
            //
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(15, 19);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First name:";
            //
            // txtFirstName
            //
            txtFirstName.Location = new Point(85, 15);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(105, 23);
            txtFirstName.TabIndex = 1;
            //
            // lblLastName
            //
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(203, 19);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last name:";
            //
            // txtLastName
            //
            txtLastName.Location = new Point(272, 15);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(105, 23);
            txtLastName.TabIndex = 3;
            //
            // btnDisplayName
            //
            btnDisplayName.Location = new Point(390, 13);
            btnDisplayName.Name = "btnDisplayName";
            btnDisplayName.Size = new Size(105, 27);
            btnDisplayName.TabIndex = 4;
            btnDisplayName.Text = "Display name";
            btnDisplayName.UseVisualStyleBackColor = true;
            btnDisplayName.Click += btnDisplayName_Click;
            //
            // lblCustomerName
            //
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerName.Location = new Point(515, 19);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(122, 15);
            lblCustomerName.TabIndex = 5;
            lblCustomerName.Text = "Customer: (not set)";
            //
            // lblMenu
            //
            lblMenu.AutoSize = true;
            lblMenu.Location = new Point(15, 65);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(64, 15);
            lblMenu.TabIndex = 6;
            lblMenu.Text = "Menu item:";
            //
            // cboMenu
            //
            cboMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMenu.FormattingEnabled = true;
            cboMenu.Location = new Point(90, 61);
            cboMenu.Name = "cboMenu";
            cboMenu.Size = new Size(190, 23);
            cboMenu.Sorted = true;
            cboMenu.TabIndex = 7;
            cboMenu.KeyDown += cboMenu_KeyDown;
            //
            // lblQty
            //
            lblQty.AutoSize = true;
            lblQty.Location = new Point(295, 65);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(28, 15);
            lblQty.TabIndex = 8;
            lblQty.Text = "Qty:";
            //
            // nudQuantity
            //
            nudQuantity.Location = new Point(328, 61);
            nudQuantity.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(60, 23);
            nudQuantity.TabIndex = 9;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // btnAddItem
            //
            btnAddItem.Location = new Point(15, 95);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(373, 30);
            btnAddItem.TabIndex = 10;
            btnAddItem.Text = "Add to order";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            //
            // grpSize
            //
            grpSize.Controls.Add(rdoSmall);
            grpSize.Controls.Add(rdoMedium);
            grpSize.Controls.Add(rdoLarge);
            grpSize.Location = new Point(15, 138);
            grpSize.Name = "grpSize";
            grpSize.Size = new Size(373, 55);
            grpSize.TabIndex = 11;
            grpSize.TabStop = false;
            grpSize.Text = "Size (drinks only: Medium +$0.50, Large +$1.00)";
            //
            // rdoSmall
            //
            rdoSmall.AutoSize = true;
            rdoSmall.Location = new Point(15, 24);
            rdoSmall.Name = "rdoSmall";
            rdoSmall.Size = new Size(56, 19);
            rdoSmall.TabIndex = 0;
            rdoSmall.Text = "Small";
            rdoSmall.UseVisualStyleBackColor = true;
            //
            // rdoMedium
            //
            rdoMedium.AutoSize = true;
            rdoMedium.Checked = true;
            rdoMedium.Location = new Point(135, 24);
            rdoMedium.Name = "rdoMedium";
            rdoMedium.Size = new Size(69, 19);
            rdoMedium.TabIndex = 1;
            rdoMedium.TabStop = true;
            rdoMedium.Text = "Medium";
            rdoMedium.UseVisualStyleBackColor = true;
            //
            // rdoLarge
            //
            rdoLarge.AutoSize = true;
            rdoLarge.Location = new Point(255, 24);
            rdoLarge.Name = "rdoLarge";
            rdoLarge.Size = new Size(55, 19);
            rdoLarge.TabIndex = 2;
            rdoLarge.Text = "Large";
            rdoLarge.UseVisualStyleBackColor = true;
            //
            // grpExtras
            //
            grpExtras.Controls.Add(chkExtraShot);
            grpExtras.Controls.Add(chkWhippedCream);
            grpExtras.Controls.Add(chkOatMilk);
            grpExtras.Location = new Point(15, 203);
            grpExtras.Name = "grpExtras";
            grpExtras.Size = new Size(373, 105);
            grpExtras.TabIndex = 12;
            grpExtras.TabStop = false;
            grpExtras.Text = "Extras";
            //
            // chkExtraShot
            //
            chkExtraShot.AutoSize = true;
            chkExtraShot.Location = new Point(15, 24);
            chkExtraShot.Name = "chkExtraShot";
            chkExtraShot.Size = new Size(130, 19);
            chkExtraShot.TabIndex = 0;
            chkExtraShot.Text = "Extra shot (+$0.75)";
            chkExtraShot.UseVisualStyleBackColor = true;
            //
            // chkWhippedCream
            //
            chkWhippedCream.AutoSize = true;
            chkWhippedCream.Location = new Point(15, 49);
            chkWhippedCream.Name = "chkWhippedCream";
            chkWhippedCream.Size = new Size(160, 19);
            chkWhippedCream.TabIndex = 1;
            chkWhippedCream.Text = "Whipped cream (+$0.50)";
            chkWhippedCream.UseVisualStyleBackColor = true;
            //
            // chkOatMilk
            //
            chkOatMilk.AutoSize = true;
            chkOatMilk.Location = new Point(15, 74);
            chkOatMilk.Name = "chkOatMilk";
            chkOatMilk.Size = new Size(125, 19);
            chkOatMilk.TabIndex = 2;
            chkOatMilk.Text = "Oat milk (+$0.60)";
            chkOatMilk.UseVisualStyleBackColor = true;
            //
            // grpService
            //
            grpService.Controls.Add(rdoDineIn);
            grpService.Controls.Add(rdoDelivery);
            grpService.Controls.Add(rdoFreeDelivery);
            grpService.Location = new Point(15, 318);
            grpService.Name = "grpService";
            grpService.Size = new Size(373, 105);
            grpService.TabIndex = 13;
            grpService.TabStop = false;
            grpService.Text = "Service";
            //
            // rdoDineIn
            //
            rdoDineIn.AutoSize = true;
            rdoDineIn.Checked = true;
            rdoDineIn.Location = new Point(15, 24);
            rdoDineIn.Name = "rdoDineIn";
            rdoDineIn.Size = new Size(65, 19);
            rdoDineIn.TabIndex = 0;
            rdoDineIn.TabStop = true;
            rdoDineIn.Text = "Dine in";
            rdoDineIn.UseVisualStyleBackColor = true;
            //
            // rdoDelivery
            //
            rdoDelivery.AutoSize = true;
            rdoDelivery.Location = new Point(15, 49);
            rdoDelivery.Name = "rdoDelivery";
            rdoDelivery.Size = new Size(116, 19);
            rdoDelivery.TabIndex = 1;
            rdoDelivery.Text = "Delivery ($3.00)";
            rdoDelivery.UseVisualStyleBackColor = true;
            //
            // rdoFreeDelivery
            //
            rdoFreeDelivery.AutoSize = true;
            rdoFreeDelivery.Location = new Point(15, 74);
            rdoFreeDelivery.Name = "rdoFreeDelivery";
            rdoFreeDelivery.Size = new Size(165, 19);
            rdoFreeDelivery.TabIndex = 2;
            rdoFreeDelivery.Text = "Free delivery (over $20)";
            rdoFreeDelivery.UseVisualStyleBackColor = true;
            //
            // lblPromo
            //
            lblPromo.AutoSize = true;
            lblPromo.Location = new Point(15, 447);
            lblPromo.Name = "lblPromo";
            lblPromo.Size = new Size(70, 15);
            lblPromo.TabIndex = 14;
            lblPromo.Text = "Promo code:";
            //
            // txtPromo
            //
            txtPromo.Location = new Point(95, 443);
            txtPromo.Name = "txtPromo";
            txtPromo.Size = new Size(120, 23);
            txtPromo.TabIndex = 15;
            //
            // lblOrder
            //
            lblOrder.AutoSize = true;
            lblOrder.Location = new Point(415, 65);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(78, 15);
            lblOrder.TabIndex = 16;
            lblOrder.Text = "Current order:";
            //
            // lstOrder
            //
            lstOrder.FormattingEnabled = true;
            lstOrder.IntegralHeight = false;
            lstOrder.ItemHeight = 15;
            lstOrder.Location = new Point(415, 85);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(370, 160);
            lstOrder.TabIndex = 17;
            //
            // btnRemoveItem
            //
            btnRemoveItem.Location = new Point(415, 253);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(130, 28);
            btnRemoveItem.TabIndex = 18;
            btnRemoveItem.Text = "Remove selected";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            //
            // lblRunningTotal
            //
            lblRunningTotal.AutoSize = true;
            lblRunningTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRunningTotal.Location = new Point(620, 259);
            lblRunningTotal.Name = "lblRunningTotal";
            lblRunningTotal.Size = new Size(112, 15);
            lblRunningTotal.TabIndex = 19;
            lblRunningTotal.Text = "Items Total: $0.00";
            //
            // lblHistory
            //
            lblHistory.AutoSize = true;
            lblHistory.Location = new Point(415, 298);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(66, 15);
            lblHistory.TabIndex = 20;
            lblHistory.Text = "Past orders:";
            //
            // lstHistory
            //
            lstHistory.FormattingEnabled = true;
            lstHistory.HorizontalScrollbar = true;
            lstHistory.IntegralHeight = false;
            lstHistory.ItemHeight = 15;
            lstHistory.Location = new Point(415, 318);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(370, 105);
            lstHistory.TabIndex = 21;
            //
            // btnSubmit
            //
            btnSubmit.Location = new Point(415, 438);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(125, 32);
            btnSubmit.TabIndex = 22;
            btnSubmit.Text = "Submit order";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            //
            // btnShowSales
            //
            btnShowSales.Location = new Point(550, 438);
            btnShowSales.Name = "btnShowSales";
            btnShowSales.Size = new Size(115, 32);
            btnShowSales.TabIndex = 23;
            btnShowSales.Text = "Sales report";
            btnShowSales.UseVisualStyleBackColor = true;
            btnShowSales.Click += btnShowSales_Click;
            //
            // btnAbout
            //
            btnAbout.Location = new Point(675, 438);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(110, 32);
            btnAbout.TabIndex = 24;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(btnDisplayName);
            Controls.Add(lblCustomerName);
            Controls.Add(lblMenu);
            Controls.Add(cboMenu);
            Controls.Add(lblQty);
            Controls.Add(nudQuantity);
            Controls.Add(btnAddItem);
            Controls.Add(grpSize);
            Controls.Add(grpExtras);
            Controls.Add(grpService);
            Controls.Add(lblPromo);
            Controls.Add(txtPromo);
            Controls.Add(lblOrder);
            Controls.Add(lstOrder);
            Controls.Add(btnRemoveItem);
            Controls.Add(lblRunningTotal);
            Controls.Add(lblHistory);
            Controls.Add(lstHistory);
            Controls.Add(btnSubmit);
            Controls.Add(btnShowSales);
            Controls.Add(btnAbout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UCO Caf\u00e9";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            grpSize.ResumeLayout(false);
            grpSize.PerformLayout();
            grpExtras.ResumeLayout(false);
            grpExtras.PerformLayout();
            grpService.ResumeLayout(false);
            grpService.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Button btnDisplayName;
        private Label lblCustomerName;
        private Label lblMenu;
        private ComboBox cboMenu;
        private Label lblQty;
        private NumericUpDown nudQuantity;
        private Button btnAddItem;
        private GroupBox grpSize;
        private RadioButton rdoSmall;
        private RadioButton rdoMedium;
        private RadioButton rdoLarge;
        private GroupBox grpExtras;
        private CheckBox chkExtraShot;
        private CheckBox chkWhippedCream;
        private CheckBox chkOatMilk;
        private GroupBox grpService;
        private RadioButton rdoDineIn;
        private RadioButton rdoDelivery;
        private RadioButton rdoFreeDelivery;
        private Label lblPromo;
        private TextBox txtPromo;
        private Label lblOrder;
        private ListBox lstOrder;
        private Button btnRemoveItem;
        private Label lblRunningTotal;
        private Label lblHistory;
        private ListBox lstHistory;
        private Button btnSubmit;
        private Button btnShowSales;
        private Button btnAbout;
    }
}