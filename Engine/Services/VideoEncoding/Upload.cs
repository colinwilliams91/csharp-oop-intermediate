using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_oop_intermediate.Engine;

namespace csharp_oop_intermediate.Engine.Services
{
    class Upload : IActivity
    {
        public void Execute()
        {
            Console.WriteLine($"Uploading video to cloud storage");
        }
    }
}
