using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModuloOito
{
    public class UsuarioBD
    {
        public string BuscarNome(int id)
        {
            MySqlConnection conexao = ConexaoBD.getInstancia().getConexao();
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();
                comando.CommandText = "SELECT NOME FROM USUARIOS WHERE ID = @varId";
                comando.Parameters.AddWithValue("varId", Convert.ToInt32(id));

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["NOME"] != null)
                    {
                        return reader["NOME"].ToString();
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
            return string.Empty;
        }

        public void InserirUsuario(string nome)
        {
            MySqlConnection conexao = ConexaoBD.getInstancia().getConexao();
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();
                comando.CommandText = "INSERT INTO USUARIOS (NOME) VALUES (@varNome)";
                comando.Parameters.AddWithValue("varNome", nome);
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

        public void EditarRegistro(int id, string nome)
        {
            MySqlConnection conexao = ConexaoBD.getInstancia().getConexao();

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();
                comando.CommandText = "UPDATE USUARIOS SET NOME = @varNome WHERE ID = @varId";
                comando.Parameters.AddWithValue("varNome", nome);
                comando.Parameters.AddWithValue("varId", id);
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
    }
}
