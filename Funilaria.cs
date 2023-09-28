using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funilaria
{
    internal class Funilaria : IFunilaria
    {

        private Queue<Carro> filaCarros;
        private List<Carro> listaDeEntrega;

        public Funilaria()
        {
            this.filaCarros = new Queue<Carro>();
            this.listaDeEntrega = new List<Carro>();
        }

        public void adicionarServico(Carro carro)
        {
            this.filaCarros.Enqueue(carro);
        }

        public bool entregarCarro(int id)
        {
            foreach (var item in listaDeEntrega)
            {
                if (item.Id == id)
                {
                    return listaDeEntrega.Remove(item);                   
                }
                
            }
            return false;
        }

        public void fazerServico()
        {        
            this.listaDeEntrega.Add(this.filaCarros.Dequeue());
        }

        public int mostrarQuantidadeCarroEmServico()
        {
            return filaCarros.Count;
        }
    }
}
