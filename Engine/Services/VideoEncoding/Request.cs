using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_intermediate.Engine.Services
{
    class Request : IActivity
    {
        public void Execute()
        {
            Console.WriteLine($"Requesting 3rd party encoding service...");
        }
    }
}
