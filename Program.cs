using System;
using data_structures_and_algorithms.Arrays;
using data_structures_and_algorithms.Graphs;
using data_structures_and_algorithms.HashTable;
using data_structures_and_algorithms.LinkedLists;
using data_structures_and_algorithms.StacksAndQueues;
using data_structures_and_algorithms.Trees;
using data_structures_and_algorithms.Algorithms.Recursion;
using data_structures_and_algorithms.Algorithms.Sorting;

namespace data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // var int1 = new int[] { 0, 2, 3, 5, 7, 11 };
            //var input = new int[] { 1, 4, 6, 8, 9, 13, 18 };
            //var input = new int[] { 2, 5, 5, 2 };
            var input = new int[] { 9, 4, 6, 20, 100, 15, 1 };
            //var input = new int[] { 100, 20, 15, 9, 4, 6, 1 };
            //var input = new int[] { 41, 72, 91, 50, 46, 68, 78, 99, 74, 89, 97, 84, 95, 41, 50 };

            var tree = new BinaryTree();
            foreach (var item in input)
            {
                tree.Insert(item);
            }

            var result = tree.BreadFirstSearch(19);
        }
    }
}
