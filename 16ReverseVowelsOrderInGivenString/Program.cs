using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.youtube.com/watch?v=fkqAHX8SGeo&list=PLt4nG7RVVk1gp0v3wg7gWB26lRzseuHQz&index=16
//16: Reverse Vowels order in Given String 
namespace _16ReverseVowelsOrderInGivenString
{
    internal class Program
    {
        public void ReverseVowelsOrderInGivenString(string str)
        {
            char[] charArray = str.ToCharArray();
            int start = 0;int end = charArray.Length-1;
            while(start<end)
            {

                if (!IsVowel(charArray[start]))
                {
                    start++;
                    continue;
                }

                if (!IsVowel(charArray[end]))
                {
                    end--;
                    continue;
                }
                char temp = charArray[start];
                charArray[start] = charArray[end];
                charArray[end] = temp; 
                
                start++; end--;
            }
            Console.WriteLine(new string(charArray));
        }
        public bool IsVowel(char c)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                return true;
            else
                return false;
          
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ReverseVowelsOrderInGivenString("Equation");
        }
    }
}
