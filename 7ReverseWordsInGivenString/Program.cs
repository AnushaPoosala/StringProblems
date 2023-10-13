using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7: Reverse words in given String
//https://www.youtube.com/watch?v=VojNNJS0dBc&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=7
namespace _7ReverseWordsInGivenString
{
    internal class Program
    {
        public void ReverseWordsInGivenStringUsingStringBuilder(string s)
        {
            //Best approach
            StringBuilder finalsb= new StringBuilder();
            StringBuilder tempsb= new StringBuilder();
            int count=s.Length-1;
            
            while(count>=0)
            {
                char c = s[count];
                if(c!=' ')
                {
                    tempsb = tempsb.Insert(0, c);
                }
                else
                {
                    finalsb = finalsb.Append(tempsb).Append(' ');
                    tempsb.Clear();
                }
                count--;
            }
            finalsb.Append(tempsb);
            Console.WriteLine(finalsb.ToString());
        }

        public void ReverseWordsInGivenStringUsingString(string s)
        {
            //not best approch.because strings are immutable,it takes lots of memory
            string tempstr = "";string finalstr = "";
            int i = s.Length-1;

            while(i>=0)
            {
                char c = s[i];
                if(c!=' ')
                {
                    tempstr = c + tempstr;
                }
                else 
                {
                    finalstr = finalstr+tempstr + ' ';
                    tempstr = "";
                }
                i--;
            }
            finalstr = finalstr + tempstr; 
            Console.WriteLine(finalstr);
        }

        public void ReverseWordsInGivenStringUsingStack(string s)
        {
            Stack<char> stack = new Stack<char>();
            int i = 0;int count=s.Length-1;
            while(count>=0)
            {
                char c = s[count];

                if(c!=' ')
                {
                    stack.Push(c);
                }
                else if(c==' ')
                {
                    while(stack.Count>0)
                    {
                        Console.Write(stack.Pop());
                    }
                    Console.Write(" ");
                }
                count--;
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string s = "try to complete up to no. 12 and review up to 15";
            string s2 = "try to complete";
            Program program=new Program();
            //program.ReverseWordsInGivenStringUsingStringBuilder(s);
            //program.ReverseWordsInGivenStringUsingString(s);
            program.ReverseWordsInGivenStringUsingStack(s);
        }
    }
}
