using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animals
    {
        public bool canRun;
        public bool hasLegs;
        public int Length { get; set; }
        public bool underWater;
    }
}
