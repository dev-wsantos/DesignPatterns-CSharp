using Bridge.Platforms;
using System;

namespace Bridge.Transmissions
{
    internal class AdvancedLive : Live
    {
        public AdvancedLive(IPlattform plattform) : base(plattform)
        {
        }

        public void Subtitle()
        {
            Console.WriteLine("Legendas ativadas na transmissão");

        }

        public void Comments()
        {
            Console.WriteLine("Comentários liberados na Live!");
        }

        public void Record()
        {
            Console.WriteLine("Iniciando gravação da Live");
        }
    }
}
