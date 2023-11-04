using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//https://www.youtube.com/watch?v=vuqzrlwqt1Y&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=17
// 17: Get Most Frequent word in String
namespace _17GetMostFrequentWordInString
{
    internal class Program
    {
        public void GetMostFrequentWordInString(string str)
        {
            str = Regex.Replace(str, "[^a-zA-Z0-9]", " ");
            string[] words= str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string,int> countingDic= new Dictionary<string,int>();

            foreach (string word in words) 
            {
                string word2 = word.ToLower();
                if (countingDic.ContainsKey(word2))
                    countingDic[word2]++;
                else
                    countingDic[word2] = 1;
            }

            Dictionary<string, int> MostFrequentDic = countingDic.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            int topFrequency = MostFrequentDic.First().Value;
            List<string> topFrequesyList = new List<string>();

            while(MostFrequentDic.Any())                    //   while (mostFrequentMap.Count > 0)---both are same
            {
                KeyValuePair<string,int> word= MostFrequentDic.First();
                if (MostFrequentDic[word.Key] == topFrequency)
                {
                    topFrequesyList.Add(word.Key);
                    MostFrequentDic.Remove(word.Key);
                }
                else
                    break;
            }

            foreach(string word in topFrequesyList) { Console.WriteLine(word); }

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GetMostFrequentWordInString("zoo Zoo best item in category LENOVO, SAMSUNG....? ITEM lenovo, Samsung are cool!");
        }
    }
}
