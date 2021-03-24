using System;

namespace DateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Date firstDate = new Date(12, 3, 2021);
            Console.WriteLine(firstDate.DisplayDate());
        }
    }
}
