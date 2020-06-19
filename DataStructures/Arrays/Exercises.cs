using System;

namespace data_structures_and_algorithms.Arrays
{
    public static partial class Arrays
    {

        public static string ReverseString(this string input)
        {
            var reversedString = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString += input[i];
            }

            return reversedString;
        }

        public static void ReverseString2(ref string input)
        {
            var array = input.ToCharArray();
            Array.Reverse(array);
            input = new string(array);
        }

        public static int[] MergeOrderedArrays(int[] int1, int[] int2)
        {
            var finalInt = new int[int1.Length + int2.Length];
            int i = 0;
            int j = 0;

            for (int k = 0; k < int1.Length + int2.Length; k++)
            {
                if (i >= int1.Length)
                {
                    finalInt[k] = int2[j];
                    j++;
                }
                else if (j >= int2.Length)
                {
                    finalInt[k] = int1[i];
                    i++;
                }
                else if (int1[i] <= int2[j])
                {
                    finalInt[k] = int1[i];
                    i++;
                }
                else
                {
                    finalInt[k] = int2[j];
                    j++;
                }
            }

            return finalInt;
        }
    }
}