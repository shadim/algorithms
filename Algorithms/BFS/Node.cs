using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BFS
{
    public class Node<T>
    {

        private IList<Node<T>> childs = new List<Node<T>>();

        public T Data { get; set; }

        public bool Visited { get; set; }

        public IList<Node<T>> Childs
        {
            get
            {
                return childs;
            }
        }
    }
}
