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
    public partial class compra : Form
    {
        public compra()
        {
            InitializeComponent();
        }

        private void pctVoltaCompras_Click(object sender, EventArgs e)
        {
            new menuprincipal().Show();
            Hide(); 
        }

        private void compra_Load(object sender, EventArgs e)
        {
            banco.dgCompra = dgvCompras;
            banco.CarregarCompra();
        }
    }
}
