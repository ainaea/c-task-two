namespace InvoiceTest
{
    public class Invoice
    {
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        private int quantity;  //Instance variable
        private decimal price;  //Instance variable

        public Invoice(string pNum, string pDes, int quantity, decimal price)
        {
            PartNumber = pNum;
            PartDescription = pDes;
            Quantity = quantity;
            Price = price;

        }

        public int Quantity
        {
            get { return quantity; }
            private set { 
                if (value > 0.0M)
                {
                    quantity = value;
                }
             }
        }

        public decimal Price
        {
            get { return price; }
            private set { 
                if (value > 0.0M)
                {
                    price = value;
                }
             }
        }

        public decimal GetInvoiceAmount()
        {
            return Price * Quantity;
        }


    }
}