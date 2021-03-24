using System;

namespace InvoiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice("D4-D", "Injector", 2, 2300M);
            Invoice invoice2 = new Invoice("D4-S", "Injector", -3, 2500M);

            Console.WriteLine($"Current quantity is {invoice1.Quantity}");
            Console.WriteLine($"Current price is {invoice2.Price}");
            Console.WriteLine($"Current invoice amount is {invoice1.GetInvoiceAmount():C}");

            // Console.WriteLine("Good morning");

        }
    }
}
