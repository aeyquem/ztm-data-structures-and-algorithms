namespace data_structures_and_algorithms.Algorithms.Sorting
{
    public static partial class Sorting
    {
        public static int[] InsertionSort(int[] items)
        {
            for (int i = 1; i < items.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (items[j + 1] >= items[j])
                    {
                        break;
                    }

                    var aux = items[j + 1];
                    items[j + 1] = items[j];
                    items[j] = aux;
                }
            }

            return items;
        }
    }
}