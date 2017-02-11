using System;

namespace WorkShop
{
    class Quizz2
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Matriculation Number");
            string input = Console.ReadLine();
            if (input.Length != 7)
            {
                Console.WriteLine("It's Invalid");
            }
            else
            {
                input = input.ToUpper();
                int chkSum = 0;
                for (int i = 0; i < 5; i++)
                {
                    int num = Convert.ToInt32(input.Substring(i + 1, 1));
                    chkSum += num * (6 - i);
                }
                chkSum = chkSum % 5;
                string chkSumChar;
                if (chkSum == 0) chkSumChar = (char)79 + "";
                else if (chkSum == 1) chkSumChar = (char)80 + "";
                else if (chkSum == 2) chkSumChar = (char)81 + "";
                else if (chkSum == 3) chkSumChar = (char)82 + "";
                else chkSumChar = (char)83 + "";

                if (chkSumChar == input.Substring(6, 1))
                {
                    Console.WriteLine("It's Valid.");
                }
                else
                {
                    Console.WriteLine("It's Invalid.");
                }
            }

            
        }
    }
}
