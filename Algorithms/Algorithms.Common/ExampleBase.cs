﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Common
{
    public abstract class ExampleBase : IExample
    {

        protected abstract string Name { get; }

        protected abstract string Help { get; set; }

        protected abstract void Initialize();

        protected abstract void RunExample();

        public void Execute()
        {
            Initialize();

            RunExample();
        }

        string IExample.Name
        {
            get { return Name; }
        }

        string IExample.Help
        {
            get
            {
                return Help;
            }
            set
            {
                Help = Help;
            }
        }

        void IExample.Initialize()
        {
            Initialize();
        }

        void IExample.RunExample()
        {
            RunExample();
        }
    }
}
