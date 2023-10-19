using System;

public class ArrayApp
{
    public static bool IfStringEqualContainingBackspace(string str1, string str2)
    {
        int end1 = str1.Length - 1;
        int end2 = str2.Length - 1;

        while (end1 >= 0 && end2 >= 0)
        {
            int str1Index = GetChar(str1, end1);
            int str2Index = GetChar(str2, end2);

            if (str1Index < 0 && str2Index < 0)
            {
                return true;
            }

            if (str1Index < 0 || str2Index < 0)
            {
                return false;
            }

            if (str1[str1Index] != str2[str2Index])
            {
                return false;
            }

            end1 = str1Index - 1;
            end2 = str2Index - 1;
        }

        if (end1 == -1 && end2 == -1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static int GetChar(string str, int end)
    {
        int specialChar = 0;

        while (end >= 0)
        {
            if (str[end] != '#')
            {
                if (specialChar == 0)
                {
                    return end;
                }
                else
                {
                    specialChar--;
                }
            }
            else
            {
                specialChar++;
            }

            end--;
        }

        return end;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(ArrayApp.IfStringEqualContainingBackspace("###e", "#e"));
    }
}
