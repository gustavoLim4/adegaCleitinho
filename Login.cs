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
            new menuprincipal().Show();
            Hide();
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
