using System.Collections.Generic;

namespace data_structures_and_algorithms.Graphs
{
    public class Graph<T>
    {
        public Dictionary<T, HashSet<T>> Connections { get; set; }

        public Graph()
        {
            Connections = new Dictionary<T, HashSet<T>>();
        }

        public Graph(T node) : this()
        {
            AddVertex(node);
        }

        public void AddVertex(T node)
        {
            if (Connections.ContainsKey(node)) return;

            Connections.Add(node, new HashSet<T>());
        }

        public void AddEdge(T node1, T node2)
        {
            if (!Connections.ContainsKey(node1) || !Connections.ContainsKey(node2))
                return;

            if (!Connections[node1].Contains(node2))
                Connections[node1].Add(node2);

            if (!Connections[node2].Contains(node1))
                Connections[node2].Add(node1);
        }

        public void ShowConnections()
        {
            foreach (var item in Connections)
            {
                System.Console.Write($"{item.Key} --> ");
                foreach (var nextItem in item.Value)
                {
                    System.Console.Write($"{nextItem} - ");
                }
                System.Console.WriteLine("");
            }
        }

    }
}