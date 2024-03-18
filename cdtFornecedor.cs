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
    public partial class cdtFornecedor : Form
    {
        public cdtFornecedor()
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
            if (txtNomecdtFornecedor.Text.Length <= 5)
            {
                MessageBox.Show("erro preencher o nome");
                txtNomecdtFornecedor.Clear();
                txtNomecdtFornecedor.Focus();
                txtNomecdtFornecedor.ForeColor = Color.Red;
            }
            else if (mskTelefonecdtFornecedor.MaskCompleted == false)
            {
                MessageBox.Show("favor preecher o telefone");
                mskTelefonecdtFornecedor.Clear();
                mskTelefonecdtFornecedor.Focus();
                mskTelefonecdtFornecedor.ForeColor = Color.Red;
            }
            else if (txtEnderecocdtFornecedor.Text.Length <= 5)
            {
                MessageBox.Show("favor preecher o endereço");
                txtEnderecocdtFornecedor.Clear();
                txtEnderecocdtFornecedor.Focus();
                txtEnderecocdtFornecedor.ForeColor = Color.Red;

            }
            else if (mskCEPcdtFornecedor.MaskCompleted == false)
            {
                MessageBox.Show("favor preecher o CEP");
                mskCEPcdtFornecedor.Clear();
                mskCEPcdtFornecedor.Focus();
                mskCEPcdtFornecedor.ForeColor = Color.Red;
            }
            else if (mskCNPJcdtFornecedor.MaskCompleted == false)
            {
                MessageBox.Show("favor preecher o CNPJ");
                mskCNPJcdtFornecedor.Clear();
                mskCNPJcdtFornecedor.Focus();
                mskCNPJcdtFornecedor.ForeColor = Color.Red;
            }
            else if (cmbStatuscdtFornecedor.Text == "")
            {
                MessageBox.Show("favor preecher o status");
                cmbStatuscdtFornecedor.SelectedIndex = -1;
                cmbStatuscdtFornecedor.Focus();
                cmbStatuscdtFornecedor.ForeColor = Color.Red;
            }
            else
            {
                variaveis.nomeFornecedor = txtNomecdtFornecedor.Text;
                variaveis.telefoneFornecedor = mskTelefonecdtFornecedor.Text;
                variaveis.enderecoFornecedor = txtEnderecocdtFornecedor.Text;
                variaveis.cepFornecedor = mskCEPcdtFornecedor.Text;
                variaveis.cnpjFornecedor = mskCNPJcdtFornecedor.Text;
                variaveis.statusFornecedor = cmbStatuscdtFornecedor.Text;
                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirFornecedor();
                    btnLimpacdtFornecedor.Enabled = false;
                    btnLimpacdtFornecedor.PerformClick();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    banco.AlterarFornecedor();
                }
            }
        }

        private void cdtFornecedor_Load(object sender, EventArgs e)
        {
            banco.CarregarDadosFornecedor();
            txtNomecdtFornecedor.Text = variaveis.nomeFornecedor;
            mskTelefonecdtFornecedor.Text = variaveis.telefoneFornecedor.ToString();
            txtEnderecocdtFornecedor.Text = variaveis.enderecoFornecedor;
            mskCEPcdtFornecedor.Text = variaveis.cepFornecedor.ToString();
            mskCNPJcdtFornecedor.Text = variaveis.cnpjFornecedor.ToString();
            cmbStatuscdtFornecedor.Text = variaveis.statusFornecedor;

            txtNomecdtFornecedor.Enabled = true;
            mskTelefonecdtFornecedor.Enabled = true;
            txtEnderecocdtFornecedor.Enabled = true;
            mskCEPcdtFornecedor.Enabled = true;
            mskCNPJcdtFornecedor.Enabled = true;
            cmbStatuscdtFornecedor.Enabled = true;
            btnLimpacdtFornecedor.Enabled = false;
        }
    }
}
