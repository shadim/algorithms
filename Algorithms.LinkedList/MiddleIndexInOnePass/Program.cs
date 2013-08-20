using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleIndexInOnePass
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            Node<int> head = linkedList.Head();

            head.Data = 100;
            linkedList.add(new Node<int>() { Data = 200 });
            linkedList.add(new Node<int>() { Data = 300 });
            linkedList.add(new Node<int>() { Data = 400 });
            linkedList.add(new Node<int>() { Data = 500 });
            linkedList.add(new Node<int>() { Data = 600 });
            linkedList.add(new Node<int>() { Data = 700 });
            linkedList.add(new Node<int>() { Data = 800 });
            linkedList.add(new Node<int>() { Data = 900 });
            linkedList.add(new Node<int>() { Data = 1000 });

            Node<int> current = head;
            Node<int> middle = head;
            int length = 0;

            Console.WriteLine("{0,-12}{1,8}{2,12}", "Iteration", "Current", "Middle");
            while (current.Next != null)
            {
                Console.WriteLine("{0,5}{1,12}{2,12}", length, current, middle);
                length++;
                if (length % 2 == 0)
                    middle = middle.Next;

                current = current.Next;
            }

            Console.WriteLine("\r\nLength:{0}", length);
            Console.WriteLine("Middle elemet:{0}", middle);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
