using System.Collections.Generic;

namespace data_structures_and_algorithms.Algorithms.DynamicProgramming
{
    public static class Memoization
    {
        public static int FibonacciMemoized(int number)
        {
            var calculations = new Dictionary<int, int>();

            return FibonacciRecursive(number);

            int FibonacciRecursive(int number)
            {
                if (number < 2) return number;

                if (calculations.ContainsKey(number))
                {
                    return calculations[number];
                }
                else
                {
                    var result = FibonacciRecursive(number - 2) + FibonacciRecursive(number - 1);
                    calculations.Add(number, result);
                    return result;
                }
            }
        }
    }
}