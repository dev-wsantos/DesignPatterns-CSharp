using Builder.Components;
using Builder.Products;

namespace Builder.Builders
{
    internal interface IBuilder
    {
        void Reset();
        Vehicle GetVehicle();

        void SetSeats(int seats);
        void SetEngine(Engine engine);
        void SetTransmission(Transmission transmission);
        void SetVehicleType(VehicleType vehicleType);
        void SetAirbags(Airbargs airbargs);

    }
}
