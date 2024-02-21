using System;
using System.Text;

class Solution
{
    public string TransformString(int N)
    {
        string result = "";
        int count = 0;
        string str = "abcdefghijklmnopqrstuvwxyz";
        char[] chAr = str.ToCharArray();
        StringBuilder finalSb= new StringBuilder();

        while (N > 0)
        {
            
            if(N%2 == 0 && count<25) 
            {
                N = N / 2;
                count++;
                continue;

            }
            else
            {
                finalSb.Insert(0,chAr[count]);
               
                N = N - 1;
            }
        }
        return finalSb.ToString();
    }

    public static void Main()
    {
        Solution solution = new Solution();

        // Test cases
        Console.WriteLine(solution.TransformString(67108876));         // input: aaaaaaaaaaa    Output: "dba" 20=ec 40=fd
        //Console.WriteLine(solution.TransformString(1));          // Output: "a"
       //Console.WriteLine(solution.TransformString(67108876));   // Output: "zzdc"
    }
}

//Question
//there is a string of length N made only of letters "a". whenever there are 2 identical adjacent letters(eg:"aa") they can be transformed into single letter that is  the next letter of the alphabet. for example "aa" can be transformed into "b" and "ee" can be transformed into "f". Hower "zz" can not be transornmed.

//What is alphabetically largest string that can be obtained from initial string?

//write function

//ckass Solution{ public string solution(int N);}

//that given N returns the alphabetically largest string that can be obtained after such transformations

//Examples:

//1.Given N = 11, the function should return "dba". The initial string "aaaaaaaaaaa" can be transormed inthe forllowing manner.
//   "aaaaaaaaaaa"->bbbbba"->"ccba"->"dba"
//2. Given N=1; the function should return "a".the initial string "a" can not be transformed in any way.
//3. Given N=67108876 the function should return  "zzdc"
 