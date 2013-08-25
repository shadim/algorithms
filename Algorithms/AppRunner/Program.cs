using Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            IExample example = new DFS();

            example.Execute();

            Console.WriteLine("Press any key to exit...");

            Console.ReadKey();
        }
    }
}
