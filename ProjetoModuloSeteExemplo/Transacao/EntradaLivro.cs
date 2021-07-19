using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModuloSeteExemplo.Transacao
{
    class EntradaLivro
    {
       public EntradaLivro()
        {
            this.ListaLivros = new List<Livro>();
            this.Fornecedor = new Fornecedor();
        }
        public int Codigo { get; set; }
        public long NumeroNota { get; set; }
        public List<Livro> ListaLivros { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
