using System;

namespace Bridge.Platforms
{
    internal class Facebook : IPlattform
    {
        public Facebook()
        {
            ConfigureRMTP();
            Console.WriteLine("Facebook: Transmissão iniciada");
        }
        public void AuthToken()
        {
            Console.WriteLine("Facebook: Autorizando a aplicação");
        }

        public void ConfigureRMTP()
        {
            Console.WriteLine("Configurando o servidor RMTP");
        }
    }
}
