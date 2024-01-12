using System;

namespace Bridge.Platforms
{
    internal class DLive : IPlattform
    {
        public DLive()
        { 
            ConfigureRMTP();
            Console.WriteLine("D-Live: Iniciando a transmissão.");
        }


        public void AuthToken()
        {
            Console.WriteLine("Autorizando a aplicação.");
        }

        public void ConfigureRMTP()
        {
            Console.WriteLine("Configurando o servidor RMTP.");
        }
    }
}
