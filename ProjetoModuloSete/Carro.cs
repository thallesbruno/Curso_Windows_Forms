using System;

namespace ProjetoModuloSete
{
    public class Carro
    {
        public Carro(String cor, String modelo, Double velocidadeMaxima, int qtdRodas, int qtdPortas)
        {
            setCor(cor);
            setModelo(modelo);
            setVelocidadeMaxima(velocidadeMaxima);
            setQtdPortas(qtdPortas);
            setQtdRodas(qtdRodas);
        }

        private String cor;
        private String modelo;
        private Double velocidadeMaxima;
        private int qtdRodas;
        private int qtdPortas;

        private void setCor(string cor)
        {
            this.cor = cor;
        }

        public string getCor()
        {
            return this.cor;
        }

        private void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public string getModelo()
        {
            return this.modelo;
        }

        private void setVelocidadeMaxima(double velocidadeMaxima)
        {
            this.velocidadeMaxima = velocidadeMaxima;
        }

        public double getVelocidadeMaxima()
        {
            return this.velocidadeMaxima;
        }

        private void setQtdRodas(int qtdRodas)
        {
            this.qtdRodas = qtdRodas;
        }

        public int getQtdRodas()
        {
            return this.qtdRodas;
        }

        private void setQtdPortas(int qtdPortas)
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
