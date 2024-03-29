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
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }

        private void pctVoltaClientes_Click(object sender, EventArgs e)
        {
            new menuprincipal().Show();
            Hide();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            banco.dgCliente = dgvCliente;
            banco.CarregarClientes();   
        }

        private void cbxClientes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxClientes.Checked == true)
            {
                banco.CarregarStatusClientes();
                txtClientes.Enabled = false;
            }
            else
            {
                banco.CarregarClientes();
                txtClientes.Enabled = true;
            }
        }

        private void txtClientes_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeUsuario = txtClientes.Text;
            banco.CarregarUsarioNome();
            if (txtClientes.Text == "")
            {
                cbxClientes.Checked = true;
            }
        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";

            new cdtClientes().Show();
            Hide();
        }

        private void btnAlterarClientes_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR";
            new cdtClientes().Show();
            Hide();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codUsuario = Convert.ToInt32(dgvCliente[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void btnExcluirClientes_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                var resposta = MessageBox.Show("Deseja realmente EXCLUIR? Essa ação não poderá ser desfeita ", "Excluir", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    
                }
            }
        }
    }
}
