namespace Project_2_Rashik
{
    
    public class OrderLine
    {
       
        private int quantity;

        // set once in the constructor
        public MenuProduct Item { get; }
        public CupSize Size { get; }

        //  the quantity is checked before it is stored // encapsulation
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(nameof(value), "Quantity must be at least 1.");

                quantity = value;
            }
        }

        public OrderLine(MenuProduct item, CupSize size, int quantity)
        {
            Item = item;
            Size = size;
            Quantity = quantity;      // validated through the property
        }

        // calculated propertie -  no stored copy that could get out of date
        public decimal UnitPrice
        {
            get { return Item.GetPrice(Size); }
        }

        public decimal LineTotal
        {
            get { return UnitPrice * Quantity; }
        }

        // Text shown in the order ListBox
        public override string ToString()
        {
            string sizeText = Item.IsDrink() ? " (" + Size + ")" : "";
            return $"{Quantity} x {Item.Name}{sizeText} - ${LineTotal:F2}";
        }
    }
}