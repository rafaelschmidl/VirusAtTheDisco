using System;
using System.Collections.Generic;
using System.Text;

namespace VirusAtTheDisco
{
    class Person
    {
        public bool IsInfected { get; set; }
        public int TimePersonIsContagious { get; set; }
        public int TimeSinceInfection { get; set; }
        public bool IsImune { get; set; }

        public Person()
        {
            IsInfected = false;
            TimePersonIsContagious = 5;
            TimeSinceInfection = 0;
            IsImune = false;
        }
    }
}