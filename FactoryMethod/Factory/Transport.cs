using FactoryMethod.Vehicles;

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
