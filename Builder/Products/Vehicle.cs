﻿using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Products
{
    internal class Vehicle
    {
        private VehicleType vehicleType;
       
        private int seats;

        private Engine engine;

        private Airbargs airbargs;

        private Transmission transmission;

        public VehicleType VehicleType { get => vehicleType; set => vehicleType = value; }
        public int Seats { get => seats; set => seats = value; }
        public Engine Engine { get => engine; set => engine = value; }
        public Transmission Transmission { get => transmission; set => transmission = value; }
        public Airbargs Airbargs { get => airbargs; set => airbargs = value; }
    }
}