using System;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace ProjetoModuloOito
{
    class Connection
    {
        public void Conectar()
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);
        }
    }
}
