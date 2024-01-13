using ChainOfResponsability.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Servers
{
    internal class Server
    {
        private Dictionary<string, string> _users = new Dictionary<string, string>();

        private Middleware _middleware;

        public void SetMiddleware(Middleware middleware)
        {
            _middleware = middleware;
        }

        public Boolean Login(string email, string password)
        {
            if (_middleware.Check(email, password))
            {
                Console.WriteLine("Usuário autenticado com sucesso!");
                Console.WriteLine("Seja bem vindo(a)");

                return true;
            }

            return false;
        }

        public void RegisterUser (string email, string password)
        {
            _users[email] = password;
        }

        public Boolean HasEmail(string email) 
        {   
            return _users.ContainsKey(email);
        }

        public Boolean IsValidPassword (string email, string password)
        {

            string value = string.Empty;

            _users.TryGetValue(email, out value);

            return password == value;
        }
    }
}
