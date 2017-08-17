namespace LM_Events
{
    partial class FormExcluirCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExcluirCadastro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupConfirmacao = new System.Windows.Forms.GroupBox();
            this.labelRGInscricaoEstadual = new System.Windows.Forms.Label();
            this.mskRGInscricao = new System.Windows.Forms.MaskedTextBox();
            this.labelCPFCNPJ = new System.Windows.Forms.Label();
            this.mskCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.labelNomes = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.buttonCancelarExcluir = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkPJ = new System.Windows.Forms.CheckBox();
            this.checkPF = new System.Windows.Forms.CheckBox();
            this.dgvExcluirCadastros = new System.Windows.Forms.DataGridView();
            this.groupConfirmacao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcluirCadastros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupConfirmacao
            // 
            this.groupConfirmacao.Controls.Add(this.labelRGInscricaoEstadual);
            this.groupConfirmacao.Controls.Add(this.mskRGInscricao);
            this.groupConfirmacao.Controls.Add(this.labelCPFCNPJ);
            this.groupConfirmacao.Controls.Add(this.mskCPFCNPJ);
            this.groupConfirmacao.Controls.Add(this.labelNomes);
            this.groupConfirmacao.Controls.Add(this.textNome);
            this.groupConfirmacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupConfirmacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupConfirmacao.Location = new System.Drawing.Point(6, 507);
            this.groupConfirmacao.Name = "groupConfirmacao";
            this.groupConfirmacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupConfirmacao.Size = new System.Drawing.Size(848, 88);
            this.groupConfirmacao.TabIndex = 11;
            this.groupConfirmacao.TabStop = false;
            this.groupConfirmacao.Text = "Confirmação de Dados ";
            // 
            // labelRGInscricaoEstadual
            // 
            this.labelRGInscricaoEstadual.AutoSize = true;
            this.labelRGInscricaoEstadual.Location = new System.Drawing.Point(702, 22);
            this.labelRGInscricaoEstadual.Name = "labelRGInscricaoEstadual";
            this.labelRGInscricaoEstadual.Size = new System.Drawing.Size(140, 20);
            this.labelRGInscricaoEstadual.TabIndex = 42;
            this.labelRGInscricaoEstadual.Text = "Inscrição Estadual";
            // 
            // mskRGInscricao
            // 
            this.mskRGInscricao.Location = new System.Drawing.Point(706, 44);
            this.mskRGInscricao.Name = "mskRGInscricao";
            this.mskRGInscricao.Size = new System.Drawing.Size(136, 26);
            this.mskRGInscricao.TabIndex = 41;
            this.mskRGInscricao.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelCPFCNPJ
            // 
            this.labelCPFCNPJ.AutoSize = true;
            this.labelCPFCNPJ.Location = new System.Drawing.Point(544, 21);
            this.labelCPFCNPJ.Name = "labelCPFCNPJ";
            this.labelCPFCNPJ.Size = new System.Drawing.Size(140, 20);
            this.labelCPFCNPJ.TabIndex = 40;
            this.labelCPFCNPJ.Text = "Inscrição Estadual";
            // 
            // mskCPFCNPJ
            // 
            this.mskCPFCNPJ.Location = new System.Drawing.Point(548, 44);
            this.mskCPFCNPJ.Name = "mskCPFCNPJ";
            this.mskCPFCNPJ.Size = new System.Drawing.Size(152, 26);
            this.mskCPFCNPJ.TabIndex = 39;
            this.mskCPFCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelNomes
            // 
            this.labelNomes.AutoSize = true;
            this.labelNomes.Location = new System.Drawing.Point(6, 22);
            this.labelNomes.Name = "labelNomes";
            this.labelNomes.Size = new System.Drawing.Size(51, 20);
            this.labelNomes.TabIndex = 5;
            this.labelNomes.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.HideSelection = false;
            this.textNome.Location = new System.Drawing.Point(10, 44);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(532, 26);
            this.textNome.TabIndex = 1;
            // 
            // buttonCancelarExcluir
            // 
            this.buttonCancelarExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancelarExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarExcluir.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelarExcluir.Image")));
            this.buttonCancelarExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarExcluir.Location = new System.Drawing.Point(754, 601);
            this.buttonCancelarExcluir.Name = "buttonCancelarExcluir";
            this.buttonCancelarExcluir.Size = new System.Drawing.Size(100, 30);
            this.buttonCancelarExcluir.TabIndex = 4;
            this.buttonCancelarExcluir.Text = "&Sair";
            this.buttonCancelarExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelarExcluir.UseVisualStyleBackColor = true;
            this.buttonCancelarExcluir.Click += new System.EventHandler(this.buttonCancelarExcluirCadastro_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluir.Image")));
            this.buttonExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluir.Location = new System.Drawing.Point(648, 601);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(100, 30);
            this.buttonExcluir.TabIndex = 12;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonExcluir);
            this.groupBox1.Controls.Add(this.groupConfirmacao);
            this.groupBox1.Controls.Add(this.buttonCancelarExcluir);
            this.groupBox1.Controls.Add(this.checkPJ);
            this.groupBox1.Controls.Add(this.checkPF);
            this.groupBox1.Controls.Add(this.dgvExcluirCadastros);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 637);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Cadastros";
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
            this.checkPJ.Click += new System.EventHandler(this.checkPJ_CheckedChanged);
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
            this.checkPF.Click += new System.EventHandler(this.checkPF_CheckedChanged);
            // 
            // dgvExcluirCadastros
            // 
            this.dgvExcluirCadastros.AllowUserToAddRows = false;
            this.dgvExcluirCadastros.AllowUserToDeleteRows = false;
            this.dgvExcluirCadastros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExcluirCadastros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvExcluirCadastros.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvExcluirCadastros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcluirCadastros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExcluirCadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcluirCadastros.Location = new System.Drawing.Point(6, 55);
            this.dgvExcluirCadastros.Name = "dgvExcluirCadastros";
            this.dgvExcluirCadastros.ReadOnly = true;
            this.dgvExcluirCadastros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvExcluirCadastros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvExcluirCadastros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvExcluirCadastros.Size = new System.Drawing.Size(848, 446);
            this.dgvExcluirCadastros.TabIndex = 34;
            this.dgvExcluirCadastros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExcluirCadastros_CellClick);
            // 
            // FormExcluirCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExcluirCadastro";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Cadastro";
            this.Load += new System.EventHandler(this.FormExcluirCadastro_Load);
            this.groupConfirmacao.ResumeLayout(false);
            this.groupConfirmacao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcluirCadastros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelarExcluir;
        public System.Windows.Forms.GroupBox groupConfirmacao;
        private System.Windows.Forms.Label labelNomes;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label labelCPFCNPJ;
        private System.Windows.Forms.MaskedTextBox mskCPFCNPJ;
        private System.Windows.Forms.Button buttonExcluir;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkPJ;
        private System.Windows.Forms.CheckBox checkPF;
        internal System.Windows.Forms.DataGridView dgvExcluirCadastros;
        private System.Windows.Forms.Label labelRGInscricaoEstadual;
        private System.Windows.Forms.MaskedTextBox mskRGInscricao;
    }
}