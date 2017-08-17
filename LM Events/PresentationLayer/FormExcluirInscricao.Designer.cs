namespace LM_Events.PresentationLayer
{
    partial class FormExcluirInscricao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExcluirInscricao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.maskedCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPessoaTipoExcluir = new System.Windows.Forms.ComboBox();
            this.labelCpfCnpj = new System.Windows.Forms.Label();
            this.buttonProcuraExcluirCadastro = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExcluirInscricao = new System.Windows.Forms.Button();
            this.buttonSairCancelaInscricao = new System.Windows.Forms.Button();
            this.groupComfirmacaoDados = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNomeExcluirCadastro = new System.Windows.Forms.TextBox();
            this.textCodigoInscricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textCodigoCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCancelarInscricao = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupComfirmacaoDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelarInscricao)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Procurar Cadastro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupComfirmacaoDados);
            this.groupBox1.Controls.Add(this.dgvCancelarInscricao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 609);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Inscrições ";
            // 
            // buttonExcluirInscricao
            // 
            this.buttonExcluirInscricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExcluirInscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirInscricao.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirInscricao.Image")));
            this.buttonExcluirInscricao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirInscricao.Location = new System.Drawing.Point(666, 627);
            this.buttonExcluirInscricao.Name = "buttonExcluirInscricao";
            this.buttonExcluirInscricao.Size = new System.Drawing.Size(100, 30);
            this.buttonExcluirInscricao.TabIndex = 38;
            this.buttonExcluirInscricao.Text = "&Cancelar";
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
            this.buttonSairCancelaInscricao.Location = new System.Drawing.Point(772, 627);
            this.buttonSairCancelaInscricao.Name = "buttonSairCancelaInscricao";
            this.buttonSairCancelaInscricao.Size = new System.Drawing.Size(100, 30);
            this.buttonSairCancelaInscricao.TabIndex = 35;
            this.buttonSairCancelaInscricao.Text = "&Sair";
            this.buttonSairCancelaInscricao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSairCancelaInscricao.UseVisualStyleBackColor = true;
            this.buttonSairCancelaInscricao.Click += new System.EventHandler(this.buttonSairCancelaInscricao_Click);
            // 
            // groupComfirmacaoDados
            // 
            this.groupComfirmacaoDados.Controls.Add(this.label2);
            this.groupComfirmacaoDados.Controls.Add(this.textNomeExcluirCadastro);
            this.groupComfirmacaoDados.Controls.Add(this.textCodigoInscricao);
            this.groupComfirmacaoDados.Controls.Add(this.label6);
            this.groupComfirmacaoDados.Controls.Add(this.textCodigoCliente);
            this.groupComfirmacaoDados.Controls.Add(this.label5);
            this.groupComfirmacaoDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupComfirmacaoDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupComfirmacaoDados.Location = new System.Drawing.Point(6, 515);
            this.groupComfirmacaoDados.Name = "groupComfirmacaoDados";
            this.groupComfirmacaoDados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupComfirmacaoDados.Size = new System.Drawing.Size(848, 80);
            this.groupComfirmacaoDados.TabIndex = 36;
            this.groupComfirmacaoDados.TabStop = false;
            this.groupComfirmacaoDados.Text = "Confirmação de Dados ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nome Evento";
            // 
            // textNomeExcluirCadastro
            // 
            this.textNomeExcluirCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeExcluirCadastro.HideSelection = false;
            this.textNomeExcluirCadastro.Location = new System.Drawing.Point(249, 45);
            this.textNomeExcluirCadastro.Name = "textNomeExcluirCadastro";
            this.textNomeExcluirCadastro.Size = new System.Drawing.Size(593, 26);
            this.textNomeExcluirCadastro.TabIndex = 51;
            // 
            // textCodigoInscricao
            // 
            this.textCodigoInscricao.Location = new System.Drawing.Point(10, 45);
            this.textCodigoInscricao.Name = "textCodigoInscricao";
            this.textCodigoInscricao.ReadOnly = true;
            this.textCodigoInscricao.Size = new System.Drawing.Size(114, 26);
            this.textCodigoInscricao.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Cód. Inscrição";
            // 
            // textCodigoCliente
            // 
            this.textCodigoCliente.Location = new System.Drawing.Point(130, 45);
            this.textCodigoCliente.Name = "textCodigoCliente";
            this.textCodigoCliente.ReadOnly = true;
            this.textCodigoCliente.Size = new System.Drawing.Size(113, 26);
            this.textCodigoCliente.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Cód. do Cliente";
            // 
            // dgvCancelarInscricao
            // 
            this.dgvCancelarInscricao.AllowUserToAddRows = false;
            this.dgvCancelarInscricao.AllowUserToDeleteRows = false;
            this.dgvCancelarInscricao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCancelarInscricao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCancelarInscricao.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCancelarInscricao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCancelarInscricao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCancelarInscricao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancelarInscricao.Location = new System.Drawing.Point(6, 25);
            this.dgvCancelarInscricao.Name = "dgvCancelarInscricao";
            this.dgvCancelarInscricao.ReadOnly = true;
            this.dgvCancelarInscricao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCancelarInscricao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCancelarInscricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCancelarInscricao.Size = new System.Drawing.Size(848, 484);
            this.dgvCancelarInscricao.TabIndex = 34;
            this.dgvCancelarInscricao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCancelarInscricao_CellClick);
            // 
            // FormExcluirInscricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 666);
            this.Controls.Add(this.buttonExcluirInscricao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSairCancelaInscricao);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExcluirInscricao";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelamento de Inscrição";
            this.Load += new System.EventHandler(this.FormExcluirInscricao_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupComfirmacaoDados.ResumeLayout(false);
            this.groupComfirmacaoDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelarInscricao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedCpfCnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPessoaTipoExcluir;
        private System.Windows.Forms.Label labelCpfCnpj;
        private System.Windows.Forms.Button buttonProcuraExcluirCadastro;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView dgvCancelarInscricao;
        private System.Windows.Forms.Button buttonExcluirInscricao;
        private System.Windows.Forms.Button buttonSairCancelaInscricao;
        public System.Windows.Forms.GroupBox groupComfirmacaoDados;
        public System.Windows.Forms.TextBox textCodigoInscricao;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textCodigoCliente;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNomeExcluirCadastro;
    }
}