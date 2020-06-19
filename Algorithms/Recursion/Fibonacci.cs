namespace data_structures_and_algorithms.Algorithms.Recursion
{
    public static partial class Recursion
    {
        //0 1 2 3 4 5 6 7 
        //0,1,1,2,3,5,8,13

        public static int FibonacciRecursive(int number)
        {
            if (number < 2) return number;

            return FibonacciRecursive(number - 2) + FibonacciRecursive(number - 1);
        }
        public static int FibonacciIterative(int number)
        {
            if (number < 2) return number;

            var num1 = 0;
            var num2 = 1;

            for (int i = 1; i < number; i++)
            {
                var sum = num1 + num2;
                num1 = num2;
                num2 = sum;
            }

            return num2;
        }

        public static int FibonacciIterativeAndrei(int number)
        {
            var arr = new int[number + 1];
            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i < number + 1; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
            }

            return arr[number];
        }

    }
}