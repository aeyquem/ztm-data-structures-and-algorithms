using System;

namespace data_structures_and_algorithms.Arrays
{
    public class DynamicArray<T>
    {
        private T[] Items { get; set; }
        public int Length { get; set; }

        public T this[int index]
        {
            get
            {
                if (Length <= 0 || index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return Items[index];
            }
            set
            {
                if (Length <= 0 || index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                Items[index] = value;
            }
        }

        public DynamicArray()
        {
            Items = new T[2];
            Length = 0;
        }

        public DynamicArray(int length)
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

        #region INSERTION
        public void Insert(T value, int index)
        {
            if (Length >= Items.Length) EnlargeCapacity();

            if (index < 0)
            {
                index = 0;
            }

            if (index >= Length)
            {
                Items[Length] = value;
            }
            else
            {
                for (int i = Length - 1; i >= index; i--)
                {
                    Items[i + 1] = Items[i];
                }
                Items[index] = value;
            }
            Length++;
        }

        public void Push(T value)
        {
            Insert(value, Length);
        }

        public void Unshift(T value)
        {
            Insert(value, 0);
        }

        #endregion INSERTION

        #region DELETION

        public T DeleteAt(int index)
        {
            if (index >= Length || Length < 1) throw new IndexOutOfRangeException();

            var shiftedValue = Items[index];

            for (int i = index + 1; i < Length; i++)
            {
                Items[i - 1] = Items[i];
            }
            Items[Length - 1] = default(T);

            Length--;
            return shiftedValue;
        }

        public T Shift()
        {
            return DeleteAt(0);
        }

        public T Pop()
        {
            return DeleteAt(Length - 1);
        }

        #endregion DELETION

    }
}