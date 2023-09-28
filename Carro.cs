using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funilaria
{
    internal class Carro : ICarro
    {
        public string Nome { get; set; }
        private static int codigo;
        public int Id { get; }

        public Carro()
        {
            Nome = "Carro";
            Id = ++codigo;
        }
    }
}
