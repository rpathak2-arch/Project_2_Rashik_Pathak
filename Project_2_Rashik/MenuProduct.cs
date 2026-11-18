namespace Project_2_Rashik
{
    // Enum ensures there is  fixed set of menu categories
    public enum Category { Coffee, Tea, Pastry, Sandwich }

    //fixed set of drink sizes (its int value indexes the surcharge array below)
    public enum CupSize { Small, Medium, Large }

    // ENCAPSULATION: the data is kept private inside the class.
    // Other code can only reach it through properties and methods,
    // and the properties check the values before accepting them.
    public class MenuProduct
    {
        //extra charge per size, indexed by (int)CupSize -> Small, Medium, Large
        private static readonly decimal[] sizeSurcharge = { 0.00m, 0.50m, 1.00m };

        // these are private bewtwen the class
        // //nothing outside this class can touch these directly
        private string name = "";
        private decimal basePrice;

        // Read-only: can be set in the constructor but never changed afterwards
        public Category Category { get; }

        public MenuProduct(string name, Category category, decimal basePrice)
        {
            Name = name;              // goes through the property, so it is validated
            Category = category;
            BasePrice = basePrice;    //validated
        }

        // Property with validation: an empty name is rejected
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");

                name = value.Trim();
            }
        }

        // property with validatio, a negative price is rejected here
        public decimal BasePrice
        {
            get { return basePrice; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");

                basePrice = value;
            }
        }

        //since only coffee and tea come in sizes
        public bool IsDrink()
        {
            return Category == Category.Coffee || Category == Category.Tea;
        }

        //he price rule lives inside the class, so the form does not need to know it
        public decimal GetPrice(CupSize size)
        {
            if (IsDrink())
                return BasePrice + sizeSurcharge[(int)size];

            return BasePrice;
        }
    }
}