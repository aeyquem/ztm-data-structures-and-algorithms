using System.Collections.Generic;

namespace data_structures_and_algorithms.HashTable
{
    public static class Exercices
    {

        public static int? FirstRecurringItem(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        return input[i];
                    }
                }
            }

            return null;
        }

        public static int? FirstRecurringItem1Point5(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (input[i] == input[j])
                    {
                        return input[j];
                    }
                }
            }

            return null;
        }

        public static int? FirstRecurringItem2(int[] input)
        {
            var hs = new HashSet<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (hs.Contains(input[i]))
                {
                    return input[i];
                }

                hs.Add(input[i]);
            }

            return null;
        }
    }

}