using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adegaCleitinho
{
    public static class banco
    {
        public static DataGridView  dgContato , dgEstoque;
        public static void carregarFuncionario()
        { 

            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM vnum_quantidade_funcionarios_ativos";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.qtdeFuncionario = reader.GetInt32(0);
                }
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar q qtde de alunos!\n\n" + erro);

            }
        }
        public static void carregarFornecedores()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM vnum_quantidade_fornecedores_ativos";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.qtdeFornecedores = reader.GetInt32(0);
                }
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar q qtde de alunos!\n\n" + erro);

            }
        }
        public static void carregarClientes()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM vnum_quantidade_usuarios_ativos";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.qtdeCliente = reader.GetInt32(0);
                }
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar q qtde de alunos!\n\n" + erro);

            }
        }

        public static void CarregaContato()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM contato";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgContato.DataSource = dt;
                dgContato.Columns[0].Visible = false; ;

                dgContato.Columns[1].HeaderText = "Nome";
                dgContato.Columns[2].HeaderText = "Email";
                dgContato.Columns[3].HeaderText = "Telefone";
                dgContato.Columns[4].HeaderText = "Mensagem";

                dgContato.Columns[5].HeaderText = "Data";
                dgContato.Columns[6].HeaderText = "Hora";
                dgContato.Columns[7].HeaderText = "Status";

                dgContato.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os e-mails !\n\n" + erro);
            }

        }
        public static void CarregaEstoque()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT marcaProduto, nomeProduto,quantidadeProduto FROM produto ;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgEstoque.DataSource = dt;
               

                dgEstoque.Columns[0].HeaderText = "Marca";
                dgEstoque.Columns[1].HeaderText = "Nome";
                dgEstoque.Columns[2].HeaderText = "quantidade";

                dgEstoque.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar o estoque!\n\n" + erro);
            }

        }

    }
}
