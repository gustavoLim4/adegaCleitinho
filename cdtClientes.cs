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
    public partial class cdtClientes : Form
    {
        public cdtClientes()
        {
            InitializeComponent();
        }

        private void pctVoltarcdtCliente_Click(object sender, EventArgs e)
        {
            new menuprincipal().Show();
            Hide();
        }

        private void btnSalvacdtCliente_Click(object sender, EventArgs e)
        {
            if (txtNomecdtCliente.Text.Length <= 5)
            {
                MessageBox.Show("Erro ao preencher o nome");
                txtNomecdtCliente.Clear();
                txtNomecdtCliente.Focus();
                lblNomecdtCliente.ForeColor = Color.Red;
            }
            else if (txtEmailcdtCliente.Text == string.Empty)
            {
                MessageBox.Show("Favor preecher o email!");
                txtEmailcdtCliente.Clear();
                txtEmailcdtCliente.Focus();
                txtEmailcdtCliente.ForeColor = Color.Red;
            }
            else if (txtSenhacdtCliente.Text == string.Empty)
            {
                MessageBox.Show("Favor preecher a senha!");
                txtSenhacdtCliente.Clear();
                txtSenhacdtCliente.Focus();
                txtSenhacdtCliente.ForeColor = Color.Red;
            }
            else if (mskDataNscdtCliente.MaskCompleted == false)
            {
                MessageBox.Show("Favor preecher a data de nascimento!");
                mskDataNscdtCliente.Clear();
                mskDataNscdtCliente.Focus();
                mskDataNscdtCliente.ForeColor = Color.Red;

            }
            else if (mskTelefonecdtCliente.MaskCompleted == false)
            {
                MessageBox.Show("Favor preecher o telefone!");
                mskTelefonecdtCliente.Clear();
                mskTelefonecdtCliente.Focus();
                mskTelefonecdtCliente.ForeColor = Color.Red;
            }
            else if (txtEnderecocdtCliente.Text == string.Empty)
            {
                MessageBox.Show("Favor preecher o endereço!");
                txtEnderecocdtCliente.Clear();
                txtEnderecocdtCliente.Focus();
                txtEnderecocdtCliente.ForeColor = Color.Red;
            }
            else if (mskCEPcdtCliente.MaskCompleted == false)
            {
                MessageBox.Show("Favor preecher o CEP!");
                mskTelefonecdtCliente.Clear();
                mskTelefonecdtCliente.Focus();
                mskTelefonecdtCliente.ForeColor = Color.Red;
            }
            else if (cmbStatuscdtCliente.Text == "")
            {
                MessageBox.Show("Favor preecher o endereço!");
                cmbStatuscdtCliente.SelectedIndex = -1;
                cmbStatuscdtCliente.Focus();
                cmbStatuscdtCliente.ForeColor = Color.Red;
            }
            else
            {
                variaveis.nomeUsuario = txtNomecdtCliente.Text;
                variaveis.emailUsuario = txtEmailcdtCliente.Text;
                variaveis.senhaUsuario = txtSenhacdtCliente.Text;
                variaveis.dataNascUsuario = DateTime.Parse(mskDataNscdtCliente.Text);
                variaveis.telefoneUsuario = mskTelefonecdtCliente.Text;
                variaveis.enderecoUsuario = txtEnderecocdtCliente.Text;
                variaveis.cepUsuario = mskCEPcdtCliente.Text;
                variaveis.statusUsuario = cmbStatuscdtCliente.Text;
                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirCliente();
                    btnLimpacdtCliente.Enabled = false;
                    btnLimpacdtCliente.PerformClick();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    
                }
                btnLimpacdtCliente.Enabled = false;
            }
        }
    }
}
