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
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void pctVoltaFornecedores_Click(object sender, EventArgs e)
        {
            new menuprincipal().Show();
            Hide();
        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {
            banco.dgFornecedores = dgvFornecedores;
            banco.CarregarFornecedores();
        }

        private void cbxFornecedores_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFornecedores.Checked == true)
            {
                banco.CarregarStatusFornecedores();
                txtFornecedores.Enabled = false;
            }
            else
            {
                banco.carregarFornecedores();
                txtFornecedores.Enabled = true;
            }
        }

        private void txtFornecedores_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeFornecedor = txtFornecedores.Text;
            banco.CarregarFornecedoresNome();
            if (txtFornecedores.Text == "")
            {
                cbxFornecedores.Checked = true;
            }
        }
    }
}
