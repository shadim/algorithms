using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Common
{
    public interface IExample
    {
         String Name { get; }

         String Help { get; set; }

         void Initialize();

         void RunExample();

         void Execute();         
    }
}
