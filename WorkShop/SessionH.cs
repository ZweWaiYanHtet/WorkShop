using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop
{
    class SessionH
    {
        public static void Main()
        {
            //1.
            //Console.Write("Enter the first string: ");
            //string s1 = Console.ReadLine().ToUpper();

            //Console.Write("Enter the second string: ");
            //string s2 = Console.ReadLine().ToUpper();

            //Console.WriteLine(InString(s1, s2));
            //-------------------------------------------------

            //2.
            //Console.Write("Enter the first string: ");
            //string s1 = Console.ReadLine().ToUpper();

            //Console.Write("Enter the second string: ");
            //string s2 = Console.ReadLine().ToUpper();

            //Console.WriteLine(FindWord(s1, s2));
            //------------------------------------------------

            //3.
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(ToHex(i) + " ");
            }
            Console.WriteLine();

            Console.Write("Enter an integer to change it to hexadecimal number: ");
            Console.WriteLine(ToHex(Convert.ToInt32(Console.ReadLine())));
            //-------------------------------------------------

            //4.
            //Console.Write("Enter a sentence: ");
            //string s = Console.ReadLine();
            //Console.Write("Enter a character to find: ");
            //char c1 = Console.ReadLine().ToCharArray()[0];
            //Console.Write("Enter a character to replace: ");
            //char c2 = Console.ReadLine().ToCharArray()[0];

            //Console.WriteLine(Substitute(s, c1, c2));
        }

        static bool InString(string s1, string s2)
        {
            bool isFound = false;
            for (int i = 0; i < s1.Length - s2.Length + 1; i++)     //s1.len - s2.len + 1 so that the array will not go out of bound
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1.Substring(i + j, 1) != s2.Substring(j, 1))
                    {
                        isFound = false;
                        break;
                    }
                    isFound = true;
                }

                if (isFound)
                {
                    return isFound;
                }
            }
            return isFound;
        }

        static int FindWord(string s1, string s2)
        {
            int postion = -1;
            for (int i = 0; i < s1.Length - s2.Length + 1; i++)     //s1.len - s2.len + 1 so that the array will not go out of bound
            {
                if (s1.Substring(i, 1) == s2.Substring(0, 1))
                {
                    postion = i;
                }
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1.Substring(i + j, 1) != s2.Substring(j, 1))
                    {
                        postion = -1;
                        break;
                    }
                }

                if (postion != -1)
                {
                    return postion;
                }
            }
            return postion;
        }

        static string[,] binaryToHexTable = new string[,]
        {
            {"0000", "0" }, {"0001", "1" }, {"0010", "2" }, {"0011", "3" },
            {"0100", "4" }, {"0101", "5" }, {"0110", "6" }, {"0111", "7" },
            {"1000", "8" }, {"1001", "9" }, {"1010", "A" }, {"1011", "B" },
            {"1100", "C" }, {"1101", "D" }, {"1110", "E" }, {"1111", "F" }
        };
        static string ToHexLongerVersion(int decNumber)         //there is a direct dec to hex version below
        {
            //The logic is to change the number to binary and change the binary to Hex
            //decimal to binary formula: http://www.helpwithpcs.com/hardware/binary-numbers.php
            //binary to decimal formula: http://www.rapidtables.com/convert/number/how-binary-to-hex.htm


            string binaryNumber = "";
            while (decNumber != 0)
            {
                binaryNumber += decNumber % 2;
                decNumber = decNumber / 2;
            }                                   //this will get a binary with a reversed order
            string temp = binaryNumber;
            binaryNumber = "";
            for (int i = temp.Length - 1; i >= 0; i--)  //reversing the binary back
            {
                binaryNumber += temp.Substring(i, 1);
            }
            //formatting the binary it lengths is always factor of 4. e.g. 0001, 0100, 10100100
            //can use a loop to clear it up **
            if (binaryNumber.Length % 4 == 1)
            {
                binaryNumber = binaryNumber.PadLeft(binaryNumber.Length + 3, '0');
            }
            else if (binaryNumber.Length % 4 == 2)
            {
                binaryNumber = binaryNumber.PadLeft(binaryNumber.Length + 2, '0');
            }
            else if (binaryNumber.Length % 4 == 3)
            {
                binaryNumber = binaryNumber.PadLeft(binaryNumber.Length + 1, '0');
            }

            //changing binary to Hex
            string hexNumber = "";
            for (int i = 0; i < binaryNumber.Length / 4; i++)       //for every 4 char of the binary number 
            {                                                       //replace it with corresponding hex number
                for (int j = 0; j < 16; j++)                        // e.g. 0100 1101 = 4D
                {
                    if (binaryNumber.Substring(i*4, 4).Equals(binaryToHexTable[j,0]))
                    {
                        hexNumber += binaryToHexTable[j, 1];
                        break;
                    }
                }
            }

            return hexNumber;
        }

        static string[,] decToHexTable = new string[,]
        {
            {"10", "A"}, {"11", "B"}, {"12", "C"}, {"13", "D"}, {"14", "E"}, {"15", "F"}
        };
        static string ToHex(int decNumber)                  //direct version
        {
            string hexNumber = "";
            while (decNumber != 0)                         
            {
                hexNumber += decNumber % 16;
                decNumber = decNumber / 16;

                if (decNumber != 0) hexNumber += ",";       //put ',' when it is not the last char
            }                                               //E.g. 31 dec will become 15,1 after this.  this is a reversed order. check formula for details

            
            string[] temp = hexNumber.Split(',');
            hexNumber = "";

            //reversing the string to the right order
            for (int i = temp.Length - 1; i > 0; i--)
            {
                hexNumber += temp[i] + ",";
            }
            hexNumber += temp[0];                           //we don't want to put ',' when it is the last char

            string[] hexChar = hexNumber.Split(',');
            hexNumber = "";

            for (int i = 0; i < hexChar.Length; i++)
            {
                if (Convert.ToInt32(hexChar[i]) > 9)        //will replace 10 to 15 with A to F
                {
                    for (int j = 0; j < decToHexTable.GetLength(0); j++)        //replacing the character
                    {
                        if (hexChar[i] == decToHexTable[j,0])
                        {
                            hexChar[i] = decToHexTable[j, 1];
                        }
                    }
                }

                hexNumber += hexChar[i];
            }

            return hexNumber;
        }

        static string Substitute(string s, char c1, char c2)
        {
            string[] splitWords = s.Split(c1);
            string newSentence = splitWords[0];

            for (int i = 0; i < splitWords.Length - 1; i++)         //-1 because we only want to loop 2 times if there is 3 words
            {
                newSentence += c2 + splitWords[i+1];
            }
            return newSentence;
        }
    }
}
