using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//12.Check if String contains any permutation/anagram of given pattern
//https://www.youtube.com/watch?v=Cf2PjdAttbk&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=12
namespace _12.CheckIfStringContainsAnyPermutationOR_AnagramOfGivenPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            Console.WriteLine(b.IsPatternAnagram("abc", "bcdcbaba")); 
        }
    }
    class B
    {
        public bool IsPatternAnagram(string pattern,string str) 
        {
            Dictionary<char,int> dic = new Dictionary<char,int>();

            for(int i=0;i<pattern.Length;i++)
            {
                char currentChar = pattern[i];
                if (dic.ContainsKey(currentChar))
                    dic[currentChar]++;
                else
                    dic[currentChar] = 1;
            }
            int countOfMatchedEle = 0;int start = 0;
            for (int i=0;i<str.Length;i++)
            {
                char currentChar = str[i];
                if (dic.ContainsKey(currentChar))
                {
                    dic[currentChar]--;
                    if (dic[currentChar] == 0)
                        countOfMatchedEle++;
                }
               
                if (dic.Count == countOfMatchedEle)
                    return true;

                if(i>=pattern.Length-1)
                {
                    char startChar = str[start];
                    if (dic.ContainsKey(startChar))
                    {
                        if (dic[startChar] == 0) 
                            countOfMatchedEle--;

                        dic[startChar]++;
                    }
                    start++;
                }
            }
            return false;
        }
    }
}
