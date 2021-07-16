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

        //private String cor;
        public String cor { get; set; }
        //private String modelo;
        public String modelo { get; set; }
        //private Double velocidadeMaxima;
        public Double VelocidadeMaxima { get; set; }
        //private int qtdRodas;
        public int qtdRodas { get; set; }
        //private int qtdPortas;
        public int qtdPortas { get; set; }

        //Cor
        /*public string Cor
        {
            get{ return this.cor; }
            set { this.cor = value; }
        }

        //Modelo
        public string Modelo
        {
            get{ return this.modelo; }
            set { this.modelo = value; }
        }

        //VelocidadeMaxima
        public double VelocidadeMaxima
        {
            get { return this.velocidadeMaxima; }
            set { this.velocidadeMaxima = value; }
        }

        //QtdRodas
        public int QtdRodas
        {
            get { return this.qtdRodas; }
            set { this.qtdRodas = value; }
        }

        //QtdPortas
        public int QtdPortas
        {
            get { return this.qtdPortas; }
            set { this.qtdPortas = value; }
        }*/

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