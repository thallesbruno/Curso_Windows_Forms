using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModuloSeteExemplo.Endereco;

namespace ProjetoModuloSeteExemplo
{
    public abstract class Pessoa
    {
        public Pessoa()
        {
            this.EnderecoCompleto = new EnderecoCompleto();
        }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public EnumTipoPessoa TipoPessoa { get; set; }
        public EnderecoCompleto EnderecoCompleto { get; set; }
    }
}
