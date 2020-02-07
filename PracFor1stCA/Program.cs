using System;

namespace PracFor1stCA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("are you male or female? ");
            string gender = Console.ReadLine();
            Console.WriteLine("what are there ages");
            int ages = int.Parse(Console.ReadLine());
            int calQuote = 0;
            int printSta = 0;
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Calculate Quote");
            Console.WriteLine("2) Print Statistic");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    calQuote = 1;
                    break;
                case "2":
                    printSta = 1;
                    break;
                case "3":
                    
                    break;
                default:
                    break;
            }
            while (calQuote == 1 || printSta == 1)
            {
                if (calQuote == 1)
                {

                }
                if (printSta == 1)
                {

                }
            }
            if ()
            
        }
    }
}
