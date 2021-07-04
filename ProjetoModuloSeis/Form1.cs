using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModuloSeis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AdicionaCaractereNUmerico(String caractere)
        {
            if (txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = caractere;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + caractere;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AdicionaCaractereNUmerico("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AdicionaCaractereNUmerico("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AdicionaCaractereNUmerico("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AdicionaCaractereNUmerico("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AdicionaCaractereNUmerico("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AdicionaCaractereNUmerico("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AdicionaCaractereNUmerico("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AdicionaCaractereNUmerico("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AdicionaCaractereNUmerico("9");
        }
    }
}
