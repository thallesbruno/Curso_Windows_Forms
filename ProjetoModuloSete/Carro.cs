using System;

namespace ProjetoModuloSete
{
    public class Carro : Veiculo
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
            throw new NotImplementedException();
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