using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.youtube.com/watch?v=3F1ydjOl9gk&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=5
//5: Reverse the given String
namespace _5ReverseTheGivenString
{
    internal class Program
    {
        public static void ReverseArrayMethod5UsingStack(string s)
        {
            Stack<char> stack = new Stack<char>();
            char[] chr=s.ToCharArray();
            foreach(var ele in chr)
                stack.Push(ele);
            while(stack.Count>0)
            { Console.WriteLine(stack.Pop());  }
        }
        public static void ReverseArrayMethod4UsingOtherString(string s)
        {
            string str2 = "";
            for(int i=0;i<s.Length; i++)
            {
                str2 =  s[i]+str2;
            }
            foreach(var ele in str2) Console.WriteLine(ele);
        }
        public static void ReverseArrayMethod3UsingStringBuilder(string s)
        {
            StringBuilder sb = new StringBuilder();
            for(int i=s.Length-1;i>=0 ; i--)
            {
                sb = sb.Append(s[i]);
            }
            string str2= sb.ToString();
            foreach(var ele in str2) Console.WriteLine(ele);

        }
        public static void ReverseArray(string s)
        {
            char[] chr = s.ToCharArray();

            for (int i = 0; i < chr.Length / 2; i++)
            {
                var temp = chr[i];
                chr[i] = chr[chr.Length - i - 1];
                chr[chr.Length - i - 1] = temp;
            }
            //1.way of printing
            //foreach (var ele in chr) { Console.WriteLine(ele); }  
            //2.way of printing
            string str2 = new string(chr);
            foreach (var ele in str2) { Console.WriteLine(ele); }
        }
        static void Main(string[] args)
        {
            string s = "My name is Anusha";
            //Program.ReverseArray(s);
            //Program.ReverseArrayMethod3UsingStringBuilder(s);
            Program.ReverseArrayMethod4UsingOtherString(s);
            //Program.ReverseArrayMethod5UsingStack(s);
        }
    }
}
