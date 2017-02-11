using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop
{
    class SessionI
    {
        public static void Main()
        {
            //1.
            //double[] avaliableCents = new double[] { 1, 0.5, 0.2, 0.1, 0.05 };
            //string[] centNames = new string[] {"100-cent coin", "50-cent coin", "20-cent coin", "10-cent coin", "5-cent coin" };
            //Console.Write("Enter an amount: ");
            //double amount = Convert.ToDouble(Console.ReadLine());
            //int[] dispensableCents = new int[avaliableCents.Length];

            //for (int i = 0; i < avaliableCents.Length; i++)
            //{
            //    while (amount - avaliableCents[i] >= 0)                 // giving larger coins as long as it can
            //    {
            //        amount = Math.Round(amount - avaliableCents[i], 2);
            //        dispensableCents[i] += 1;
            //    }
            //}

            //Console.WriteLine("The coin(s) to be dispensed will be:_ ");
            //for (int i = 0; i < dispensableCents.Length; i++)
            //{
            //    if (dispensableCents[i] != 0)
            //    {
            //        Console.WriteLine("{0} {1}(s)", dispensableCents[i], centNames[i]);
            //    }
            //}
            //------------------------------------------------------------------------------

            //2.
            int[] intArr = new int[10];

            var rdn = new Random();
            for (int i = 0; i < 50; i++)
            {
                int rdnNumber = rdn.Next(0,10);
                intArr[rdnNumber] += 1;
            }

            Console.WriteLine("Number\t\tCount");
            for (int i = 0; i < intArr.Length; i++)
            {
                
                Console.WriteLine("{0}\t\t{1}", i, intArr[i]);
            }
            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("Number");
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write("{0}\t\t", intArr[i]);
                for (int j = 0; j < intArr[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
