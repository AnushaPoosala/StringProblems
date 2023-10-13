using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6: Reverse Individual Words in Given String
//https://www.youtube.com/watch?v=7a-hwudRoKc&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=6

namespace _6ReverseIndividualWordsInGivenString
{
    internal class Program
    {
        public void ReverseIndividualWordsInGivenStringUsingStringBuilderBestApproach(string s)
        {
            //time:O(n) sapce:O(1) very optimal solution
            int start = 0;int end = 0;StringBuilder finalsb = new StringBuilder();
            StringBuilder tempsb = new StringBuilder();
            while (end < s.Length)
            {
                char c = s[end];
                if (c != ' ')
                {
                    tempsb.Insert(0, c);
                }
                else if (s[end] == ' ')
                {
                    finalsb.Append(tempsb).Append(' ');
                    tempsb.Clear();
                }
                end++;
            }
            finalsb.Append(tempsb);
        Console.WriteLine(finalsb.ToString());
        }
        public void ReverseIndividualWordsInGivenStringUsingStack(string s)
        {
            //time:O<n) space:O(n) not optimal because of extra space for stack
            Stack<char> stack = new Stack<char>();
            int i = 0;
            while (i < s.Length)
            {
                char c = s[i];
                if (s[i] != ' ')
                {
                    stack.Push(c);
                }
                else if (s[i]==' ')
                {
                    while(stack.Count > 0)
                    {
                        Console.Write(stack.Pop()); 
                    }
                    Console.Write(" ");
                }
                i++;
            }
            while(stack.Count > 0)
                stack.Pop();
        }
        public void ReverseIndividualWordsInGivenStringUsingString(string s)
        {
            //time:O<n) space:O(1) not optimal because strings are immutable takes extran memory
            string tempstr="" ;string finalstr="";int i = 0;
            while(i<s.Length)
            {
                char c = s[i];
                if(c!=' ')
                {
                    tempstr = c + tempstr;
                }
                else
                {
                    finalstr= finalstr+tempstr+' ';
                    tempstr = "";
                }
                i++;
            }
            finalstr= finalstr+tempstr;
            Console.WriteLine(finalstr);
        }
        static void Main(string[] args)
        {
            string s = "try to finish 4 string programs today";
            string s2 = "Hello    world ";
            Program program = new Program();
            //program.ReverseIndividualWordsInGivenString(s2);
            //program.ReverseIndividualWordsInGivenStringUsingStringBuilderBestApproach(s);
            //program.ReverseIndividualWordsInGivenStringUsingString(s2);
            program.ReverseIndividualWordsInGivenStringUsingStack(s);
        }
        public void ReverseIndividualWordsInGivenString(string s)
        {
            //time:O(n) space:O(n+m) not optimal sol, ,but it is my own solution
            char[] chr = s.ToCharArray();
            List<List<char>> strlist = new List<List<char>>();
            int end = 0;
            List<char> list = new List<char>();

            while (end < chr.Length)
            {
                if (chr[end] != ' ')
                    list.Insert(0, chr[end]);

                else if (chr[end] == ' ')
                {
                    list.Add(' ');
                    strlist.Add(new List<char>(list));
                    list.Clear();
                }
                end++;
            }
            strlist.Add(new List<char>(list));

            foreach (var chararray in strlist)
            {
                foreach (var ele in chararray)
                    Console.Write(ele);
            }
            Console.WriteLine();
        }
    }
}
