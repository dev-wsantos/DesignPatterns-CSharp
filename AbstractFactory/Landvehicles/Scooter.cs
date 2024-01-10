using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
    internal class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Carregando encomenda... encomenda carregada");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Patinete: Iniciando a rota.");
        }
    }
}
