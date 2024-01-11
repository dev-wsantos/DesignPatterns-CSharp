using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Components
{
    internal class Airbargs
    {
        private bool ativo = false;

        private string name = "Airbag";

        public bool Ativo { get => ativo; set => ativo = value; }
        public string Name { get => name; }

        public Airbargs(bool ativo)
        {
            this.ativo = ativo;
        }
    }
}
