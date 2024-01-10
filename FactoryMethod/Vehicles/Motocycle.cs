using System;

namespace FactoryMethod.Vehicles
{
    internal class Motocycle : IVehicles
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega");
        }
    }
}
