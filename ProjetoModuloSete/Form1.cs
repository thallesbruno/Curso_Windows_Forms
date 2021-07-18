using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModuloSete
{
    public partial class Form1 : Form
    {
        private Carro meuCarro;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            meuCarro = new Carro();
            meuCarro.cor = "Prata";
            meuCarro.modelo = "Honda City";
            MessageBox.Show(ConverterParaString(meuCarro));
            //MessageBox.Show(meuCarro.cor);

            Motocicleta minhaMoto = new Motocicleta();
            minhaMoto.cor = "Preta";
            //MessageBox.Show(minhaMoto.Ligar());
            MessageBox.Show(ConverterParaString(minhaMoto));

            /*Veiculo meuVeiculo = new Veiculo();
            meuVeiculo.cor = "Azul";
            MessageBox.Show(ConverterParaString(meuVeiculo));*/
        }

        public string ConverterParaString(Veiculo veiculo)
        {
            if (typeof(Veiculo) == veiculo.GetType())
            {
                return "Veiculo Cor: " + veiculo.cor;
            }
            else if (typeof(Carro) == veiculo.GetType())
            {
                return "Carro Cor: " + veiculo.cor;
            }
            else if (typeof(Motocicleta) == veiculo.GetType())
            {
                return "Motocicleta Cor: " + veiculo.cor;
            }return String.Empty;
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(meuCarro.Ligar());
            //MessageBox.Show(meuCarro.Ligar(10));
            //MessageBox.Show(meuCarro.Ligar(10.50));
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(meuCarro.Acelerar());
        }

    }
}
