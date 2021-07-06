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

        private Double numero1;
        private Double numero2;
        private String operacao;
        private double resultado;

        private bool PressionouIgual;

        private void Form1_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtDisplay.Clear();
            numero1 = 0;
            numero2 = 0;
            operacao = String.Empty;
            resultado = 0;
            PressionouIgual = false;
        }        

        private void AdicionarCaractereNumerico(String caractere)
        {
            if (PressionouIgual == true)
            {
                txtDisplay.Clear();
                PressionouIgual = false;
            }
            if (txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = caractere;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + caractere;
            }
        }

        private void AdicionarCaractereOperacao(String caractere)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                if (txtDisplay.Text.Trim().Contains("."))
                {
                    numero1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ","));
                }
                else
                {
                    numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                }
                operacao = caractere;
                txtDisplay.Clear();
            }
        }

        private void Calcular()
        {
            switch (operacao)
            {
                case "/":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("Divisão por zero!");
                        break;
                    }
                    resultado = numero1 / numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "+":
                    resultado = numero1 + numero2;
                    break;
            }
            txtDisplay.Text = resultado.ToString().Replace(",", ".");
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
            AdicionarCaractereNumerico("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AdicionarCaractereNumerico("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AdicionarCaractereNumerico("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AdicionarCaractereNumerico("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AdicionarCaractereNumerico("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AdicionarCaractereNumerico("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AdicionarCaractereNumerico("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AdicionarCaractereNumerico("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AdicionarCaractereNumerico("9");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            AdicionarCaractereOperacao("/");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            AdicionarCaractereOperacao("*");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            AdicionarCaractereOperacao("-");
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            AdicionarCaractereOperacao("+");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                if (txtDisplay.Text.Trim().Contains("."))
                {
                    numero2 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ","));
                }
                else
                {
                    numero2 = Convert.ToDouble(txtDisplay.Text.Trim());
                }
                Calcular();
                PressionouIgual = true;
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (PressionouIgual)
            {

            }
            if (txtDisplay.Text.Trim().Equals(String.Empty)) txtDisplay.Text = "0.";
            if (txtDisplay.Text.Trim().Contains(".")) return;
            txtDisplay.Text += ".";
        }
    }
}
