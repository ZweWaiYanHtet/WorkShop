using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop
{
    class SessionE
    {
        public static void Main()
        {
            //1.a
            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int ans = 1;
            //for (int i = 1; i <= num; i++)
            //{
            //    ans *= i;
            //}
            //Console.WriteLine("The factorial is {0}", ans);
            //-------------------------------------------------

            //1.b
            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int ans = 1;
            //for (int i = num; i > 1; i--)
            //{
            //    ans *= i;
            //}
            //Console.WriteLine("The factorial is {0}", ans);
            //-------------------------------------------------

            //2.
            //Console.WriteLine("NO\t\t\tINVERSE\t\t\tSQUARE ROOT\t\tSQUARE");
            //Console.WriteLine("---------------------------------------------------------------------------------------");
            //for (double i = 1; i <= 10; i++)
            //{
            //    Console.Write("{0:0.0##}\t\t\t",i);
            //    Console.Write("{0:0.0##}\t\t\t", 1/i);
            //    Console.Write("{0:0.0##}\t\t\t", Math.Sqrt(i));
            //    Console.WriteLine("{0:0.0##}", Math.Pow(i,2));
            //}
            //-------------------------------------------------

            //3.
            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //bool foundAFactor = false;

            //for (int i = 2; i < num; i++)
            //{
            //    if(num % i == 0)
            //    {
            //        foundAFactor = true;
            //        break;
            //    }
            //}

            //if (foundAFactor)
            //{
            //    Console.WriteLine("Not Prime");
            //}
            //else
            //{
            //    Console.WriteLine("Prime");
            //}
            //-------------------------------------------------

            //4
            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int sumOfFactors = 0;
            //for (int i = 1; i < num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        sumOfFactors += i;
            //    }
            //}

            //if (sumOfFactors == num)
            //{
            //    Console.WriteLine("Perfect Number");
            //}
            //else
            //{
            //    Console.WriteLine("Not A Perfect Number");
            //}
            //-------------------------------------------------

            //5.
            //bool foundAFactor = false;
            //for (int i = 5; i <= 10000; i++)
            //{
            //    foundAFactor = false;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            foundAFactor = true;
            //            break;
            //        }
            //    }

            //    if (!foundAFactor)
            //    {
            //        Console.WriteLine("{0}\t is a prime number.", i);
            //    }
            //}
            //-------------------------------------------------

            //6.
            //int sumOfFactors = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    sumOfFactors = 0;
            //    for (int j = 1; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            sumOfFactors += j;
            //        }
            //    }

            //    if (sumOfFactors == i)
            //    {
            //        Console.WriteLine("{0}\t is a perfect number", i);
            //    }
            //}

        }
    }
}
