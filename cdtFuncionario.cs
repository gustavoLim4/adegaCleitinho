using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adegaCleitinho
{
    public partial class cdtFuncionario : Form
    {
        public cdtFuncionario()
        {
            InitializeComponent();
        }

        private void pctVoltacdtFuncionario_Click(object sender, EventArgs e)
        {
             
            new funcionario().Show();
            Hide();
        }

        private void btnCadastracdtFuncionario_Click(object sender, EventArgs e)
        {

            if (txtNomecdtFuncionario.Text.Length <= 5)
            {
                MessageBox.Show("erro preencher o nome");
                txtNomecdtFuncionario.Clear();
                txtNomecdtFuncionario.Focus();
                lblNomecdtFuncionario.ForeColor = Color.Red;

            }
            else if (txtEmailcdtFuncionario.Text == string.Empty)
            {
                MessageBox.Show("favor preecher o email");
                txtEmailcdtFuncionario.Clear();
                txtEmailcdtFuncionario.Focus();
                lblEmailcdtFuncionario.ForeColor = Color.Red;
            }
            else if (txtSenhacdtFuncionario.Text == string.Empty)
            {
                MessageBox.Show("favor preecher a senha");
                txtSenhacdtFuncionario.Clear();
                txtSenhacdtFuncionario.Focus();
                lblSenhacdtFuncionario.ForeColor = Color.Red;

            }
            else if (txtCargocdtFuncionaio.Text == string.Empty)
            {
                MessageBox.Show("favor preecher o cargo");
                txtCargocdtFuncionaio.Clear();
                txtCargocdtFuncionaio.Focus();
                lblCargocdtFuncionaio.ForeColor = Color.Red;

            }
            else if (cbmNivelcdtFuncionaio.Text == "")
            {
                MessageBox.Show("favor preecher o nivel");
                cbmNivelcdtFuncionaio.SelectedIndex = -1;
                cbmNivelcdtFuncionaio.Focus();
                lblCargocdtFuncionaio.ForeColor = Color.Red;

            }
            else if (mskDataNscdtFuncionario.MaskCompleted == false)
            {
                MessageBox.Show("favor preecher a data de nascimento");
                mskDataNscdtFuncionario.Clear();
                mskDataNscdtFuncionario.Focus();
                lblDataNasccdtFuncionario.ForeColor = Color.Red;

            }
            else if (mskDataADcdtFuncionario.MaskCompleted == false)
            {
                MessageBox.Show("favor preecher a data de admissão");
                mskDataADcdtFuncionario.Clear();
                mskDataADcdtFuncionario.Focus();
                lblDataADcdtFuncionario.ForeColor = Color.Red;
            }
            else if (mskTelefonecdtFuncionaio.MaskCompleted == false)
            {
                MessageBox.Show("favor preecher o telefone");
                mskTelefonecdtFuncionaio.Clear();
                mskTelefonecdtFuncionaio.Focus();
                lblTelefonecdtFuncionaio.ForeColor = Color.Red;
            }
            else if (cmbStatuscdtFuncionaio.Text == "")
            {
                MessageBox.Show("favor preecher status");
                cmbStatuscdtFuncionaio.SelectedIndex = -1;
                cmbStatuscdtFuncionaio.Focus();
                lblstatuscdtFuncionaio.ForeColor = Color.Red;

            }
            else
            {
                variaveis.nomeFuncionario = txtNomecdtFuncionario.Text;
                variaveis.emailFuncionario = txtEmailcdtFuncionario.Text;
                variaveis.senhaFuncionario = txtSenhacdtFuncionario.Text;
                variaveis.cargoFuncionario = txtCargocdtFuncionaio.Text;
                variaveis.nivelFuncionario = cbmNivelcdtFuncionaio.Text;
                variaveis.dataNascFuncionario = DateTime.Parse(mskDataNscdtFuncionario.Text);
                variaveis.admissaoFuncionaro = DateTime.Parse(mskDataADcdtFuncionario.Text);
                variaveis.telefoneFuncionario = mskTelefonecdtFuncionaio.Text;
                variaveis.statusFuncionario = cmbStatuscdtFuncionaio.Text;
                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirInstrutor();
                    btnLimapacdtFuncionario.Enabled = false;
                    btnLimapacdtFuncionario.PerformClick();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    banco.AlterarFuncionario();
                   if (variaveis.atFotoInstrutores == "S") 
                    {
                        banco.AlterarFoto();
                    }
                }
                btnLimapacdtFuncionario.Enabled = false;
            }
        }

        private void txtNomecdtFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmailcdtFuncionario.Enabled = true;
                txtEmailcdtFuncionario.Focus();

            }
        }

        private void txtEmailcdtFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenhacdtFuncionario.Enabled = true;
                txtSenhacdtFuncionario.Focus();

            }
        }

        private void txtSenhacdtFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCargocdtFuncionaio.Enabled = true;
                txtCargocdtFuncionaio.Focus();

            }
        }

        private void txtCargocdtFuncionaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cbmNivelcdtFuncionaio.Enabled = true;
                cbmNivelcdtFuncionaio.Focus();

            }
        }

        private void cbmNivelcdtFuncionaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mskDataNscdtFuncionario.Enabled = true;
                mskDataNscdtFuncionario.Focus();

            }
        }

        private void mskDataNscdtFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mskDataADcdtFuncionario.Enabled = true;
                mskDataADcdtFuncionario.Focus();

            }
        }

        private void mskDataADcdtFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mskTelefonecdtFuncionaio.Enabled = true;
                mskTelefonecdtFuncionaio.Focus();

            }
        }

        private void mskTelefonecdtFuncionaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatuscdtFuncionaio.Enabled = true;
                cmbStatuscdtFuncionaio.Focus();

            }
        }

        private void cmbStatuscdtFuncionaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSalvacdtFuncionario.Enabled = true;
                btnSalvacdtFuncionario.Focus();
            }
        }

        private void cdtFuncionario_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "ALTERAR")
            {
                
                banco.CarregarDadosFuncionario();
                txtNomecdtFuncionario.Text = variaveis.nomeFuncionario;
                txtEmailcdtFuncionario.Text = variaveis.emailFuncionario;
                txtSenhacdtFuncionario.Text = variaveis.senhaFuncionario;
                txtCargocdtFuncionaio.Text = variaveis.cargoFuncionario;
                cbmNivelcdtFuncionaio.Text = variaveis.nivelFuncionario;
                mskDataNscdtFuncionario.Text = variaveis.dataNascFuncionario.ToString();
                mskDataADcdtFuncionario.Text = variaveis.admissaoFuncionaro.ToString();
                mskTelefonecdtFuncionaio.Text = variaveis.telefoneFuncionario;
                cmbStatuscdtFuncionaio.Text = variaveis.statusFuncionario;


                txtNomecdtFuncionario.Enabled = true;
                txtEmailcdtFuncionario.Enabled = true;
                txtSenhacdtFuncionario.Enabled = true;
                txtCargocdtFuncionaio.Enabled = true;
                cbmNivelcdtFuncionaio.Enabled = true;
                mskDataNscdtFuncionario.Enabled = true;
                mskDataADcdtFuncionario.Enabled = true;
                mskTelefonecdtFuncionaio.Enabled = true;
                cmbStatuscdtFuncionaio.Enabled = true;
                btnMaiscdtFunionario.Enabled = true;
                btnSalvacdtFuncionario.Enabled = true;
                btnLimapacdtFuncionario.Enabled = false;
            }
        }

        private void btnMaiscdtFunionario_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofdFoto = new OpenFileDialog();
                ofdFoto.Multiselect = false;
                ofdFoto.FileName = "";
                ofdFoto.InitialDirectory = @"C:";
                ofdFoto.Title = "Selecione uma foto:";
                ofdFoto.Filter = "JPG ou PNG (*.jpg ou *.png)|*.jpg;*.png";
                ofdFoto.CheckPathExists = true; //Checar se o caminho existe
                ofdFoto.CheckFileExists = true;//Checar se o arquivo existe
                ofdFoto.RestoreDirectory = true;//Restaurar ao diretório inicial

                DialogResult dr = ofdFoto.ShowDialog();
                pctFotoInstrutores.Image = Image.FromFile(ofdFoto.FileName);
                variaveis.fotoFuncionario = "funcionario/" + Regex.Replace(txtNomecdtFuncionario.Text, @"\s", "").ToLower() + Regex.Replace(txtCargocdtFuncionaio.Text, @"\s", "").ToLower() + ".png";

                if (dr == DialogResult.OK)
                {
                    try
                    {
                        variaveis.atFotoInstrutores = "S";
                        variaveis.caminhoFotoInstrutores = ofdFoto.FileName;

                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show("Erro de segurança - Fale com o Admin.\n Mensagem: " + ex.Message + "\n Detalhe: " + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Você não tem permissão. \n Mensagem: " + ex.Message);
                    }
                }
                btnSalvacdtFuncionario.Enabled = true;
                btnSalvacdtFuncionario.Focus();
            }
            catch
            {
                btnSalvacdtFuncionario.Enabled = true;
                btnSalvacdtFuncionario.Focus();
            }


        }
   
    }
}
