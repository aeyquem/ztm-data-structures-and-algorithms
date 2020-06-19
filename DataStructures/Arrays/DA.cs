using System;

namespace data_structures_and_algorithms.Arrays
{
    public class DA<T>
    {
        public T[] Items { get; set; }
        public int Length { get; set; }

        public DA()
        {
            Items = new T[2];
            Length = 2;
        }

        public DA(int length)
        {
            Items = new T[length];
            Length = length;
        }

        private void EnlargeCapacity()
        {
            var newArray = new T[Items.Length * 2];
            for (int i = 0; i < Items.Length; i++)
            {
                newArray[i] = Items[i];
            }
            Items = newArray;
        }

        public void Insert(int index)
        {
            throw new NotImplementedException();
        }

        public void Shift(int index)
        {
            throw new NotImplementedException();
        }

        public void Unshift(int index)
        {
            throw new NotImplementedException();
        }

    }
}