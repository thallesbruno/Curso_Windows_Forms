using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModuloSeteExemplo
{
    public class Livro : Entidade
    {
        public Livro()
        {
            this.ListaAutores = new List<Autor>;
            this.Editora = new Editora();
        }
        public double PrecoCompra { get; set; }
        public double PrecoVenda { get; set; }
        public List<Autor> ListaAutores { get; set; }
        public Editora Editora { get; set; }
    }
}
