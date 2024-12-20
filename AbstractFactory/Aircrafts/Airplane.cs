﻿using System;

namespace AbstractFactory.Aircrafts
{
    internal class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos... ventos à 25km, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros à bordo. Vôo autorizado");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem...");
        }
    }
}
