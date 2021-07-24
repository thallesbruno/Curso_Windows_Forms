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

                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();
                if (txtIdBusca.Text.Trim().Equals(String.Empty))
                {
                    comando.CommandText = "SELECT NOME FROM USUARIOS";
                }
                else
                {
                    comando.CommandText = "SELECT NOME FROM USUARIOS WHERE ID = @varId";
                    comando.Parameters.AddWithValue("varId", Convert.ToInt32(txtIdBusca.Text.Trim()));
                }
                

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["NOME"] != null)
                    {
                        MessageBox.Show(reader["NOME"].ToString());
                    }
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();
                comando.CommandText = "INSERT INTO USUARIOS (NOME) VALUES (@varNome)";
                comando.Parameters.AddWithValue("varNome", txtNome.Text.Trim());
                int valorRetorno = comando.ExecuteNonQuery();
                if (valorRetorno < 1)
                    MessageBox.Show("Erro ao inserir!");
                else
                    MessageBox.Show("Registro inserido com sucesso!");
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

        private void button3_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();
                comando.CommandText = "UPDATE USUARIOS SET NOME = @varNome WHERE ID = @varId";
                comando.Parameters.AddWithValue("varNome", txtNome2.Text.Trim());
                comando.Parameters.AddWithValue("varId", Convert.ToInt32(txtId.Text.Trim()));
                int valorRetorno = comando.ExecuteNonQuery();
                if (valorRetorno < 1)
                    MessageBox.Show("Erro ao editar!");
                else
                    MessageBox.Show("Registro editado com sucesso!");
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

        private void button4_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();
                comando.CommandText = "DELETE FROM USUARIOS WHERE ID = @varId";
                comando.Parameters.AddWithValue("varId", Convert.ToInt32(txtId2.Text.Trim()));
                int valorRetorno = comando.ExecuteNonQuery();
                if (valorRetorno < 1)
                    MessageBox.Show("Erro ao excluir!");
                else
                    MessageBox.Show("Registro excluído com sucesso!");
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