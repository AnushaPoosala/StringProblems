using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//13: Find all anagrams present in String for a given pattern
//https://www.youtube.com/watch?v=lKgUHSi9BE8&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=13

namespace ConsoleApp1
{
    internal class Program
    {
        public void FindAllAnagramsInStringForAGivenPattern(string pattern, string str)
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

            int countOfAnagrams = 0; int countOfMatchingEle = 0; int start = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];

                if (dic.ContainsKey(currentChar))
                {
                    dic[currentChar]--;
                    if (dic[currentChar] == 0)
                        countOfMatchingEle++;
                }
                if (countOfMatchingEle == dic.Count)
                {
                    Console.WriteLine("Anagram starts at index:{0}", start);
                    countOfAnagrams++;
                }
                if (i >= pattern.Length - 1)
                {
                    char charAtStart = str[start++];
                    if (dic.ContainsKey(charAtStart))
                    {
                        if (dic[charAtStart] == 0)
                            countOfMatchingEle--;
                        dic[charAtStart]++;
                    }
                }
            }
            Console.WriteLine("count of Anagrams:{0}", countOfAnagrams);
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.FindAllAnagramsInStringForAGivenPattern("abcd", "bcdcbabcbabcd");
        }
    }
}