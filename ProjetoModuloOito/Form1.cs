using System;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace ProjetoModuloOito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new UsuarioBD().BuscarNome(Convert.ToInt32(txtIdBusca.Text.Trim())));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new UsuarioBD().InserirUsuario(txtNome.Text.Trim());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new UsuarioBD().EditarRegistro(Convert.ToInt32(txtId.Text.Trim()), txtNome2.Text.Trim());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new UsuarioBD().ExcluirRegistro(Convert.ToInt32(txtId2.Text.Trim()));
        }
    }
}