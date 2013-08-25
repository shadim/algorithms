using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Common
{
    public class DFS : ExampleBase
    {
        private Graph<int> graph;

        protected override string Name
        {
            get { return "DFS (Depth First Search)"; }
        }

        protected override string Help
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
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
            Vertex<int> root = graph[0];

            Stack<Vertex<int>> stack = new Stack<Vertex<int>>();
            stack.Push(root);
            Console.WriteLine(root.Data);
            root.isVisited = true;

            while (stack.Count > 0)
            {
                Vertex<int> n = stack.Peek();
                Vertex<int> child = graph.getUnvisitedChildNode(n);

                if (child != null)
                {
                    child.isVisited = true;
                    Console.WriteLine(child.Data);
                    stack.Push(child);
                }
                else
                {
                    stack.Pop();
                }
            }
        }

        
    }
}
