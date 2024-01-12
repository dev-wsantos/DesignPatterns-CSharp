using Bridge.Platforms;
using System;

namespace Bridge.Transmissions
{
    internal class Live : ITransmission
    {
        protected IPlattform _plattform;

        public Live(IPlattform plattform)
        {
            _plattform = plattform;
        }

        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na plataforma {_plattform}");
            
        }

        public void Result()
        {
            Console.WriteLine("**** ON AIR ****");
        }
    }
}
