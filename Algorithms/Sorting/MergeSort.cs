namespace data_structures_and_algorithms.Algorithms.Sorting
{
    public static partial class Sorting
    {
        public static int[] MergeSort(int[] items)
        {
            if (items.Length == 1)
            {
                return items;
            }

            var left = MergeSort(items.SubArray(0, items.Length / 2 - 1));
            var right = MergeSort(items.SubArray(items.Length / 2, items.Length - 1));


            var counterLeft = 0;
            var counterRight = 0;
            var totalCounter = 0;

            while (totalCounter < items.Length)
            {
                if (counterRight >= right.Length)
                {
                    items[totalCounter] = left[counterLeft++];
                }
                else if (counterLeft >= left.Length)
                {
                    items[totalCounter] = right[counterRight++];
                }
                else if (left[counterLeft] <= right[counterRight])
                {
                    items[totalCounter] = left[counterLeft++];
                }
                else if (left[counterLeft] > right[counterRight])
                {
                    items[totalCounter] = right[counterRight++];
                }
                totalCounter++;
            }

            return items;
        }

        public static int[] SubArray(this int[] array, int start, int end)
        {
            int arrayLength = end - start + 1;
            int[] subArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                subArray[i] = array[i + start];
            }
            return subArray;
        }
    }
}