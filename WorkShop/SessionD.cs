using System;

namespace WorkShop
{
    class SessionD
    {
        public static void Main()
        {
            //1.
            //Console.WriteLine("Enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //while(num != 88)
            //{
            //    Console.WriteLine("Enter a number");
            //    num = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Lucky you...");
            //-------------------------------------------------

            //2.
            //Console.Write("Enter First Number: ");
            //int A = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Second Number: ");
            //int B = Convert.ToInt32(Console.ReadLine());

            //int HCF = 0, a = A, b = B;

            //while (a != b)
            //{
            //    if(a > b)
            //    {
            //        a = a - b;
            //    }
            //    else
            //    {
            //        b = b - a;
            //    }
            //}

            //HCF = a;
            //int LCF = (A * B) / HCF;

            //Console.WriteLine("HCF: {0}", HCF);
            //Console.WriteLine("LCF: {0}", LCF);

            //3.a
            //int randomNumber = new Random().Next(0, 10);
            //int guessedNumber = -1;
            //int count = 0;

            //while(guessedNumber != randomNumber)
            //{
            //    Console.Write("Guess the Number: ");
            //    guessedNumber = Convert.ToInt32(Console.ReadLine());

            //    count++;
            //}

            //Console.WriteLine("Congratulation! You successfully guessed the number! Total Attempt: {0}", count);
            //-------------------------------------------------

            //3.b
            //int randomNumber = new Random().Next(0, 10);
            //int guessedNumber = -1;
            //int count = 0;

            //Console.Write("Guess the Number: ");
            //guessedNumber = Convert.ToInt32(Console.ReadLine());
            //count++;

            //while (guessedNumber != randomNumber)
            //{
            //    Console.Write("Try Again! Guess the Number: ");
            //    guessedNumber = Convert.ToInt32(Console.ReadLine());

            //    count++;
            //}

            //if(count < 3)
            //{
            //    Console.WriteLine("You are a Wizard! Total Attempt: {0}", count);
            //}
            //else if (count < 6)
            //{
            //    Console.WriteLine("You are a good guesser! Total Attempt: {0}", count);
            //}
            //else
            //{
            //    Console.WriteLine("You are lousy! Total Attempt: {0}", count);
            //}
            //-------------------------------------------------

            //4.
            Console.Write("Enter a number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            double G = (N >= 1) ? (double)new Random().Next(1, N) : 0.000;

            while (N != Math.Round(G * G, 5))
            {
                G = (G + N / G) / 2;
            }

            Console.WriteLine("The square root is {0:0.###}", G);
        }
    }
}
