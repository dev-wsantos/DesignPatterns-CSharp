using System;

namespace Bridge.Platforms
{
    internal class Youtube : IPlattform
    {
        public Youtube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: Transmissão iniciada");
        }


        public void AuthToken()
        {
            Console.WriteLine("Youtube: Autorizando a aplicação.");
        }

        public void ConfigureRMTP()
        {
            Console.WriteLine("Configurando o servidor RMTP.");
        }
    }
}
