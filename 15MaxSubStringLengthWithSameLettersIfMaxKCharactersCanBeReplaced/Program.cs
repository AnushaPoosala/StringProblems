using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.youtube.com/watch?v=qxDH4nxtt1w&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=15
//15: Max sub-string length with same letters if max 'K' characters can be replaced 
namespace _15MaxSubStringLengthWithSameLettersIfMaxKCharactersCanBeReplaced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str2 = "bcccbababd";
            string str = "bhfbakbbb";
            MaxSubStringLengthWithSameLettersIfMaxKCharactersCanBeReplaced(str, 2);
        }
        private static void MaxSubStringLengthWithSameLettersIfMaxKCharactersCanBeReplaced(string str, int k)
        {
            int start = 0; int end = 0; int maxSubStringLength = 0; int maxOccurenceedValue = 1; Dictionary<char, int> dic = new Dictionary<char, int>();

            while (end < str.Length)
            {
                char currentChar = str[end];
                if (dic.ContainsKey(currentChar))
                {
                    dic[currentChar]++;
                }
                else
                    dic[currentChar] = 1;
                maxOccurenceedValue = Math.Max(maxOccurenceedValue, dic[currentChar]);

                if ((end - start + 1 - maxOccurenceedValue) > k)
                {
                    char startChar = str[start];
                    dic[startChar]--;
                    start++;
                }
                maxSubStringLength = Math.Max(maxSubStringLength, end - start + 1);
                end++;
            }
            Console.WriteLine("Actual string is:{0}, K is:{1}",str,2);
            Console.WriteLine("Max sub-string length with same letters if max 'K' characters can be replaced " + maxSubStringLength);
        }
    }
}
