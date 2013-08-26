using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Common
{
    public class BFS : ExampleBase
    {
        private Graph<int> graph;

        protected override string Name
        {
            get { return "BFS (Breath first search)"; }
        }

        protected override void Initialize()
        {
            graph = new Graph<int>(6);

            graph.AddVertex(new Vertex<int> { Data = 10 });
            graph.AddVertex(new Vertex<int> { Data = 11 });
            graph.AddVertex(new Vertex<int> { Data = 12 });
            graph.AddVertex(new Vertex<int> { Data = 13 });
            graph.AddVertex(new Vertex<int> { Data = 14 });
            graph.AddVertex(new Vertex<int> { Data = 15 });

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(0, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(1, 5);
            graph.AddEdge(2, 5);
        }

        protected override void RunExample()
        {
            LinkedList<Vertex<int>> q = new LinkedList<Vertex<int>>();

            Vertex<int> root= graph[0];
            root.isVisited = true;
            Console.WriteLine(root.Data);
            q.AddLast(root);

            while (q.Count > 0)
            {
                Vertex<int> n= q.ElementAt(0);
                q.RemoveFirst();
                Vertex<int> child = null;

                while ((child = graph.getUnvisitedChildNode(n)) != null)
                {
                    child.isVisited = true;
                    q.AddLast(child);
                    Console.WriteLine(child.Data);
                }
            }

        }
    }
}
