using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModuloSeteExemplo.Endereco
{
    public class Cidade : Entidade
    {
        public Cidade()
        {
            this.Estado = new Estado();
        }
        public Estado Estado { get; set; }
    }
}
