using System;

namespace AbstractFactory.Aircrafts
{
    internal class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando o vento... vento sudeste, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros okay! Ligando as hélices");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem...");
        }
    }
}
