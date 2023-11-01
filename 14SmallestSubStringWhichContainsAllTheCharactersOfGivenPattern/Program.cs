using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//14: Smallest Sub-string which contains all the characters of given Pattern
//https://www.youtube.com/watch?v=GZjW14vX2Ps&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=14

namespace _14SmallestSubStringWhichContainsAllTheCharactersOfGivenPattern
{
    internal class Program
    {
        public void SmallestSubStringWhichContainsAllTheCharactersOfGivenPattern(string pattern, string str)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < pattern.Length; i++)
            {
                char currentChar = pattern[i];
                if (dic.ContainsKey(currentChar))
                    dic[currentChar]++;
                else
                    dic[currentChar] = 1;
            }

            int countOfMatchingEle = 0; int start = 0;
            int subArrayLength = int.MaxValue; int subArrayStart = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];
                if (dic.ContainsKey(currentChar))
                {
                    dic[currentChar]--;
                    if (dic[currentChar] == 0)
                        countOfMatchingEle++;
                }

                while (countOfMatchingEle == dic.Count)
                {
                    if (subArrayLength > i - start + 1)
                    {
                        subArrayLength = i - start + 1;
                        subArrayStart = start;
                    }

                    char charAtStart = str[start++];
                    if (dic.ContainsKey(charAtStart))
                    {
                        if (dic[charAtStart] == 0)
                            countOfMatchingEle--;
                        dic[charAtStart]++;
                    }
                }

            }

            Console.WriteLine("Min subArray start is:{0} Min Length of Subarray with the pattern:{1}", subArrayStart, subArrayLength);
            Console.WriteLine("{0} {1}", str, pattern);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.SmallestSubStringWhichContainsAllTheCharactersOfGivenPattern("abcd", "bcdefcbabcbd");
        }
    }
}

