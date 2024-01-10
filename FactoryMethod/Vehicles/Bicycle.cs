using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    internal class Bicycle : IVehicles
    {
        public void GetCargo()
        {
            Console.WriteLine("Indo até o ponto de início para pegar a encomenda");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Encomenda em mãos. Iniciando a rota de entrega");
        }
    }
}
