using System;

namespace FindFirstNonConsecFunc
{
    public class Class1
    {
       
        public static string GetValue(int[] input)
        {
         for (int i = 0; i <= input.Length-2; i++)
            {
               if (input[i] + 1 != input[i +1])
                {
                    string value = input[i + 1].ToString();

                    return value;
                }
            }
            return null;
        }
    }
}