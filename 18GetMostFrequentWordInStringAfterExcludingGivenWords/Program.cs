using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//18: Get Most Frequent word in String after excluding given words
//https://www.youtube.com/watch?v=-_Tm96pfc18&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=18

namespace _18GetMostFrequentWordInStringAfterExcludingGivenWords
{
    internal class Program
    {
        public static void GetMostFrequentWordInStringAfterExcludingGivenWords(string str, string[] exclude)
        {
            str = Regex.Replace(str, "[^a-zA-Z0-9]", " ");
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string,int> countingDic = new Dictionary<string,int>();

            foreach (string word in words) 
            {
                string word2 = word.ToLower();
                
                if (countingDic.ContainsKey(word2))
                    countingDic[word2]++;
                else
                    countingDic[word2] = 1;
            }
            foreach (string word in exclude) 
            {
                if (countingDic.ContainsKey(word))
                    countingDic.Remove(word);
            }

            Dictionary<string, int> FrequencyDic= countingDic.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).ToDictionary(x=>x.Key,x=>x.Value);
            int topFrequency = FrequencyDic.First().Value;
            List<string> topFrequencyList=new List<string>();

            while(FrequencyDic.Count>0)
            {
                KeyValuePair<string,int> word=FrequencyDic.First();

                if(FrequencyDic[word.Key]== topFrequency)
                {
                    topFrequencyList.Add(word.Key);
                    FrequencyDic.Remove(word.Key);
                }
                else
                    break;
            }

            foreach (string word in topFrequencyList) { Console.WriteLine(word); }


        }
        static void Main(string[] args)
        {
            String[] excludingItems = { "in", "are","zoo" };
            Program.GetMostFrequentWordInStringAfterExcludingGivenWords("Best items in category are Samsung, lenovo. Samsung items are nice. Lenovo are cool ", excludingItems);
        }
    }
}
