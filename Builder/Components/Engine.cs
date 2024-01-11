using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Components
{
    internal class Engine
    {
        private double power;

        public double Power { get => power; set => power = value; }

        public Engine(double power)
        {
            this.power = power;
        }
    }
}
