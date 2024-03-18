using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adegaCleitinho
{
    public partial class funcionario : Form
    {
        public funcionario()
        {
            InitializeComponent();
        }

        private void pctVoltaFuncionario_Click(object sender, EventArgs e)
        {
            new menuprincipal().Show();
            Hide();
        }

        private void funcionario_Load(object sender, EventArgs e)
        {
            banco.dgFuncionario = dgvFuncionario;
            banco.CarragarInstrutores();

        }

        private void cbxFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFuncionario.Checked == true)
            {
                banco.CarregaInstrutorStatus();
                txtFuncionario.Enabled = false;
            }
            else
            {
                banco.CarragarInstrutores();
                txtFuncionario.Enabled = true;
            }
        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeFuncionario = txtFuncionario.Text;
            banco.CarregaInstrutorNome();
            if (txtFuncionario.Text == "")
            {
                cbxFuncionario.Checked = true;
            }
          
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";

            new cdtFuncionario().Show();
            Hide();
        }

        private void btnAlterarFuncionario_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR";

            new cdtFuncionario().Show();
            Hide();
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codInstrutores = Convert.ToInt32(dgvFuncionario[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                var resposta = MessageBox.Show("Deseja realmente excluir ? Essa ação não poderé ser desfeita ", "Excluir", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    banco.DesativarFuncionario();
                    banco.CarragarInstrutores();
                    dgvFuncionario.ClearSelection();
                }
                else
                {
                    dgvFuncionario.ClearSelection();
                }
            }
        }

        
    }
}
