namespace data_structures_and_algorithms.Algorithms.Sorting
{
    public static partial class Sorting
    {
        public static int[] BubbleSort(int[] items)
        {
            for (int i = items.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (items[j] > items[j + 1])
                    {
                        var aux = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = aux;
                    }
                }
            }

            return items;
        }
    }
}