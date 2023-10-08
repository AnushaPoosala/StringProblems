using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Source Program:https://www.youtube.com/watch?v=ZBISw8z3tts&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=2
// 2: Print first character of every word
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "Hello Anusha.!! Please be determined to Finish DSA. It is easy to complete with in 3 months,  If you focus and be consustent. ";
            char[] chr = str.ToCharArray();

            for (int i = 0; i < chr.Length; i++)
            {
                if (chr[i] != ' ' && (i == 0 || chr[i - 1] == ' '))
                    Console.WriteLine(chr[i]);
            }
            Console.WriteLine();
            //for (int i = 0; i < str.Length; i++)
            //{
            //   if (str[i] != ' ' && (i == 0 || str[i - 1] == ' '))
            //        Console.WriteLine(str[i]);
            //}
            //Console.WriteLine();
        }

    }
}

//We can get output by using any one of the for loops.
//But if we use "String str" directly, it creates many "substrings of individual characters in memory".(Memory wise poor performance)
//in terms of memory if we use str, it creates a new string for each character to be printed.
//imp//Since strings are immutable, every time you access or manipulate the string (e.g., using indexing, substring operations, etc.), you are effectively creating new string objects to represent the modified versions.
//imp//You are accessing characters within the string and comparing them. This comparison does not modify the original string. However, it may involve creating temporary string objects to represent substrings when you use indexing (str[i]) because each operation results in a new string object.
//imp//While this immutability does not significantly impact small-scale operations, it can lead to performance and memory considerations when dealing with very large strings or performing extensive string manipulation. In such cases, it's often more efficient to use a StringBuilder or other data structures (here char[])
//Converting the String to char[] and then doing action in chr[] is the best way.
//imp//Debug->Performance Profile->Check "Memory Usage"




