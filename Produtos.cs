﻿using System;
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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void pctVoltaProdutos_Click(object sender, EventArgs e)
        {
            new menuprincipal().Show();
            Hide();

        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            banco.dgProdutos = dgvProdutos;
            banco.CarregarProdutos();
        }
    }
}
