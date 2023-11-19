using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_intermediate.Engine.Services
{
    class Update : IActivity
    {
        public void Execute()
        {
            //if (context == null) 
            //    throw new Exception("DB Context null");

            Console.WriteLine($"Status of video record in DB post to \"Processing\"");
        }
    }
}
