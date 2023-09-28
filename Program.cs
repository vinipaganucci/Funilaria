using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funilaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funilaria funilaria1 = new Funilaria();
            Carro carro1 = new Carro();
            Carro carro2 = new Carro();
            Carro carro3 = new Carro();

            funilaria1.adicionarServico(carro1);
            funilaria1.adicionarServico(carro2);
            funilaria1.adicionarServico(carro3);

            funilaria1.mostrarQuantidadeCarroEmServico();

            funilaria1.fazerServico();
            funilaria1.fazerServico();
            funilaria1.fazerServico();

            funilaria1.mostrarQuantidadeCarroEmServico();

            funilaria1.entregarCarro(2);
            funilaria1.entregarCarro(3);
            funilaria1.entregarCarro(1);
            funilaria1.entregarCarro(5);






        }
    }
}
