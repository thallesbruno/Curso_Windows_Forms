using System;

namespace ProjetoModuloSete
{
    public class Carro
    {
        public String cor;
        public String modelo;
        public Double velocidadeMaxima;
        public int qtdRodas;
        public int qtdPortas;

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
