using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop
{
    class SessionF
    {
        public static void Main()
        {
            //1.
            //int[] sales = new int[] { 7, 5, 6, 3, 8, 99, 6, 6, 4, 5, 1, 56 };

            //for (int i = 0; i < 12; i++)
            //{
            //    Console.Write(sales[i] + " ");
            //}
            //Console.WriteLine();

            //int month = 0, salesAmount = sales[0];
            //Console.WriteLine("Maximum Sales");
            //for (int i = 0; i < 12; i++)
            //{
            //    if (sales[i] > salesAmount)
            //    {
            //        salesAmount = sales[i];
            //        month = i;
            //    }
            //}
            //Console.WriteLine("Month: {0}, Sales: {1}", month, salesAmount);

            //month = 0; salesAmount = sales[0];
            //Console.WriteLine("Minimum Sales");
            //for (int i = 0; i < 12; i++)
            //{
            //    if (sales[i] < salesAmount)
            //    {
            //        salesAmount = sales[i];
            //        month = i;
            //    }
            //}
            //Console.WriteLine("Month: {0}, Sales: {1}", month, salesAmount);
            //--------------------------------------------------------------------------

            //2.
            //int[] num = new int[] { 3, 4, 1, 2, 5 };

            //for (int g = 0; g < num.Length; g++)
            //{
            //    for (int r = g + 1; r < num.Length; r++)
            //    {
            //        if (num[g] < num[r])
            //        {
            //            int temp;
            //            temp = num[g];
            //            num[g] = num[r];
            //            num[r] = temp;
            //        }
            //    }
            //    for (int i = 0; i < num.Length; i++)
            //    {
            //        Console.Write(num[i] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //--------------------------------------------------------------

            //3.
            int[,] studentMarks = new int[,] {              //students are in [0] and the subjects are in [1]
                { 56, 84, 68, 29}, { 94, 73, 31, 96},
                { 41, 63, 36, 90}, { 99, 9, 18, 17},
                { 62, 3, 65, 75}, { 40, 96, 53, 23},
                { 81, 15, 27, 30}, { 21, 70, 100, 22},
                { 88, 50, 13, 12}, { 48, 54, 52, 78},
                { 64, 71, 67, 25}, { 16, 93, 46, 72},
            };


            Console.WriteLine("Subject 1\tSubject 2\tSubject 3\tSubject 4\tTotal\t\tAvg");
            for (int i = 0; i < studentMarks.GetLength(0); i++)             //for each of the student
            {
                int total = 0;
                for (int j = 0; j < studentMarks.GetLength(1); j++)         //for each of the subject
                {
                    Console.Write(studentMarks[i, j] + "\t\t");
                    total += studentMarks[i, j];                            //getting total
                }
                Console.Write(total + "\t\t");
                double avg = (double)total / studentMarks.GetLength(1);                // total/number of subjects
                Console.WriteLine(avg);
            }

            Console.WriteLine();
            Console.WriteLine("Average per subject:");
            Console.WriteLine("Subject 1\tSubject 2\tSubject 3\tSubject 4");
            for (int i = 0; i < studentMarks.GetLength(1); i++)             //for each of the subject
            {
                int total = 0;
                for (int j = 0; j < studentMarks.GetLength(0); j++)         //for each of the student
                {
                    total += studentMarks[j, i];
                }
                double avg = (double)total / studentMarks.GetLength(0);     // total / number of students
                Console.Write("{0:0.##}\t\t", avg);
            }
            Console.WriteLine();

        }
    }
}
