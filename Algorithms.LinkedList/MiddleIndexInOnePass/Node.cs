﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleIndexInOnePass
{
    public class Node<T>
    {        
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public override string ToString()
        {
            return String.Format("{0}", Data);
        }
    }
}
