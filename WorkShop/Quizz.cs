using System;

namespace WorkShop
{
    class Quizz
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Bank of ISS");
            Console.Write("Enter your PIN: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int PIN = 123456, count = 0;
            count++;
            while(input != PIN && count < 3)
            {
                Console.WriteLine("Incorrect PIN. Please try again");
                Console.Write("Enter your PIN: ");
                input = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            if (PIN == input)
            {
                Console.WriteLine("PIN accepted. You can access your account now.");
            }
            else
            {
                Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");
            }





































        }
    }
}
