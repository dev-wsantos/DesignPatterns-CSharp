using Builder.Builders;
using Builder.Components;

namespace Builder.Directors
{
    internal class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }
        public void ConstructSedanCar()
        {
            builder.SetVehicleType(VehicleType.SEDAN);
            builder.SetEngine(new Engine(2.0));
            builder.SetSeats(5);
            builder.SetTransmission(Transmission.AUTOMATIC);
        }

        public void ConstructTruck()
        {
            builder.SetVehicleType(VehicleType.TRUCK);
            builder.SetEngine(new Engine(4.0));
            builder.SetSeats(2);
            builder.SetTransmission(Transmission.MANUAL);
        }

        public void ConstructSUV()
        {
            builder.SetVehicleType(VehicleType.SUV);
            builder.SetEngine(new Engine(2.6));
            builder.SetSeats(3);
            builder.SetTransmission(Transmission.AUTOMATIC_SEQUENCIAL);
            builder.SetAirbags(new Airbargs(true));
        }
    }
}
