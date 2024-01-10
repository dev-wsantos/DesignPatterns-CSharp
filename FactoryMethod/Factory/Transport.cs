using FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    internal abstract class Transport
    {
        public void StartTransport()
        {
            IVehicles vehicles = CreateTransport();
            vehicles.StartRoute();

        }
        protected abstract IVehicles CreateTransport();
       
    }
}
