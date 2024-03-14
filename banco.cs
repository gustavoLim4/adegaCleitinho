using MySql.Data.MySqlClient;
using Mysqlx.Session;
using Org.BouncyCastle.Asn1.BC;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace adegaCleitinho
{
    public static class banco
    {
        // tabelas
        public static DataGridView dgContato, dgEstoque, dgFuncionario, dgCliente, dgFornecedores, dgEmail, dgProdutos, dgCompra;
        // tabelas


        // menu exibir
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
        public static void carregarCompras()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT SUM(precoCompra) AS precoCompra FROM vnum_quantidade_compras;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.somageralCompras = reader.GetDouble(0);

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
                dgContato.Columns[0].Visible = false;

                dgContato.Columns[1].HeaderText = "Nome";
                dgContato.Columns[2].HeaderText = "Email";
                dgContato.Columns[3].HeaderText = "Telefone";
                dgContato.Columns[4].HeaderText = "Mensagem";

                dgContato.Columns[5].HeaderText = "Data";
                dgContato.Columns[6].HeaderText = "Hora";
                dgContato.Columns[7].Visible = false;

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
        // menu exibir



        //FUNCIONARIOS
        private static bool ValidarFTP()
        {
            if (string.IsNullOrEmpty(variaveis.enderecoServidorFtp) || string.IsNullOrEmpty(variaveis.usuarioFtp) || string.IsNullOrEmpty(variaveis.senhaFtp))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static byte[] GetImgToByte(string caminhoArquivoFtp)
        {
            try
            {
                WebClient ftpclient = new WebClient();
                ftpclient.Credentials = new NetworkCredential(variaveis.usuarioFtp, variaveis.senhaFtp);
                byte[] imageToByte = ftpclient.DownloadData(caminhoArquivoFtp);
                return imageToByte;
            }
            catch
            {
                WebClient ftpclient = new WebClient();
                ftpclient.Credentials = new NetworkCredential(variaveis.usuarioFtp, variaveis.senhaFtp);
                byte[] imageToByte = ftpclient.DownloadData(variaveis.enderecoServidorFtp + @"\funcionario\semfoto.png");
                return imageToByte;
            }
        }

        //Converter a imagem de Byte para IMG
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        public static void CarragarInstrutores()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM funcionarios";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgFuncionario.DataSource = dt;

                dgFuncionario.Columns[0].Visible = false;
                dgFuncionario.Columns[1].HeaderText = "Nome";
                dgFuncionario.Columns[2].HeaderText = "Data Nascimento";
                dgFuncionario.Columns[3].HeaderText = "Cargo";
                dgFuncionario.Columns[4].HeaderText = "Email";
                dgFuncionario.Columns[5].HeaderText = "Senha";
                dgFuncionario.Columns[6].HeaderText = "Nivel";
                dgFuncionario.Columns[7].HeaderText = "Telefone";
                dgFuncionario.Columns[8].HeaderText = "admissão";
                dgFuncionario.Columns[9].Visible = false;
                dgFuncionario.Columns[10].HeaderText = "status";

                dgFuncionario.ClearSelection();

                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar o Funcionario!\n\n" + erro);
            }
        }
        public static void CarregaInstrutorStatus()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM funcionarios WHERE statusFuncionario = 'ATIVO' ORDER BY nomeFuncionario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgFuncionario.DataSource = dt;

                dgFuncionario.Columns[0].Visible = false;
                dgFuncionario.Columns[1].HeaderText = "Nome";
                dgFuncionario.Columns[2].HeaderText = "Data Nascimento";
                dgFuncionario.Columns[3].HeaderText = "Cargo";
                dgFuncionario.Columns[4].HeaderText = "Email";
                dgFuncionario.Columns[5].HeaderText = "Senha";
                dgFuncionario.Columns[6].HeaderText = "Nivel";
                dgFuncionario.Columns[7].HeaderText = "Telefone";
                dgFuncionario.Columns[8].HeaderText = "admissão";
                dgFuncionario.Columns[9].Visible = false;
                dgFuncionario.Columns[10].HeaderText = "status";

                dgFuncionario.ClearSelection();

                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar o status Funcionario!\n\n" + erro);
            }
        }
        public static void CarregaInstrutorNome()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM funcionarios WHERE nomeFuncionario LIKE '%" + variaveis.nomeFuncionario + "%' ORDER BY nomeFuncionario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgFuncionario.DataSource = dt;

                dgFuncionario.Columns[0].Visible = false;
                dgFuncionario.Columns[1].HeaderText = "Nome";
                dgFuncionario.Columns[2].HeaderText = "Data Nascimento";
                dgFuncionario.Columns[3].HeaderText = "Cargo";
                dgFuncionario.Columns[4].HeaderText = "Email";
                dgFuncionario.Columns[5].HeaderText = "Senha";
                dgFuncionario.Columns[6].HeaderText = "Nivel";
                dgFuncionario.Columns[7].HeaderText = "Telefone";
                dgFuncionario.Columns[8].HeaderText = "admissão";
                dgFuncionario.Columns[9].Visible = false;
                dgFuncionario.Columns[10].HeaderText = "status";

                dgFuncionario.ClearSelection();

                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar o nome Funcionario!\n\n" + erro);
            }
        }

        public static void InserirInstrutor()
        {
            try
            {
                conexao.Conectar();
                string inserir = "INSERT INTO funcionarios(nomeFuncionario,dataNascFuncionario, cargoFuncionario, emailFuncionario, senhaFuncionario, nivelFuncionario, telefoneFuncionario, admissaoFuncionaro, statusFuncionario , fotoFuncionario) VALUES (@nome,@dataNas,@cargo,@email,@senha,@nivel,@telefone,@dataAdm,@status, @foto);";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);

                cmd.Parameters.AddWithValue("@nome", variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@dataNas", variaveis.dataNascFuncionario);
                cmd.Parameters.AddWithValue("@cargo", variaveis.cargoFuncionario);
                cmd.Parameters.AddWithValue("@email", variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhaFuncionario);
                cmd.Parameters.AddWithValue("@nivel", variaveis.nivelFuncionario);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefoneFuncionario);
                cmd.Parameters.AddWithValue("@dataAdm", variaveis.admissaoFuncionaro);
                cmd.Parameters.AddWithValue("@status", variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@foto", variaveis.fotoFuncionario);

                cmd.ExecuteNonQuery();
                var resposta = MessageBox.Show("O Cadastro foi realizado com sucesso?", "Sucesso", MessageBoxButtons.OK);
                if (resposta == DialogResult.OK)
                {
                    new funcionario().Show();

                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastra funcionario!\n\n" + erro.Message, "ERRO");
            }
        }
        public static void CarregarDadosFuncionario()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM funcionarios WHERE idFuncionario = @codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codInstrutores);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    variaveis.nomeFuncionario = reader.GetString(1);
                    variaveis.emailFuncionario = reader.GetString(4);
                    variaveis.senhaFuncionario = reader.GetString(5);
                    variaveis.cargoFuncionario = reader.GetString(3);
                    variaveis.nivelFuncionario = reader.GetString(6);
                    variaveis.dataNascFuncionario = reader.GetDateTime(2);
                    variaveis.fotoInstrutor = variaveis.fotoInstrutor.Remove(0, 12);
                    variaveis.admissaoFuncionaro = reader.GetDateTime(8);
                    variaveis.telefoneFuncionario = reader.GetString(7);
                    variaveis.statusFuncionario = reader.GetString(10);

                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os dados de funcionario !\n\n" + erro);
            }


        }
        public static void AlterarFuncionario()
        {
            try
            {
                conexao.Conectar();
                string inserir = "UPDATE funcionarios SET nomeFuncionario=@nome,dataNascFuncionario=@dataNasc,cargoFuncionario=@cargo,emailFuncionario=@email,senhaFuncionario=@senha,nivelFuncionario=@nivel,telefoneFuncionario=@telefone,admissaoFuncionaro=@admissao,statusFuncionario=@status WHERE idFuncionario = @codigo";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);

                cmd.Parameters.AddWithValue("@nome", variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@email", variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhaFuncionario);
                cmd.Parameters.AddWithValue("@cargo", variaveis.cargoFuncionario);
                cmd.Parameters.AddWithValue("@nivel", variaveis.nivelFuncionario);
                cmd.Parameters.AddWithValue("@dataNasc", variaveis.dataNascFuncionario);
                cmd.Parameters.AddWithValue("@admissao", variaveis.admissaoFuncionaro);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefoneFuncionario);
                cmd.Parameters.AddWithValue("@status", variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codInstrutores);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario alterado com sucessso!", "ALTERAÇÃO DO FUNCIONARIO");

            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os dados de funcionario !\n\n" + erro);
            }
        }

        public static void AlterarFoto()
        {
            try
            {
                conexao.Conectar();
                string inserir = "UPDATE funcionarios SET fotoFuncionario = @foto WHERE idFuncionario=@codigo";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);
                //parâmetros
                cmd.Parameters.AddWithValue("@foto", variaveis.fotoInstrutor);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codInstrutores);
                //fim parâmetros

                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotoInstrutor))
                    {
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "funcionario/" + Path.GetFileName(variaveis.fotoInstrutor); // nome da pasta aonde ira ser armazenado as fotos (de acordo com o projeto (funcionario))
                        try
                        {
                            ftp.EnviarArquivoFtp(variaveis.caminhoFotoInstrutores, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                        }
                        catch
                        {
                            MessageBox.Show("Foto não selecionada ou existente.", "FOTO");
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar a foto do Funcionário!\n\n" + erro.Message, "ERRO");
            }
        }





        public static void DesativarFuncionario()
        {
            try
            {
                conexao.Conectar();
                string inserir = "UPDATE funcionarios SET statusFuncionario='DESATIVADO' WHERE idFuncionario=@codigo";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);
                //parametros

                cmd.Parameters.AddWithValue("@status", variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codInstrutores);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario deletado com sucessso!", "ALTERAÇÃO DO FUNCIONARIO");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao desativar funcionario!\n\n" + erro.Message, "ERRO!");
            }
        }
        //FUNCIONARIOS



        //Clientes
        public static void CarregarClientes()
            {
                try
                {
                    conexao.Conectar();
                    string selecionar = "SELECT * FROM usuarios;";
                    MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgCliente.DataSource = dt;

                    dgCliente.Columns[0].Visible = false;
                    dgCliente.Columns[1].HeaderText = "Nome";
                    dgCliente.Columns[2].HeaderText = "Email";
                    dgCliente.Columns[3].HeaderText = "Senha";
                    dgCliente.Columns[4].HeaderText = "Data";
                    dgCliente.Columns[5].HeaderText = "Telefone";
                    dgCliente.Columns[6].HeaderText = "Endereço";
                    dgCliente.Columns[7].HeaderText = "CEP";
                    dgCliente.Columns[8].Visible = false;

                    dgCliente.ClearSelection();

                    conexao.Desconectar();

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar clientes!\n\n" + erro);
                }
            }
            public static void CarregarStatusClientes()
            {
                try
                {
                    conexao.Conectar();
                    string selecionar = "SELECT * FROM usuarios WHERE statusUsuario = 'ATIVO' ORDER BY nomeUsuario;";
                    MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgCliente.DataSource = dt;

                    dgCliente.Columns[0].Visible = false;
                    dgCliente.Columns[1].HeaderText = "Nome";
                    dgCliente.Columns[2].HeaderText = "Email";
                    dgCliente.Columns[3].HeaderText = "Senha";
                    dgCliente.Columns[4].HeaderText = "Data";
                    dgCliente.Columns[5].HeaderText = "Telefone";
                    dgCliente.Columns[6].HeaderText = "Endereço";
                    dgCliente.Columns[7].HeaderText = "CEP";
                    dgCliente.Columns[8].Visible = false;

                    dgCliente.ClearSelection();

                    conexao.Desconectar();

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar status clientes!\n\n" + erro);
                }
            }
            public static void CarregarUsarioNome()
            {
                try
                {
                    conexao.Conectar();
                    string selecionar = "SELECT * FROM usuarios WHERE nomeUsuario LIKE '%" + variaveis.nomeUsuario + "%' ORDER BY nomeUsuario;";
                    MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgCliente.DataSource = dt;

                    dgCliente.Columns[0].Visible = false;
                    dgCliente.Columns[1].HeaderText = "Nome";
                    dgCliente.Columns[2].HeaderText = "Email";
                    dgCliente.Columns[3].HeaderText = "Senha";
                    dgCliente.Columns[4].HeaderText = "Data";
                    dgCliente.Columns[5].HeaderText = "Telefone";
                    dgCliente.Columns[6].HeaderText = "Endereço";
                    dgCliente.Columns[7].HeaderText = "CEP";
                    dgCliente.Columns[8].Visible = false;

                    dgCliente.ClearSelection();

                    conexao.Desconectar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar nome clientes!\n\n" + erro);
                }
            }
            //Clientes


            //Fornecedores
            public static void CarregarFornecedores()
            {
                try
                {
                    conexao.Conectar();
                    string selecionar = "SELECT * FROM fornecedores";
                    MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgFornecedores.DataSource = dt;

                    dgFornecedores.Columns[0].Visible = false;
                    dgFornecedores.Columns[1].HeaderText = "Nome";
                    dgFornecedores.Columns[2].HeaderText = "Telefone";
                    dgFornecedores.Columns[3].HeaderText = "Endereço";
                    dgFornecedores.Columns[4].HeaderText = "CEP";
                    dgFornecedores.Columns[5].HeaderText = "CNPJ";
                    dgFornecedores.Columns[6].Visible = false;


                    dgFornecedores.ClearSelection();

                    conexao.Desconectar();

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar o Fornecedores!\n\n" + erro);
                }
            }
            public static void CarregarStatusFornecedores()
            {
                try
                {
                    conexao.Conectar();
                    string selecionar = "SELECT * FROM fornecedores WHERE statusFornecedor = 'ATIVO' ORDER BY nomeFornecedor;";
                    MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgFornecedores.DataSource = dt;

                    dgFornecedores.Columns[0].Visible = false;
                    dgFornecedores.Columns[1].HeaderText = "Nome";
                    dgFornecedores.Columns[2].HeaderText = "Telefone";
                    dgFornecedores.Columns[3].HeaderText = "Endereço";
                    dgFornecedores.Columns[4].HeaderText = "CEP";
                    dgFornecedores.Columns[5].HeaderText = "CNPJ";
                    dgFornecedores.Columns[6].Visible = false;


                    dgFornecedores.ClearSelection();

                    conexao.Desconectar();

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar o Fornecedores!\n\n" + erro);
                }
            }
            public static void CarregarFornecedoresNome()
            {
                try
                {
                    conexao.Conectar();
                    string selecionar = "SELECT * FROM fornecedores WHERE nomeFornecedor LIKE '%" + variaveis.nomeFornecedor + "%' ORDER BY nomeFornecedor";
                    MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgFornecedores.DataSource = dt;

                    dgFornecedores.Columns[0].Visible = false;
                    dgFornecedores.Columns[1].HeaderText = "Nome";
                    dgFornecedores.Columns[2].HeaderText = "Telefone";
                    dgFornecedores.Columns[3].HeaderText = "Endereço";
                    dgFornecedores.Columns[4].HeaderText = "CEP";
                    dgFornecedores.Columns[5].HeaderText = "CNPJ";
                    dgFornecedores.Columns[6].Visible = false;


                    dgFornecedores.ClearSelection();

                    conexao.Desconectar();

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar o Fornecedores!\n\n" + erro);
                }
            }
            //Fornecedores


            //E-mail
            public static void CarregarEmail()
            {
                try
                {
                    conexao.Conectar();
                    string selecionar = "SELECT * FROM contato";
                    MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgEmail.DataSource = dt;

                    dgEmail.Columns[0].Visible = false;
                    dgEmail.Columns[1].HeaderText = "Nome";
                    dgEmail.Columns[2].HeaderText = "email";
                    dgEmail.Columns[3].HeaderText = "Telefone";
                    dgEmail.Columns[4].HeaderText = "Assunto";
                    dgEmail.Columns[5].HeaderText = "Data";
                    dgEmail.Columns[6].HeaderText = "Hora";
                    dgEmail.Columns[7].Visible = false;

                    dgEmail.ClearSelection();

                    conexao.Desconectar();

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar o E-mail!\n\n" + erro);
                }
            }
            public static void CarregarStatusEmail()
            {
                try
                {
                    conexao.Conectar();
                    string selecionar = "SELECT * FROM contato WHERE statusContato = 'ATIVO' ORDER BY nomeContato;";
                    MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgEmail.DataSource = dt;

                    dgEmail.Columns[0].Visible = false;
                    dgEmail.Columns[1].HeaderText = "Nome";
                    dgEmail.Columns[2].HeaderText = "email";
                    dgEmail.Columns[3].HeaderText = "Telefone";
                    dgEmail.Columns[4].HeaderText = "Assunto";
                    dgEmail.Columns[5].HeaderText = "Data";
                    dgEmail.Columns[6].HeaderText = "Hora";
                    dgEmail.Columns[7].Visible = false;

                    dgEmail.ClearSelection();

                    conexao.Desconectar();

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar status o E-mail!\n\n" + erro);
                }
            }
            public static void CarregarEmailNome()
            {
                try
                {
                    conexao.Conectar();
                    string selecionar = "SELECT * FROM contato WHERE nomeContato LIKE '%" + variaveis.nomeContato + "%' ORDER BY nomeContato;";
                    MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgEmail.DataSource = dt;

                    dgEmail.Columns[0].Visible = false;
                    dgEmail.Columns[1].HeaderText = "Nome";
                    dgEmail.Columns[2].HeaderText = "email";
                    dgEmail.Columns[3].HeaderText = "Telefone";
                    dgEmail.Columns[4].HeaderText = "Assunto";
                    dgEmail.Columns[5].HeaderText = "Data";
                    dgEmail.Columns[6].HeaderText = "Hora";
                    dgEmail.Columns[7].Visible = false;

                    dgEmail.ClearSelection();

                    conexao.Desconectar();

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar o nome E-mail!\n\n" + erro);
                }
            }
            //E-mail


            //produtos
            public static void CarregarProdutos()
            {
                try
                {
                    conexao.Conectar();
                    string selecionar = "SELECT * FROM produto;";
                    MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgProdutos.DataSource = dt;

                    dgProdutos.Columns[0].Visible = false;
                    dgProdutos.Columns[1].HeaderText = "Marca";
                    dgProdutos.Columns[2].HeaderText = "Nome";
                    dgProdutos.Columns[3].HeaderText = "Validade";
                    dgProdutos.Columns[4].HeaderText = "Alcoolico";
                    dgProdutos.Columns[5].HeaderText = "Quantidade";
                    dgProdutos.Columns[6].Visible = false;
                    dgProdutos.Columns[7].HeaderText = "Forcenecedor";

                    dgProdutos.ClearSelection();

                    conexao.Desconectar();

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar o E-mail!\n\n" + erro);
                }
            }
            //produtos


            //compra

            public static void CarregarCompra()
            {
                try
                {
                    conexao.Conectar();
                    string selecionar = "SELECT usuarios.nomeUsuario ,compra.dataCompra, compra.horaCompra,compra.precoCompra FROM compra INNER JOIN usuarios ON compra.idCompra = usuarios.idUsuario;";
                    MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgCompra.DataSource = dt;

                    dgCompra.Columns[0].HeaderText = "Nome";
                    dgCompra.Columns[1].HeaderText = "Data";
                    dgCompra.Columns[2].HeaderText = "hora";
                    dgCompra.Columns[3].HeaderText = "preço";
                    dgCompra.ClearSelection();

                    conexao.Desconectar();

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar o Compra!\n\n" + erro);
                }

                //compra

            }
       
    
    }

    public class Bitmap
    {
        private MemoryStream mStream;
        private bool v;

        public Bitmap(MemoryStream mStream, bool v)
        {
            this.mStream = mStream;
            this.v = v;
        }
    }
}
