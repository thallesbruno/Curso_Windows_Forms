using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModuloSeteExemplo.Endereco
{
    public class EnderecoCompleto
    {
        public EnderecoCompleto()
        {
            this.Bairro = new Bairro();
        }
        public int Numero { get; set; }
        public string Rua { get; set; }
        public Bairro Bairro { get; set; }
        public String LocalReferencia { get; set; }
    }
}
