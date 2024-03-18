namespace adegaCleitinho
{
    partial class funcionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFunionario = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.cbxFuncionario = new System.Windows.Forms.CheckBox();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnAlterarFuncionario = new System.Windows.Forms.Button();
            this.pnlFuncionario = new System.Windows.Forms.Panel();
            this.pctVoltaFuncionario = new System.Windows.Forms.PictureBox();
            this.pctFuncionario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.pnlFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltaFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFunionario
            // 
            this.lblFunionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            this.lblFunionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunionario.ForeColor = System.Drawing.Color.Black;
            this.lblFunionario.Location = new System.Drawing.Point(372, 59);
            this.lblFunionario.Name = "lblFunionario";
            this.lblFunionario.Size = new System.Drawing.Size(529, 48);
            this.lblFunionario.TabIndex = 8;
            this.lblFunionario.Text = "FUNCIONARIOS";
            this.lblFunionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.BackColor = System.Drawing.Color.Black;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(219, 137);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(109, 33);
            this.lblNomeFuncionario.TabIndex = 9;
            this.lblNomeFuncionario.Text = "Nome :";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFuncionario.Location = new System.Drawing.Point(325, 142);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(613, 26);
            this.txtFuncionario.TabIndex = 11;
            this.txtFuncionario.TextChanged += new System.EventHandler(this.txtFuncionario_TextChanged);
            // 
            // cbxFuncionario
            // 
            this.cbxFuncionario.AutoSize = true;
            this.cbxFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            this.cbxFuncionario.Location = new System.Drawing.Point(944, 138);
            this.cbxFuncionario.Name = "cbxFuncionario";
            this.cbxFuncionario.Size = new System.Drawing.Size(114, 37);
            this.cbxFuncionario.TabIndex = 12;
            this.cbxFuncionario.Text = "Ativos";
            this.cbxFuncionario.UseVisualStyleBackColor = true;
            this.cbxFuncionario.CheckedChanged += new System.EventHandler(this.cbxFuncionario_CheckedChanged);
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.AllowUserToResizeColumns = false;
            this.dgvFuncionario.AllowUserToResizeRows = false;
            this.dgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFuncionario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFuncionario.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFuncionario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFuncionario.EnableHeadersVisualStyles = false;
            this.dgvFuncionario.GridColor = System.Drawing.Color.White;
            this.dgvFuncionario.Location = new System.Drawing.Point(185, 179);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFuncionario.RowHeadersVisible = false;
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(895, 360);
            this.dgvFuncionario.TabIndex = 29;
            this.dgvFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellClick);
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            this.btnExcluirFuncionario.FlatAppearance.BorderSize = 0;
            this.btnExcluirFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(325, 564);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(134, 43);
            this.btnExcluirFuncionario.TabIndex = 30;
            this.btnExcluirFuncionario.Text = "Excluir";
            this.btnExcluirFuncionario.UseVisualStyleBackColor = false;
            this.btnExcluirFuncionario.Click += new System.EventHandler(this.btnExcluirFuncionario_Click);
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            this.btnCadastrarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(804, 564);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(134, 43);
            this.btnCadastrarFuncionario.TabIndex = 31;
            this.btnCadastrarFuncionario.Text = "Cadastrar";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // btnAlterarFuncionario
            // 
            this.btnAlterarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            this.btnAlterarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnAlterarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFuncionario.Location = new System.Drawing.Point(578, 564);
            this.btnAlterarFuncionario.Name = "btnAlterarFuncionario";
            this.btnAlterarFuncionario.Size = new System.Drawing.Size(134, 43);
            this.btnAlterarFuncionario.TabIndex = 32;
            this.btnAlterarFuncionario.Text = "Alterar";
            this.btnAlterarFuncionario.UseVisualStyleBackColor = false;
            this.btnAlterarFuncionario.Click += new System.EventHandler(this.btnAlterarFuncionario_Click);
            // 
            // pnlFuncionario
            // 
            this.pnlFuncionario.BackColor = System.Drawing.Color.Black;
            this.pnlFuncionario.Controls.Add(this.btnAlterarFuncionario);
            this.pnlFuncionario.Controls.Add(this.btnCadastrarFuncionario);
            this.pnlFuncionario.Controls.Add(this.btnExcluirFuncionario);
            this.pnlFuncionario.Controls.Add(this.dgvFuncionario);
            this.pnlFuncionario.Controls.Add(this.pctVoltaFuncionario);
            this.pnlFuncionario.Controls.Add(this.cbxFuncionario);
            this.pnlFuncionario.Controls.Add(this.txtFuncionario);
            this.pnlFuncionario.Controls.Add(this.lblNomeFuncionario);
            this.pnlFuncionario.Controls.Add(this.lblFunionario);
            this.pnlFuncionario.Controls.Add(this.pctFuncionario);
            this.pnlFuncionario.Location = new System.Drawing.Point(4, 5);
            this.pnlFuncionario.Name = "pnlFuncionario";
            this.pnlFuncionario.Size = new System.Drawing.Size(1222, 655);
            this.pnlFuncionario.TabIndex = 0;
            
            // 
            // pctVoltaFuncionario
            // 
            this.pctVoltaFuncionario.Image = global::adegaCleitinho.Properties.Resources.voltarImagem;
            this.pctVoltaFuncionario.Location = new System.Drawing.Point(1136, 21);
            this.pctVoltaFuncionario.Name = "pctVoltaFuncionario";
            this.pctVoltaFuncionario.Size = new System.Drawing.Size(61, 56);
            this.pctVoltaFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctVoltaFuncionario.TabIndex = 13;
            this.pctVoltaFuncionario.TabStop = false;
            this.pctVoltaFuncionario.Click += new System.EventHandler(this.pctVoltaFuncionario_Click);
            // 
            // pctFuncionario
            // 
            this.pctFuncionario.Image = global::adegaCleitinho.Properties.Resources.logo;
            this.pctFuncionario.Location = new System.Drawing.Point(27, 7);
            this.pctFuncionario.Name = "pctFuncionario";
            this.pctFuncionario.Size = new System.Drawing.Size(230, 83);
            this.pctFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFuncionario.TabIndex = 2;
            this.pctFuncionario.TabStop = false;
            // 
            // funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(200)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.pnlFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "funcionariobtn";
            this.Load += new System.EventHandler(this.funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.pnlFuncionario.ResumeLayout(false);
            this.pnlFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltaFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctFuncionario;
        private System.Windows.Forms.Label lblFunionario;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.CheckBox cbxFuncionario;
        private System.Windows.Forms.PictureBox pctVoltaFuncionario;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Button btnAlterarFuncionario;
        private System.Windows.Forms.Panel pnlFuncionario;
    }
}