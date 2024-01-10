﻿using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    internal class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Motocycle();
        }
    }
}
