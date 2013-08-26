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
            IExample[] examples = new IExample[]{
                new DFS(),
                new BFS()
            };

            Console.WriteLine("Select algorithm example:\r\n");

            for (int i = 0; i < examples.Length; i++)
            {
                Console.WriteLine("[{0}]\t\t{1}", i + 1, examples[i].Name);
            }

            int result;
            if (int.TryParse(Console.ReadLine(), out result))
            {
                IExample example = examples[result-1];

                example.Execute();
            }
            Console.WriteLine("Press any key to exit...");

            Console.ReadKey();
        }
    }
}
