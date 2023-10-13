using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//8: Find number of unique characters in given String 
//https://www.youtube.com/watch?v=e3W4Z__CYnM&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=8
namespace _8FindNumberOfUniqueCharactersInGivenString
{
    internal class Program
    {
        public void FindNumberOfUniqueCharactersInGivenString(string s)
        {
            HashSet<char> uniqueCharacters = new HashSet<char>();
            for(int i=0;i<s.Length; i++)
            {
                char c = s[i];
                uniqueCharacters.Add(c);
            }
            foreach(var ele in uniqueCharacters) { Console.WriteLine(ele); }
            Console.WriteLine("No. of unique chars: "+uniqueCharacters.Count);
        }
        static void Main(string[] args)
        {
            string str = "bccbababd";
            Program program = new Program();
            program.FindNumberOfUniqueCharactersInGivenString(str);
        }
    }
}
