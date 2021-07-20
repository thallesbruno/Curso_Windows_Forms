using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModuloSeteExemplo.Transacao
{
    class SaidaLivro
    {
        public SaidaLivro()
        {
            this.ListaLivros = new List<Livro>();
            this.Cliente = new Cliente();
        }
        public int Codigo { get; set; }
        public long NumeroNota { get; set; }
        public List<Livro> ListaLivros { get; set; }
        public Cliente Cliente { get; set; }

        public double CalcularPrecoTotalSaida()
        {
            double precoVendaTotal = 0;
            foreach (Livro livro in this.ListaLivros)
            {
                precoVendaTotal += livro.PrecoCompra;
            }
            return precoVendaTotal;
        }
    }
}
