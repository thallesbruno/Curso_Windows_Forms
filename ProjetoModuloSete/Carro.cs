using System;

namespace ProjetoModuloSete
{
    public class Carro
    {
        public String cor { get; set; }
        public String modelo { get; set; }
        public Double velocidadeMaxima { get; set; }
        public int qtdRodas { get; set; }
        public int qtdPortas { get; set; }
        public string Ligar()
        {
            return "Carro ligado!";
        }

        public string Acelerar()
        {
            return "Carro acelerou!";
        }
    }
}