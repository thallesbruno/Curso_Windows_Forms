using System;

namespace ProjetoModuloSete
{
    public class Carro
    {
        private String cor;
        private String modelo;
        private Double velocidadeMaxima;
        private int qtdRodas;
        private int qtdPortas;

        public void setCor(string cor)
        {
            this.cor = cor;
        }

        public string getCor()
        {
            return this.cor;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public string getModelo()
        {
            return this.modelo;
        }

        public void setVelocidadeMaxima(double velocidadeMaxima)
        {
            this.velocidadeMaxima = velocidadeMaxima;
        }

        public double getVelocidadeMaxima()
        {
            return this.velocidadeMaxima;
        }

        public void setQtdRodas(int qtdRodas)
        {
            this.qtdRodas = qtdRodas;
        }

        public int getQtdRodas()
        {
            return this.qtdRodas;
        }

         public void setQtdPortas(int qtdPortas)
        {
            this.qtdPortas = qtdPortas;
        }

        public int getQtdPortas()
        {
            return this.qtdPortas;
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
