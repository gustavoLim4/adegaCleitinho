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
    }
}
