using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Node<int> root = new Node<int>();
            root.Data = random.Next(100);

            Init(root,2);

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

        private static void Init(Node<int> node, int level)
        {
            if (level <= 0)
                return;

            Node<int> n1 = new Node<int>() { Data = random.Next(100)};
            Node<int> n2 = new Node<int>() { Data = random.Next(100) };

            node.Childs.Add(n1);
            node.Childs.Add(n2);

            Init(n1, --level);
            Init(n2, --level);
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
