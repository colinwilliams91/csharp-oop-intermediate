﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_intermediate.Engine.Services
{
    class Emailer : IActivity
    {
        public void Execute()
        {
            Console.WriteLine($"Sending email notification to video owner. Encoding process started...");
        }
    }
}
