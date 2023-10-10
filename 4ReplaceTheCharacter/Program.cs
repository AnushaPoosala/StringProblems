using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sourceProgram:https://www.youtube.com/watch?v=_L_1Nrsc5OE&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=4
//String Problem-4: Replace the character

namespace _4ReplaceTheCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "hi Anusha! Please Utilize the time. Otherwise you will cry in the future, because time is precious";
            char[] chr=s.ToCharArray();

            for(int i=0;i<chr.Length;i++)
            {
                if (chr[i] == 't' || chr[i]=='T') 
                {
                    chr[i] = 'L';
                }
            }
            foreach(var ele in chr) { Console.Write(ele); }
        }
    }
}
