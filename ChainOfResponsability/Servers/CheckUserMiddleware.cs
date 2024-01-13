using System;
using ChainOfResponsability.Middlewares;


namespace ChainOfResponsability.Servers
{
    internal class CheckUserMiddleware : Middleware
    {
        private Server server;

        public CheckUserMiddleware(Server server)
        {
            this.server = server;
        }

        public override bool Check(string email, string password)
        {
           if(!server.HasEmail(email)) 
           {

                Console.WriteLine("E-mail inválido");

                return false;
           }

           if (!server.IsValidPassword(email, password))
           {
                Console.WriteLine("E-mail ou senha inválidos");

                return false;
           }

           return CheckNext(email, password);
        }
    }
}
