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
    public partial class menuprincipal : Form
    {
        public menuprincipal()
        {
            InitializeComponent();
        }

        private void pctFechaMenu_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNoCancel);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resposta == DialogResult.No)
            {
                new frmadega().Show();
                Close();
            }
        }

        private void lblNumInstrutor_Click(object sender, EventArgs e)
        {

        }

        private void pnlmenuPR_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
    
}
