﻿using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;


namespace AbstractFactory.Factories
{
    internal class UberTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Airplane();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Car();
        }
    }
}
