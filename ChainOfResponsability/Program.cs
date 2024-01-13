using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;
using System;
using System.Runtime.Remoting.Channels;

namespace ChainOfResponsability
{
    internal class Program
    {
        private static Server server;

        static void Init()
        {
            server = new Server();

            server.RegisterUser("dev.usuario@outlook.com", "2893209jiwçdhfsdklfçakhsdhfla");

            server.RegisterUser("usuario@gmail.com", "MNSFISjdap9uwy498yh~4i23");

            Middleware middleware = new CheckUserMiddleware(server);

            middleware.LinkWith(new CheckPermissionMiddleware());

            server.SetMiddleware(middleware);
        }

        static void Main(string[] args)
        {
            Init();

            Boolean done;

            do
            {
                Console.Write("Digite seu e-mail: \n");

                string email = Console.ReadLine();

                Console.Write("Digite sua senha: \n");

                string senha = Console.ReadLine();

                done = server.Login(email, senha);

            } while (!done);

            Console.ReadKey();
        }
    }
}
