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
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void pctVoltaEmail_Click(object sender, EventArgs e)
        {
            new menuprincipal().Show();
            Hide();
        }

        private void Email_Load(object sender, EventArgs e)
        {
            banco.dgEmail = dgvEmail;
            banco.CarregarEmail();
        }

        private void cbxEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEmail.Checked == true)
            {
                banco.CarregarStatusEmail();
                txtEmail.Enabled = false;
            }
            else
            {
                banco.CarregarEmail();
                txtEmail.Enabled = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeContato = txtEmail.Text;
            banco.CarregarEmailNome();
            if (txtEmail.Text == "")
            {
                cbxEmail.Checked = true;
            }
        }
    }
}
