namespace adegaCleitinho
{
    partial class Email
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.btnAlterarEmail = new System.Windows.Forms.Button();
            this.btnCadastrarEmail = new System.Windows.Forms.Button();
            this.btnExcluirEmail = new System.Windows.Forms.Button();
            this.pctVoltaEmail = new System.Windows.Forms.PictureBox();
            this.cbxEmail = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNomeEmail = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pctEmail = new System.Windows.Forms.PictureBox();
            this.dgvEmail = new System.Windows.Forms.DataGridView();
            this.pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltaEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.Black;
            this.pnlEmail.Controls.Add(this.dgvEmail);
            this.pnlEmail.Controls.Add(this.btnAlterarEmail);
            this.pnlEmail.Controls.Add(this.btnCadastrarEmail);
            this.pnlEmail.Controls.Add(this.btnExcluirEmail);
            this.pnlEmail.Controls.Add(this.pctVoltaEmail);
            this.pnlEmail.Controls.Add(this.cbxEmail);
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Controls.Add(this.lblNomeEmail);
            this.pnlEmail.Controls.Add(this.lblEmail);
            this.pnlEmail.Controls.Add(this.pctEmail);
            this.pnlEmail.Location = new System.Drawing.Point(4, 5);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(1222, 655);
            this.pnlEmail.TabIndex = 2;
            // 
            // btnAlterarEmail
            // 
            this.btnAlterarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            this.btnAlterarEmail.FlatAppearance.BorderSize = 0;
            this.btnAlterarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarEmail.Location = new System.Drawing.Point(578, 564);
            this.btnAlterarEmail.Name = "btnAlterarEmail";
            this.btnAlterarEmail.Size = new System.Drawing.Size(134, 43);
            this.btnAlterarEmail.TabIndex = 32;
            this.btnAlterarEmail.Text = "Alterar";
            this.btnAlterarEmail.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarEmail
            // 
            this.btnCadastrarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            this.btnCadastrarEmail.FlatAppearance.BorderSize = 0;
            this.btnCadastrarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEmail.Location = new System.Drawing.Point(804, 564);
            this.btnCadastrarEmail.Name = "btnCadastrarEmail";
            this.btnCadastrarEmail.Size = new System.Drawing.Size(134, 43);
            this.btnCadastrarEmail.TabIndex = 31;
            this.btnCadastrarEmail.Text = "Cadastrar";
            this.btnCadastrarEmail.UseVisualStyleBackColor = false;
            // 
            // btnExcluirEmail
            // 
            this.btnExcluirEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            this.btnExcluirEmail.FlatAppearance.BorderSize = 0;
            this.btnExcluirEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirEmail.Location = new System.Drawing.Point(325, 564);
            this.btnExcluirEmail.Name = "btnExcluirEmail";
            this.btnExcluirEmail.Size = new System.Drawing.Size(134, 43);
            this.btnExcluirEmail.TabIndex = 30;
            this.btnExcluirEmail.Text = "Excluir";
            this.btnExcluirEmail.UseVisualStyleBackColor = false;
            // 
            // pctVoltaEmail
            // 
            this.pctVoltaEmail.Image = global::adegaCleitinho.Properties.Resources.voltarImagem;
            this.pctVoltaEmail.Location = new System.Drawing.Point(1136, 21);
            this.pctVoltaEmail.Name = "pctVoltaEmail";
            this.pctVoltaEmail.Size = new System.Drawing.Size(61, 56);
            this.pctVoltaEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctVoltaEmail.TabIndex = 13;
            this.pctVoltaEmail.TabStop = false;
            this.pctVoltaEmail.Click += new System.EventHandler(this.pctVoltaEmail_Click);
            // 
            // cbxEmail
            // 
            this.cbxEmail.AutoSize = true;
            this.cbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            this.cbxEmail.Location = new System.Drawing.Point(944, 138);
            this.cbxEmail.Name = "cbxEmail";
            this.cbxEmail.Size = new System.Drawing.Size(114, 37);
            this.cbxEmail.TabIndex = 12;
            this.cbxEmail.Text = "Ativos";
            this.cbxEmail.UseVisualStyleBackColor = true;
            this.cbxEmail.CheckedChanged += new System.EventHandler(this.cbxEmail_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(325, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(613, 26);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblNomeEmail
            // 
            this.lblNomeEmail.AutoSize = true;
            this.lblNomeEmail.BackColor = System.Drawing.Color.Black;
            this.lblNomeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            this.lblNomeEmail.Location = new System.Drawing.Point(219, 137);
            this.lblNomeEmail.Name = "lblNomeEmail";
            this.lblNomeEmail.Size = new System.Drawing.Size(109, 33);
            this.lblNomeEmail.TabIndex = 9;
            this.lblNomeEmail.Text = "Nome :";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(372, 59);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(529, 48);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-MAILS";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctEmail
            // 
            this.pctEmail.Image = global::adegaCleitinho.Properties.Resources.logo;
            this.pctEmail.Location = new System.Drawing.Point(27, 7);
            this.pctEmail.Name = "pctEmail";
            this.pctEmail.Size = new System.Drawing.Size(230, 83);
            this.pctEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEmail.TabIndex = 2;
            this.pctEmail.TabStop = false;
            // 
            // dgvEmail
            // 
            this.dgvEmail.AllowUserToAddRows = false;
            this.dgvEmail.AllowUserToDeleteRows = false;
            this.dgvEmail.AllowUserToResizeColumns = false;
            this.dgvEmail.AllowUserToResizeRows = false;
            this.dgvEmail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmail.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmail.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEmail.EnableHeadersVisualStyles = false;
            this.dgvEmail.GridColor = System.Drawing.Color.White;
            this.dgvEmail.Location = new System.Drawing.Point(184, 181);
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmail.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEmail.RowHeadersVisible = false;
            this.dgvEmail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmail.Size = new System.Drawing.Size(895, 360);
            this.dgvEmail.TabIndex = 34;
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.pnlEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.Load += new System.EventHandler(this.Email_Load);
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltaEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Button btnAlterarEmail;
        private System.Windows.Forms.Button btnCadastrarEmail;
        private System.Windows.Forms.Button btnExcluirEmail;
        private System.Windows.Forms.PictureBox pctVoltaEmail;
        private System.Windows.Forms.CheckBox cbxEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNomeEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pctEmail;
        private System.Windows.Forms.DataGridView dgvEmail;
    }
}