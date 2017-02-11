using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop
{
    class SessionG
    {
        public static void Main()
        {
            //1.
            //Console.WriteLine("Enter the Phrase Below_");
            //string phrase = Console.ReadLine();

            //int numOfA = 0;
            //for (int i = 0; i < phrase.Length; i++)
            //{
            //    string currentChar = phrase.Substring(i, 1);

            //    if (currentChar.ToUpper().Equals("A") )
            //    {
            //        numOfA += 1;
            //    }
            //}

            //int numOfE = 0;
            //for (int i = 0; i < phrase.Length; i++)
            //{
            //    string currentChar = phrase.Substring(i, 1);

            //    if (currentChar.ToUpper().Equals("E"))
            //    {
            //        numOfE += 1;
            //    }
            //}

            //int numOfI = 0;
            //for (int i = 0; i < phrase.Length; i++)
            //{
            //    string currentChar = phrase.Substring(i, 1);

            //    if (currentChar.ToUpper().Equals("I"))
            //    {
            //        numOfI += 1;
            //    }
            //}

            //int numOfO = 0;
            //for (int i = 0; i < phrase.Length; i++)
            //{
            //    string currentChar = phrase.Substring(i, 1);

            //    if (currentChar.ToUpper().Equals("O"))
            //    {
            //        numOfO += 1;
            //    }
            //}

            //int numOfU = 0;
            //for (int i = 0; i < phrase.Length; i++)
            //{
            //    string currentChar = phrase.Substring(i, 1);

            //    if (currentChar.ToUpper().Equals("U"))
            //    {
            //        numOfU += 1;
            //    }
            //}

            //Console.WriteLine("Total vowels: {0}", numOfA + numOfE + numOfI + numOfO + numOfU);
            //Console.WriteLine("A: {0}", numOfA);
            //Console.WriteLine("E: {0}", numOfE);
            //Console.WriteLine("I: {0}", numOfI);
            //Console.WriteLine("O: {0}", numOfO);
            //Console.WriteLine("U: {0}", numOfU);

            //-----------------------------------------------------------------
            //2.a
            //Console.Write("Enter a word: ");
            //string word = Console.ReadLine();
            //bool isPalindrome = true;
            //string reversedWord = "";

            //for (int i = word.Length; i > 0; i--)
            //{
            //    reversedWord += word.Substring(i - 1, 1);
            //}

            //int timesToCheck = (int)Math.Floor(word.Length / 2.0);          //if the first half is the same, it's a palindrome
            //for (int i = 0; i < timesToCheck; i++)
            //{
            //    if (word.Substring(i, 1) != reversedWord.Substring(i, 1))
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //if (isPalindrome)
            //{
            //    Console.WriteLine("It's a Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("It's not a Palindrome");
            //}
            //------------------------------------------------------------

            //2.b
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            ////making the sentence optimized
            //sentence.Trim();
            //sentence = sentence.ToLower();
            //string[] brokenSentence = sentence.Split(' ', '.');
            //sentence = "";  //clearing the sentence to reconstruct
            //for (int i = 0; i < brokenSentence.Length; i++)
            //{
            //    sentence += brokenSentence[i];
            //}
            //bool isPalindrome = true;

            //string reversedSentence = "";

            //for (int i = sentence.Length; i > 0; i--)
            //{
            //    reversedSentence += sentence.Substring(i - 1, 1);
            //}

            //int timesToCheck = (int)Math.Floor(sentence.Length / 2.0);          //if the first half is the same, it's a palindrome
            //for (int i = 0; i < timesToCheck; i++)
            //{
            //    if (sentence.Substring(i, 1) != reversedSentence.Substring(i, 1))
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //if (isPalindrome)
            //{
            //    Console.WriteLine("It's a Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("It's not a Palindrome");
            //}
            //-------------------------------------------------------------------

            //3. 
            //Console.Write("Enter a phrase/sentence: ");
            //string phrase = Console.ReadLine();
            //string[] words = phrase.Split(' ');
            //phrase = "";
            //for (int i = 0; i < words.Length; i++)
            //{
            //    //Making first letter of the word into upper case
            //    words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1, words[i].Length - 1);
            //    phrase += words[i] + " ";
            //}
            //phrase.Trim();

            //Console.WriteLine(phrase);
            //--------------------------------------------------------------------

            //4.
            string[] names = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[] { 63, 29, 75, 82, 55 };

            //Descending marks
            Console.WriteLine("Order By Marks Descending\n---------------------------");
            //using sorting algorithm from Session F No.2
            for (int g = 0; g < marks.Length; g++)
            {
                for (int r = g + 1; r < marks.Length; r++)
                {
                    if (marks[g] < marks[r])
                    {
                        int tempInt;
                        tempInt = marks[g];
                        marks[g] = marks[r];
                        marks[r] = tempInt;

                        string tempStr;
                        tempStr = names[g];
                        names[g] = names[r];
                        names[r] = tempStr;
                    }
                }
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + "\t\t" + marks[i]);
            }

            //Alphabetically
            Console.WriteLine("\n\nOrder By Names Alphabetically\n---------------------------");
            //using sorting algorithm from Session F No.2
            for (int g = 0; g < names.Length; g++)
            {
                for (int r = g + 1; r < names.Length; r++)
                {
                    if (names[g].CompareTo(names[r]) == 1)              //if first name is greater than the second one
                    {
                        int tempInt;
                        tempInt = marks[g];
                        marks[g] = marks[r];
                        marks[r] = tempInt;

                        string tempStr;
                        tempStr = names[g];
                        names[g] = names[r];
                        names[r] = tempStr;
                    }
                }
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + "\t\t" + marks[i]);
            }

        }
    }
}
