﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public class Bird : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("chip chip");
        }
    }
}
