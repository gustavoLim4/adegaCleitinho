namespace adegaCleitinho
{
    partial class frmadega
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlFundo2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pctEmail = new System.Windows.Forms.PictureBox();
            this.pnlSenha = new System.Windows.Forms.Panel();
            this.pctMostrar = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pctSenha = new System.Windows.Forms.PictureBox();
            this.btnEntraLG = new System.Windows.Forms.Button();
            this.pctFecharLogin = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFundo.SuspendLayout();
            this.pnlFundo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).BeginInit();
            this.pnlSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFecharLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.White;
            this.pnlFundo.Controls.Add(this.pnlFundo2);
            this.pnlFundo.Location = new System.Drawing.Point(-2, -1);
            this.pnlFundo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(509, 523);
            this.pnlFundo.TabIndex = 0;
            // 
            // pnlFundo2
            // 
            this.pnlFundo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(76)))));
            this.pnlFundo2.Controls.Add(this.pictureBox3);
            this.pnlFundo2.Location = new System.Drawing.Point(57, 142);
            this.pnlFundo2.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFundo2.Name = "pnlFundo2";
            this.pnlFundo2.Size = new System.Drawing.Size(389, 209);
            this.pnlFundo2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = global::adegaCleitinho.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(11, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(366, 186);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.SystemColors.Window;
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Controls.Add(this.pctEmail);
            this.pnlEmail.Location = new System.Drawing.Point(624, 280);
            this.pnlEmail.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(270, 41);
            this.pnlEmail.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(139)))));
            this.txtEmail.Location = new System.Drawing.Point(46, 11);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 21);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // pctEmail
            // 
            this.pctEmail.Image = global::adegaCleitinho.Properties.Resources.emaillogo;
            this.pctEmail.Location = new System.Drawing.Point(6, 2);
            this.pctEmail.Margin = new System.Windows.Forms.Padding(2);
            this.pctEmail.Name = "pctEmail";
            this.pctEmail.Size = new System.Drawing.Size(35, 37);
            this.pctEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEmail.TabIndex = 0;
            this.pctEmail.TabStop = false;
            // 
            // pnlSenha
            // 
            this.pnlSenha.BackColor = System.Drawing.SystemColors.Window;
            this.pnlSenha.Controls.Add(this.pctMostrar);
            this.pnlSenha.Controls.Add(this.txtSenha);
            this.pnlSenha.Controls.Add(this.pctSenha);
            this.pnlSenha.Location = new System.Drawing.Point(624, 348);
            this.pnlSenha.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSenha.Name = "pnlSenha";
            this.pnlSenha.Size = new System.Drawing.Size(270, 41);
            this.pnlSenha.TabIndex = 4;
            // 
            // pctMostrar
            // 
            this.pctMostrar.Image = global::adegaCleitinho.Properties.Resources.monstra;
            this.pctMostrar.Location = new System.Drawing.Point(246, 23);
            this.pctMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.pctMostrar.Name = "pctMostrar";
            this.pctMostrar.Size = new System.Drawing.Size(20, 15);
            this.pctMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMostrar.TabIndex = 2;
            this.pctMostrar.TabStop = false;
            this.pctMostrar.Click += new System.EventHandler(this.pctMostrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(76)))));
            this.txtSenha.Location = new System.Drawing.Point(46, 11);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(222, 21);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // pctSenha
            // 
            this.pctSenha.Image = global::adegaCleitinho.Properties.Resources.SenhaLogo;
            this.pctSenha.Location = new System.Drawing.Point(5, 2);
            this.pctSenha.Margin = new System.Windows.Forms.Padding(2);
            this.pctSenha.Name = "pctSenha";
            this.pctSenha.Size = new System.Drawing.Size(35, 37);
            this.pctSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSenha.TabIndex = 0;
            this.pctSenha.TabStop = false;
            // 
            // btnEntraLG
            // 
            this.btnEntraLG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(200)))), ((int)(((byte)(64)))));
            this.btnEntraLG.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEntraLG.FlatAppearance.BorderSize = 2;
            this.btnEntraLG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntraLG.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntraLG.ForeColor = System.Drawing.Color.White;
            this.btnEntraLG.Location = new System.Drawing.Point(699, 416);
            this.btnEntraLG.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntraLG.Name = "btnEntraLG";
            this.btnEntraLG.Size = new System.Drawing.Size(122, 38);
            this.btnEntraLG.TabIndex = 5;
            this.btnEntraLG.Text = "Entrar";
            this.btnEntraLG.UseVisualStyleBackColor = false;
            this.btnEntraLG.Click += new System.EventHandler(this.btnEntraLG_Click);
            // 
            // pctFecharLogin
            // 
            this.pctFecharLogin.Image = global::adegaCleitinho.Properties.Resources.fechar_menu;
            this.pctFecharLogin.Location = new System.Drawing.Point(944, 21);
            this.pctFecharLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pctFecharLogin.Name = "pctFecharLogin";
            this.pctFecharLogin.Size = new System.Drawing.Size(34, 39);
            this.pctFecharLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFecharLogin.TabIndex = 2;
            this.pctFecharLogin.TabStop = false;
            this.pctFecharLogin.Click += new System.EventHandler(this.pctFecharLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::adegaCleitinho.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(679, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmadega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.btnEntraLG);
            this.Controls.Add(this.pnlSenha);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.pctFecharLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmadega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fmradega";
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).EndInit();
            this.pnlSenha.ResumeLayout(false);
            this.pnlSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFecharLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel pnlFundo2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctFecharLogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pctEmail;
        private System.Windows.Forms.Panel pnlSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pctSenha;
        private System.Windows.Forms.Button btnEntraLG;
        private System.Windows.Forms.PictureBox pctMostrar;
    }
}

