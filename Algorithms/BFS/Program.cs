using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> root = new Node<int>();
            root.Data = 1;
            root.Childs.Add(new Node<int>() { Data = 2 });
            root.Childs.Add(new Node<int>() { Data = 3 });



            List<Node<int>> queue = new List<Node<int>>();
            queue.Add(root);
            Console.WriteLine(root.Data);
            root.Visited = true;

            while (queue.Count > 0)
            {
              
                Node<int> node = queue[0];
                queue.Remove(node);
                Node<int> child = null;

                while ((child = GetUnvisitedChildNode(node)) != null)
                {
                    child.Visited = true;
                    Console.WriteLine(child.Data);
                    queue.Add(child);
                }
            }
        }

        private static Node<int> GetUnvisitedChildNode(Node<int> node)
        {
            foreach (Node<int> n in node.Childs)
                if (n.Visited == false)
                    return n;
            
            return null;
        }
    }
}
