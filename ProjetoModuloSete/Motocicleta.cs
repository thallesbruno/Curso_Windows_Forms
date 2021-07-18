using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModuloSete
{
    public class Motocicleta : IVeiculo
    {
        public String cor { get; set; }
        public String modelo { get; set; }
        public Double velocidadeMaxima { get; set; }
        public int qtdRodas { get; set; }
        public int qtdPortas { get; set; }

        public string Acelerar()
        {
            throw new NotImplementedException();
        }

        public string Ligar()
        {
            return "Motocicleta ligada.";
        }

        public string Ligar(int velocidade)
        {
            throw new NotImplementedException();
        }

        public string Ligar(double velocidade)
        {
            throw new NotImplementedException();
        }
    }
}
