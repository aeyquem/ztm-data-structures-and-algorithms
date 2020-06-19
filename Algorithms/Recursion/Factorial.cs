namespace data_structures_and_algorithms.Algorithms.Recursion
{
    public static partial class Recursion
    {
        public static int FactorialRecursive(int number)
        {
            if (number <= 1)
            {
                return number;
            }

            return (number * FactorialRecursive(number - 1));
        }

        public static int FactorialIterative(int number)
        {
            var result = number;
            for (int i = number - 1; i > 1; i--)
            {
                result = result * i;
            }

            return result;
        }
    }
}