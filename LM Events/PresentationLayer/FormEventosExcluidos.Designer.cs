namespace LM_Events.PresentationLayer
{
    partial class FormEventosExcluidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventosExcluidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textCodigoEvento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maskedCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPessoaTipoExcluir = new System.Windows.Forms.ComboBox();
            this.labelCpfCnpj = new System.Windows.Forms.Label();
            this.buttonProcuraExcluirCadastro = new System.Windows.Forms.Button();
            this.buttonRestaurarEvento = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.dgvEventoCancelado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventoCancelado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textCodigoEvento
            // 
            this.textCodigoEvento.Enabled = false;
            this.textCodigoEvento.Location = new System.Drawing.Point(321, 603);
            this.textCodigoEvento.Name = "textCodigoEvento";
            this.textCodigoEvento.ReadOnly = true;
            this.textCodigoEvento.Size = new System.Drawing.Size(113, 26);
            this.textCodigoEvento.TabIndex = 48;
            this.textCodigoEvento.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(198, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Cód. do Evento";
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
            // buttonRestaurarEvento
            // 
            this.buttonRestaurarEvento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRestaurarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestaurarEvento.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestaurarEvento.Image")));
            this.buttonRestaurarEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRestaurarEvento.Location = new System.Drawing.Point(638, 601);
            this.buttonRestaurarEvento.Name = "buttonRestaurarEvento";
            this.buttonRestaurarEvento.Size = new System.Drawing.Size(105, 30);
            this.buttonRestaurarEvento.TabIndex = 38;
            this.buttonRestaurarEvento.Text = "&Restaurar";
            this.buttonRestaurarEvento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRestaurarEvento.UseVisualStyleBackColor = true;
            this.buttonRestaurarEvento.Click += new System.EventHandler(this.buttonExcluirInscricao_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Image = ((System.Drawing.Image)(resources.GetObject("buttonSair.Image")));
            this.buttonSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSair.Location = new System.Drawing.Point(749, 601);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(105, 30);
            this.buttonSair.TabIndex = 35;
            this.buttonSair.Text = "&Sair";
            this.buttonSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSairCancelaInscricao_Click);
            // 
            // dgvEventoCancelado
            // 
            this.dgvEventoCancelado.AllowUserToAddRows = false;
            this.dgvEventoCancelado.AllowUserToDeleteRows = false;
            this.dgvEventoCancelado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventoCancelado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEventoCancelado.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvEventoCancelado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventoCancelado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEventoCancelado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventoCancelado.Location = new System.Drawing.Point(6, 25);
            this.dgvEventoCancelado.Name = "dgvEventoCancelado";
            this.dgvEventoCancelado.ReadOnly = true;
            this.dgvEventoCancelado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvEventoCancelado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvEventoCancelado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEventoCancelado.Size = new System.Drawing.Size(848, 570);
            this.dgvEventoCancelado.TabIndex = 34;
            this.dgvEventoCancelado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscricaoCancelada_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRestaurarEvento);
            this.groupBox1.Controls.Add(this.buttonSair);
            this.groupBox1.Controls.Add(this.dgvEventoCancelado);
            this.groupBox1.Controls.Add(this.textCodigoEvento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 637);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Eventos Cancelados";
            // 
            // FormEventosExcluidos
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
            this.Name = "FormEventosExcluidos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos Cancelados";
            this.Load += new System.EventHandler(this.FormInscricoesCanceladas_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventoCancelado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox textCodigoEvento;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox maskedCpfCnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPessoaTipoExcluir;
        private System.Windows.Forms.Label labelCpfCnpj;
        private System.Windows.Forms.Button buttonProcuraExcluirCadastro;
        private System.Windows.Forms.Button buttonRestaurarEvento;
        private System.Windows.Forms.Button buttonSair;
        internal System.Windows.Forms.DataGridView dgvEventoCancelado;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}