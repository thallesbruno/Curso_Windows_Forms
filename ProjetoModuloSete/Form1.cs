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
            meuCarro.Cor = "Prata";
            meuCarro.Modelo = "Honda City";
            meuCarro.VelocidadeMaxima = 220;
            meuCarro.QtdPortas = 4;
            meuCarro.QtdRodas = 4;
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(meuCarro.Ligar());
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(meuCarro.Acelerar());
        }

    }
}
