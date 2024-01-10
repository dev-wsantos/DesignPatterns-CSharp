using FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    internal class MotocycleTransport : Transport
    {
        protected override IVehicles CreateTransport()
        {
            return new Motocycle();
        }
    }
}
