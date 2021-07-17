using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModuloSete
{
    public class Veiculo
    {
        public String cor { get; set; }
        public String modelo { get; set; }
        public Double velocidadeMaxima { get; set; }
        public int qtdRodas { get; set; }
        public int qtdPortas { get; set; }

        public string Ligar()
        {
            return "Veículo ligado!";
        }
        public string Ligar(int velocidade)
        {
            return "Veículo ligado! Velocidade inicial: " + velocidade;
        }
        public string Ligar(double velocidade)
        {
            return "Veículo ligado! Velocidade inicial: " + velocidade;
        }

        public string Acelerar()
        {
            return "Veículo acelerou!";
        }
    }
}
