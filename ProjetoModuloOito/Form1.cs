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
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);

            try
            {
                conexao.Open();
                MessageBox.Show("Conexão criada com sucesso!");
            }
            catch (MySqlException mysqle)
            {

                MessageBox.Show("Erro de acesso ao MySQL: " + mysqle.Message, "Erro");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}