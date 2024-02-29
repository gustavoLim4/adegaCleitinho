using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace adegaCleitinho
{
    public static class conexao
    {
        //string de conexão com o banco dde dados 
        public static string db = "SERVER=localhost;USER=root;DATABASE=dbadega";

        //reconhecer a biblioteca do musql 
        public static MySqlConnection conn;

        //metodo para conectar o banco de dados
        public static void Conectar()
        {
            try
            {
                conn = new MySqlConnection(db);
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o banco de dados", "ERRO");
            }
        }
        public static void Desconectar()
        {
            try
            {
                conn = new MySqlConnection(db);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao desconectar com o banco de dados", "ERRO");
            }
        }
    }
}
