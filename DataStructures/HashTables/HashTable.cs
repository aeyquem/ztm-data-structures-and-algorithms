using System;
using System.Collections.Generic;

namespace data_structures_and_algorithms.HashTable
{
    public class HashTable<T>
    {
        private item<T>[] Items { get; set; }

        public HashTable(int size)
        {
            Items = new item<T>[size];
        }

        private int hash(string key)
        {
            var hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)(key[i]) * i) % Items.Length;
            }
            return hash;
        }

        public void set(string key, T value)
        {
            var hashedKey = hash(key);
            var newItem = new item<T>(key, value);
            var item = Items[hashedKey];

            if (item == null)
            {
                Items[hashedKey] = newItem;
            }
            else
            {
                while (item.Next != null)
                {
                    item = item.Next;
                }
                item.Next = newItem;
            }
            //if we try to use
            // while(item != null)
            // {
            //     item = item.next;
            // }
            //item = newItem;
            // the array is not updated 🤷‍♂️
        }

        public T get(string key)
        {
            var hashedKey = hash(key);
            Console.WriteLine($"{key} : {Items[hashedKey]}");
            var item = Items[hashedKey];
            while (item?.Key != key)
            {
                item = item.Next;
            }
            return item.Value;
        }


        public string[] keys()
        {
            var keys = new List<string>();
            for (int i = 0; i < Items.Length; i++)
            {
                var item = Items[i];
                while (item != null)
                {
                    keys.Add(item.Key);
                    item = item.Next;
                }
            }

            return keys.ToArray();
        }

    }

    public class item<T>
    {
        public string Key { get; set; }
        public T Value { get; set; }
        public item<T> Next { get; set; }

        public item(string key, T value)
        {
            this.Key = key;
            this.Value = value;
            Next = null;
        }
    }
}