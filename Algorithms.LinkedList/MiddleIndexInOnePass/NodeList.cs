using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleIndexInOnePass
{
    public class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public LinkedList()
        {
            this.head = new Node<T>();
            tail = head;
        }

        public Node<T> Head()
        {
            return head;
        }

        public void add(Node<T> node)
        {
            tail.Next = node;
            tail = node;
        }
    }
}
