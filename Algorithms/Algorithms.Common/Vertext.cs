using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Common
{
    public class Vertex<T>
    {
        public T Data { get; set; }
        public bool isVisited { get; set; }
    }
}
