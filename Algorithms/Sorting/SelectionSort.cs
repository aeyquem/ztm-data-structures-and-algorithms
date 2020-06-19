namespace data_structures_and_algorithms.Algorithms.Sorting
{
    public static partial class Sorting
    {
        public static int[] SelectionSort(int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                var lowerIndex = i;
                for (int j = i+1; j < items.Length; j++)
                {
                    if (items[j] < items[lowerIndex])
                    {
                        lowerIndex = items[j];
                    }
                }
                var aux = items[i];
                items[i] = items[lowerIndex];
                items[lowerIndex] = aux;
            }
            return items;
        }
    }
}