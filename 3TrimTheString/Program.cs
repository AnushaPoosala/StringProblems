using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3TrimTheString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "  hi Anusha! Please Utilize the time. Otherwise you will cry in the future  ";
            char[] chr = s.ToCharArray();
            int start = 0;int end = 0;
           
            for(int i=0;i<chr.Length; i++)
            {
                if (chr[i]!=' ')
                {
                    start = i;
                    break;
                }
            }
            for (int i = chr.Length-1; i >=0; i--)
            {
                if (chr[i] != ' ')
                {
                    end = i;
                    break;
                }
            }
            int count = end - start + 1;
            string result=new string(chr,start,count);
            Console.WriteLine("Trimmed string is:"+result);
        }
    }
}
