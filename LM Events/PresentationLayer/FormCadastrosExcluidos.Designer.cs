namespace LM_Events.PresentationLayer
{
    partial class FormCadastrosExcluidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrosExcluidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textCodigoCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maskedCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPessoaTipoExcluir = new System.Windows.Forms.ComboBox();
            this.labelCpfCnpj = new System.Windows.Forms.Label();
            this.buttonProcuraExcluirCadastro = new System.Windows.Forms.Button();
            this.buttonExcluirInscricao = new System.Windows.Forms.Button();
            this.buttonSairCancelaInscricao = new System.Windows.Forms.Button();
            this.dgvInscricaoCancelada = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkPJ = new System.Windows.Forms.CheckBox();
            this.checkPF = new System.Windows.Forms.CheckBox();
            this.textCodigoEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscricaoCancelada)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textCodigoCliente
            // 
            this.textCodigoCliente.Enabled = false;
            this.textCodigoCliente.Location = new System.Drawing.Point(417, 605);
            this.textCodigoCliente.Name = "textCodigoCliente";
            this.textCodigoCliente.ReadOnly = true;
            this.textCodigoCliente.Size = new System.Drawing.Size(113, 26);
            this.textCodigoCliente.TabIndex = 48;
            this.textCodigoCliente.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(294, 608);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Cód. do Cliente";
            this.label5.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.maskedCpfCnpj);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.comboPessoaTipoExcluir);
            this.groupBox4.Controls.Add(this.labelCpfCnpj);
            this.groupBox4.Controls.Add(this.buttonProcuraExcluirCadastro);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(0, 0);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Procurar Cadastro";
            // 
            // maskedCpfCnpj
            // 
            this.maskedCpfCnpj.Location = new System.Drawing.Point(378, 30);
            this.maskedCpfCnpj.Name = "maskedCpfCnpj";
            this.maskedCpfCnpj.Size = new System.Drawing.Size(152, 26);
            this.maskedCpfCnpj.TabIndex = 28;
            this.maskedCpfCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedCpfCnpj.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pessoa Tipo";
            // 
            // comboPessoaTipoExcluir
            // 
            this.comboPessoaTipoExcluir.FormattingEnabled = true;
            this.comboPessoaTipoExcluir.Items.AddRange(new object[] {
            "Pessoa Física",
            "Pessoa Jurídica"});
            this.comboPessoaTipoExcluir.Location = new System.Drawing.Point(108, 30);
            this.comboPessoaTipoExcluir.Name = "comboPessoaTipoExcluir";
            this.comboPessoaTipoExcluir.Size = new System.Drawing.Size(166, 28);
            this.comboPessoaTipoExcluir.TabIndex = 13;
            // 
            // labelCpfCnpj
            // 
            this.labelCpfCnpj.AutoSize = true;
            this.labelCpfCnpj.Location = new System.Drawing.Point(311, 33);
            this.labelCpfCnpj.Name = "labelCpfCnpj";
            this.labelCpfCnpj.Size = new System.Drawing.Size(58, 20);
            this.labelCpfCnpj.TabIndex = 12;
            this.labelCpfCnpj.Text = "default";
            this.labelCpfCnpj.Visible = false;
            // 
            // buttonProcuraExcluirCadastro
            // 
            this.buttonProcuraExcluirCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProcuraExcluirCadastro.Enabled = false;
            this.buttonProcuraExcluirCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcuraExcluirCadastro.Image = ((System.Drawing.Image)(resources.GetObject("buttonProcuraExcluirCadastro.Image")));
            this.buttonProcuraExcluirCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProcuraExcluirCadastro.Location = new System.Drawing.Point(558, 28);
            this.buttonProcuraExcluirCadastro.Name = "buttonProcuraExcluirCadastro";
            this.buttonProcuraExcluirCadastro.Size = new System.Drawing.Size(96, 30);
            this.buttonProcuraExcluirCadastro.TabIndex = 2;
            this.buttonProcuraExcluirCadastro.Text = "&Procurar";
            this.buttonProcuraExcluirCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProcuraExcluirCadastro.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirInscricao
            // 
            this.buttonExcluirInscricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExcluirInscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirInscricao.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirInscricao.Image")));
            this.buttonExcluirInscricao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirInscricao.Location = new System.Drawing.Point(638, 601);
            this.buttonExcluirInscricao.Name = "buttonExcluirInscricao";
            this.buttonExcluirInscricao.Size = new System.Drawing.Size(105, 30);
            this.buttonExcluirInscricao.TabIndex = 38;
            this.buttonExcluirInscricao.Text = "&Restaurar";
            this.buttonExcluirInscricao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExcluirInscricao.UseVisualStyleBackColor = true;
            this.buttonExcluirInscricao.Click += new System.EventHandler(this.buttonExcluirInscricao_Click);
            // 
            // buttonSairCancelaInscricao
            // 
            this.buttonSairCancelaInscricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSairCancelaInscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSairCancelaInscricao.Image = ((System.Drawing.Image)(resources.GetObject("buttonSairCancelaInscricao.Image")));
            this.buttonSairCancelaInscricao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSairCancelaInscricao.Location = new System.Drawing.Point(749, 601);
            this.buttonSairCancelaInscricao.Name = "buttonSairCancelaInscricao";
            this.buttonSairCancelaInscricao.Size = new System.Drawing.Size(105, 30);
            this.buttonSairCancelaInscricao.TabIndex = 35;
            this.buttonSairCancelaInscricao.Text = "&Sair";
            this.buttonSairCancelaInscricao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSairCancelaInscricao.UseVisualStyleBackColor = true;
            this.buttonSairCancelaInscricao.Click += new System.EventHandler(this.buttonSairCancelaInscricao_Click);
            // 
            // dgvInscricaoCancelada
            // 
            this.dgvInscricaoCancelada.AllowUserToAddRows = false;
            this.dgvInscricaoCancelada.AllowUserToDeleteRows = false;
            this.dgvInscricaoCancelada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInscricaoCancelada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInscricaoCancelada.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvInscricaoCancelada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInscricaoCancelada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInscricaoCancelada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscricaoCancelada.Location = new System.Drawing.Point(6, 55);
            this.dgvInscricaoCancelada.Name = "dgvInscricaoCancelada";
            this.dgvInscricaoCancelada.ReadOnly = true;
            this.dgvInscricaoCancelada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvInscricaoCancelada.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvInscricaoCancelada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInscricaoCancelada.Size = new System.Drawing.Size(848, 540);
            this.dgvInscricaoCancelada.TabIndex = 34;
            this.dgvInscricaoCancelada.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscricaoCancelada_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkPJ);
            this.groupBox1.Controls.Add(this.checkPF);
            this.groupBox1.Controls.Add(this.textCodigoEmpresa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonExcluirInscricao);
            this.groupBox1.Controls.Add(this.buttonSairCancelaInscricao);
            this.groupBox1.Controls.Add(this.dgvInscricaoCancelada);
            this.groupBox1.Controls.Add(this.textCodigoCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 637);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Cadastros Excluidos";
            // 
            // checkPJ
            // 
            this.checkPJ.AutoSize = true;
            this.checkPJ.Location = new System.Drawing.Point(158, 25);
            this.checkPJ.Name = "checkPJ";
            this.checkPJ.Size = new System.Drawing.Size(155, 24);
            this.checkPJ.TabIndex = 52;
            this.checkPJ.Text = "Pessoas Jurídicas";
            this.checkPJ.UseVisualStyleBackColor = true;
            this.checkPJ.CheckedChanged += new System.EventHandler(this.checkPJ_CheckedChanged);
            // 
            // checkPF
            // 
            this.checkPF.AutoSize = true;
            this.checkPF.Location = new System.Drawing.Point(10, 25);
            this.checkPF.Name = "checkPF";
            this.checkPF.Size = new System.Drawing.Size(142, 24);
            this.checkPF.TabIndex = 51;
            this.checkPF.Text = "Pessoas Físicas";
            this.checkPF.UseVisualStyleBackColor = true;
            this.checkPF.CheckedChanged += new System.EventHandler(this.checkPF_CheckedChanged);
            // 
            // textCodigoEmpresa
            // 
            this.textCodigoEmpresa.Enabled = false;
            this.textCodigoEmpresa.Location = new System.Drawing.Point(159, 603);
            this.textCodigoEmpresa.Name = "textCodigoEmpresa";
            this.textCodigoEmpresa.ReadOnly = true;
            this.textCodigoEmpresa.Size = new System.Drawing.Size(113, 26);
            this.textCodigoEmpresa.TabIndex = 50;
            this.textCodigoEmpresa.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(21, 606);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Cód. do Empresa";
            this.label1.Visible = false;
            // 
            // FormCadastrosExcluidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastrosExcluidos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros Excluidos";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscricaoCancelada)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox textCodigoCliente;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox maskedCpfCnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPessoaTipoExcluir;
        private System.Windows.Forms.Label labelCpfCnpj;
        private System.Windows.Forms.Button buttonProcuraExcluirCadastro;
        private System.Windows.Forms.Button buttonExcluirInscricao;
        private System.Windows.Forms.Button buttonSairCancelaInscricao;
        internal System.Windows.Forms.DataGridView dgvInscricaoCancelada;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox textCodigoEmpresa;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkPJ;
        private System.Windows.Forms.CheckBox checkPF;
    }
}