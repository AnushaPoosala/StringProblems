using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//10: Longest sub-string length with no repeating characters
//https://www.youtube.com/watch?v=FRlfT05zAg4&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=10
namespace _10LongestSub_stringLengthWithNoRepeatingCharacters
{
    internal class Program
    {
        static void LongestSub_stringLengthWithNoRepeatingCharacters(String s)
        {
            Dictionary<char,int> dic=new Dictionary<char,int>();
            int start = 0;int end=0;int maxLength = 0;

            while(end<s.Length)
            {
                char currentChar = s[end];
                
                if (dic.ContainsKey(currentChar)) 
                {
                    start = Math.Max(start, dic[currentChar]+1);
                }

                dic[currentChar] = end;
                maxLength = Math.Max(maxLength, end - start + 1);
                end++;
            }
            Console.WriteLine(maxLength);
        }
        static void Main(string[] args)
        {
            Program.LongestSub_stringLengthWithNoRepeatingCharacters("babccbacd");
        }
    }
}
