using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//19: Get the frequency of every word in given String
//https://www.youtube.com/watch?v=j8uv0JoSlmI&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=19

namespace _19GetTheFrequencyOfEveryWordInGivenString
{
    internal class Program
    {
        public void GetTheFrequencyOfEveryWordInGivenString(string str)
        {
            str = Regex.Replace(str, "[^a-zA-Z0-9]", " ");
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> countingDic = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string word2 = word.ToLower();
                if (countingDic.ContainsKey(word2))
                    countingDic[word2]++;
                else
                    countingDic[word2] = 1;
            }

            Dictionary<string, int> MostFrequentDic = countingDic.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach(KeyValuePair<string,int> pair in MostFrequentDic)
            {
                Console.WriteLine("{0}:{1}",pair.Key,pair.Value);
            }
            
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GetTheFrequencyOfEveryWordInGivenString("zoo app app Zoo zoo Best items in category are Samsung lenovo. Samsung items are nice. Lenovo are cool!");
        }
    }
}
