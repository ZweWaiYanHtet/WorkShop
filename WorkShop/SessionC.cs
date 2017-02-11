using System;


namespace WorkShop
{
    class SessionC
    {
        public static void Main()
        {
            //1.
            //Console.Write("Enter Your Name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter Your Gender(M or F) :");
            //string gender = Console.ReadLine();

            //if(gender == "M")
            //{
            //    Console.WriteLine("Good Morning Mr. {0}", name);
            //}
            //else
            //{
            //    Console.WriteLine("Good Morning Mrs. {0}", name);
            //}
            //-------------------------------------------------

            //2.
            //Console.Write("Enter Your Name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter Your Gender(M or F) :");
            //string gender = Console.ReadLine();
            //Console.Write("Enter Your Age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if (gender == "M")
            //{
            //    if(age < 40)
            //    {
            //        Console.WriteLine("Good Morning Mr. {0}", name);
            //    } else
            //    {
            //        Console.WriteLine("Good Morning Uncle {0}", name);
            //    }
            //}
            //else
            //{
            //    if(age < 40)
            //    {
            //        Console.WriteLine("Good Morning Mrs. {0}", name);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Good Morning Aunty {0}", name);
            //    }
            //}
            //-------------------------------------------------

            //3.
            //Console.Write("Enter marks: ");
            //int mark = Convert.ToInt32(Console.ReadLine());
            //if (mark > 100)
            //{
            //    Console.WriteLine("**Error**");
            //}
            //else if (mark >= 80)
            //{
            //    Console.WriteLine("Your scored {0} marks which is A grade.", mark);
            //}
            //else if (mark >= 60)
            //{
            //    Console.WriteLine("Your scored {0} marks which is B grade.", mark);
            //}
            //else if (mark >= 40)
            //{
            //    Console.WriteLine("Your scored {0} marks which is C grade.", mark);
            //}
            //else if (mark >= 0)
            //{
            //    Console.WriteLine("Your scored {0} marks which is F grade.", mark);
            //}
            //else
            //{
            //    Console.WriteLine("**Error**");
            //}
            //-------------------------------------------------

            //.4
            //Console.Write("Enter the kilometres travelled: ");
            //double km = Convert.ToDouble(Console.ReadLine());
            //km = Math.Ceiling(km * 10) / 10;            //rounding up the kilometers to 1 decimal place
            //double cost = 2.4;

            //if (km <= 0.5)
            //{
            //    Console.WriteLine("The total cost: ${0}", cost);
            //}
            //else if (km <= 9)
            //{
            //    double ExtraKm = km - 0.5;
            //    cost = 2.4 + (ExtraKm * 0.4);
            //    Console.WriteLine("The total cost: ${0}", cost);
            //}
            //else
            //{
            //    double ExtraKm = km - 9.0;
            //    cost = 2.4 + (0.4 * 8.5) + (ExtraKm * 0.5);
            //    Console.WriteLine("The total cost: ${0}", cost);
            //}
            //-------------------------------------------------

            //5.
            //Console.Write("Enter a 3-digit number: ");
            //int input = Convert.ToInt32(Console.ReadLine());
            ////getting the 3 digits i.e. hundred number, ten number, unit number
            //int number, hn, tn, un;
            //number = input;
            //hn = (int)Math.Floor(number / 100.0);     //getting the number in hunderd position

            //number = number - (hn * 100);           //removing the number in hunderd position

            //tn = (int)Math.Floor(number / 10.0);    //getting the number in ten position

            //un = number - (tn * 10);                // getting the number in unit position by removing the ten position

            //int armNum = (int)Math.Pow(hn, 3) + (int)Math.Pow(tn, 3) + (int)Math.Pow(un, 3);

            //if (input == armNum)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //-------------------------------------------------

            //6.
            int tVPrice = 900, dVDPrice = 500, mP3Price = 700;
            int tVQty, dVDQty, mP3Qty;
            Console.WriteLine("Product:\tTV");
            Console.Write("Enter Quantity: ");
            tVQty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nProduct:\tDVD");
            Console.Write("Enter Quantity: ");
            dVDQty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nProduct:\tmP3");
            Console.Write("Enter Quantity: ");
            mP3Qty = Convert.ToInt32(Console.ReadLine());

            int tVAmount = tVPrice * tVQty, dVDAmount = dVDPrice * dVDQty, mP3Amount = mP3Price * mP3Qty;

            int discountAmount = tVAmount + dVDAmount;

            if (discountAmount > 10000)
            {
                discountAmount = discountAmount - (discountAmount * 15 / 100);
            }
            else
            {
                discountAmount = discountAmount - (discountAmount * 10 / 100);
            }

            int totalAmount = discountAmount + mP3Amount;

            Console.WriteLine("\nTotal Amount: ${0:#,###}", totalAmount);

        }
    }
}
