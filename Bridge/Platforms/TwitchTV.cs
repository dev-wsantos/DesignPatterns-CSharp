using System;


namespace Bridge.Platforms
{
    internal class TwitchTV : IPlattform
    {
        public TwitchTV()
        {
            ConfigureRMTP();
            Console.WriteLine("TwitchTV: Iniciando a transmissão");
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
