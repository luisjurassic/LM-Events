namespace LM_Events.PresentationLayer
{
    partial class FormInscricoesExcluidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscricoesExcluidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textCodigoInscricoes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maskedCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPessoaTipoExcluir = new System.Windows.Forms.ComboBox();
            this.labelCpfCnpj = new System.Windows.Forms.Label();
            this.buttonProcuraExcluirCadastro = new System.Windows.Forms.Button();
            this.buttonRestaurarInscricao = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.dgvinscricoesCancelado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinscricoesCancelado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textCodigoInscricoes
            // 
            this.textCodigoInscricoes.Enabled = false;
            this.textCodigoInscricoes.Location = new System.Drawing.Point(321, 603);
            this.textCodigoInscricoes.Name = "textCodigoInscricoes";
            this.textCodigoInscricoes.ReadOnly = true;
            this.textCodigoInscricoes.Size = new System.Drawing.Size(113, 26);
            this.textCodigoInscricoes.TabIndex = 48;
            this.textCodigoInscricoes.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(177, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Cód. do inscricoes";
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
            this.buttonProcuraExcluirCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProcuraExcluirCadastro.Location = new System.Drawing.Point(558, 28);
            this.buttonProcuraExcluirCadastro.Name = "buttonProcuraExcluirCadastro";
            this.buttonProcuraExcluirCadastro.Size = new System.Drawing.Size(96, 30);
            this.buttonProcuraExcluirCadastro.TabIndex = 2;
            this.buttonProcuraExcluirCadastro.Text = "&Procurar";
            this.buttonProcuraExcluirCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProcuraExcluirCadastro.UseVisualStyleBackColor = true;
            // 
            // buttonRestaurarInscricao
            // 
            this.buttonRestaurarInscricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRestaurarInscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestaurarInscricao.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestaurarInscricao.Image")));
            this.buttonRestaurarInscricao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRestaurarInscricao.Location = new System.Drawing.Point(6, 601);
            this.buttonRestaurarInscricao.Name = "buttonRestaurarInscricao";
            this.buttonRestaurarInscricao.Size = new System.Drawing.Size(105, 30);
            this.buttonRestaurarInscricao.TabIndex = 38;
            this.buttonRestaurarInscricao.Text = "&Restaurar";
            this.buttonRestaurarInscricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRestaurarInscricao.UseVisualStyleBackColor = true;
            this.buttonRestaurarInscricao.Click += new System.EventHandler(this.buttonExcluirInscricao_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Image = ((System.Drawing.Image)(resources.GetObject("buttonSair.Image")));
            this.buttonSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSair.Location = new System.Drawing.Point(792, 601);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(62, 30);
            this.buttonSair.TabIndex = 35;
            this.buttonSair.Text = "&Sair";
            this.buttonSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSairCancelaInscricao_Click);
            // 
            // dgvinscricoesCancelado
            // 
            this.dgvinscricoesCancelado.AllowUserToAddRows = false;
            this.dgvinscricoesCancelado.AllowUserToDeleteRows = false;
            this.dgvinscricoesCancelado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvinscricoesCancelado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvinscricoesCancelado.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvinscricoesCancelado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinscricoesCancelado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvinscricoesCancelado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinscricoesCancelado.Location = new System.Drawing.Point(6, 25);
            this.dgvinscricoesCancelado.Name = "dgvinscricoesCancelado";
            this.dgvinscricoesCancelado.ReadOnly = true;
            this.dgvinscricoesCancelado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvinscricoesCancelado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvinscricoesCancelado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvinscricoesCancelado.Size = new System.Drawing.Size(848, 570);
            this.dgvinscricoesCancelado.TabIndex = 34;
            this.dgvinscricoesCancelado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscricaoCancelada_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRestaurarInscricao);
            this.groupBox1.Controls.Add(this.buttonSair);
            this.groupBox1.Controls.Add(this.dgvinscricoesCancelado);
            this.groupBox1.Controls.Add(this.textCodigoInscricoes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 637);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Inscrições Canceladas";
            // 
            // FormInscricoesExcluidos
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
            this.Name = "FormInscricoesExcluidos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscricões Canceladas";
            this.Load += new System.EventHandler(this.FormInscricoesCanceladas_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinscricoesCancelado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox textCodigoInscricoes;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox maskedCpfCnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPessoaTipoExcluir;
        private System.Windows.Forms.Label labelCpfCnpj;
        private System.Windows.Forms.Button buttonProcuraExcluirCadastro;
        private System.Windows.Forms.Button buttonRestaurarInscricao;
        private System.Windows.Forms.Button buttonSair;
        internal System.Windows.Forms.DataGridView dgvinscricoesCancelado;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}