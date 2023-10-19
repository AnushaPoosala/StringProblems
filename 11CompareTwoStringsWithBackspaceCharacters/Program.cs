using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//11: Compare two Strings with backspace characters
//https://www.youtube.com/watch?v=8bCdNqjFS50&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=11
namespace _11CompareTwoStringsWithBackspaceCharacters
{
    class C
    {
        public bool CompareTwoStringsWithBackspaceChar(string str1, string str2)
        {
            int end1 = str1.Length - 1; int end2 = str2.Length - 1;
            while (end1>=0 && end2>=0)
            {
                int charPositionOfStr1 = GetNonSpecialChar(str1, end1);
                int charPositionOfStr2 = GetNonSpecialChar(str2, end2);

                if(charPositionOfStr1 < 0 && charPositionOfStr2 < 0)
                    return true;

                if (charPositionOfStr1 < 0 || charPositionOfStr2 < 0)
                    return false;

                if (str1[charPositionOfStr1] != str2[charPositionOfStr2])
                    return false;

                end1= charPositionOfStr1-1;
                end2= charPositionOfStr2-1;
            }

            if (end1 == -1 && end2 == -1)
                return true;
            else
                return false;

        }
        public int GetNonSpecialChar(string str,int end)
        {
            int specialCharCount = 0;
            while (end>=0)
            {
                char currentChar = str[end];
                if (currentChar !='#')
                {
                    if (specialCharCount == 0)
                        return end;
                    else 
                        specialCharCount--;
                }
                else
                    specialCharCount++;
                end--;
            }
            return end; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C obj = new C();
            string str1 = "bdef###e";
            string str2 = "bb#e";
            Console.WriteLine(obj.CompareTwoStringsWithBackspaceChar(str1, str2)); 
        }
    }
    class B
    {
        public void CompareTwoStringsWithBackspaceCharacter(string str1, string str2)
        {
            StringBuilder sb1 = new StringBuilder(); int count = 0;
            StringBuilder sb2 = new StringBuilder(); int count2 = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                char currentChar = str1[i];
                if (currentChar == '#' && i >= 1)
                {
                    sb1.Remove(sb1.Length - 1, 1);

                    count++;
                }
                else
                    sb1.Append(currentChar);
            }
            Console.WriteLine(sb1.ToString());

            for (int i = 0; i < str2.Length; i++)
            {
                char currentChar = str2[i];
                if (currentChar == '#' && i >= 1)
                {
                    sb2.Remove(sb2.Length - 1, 1);
                    count2++;
                }
                else
                    sb2.Append(currentChar);
            }
            Console.WriteLine(sb2.ToString());

            if (sb1.Length != sb2.Length)
            {
                Console.WriteLine("both strings are different with #");
                return;
            }
            for (int i = 0; i < sb1.Length; i++)
            {
                if (sb1[i] != sb2[i])
                {
                    Console.WriteLine("both strings are different with #");
                    return;
                }

            }
            Console.WriteLine("Both the strings are same with #");
        }
    }

}

