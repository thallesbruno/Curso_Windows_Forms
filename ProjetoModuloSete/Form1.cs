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
        private Carro meuCarro = new Carro();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            meuCarro = new Carro();
            meuCarro.setCor("Prata");
            meuCarro.setModelo("Honda City");
            meuCarro.setQtdPortas(4);
            meuCarro.setQtdRodas(4);
            meuCarro.setVelocidadeMaxima(220);
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
