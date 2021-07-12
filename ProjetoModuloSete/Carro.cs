using System;

namespace ProjetoModuloSete
{
    public class Carro
    {
        public Carro()
        {
            /*Cor = cor;
            setModelo(modelo);
            setVelocidadeMaxima(velocidadeMaxima);
            setQtdPortas(qtdPortas);
            setQtdRodas(qtdRodas);*/
        }

        private String cor;
        private String modelo;
        private Double velocidadeMaxima;
        private int qtdRodas;
        private int qtdPortas;

        public string Cor
        {
            get{ return this.cor; }
            set { this.cor = value; }
        }

        public string Modelo
        {
            get{ return this.modelo; }
            set { this.modelo = value; }
        }

        public double VelocidadeMaxima
        {
            get { return this.velocidadeMaxima; }
            set { this.velocidadeMaxima = value; }
        }

        public int QtdRodas
        {
            get { return this.qtdRodas; }
            set { this.qtdRodas = value; }
        }

        public int QtdPortas
        {
            get { return this.qtdPortas; }
            set { this.qtdPortas = value; }
        }

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
