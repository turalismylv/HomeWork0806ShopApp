﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Coffe
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public Coffe(string name, int count, double price) {

            Name = name;
            Count = count;
            Price = price;
        
        
        }
    }
}
