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
    }
}
