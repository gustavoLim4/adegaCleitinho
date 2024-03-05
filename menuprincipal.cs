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
            lblusuario.Text = variaveis.usuario;
            lbldata.Text = DateTime.Now.ToString("dd/MM/yyyy");
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
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


        private void menuprincipal_Load(object sender, EventArgs e)
        {
            banco.carregarFuncionario();
            lblNumfuncionario.Text = variaveis.qtdeFuncionario.ToString();

            banco.carregarFornecedores();
            lblNumFornecedor.Text = variaveis.qtdeFornecedores.ToString();

            banco.carregarClientes();
            lblNumCliente.Text = variaveis.qtdeCliente.ToString();

            banco.carregarCompras();
            lblNumCompra.Text = variaveis.somageralCompras.ToString("N2"); //n2 para as casa decimal


            banco.dgContato = dgvMensagem;
            banco.CarregaContato();

            banco.dgEstoque = dgvEstoque;
            banco.CarregaEstoque();
            

          
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            new funcionario().Show();
            Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new clientes().Show();
            Hide();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            new Fornecedor().Show();
            Hide();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            new Email().Show();
            Hide();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            new Produtos().Show();
            Hide();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            new compra().Show();
            Hide();
        }

     
    }
    
}
