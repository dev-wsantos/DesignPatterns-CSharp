using System;

namespace AbstractFactory.Aircrafts
{
    internal class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos...verificando a umidade... Ventos e umidade Okay!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Preparando a encomenda... encomenda carregada");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Drone iniciando a decolagem");
        }
    }
}
