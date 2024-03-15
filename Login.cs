using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adegaCleitinho
{
    public partial class frmadega : Form
    {

        int mostrar = 0;

        public frmadega()
        {
            InitializeComponent();
        }


        private void btnEntraLG_Click(object sender, EventArgs e)
        {
            variaveis.usuario = txtEmail.Text;
            variaveis.senha = txtSenha.Text;

            if (variaveis.usuario == "gustavo" && variaveis.senha == "1234")
            {

                variaveis.nivel = "NÍVEL 1";
                new menuprincipal().Show();
                Hide();

            }
            else
            {
                try
                {
                    conexao.Conectar();
                    string selecionar = "SELECT nomeFuncionario , emailFuncionario , senhaFuncionario , nivelFuncionario FROM funcionarios WHERE emailFuncionario=@email AND senhaFuncionario=@senha AND statusFuncionario=@status";

                    MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                    cmd.Parameters.AddWithValue("@email", variaveis.usuario);
                    cmd.Parameters.AddWithValue("@senha", variaveis.senha);
                    cmd.Parameters.AddWithValue("@status", "ATIVO");

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        variaveis.usuario = reader.GetString(1);
                        variaveis.nivel = reader.GetString(3);
                        MessageBox.Show(variaveis.usuario + variaveis.senha + variaveis.nivel);
                        new menuprincipal().Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("ACESSO NEGADO!");
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtEmail.Focus();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro ao logar." + err);
                }
            }
        }

        private void pctFecharLogin_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("deseja sair ", "ENCERRAR", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Enabled = true;
                txtSenha.Focus();

            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntraLG.Enabled = true;
                btnEntraLG.Focus();

            }
        }

        private void pctMostrar_Click(object sender, EventArgs e)
        {
            if (mostrar == 0)
            {
                txtSenha.PasswordChar = '\0';
                pctMostrar.Image = Properties.Resources.esconder;
                mostrar = 1;
            }
            else
            {
                txtSenha.PasswordChar = '*';
                pctMostrar.Image = Properties.Resources.mostrar; //ao click ela vai mostrar o olho diferente
                mostrar = 0;
            }
        }

       
    }
}
