using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//9: Find longest sub-string length with K distinct characters
//https://www.youtube.com/watch?v=k--bSleyD4E&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=9
namespace _9FindLongestSub_stringLengthWithKDistinctCharacters
{
    internal class Program
    {
        public static void LongestSub_stringLengthWithKDistinctCharacters(string s,int k)
        {
            Dictionary<char,int> dic = new Dictionary<char,int>();
            int start = 0;int end = 0;int maxLength = 0;

            while(end<s.Length)
            {
                char currentChar = s[end]; 
                if (dic.ContainsKey(currentChar))
                {
                    dic[currentChar]++;
                }
                else
                {
                    dic[currentChar] = 1;
                }
                while(dic.Count>k)
                {
                    char strtingChar = s[start++];
                    dic[strtingChar]--;
                    if (dic[strtingChar] ==0)
                    {
                        dic.Remove(strtingChar);
                    }
                }
                maxLength = Math.Max(maxLength, end - start + 1);
                end++;
            }
            Console.WriteLine(maxLength);
        }
        static void Main(string[] args)
        {
            string s = "bccccccbababd";
            Program.LongestSub_stringLengthWithKDistinctCharacters(s,2);

        }
    }
}
