namespace LM_Events.PresentationLayer
{
    partial class FormExcluirEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExcluirEvento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.textNomeExcluirCadastro = new System.Windows.Forms.TextBox();
            this.textCodigoInscricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.btnDataInicio = new System.Windows.Forms.Button();
            this.radioButtonMes = new System.Windows.Forms.RadioButton();
            this.radioButtonDia = new System.Windows.Forms.RadioButton();
            this.buttonExcluirEvento = new System.Windows.Forms.Button();
            this.buttonSairCancelaEvento = new System.Windows.Forms.Button();
            this.groupComfirmacaoDados = new System.Windows.Forms.GroupBox();
            this.dgvCancelarEvento = new System.Windows.Forms.DataGridView();
            this.textBuscaEventoCancelar = new System.Windows.Forms.TextBox();
            this.buttonProcuraExcluirCadastro = new System.Windows.Forms.Button();
            this.maskedCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPessoaTipoExcluir = new System.Windows.Forms.ComboBox();
            this.labelCpfCnpj = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.calendarioEventos = new System.Windows.Forms.MonthCalendar();
            this.groupBox1.SuspendLayout();
            this.groupComfirmacaoDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelarEvento)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nome Evento";
            // 
            // textNomeExcluirCadastro
            // 
            this.textNomeExcluirCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeExcluirCadastro.HideSelection = false;
            this.textNomeExcluirCadastro.Location = new System.Drawing.Point(130, 45);
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
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Cód. do Evento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNome);
            this.groupBox1.Controls.Add(this.btnDataInicio);
            this.groupBox1.Controls.Add(this.radioButtonMes);
            this.groupBox1.Controls.Add(this.radioButtonDia);
            this.groupBox1.Controls.Add(this.groupComfirmacaoDados);
            this.groupBox1.Controls.Add(this.dgvCancelarEvento);
            this.groupBox1.Controls.Add(this.textBuscaEventoCancelar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 605);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Eventos";
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Location = new System.Drawing.Point(307, 25);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(156, 24);
            this.radioButtonNome.TabIndex = 43;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Procura Por Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            this.radioButtonNome.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnDataInicio
            // 
            this.btnDataInicio.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.btnDataInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnDataInicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDataInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnDataInicio.Image")));
            this.btnDataInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDataInicio.Location = new System.Drawing.Point(660, 22);
            this.btnDataInicio.Name = "btnDataInicio";
            this.btnDataInicio.Size = new System.Drawing.Size(194, 30);
            this.btnDataInicio.TabIndex = 39;
            this.btnDataInicio.Text = "Calendário de Eventos";
            this.btnDataInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataInicio.UseVisualStyleBackColor = false;
            this.btnDataInicio.Click += new System.EventHandler(this.btnDataInicio_Click);
            // 
            // radioButtonMes
            // 
            this.radioButtonMes.AutoSize = true;
            this.radioButtonMes.Location = new System.Drawing.Point(150, 25);
            this.radioButtonMes.Name = "radioButtonMes";
            this.radioButtonMes.Size = new System.Drawing.Size(151, 24);
            this.radioButtonMes.TabIndex = 42;
            this.radioButtonMes.TabStop = true;
            this.radioButtonMes.Text = "Procura Pelo Mês";
            this.radioButtonMes.UseVisualStyleBackColor = true;
            this.radioButtonMes.CheckedChanged += new System.EventHandler(this.radioButtonMes_CheckedChanged);
            // 
            // radioButtonDia
            // 
            this.radioButtonDia.AutoSize = true;
            this.radioButtonDia.Location = new System.Drawing.Point(6, 25);
            this.radioButtonDia.Name = "radioButtonDia";
            this.radioButtonDia.Size = new System.Drawing.Size(138, 24);
            this.radioButtonDia.TabIndex = 41;
            this.radioButtonDia.TabStop = true;
            this.radioButtonDia.Text = "Procura Por Dia";
            this.radioButtonDia.UseVisualStyleBackColor = true;
            this.radioButtonDia.CheckedChanged += new System.EventHandler(this.radioButtonDia_CheckedChanged);
            // 
            // buttonExcluirEvento
            // 
            this.buttonExcluirEvento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExcluirEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirEvento.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirEvento.Image")));
            this.buttonExcluirEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirEvento.Location = new System.Drawing.Point(666, 623);
            this.buttonExcluirEvento.Name = "buttonExcluirEvento";
            this.buttonExcluirEvento.Size = new System.Drawing.Size(100, 30);
            this.buttonExcluirEvento.TabIndex = 38;
            this.buttonExcluirEvento.Text = "&Cancelar";
            this.buttonExcluirEvento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExcluirEvento.UseVisualStyleBackColor = true;
            this.buttonExcluirEvento.Click += new System.EventHandler(this.buttonExcluirEvento_Click);
            // 
            // buttonSairCancelaEvento
            // 
            this.buttonSairCancelaEvento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSairCancelaEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSairCancelaEvento.Image = ((System.Drawing.Image)(resources.GetObject("buttonSairCancelaEvento.Image")));
            this.buttonSairCancelaEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSairCancelaEvento.Location = new System.Drawing.Point(772, 623);
            this.buttonSairCancelaEvento.Name = "buttonSairCancelaEvento";
            this.buttonSairCancelaEvento.Size = new System.Drawing.Size(100, 30);
            this.buttonSairCancelaEvento.TabIndex = 35;
            this.buttonSairCancelaEvento.Text = "&Sair";
            this.buttonSairCancelaEvento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSairCancelaEvento.UseVisualStyleBackColor = true;
            this.buttonSairCancelaEvento.Click += new System.EventHandler(this.buttonSairCancelaEvento_Click);
            // 
            // groupComfirmacaoDados
            // 
            this.groupComfirmacaoDados.Controls.Add(this.label2);
            this.groupComfirmacaoDados.Controls.Add(this.textNomeExcluirCadastro);
            this.groupComfirmacaoDados.Controls.Add(this.textCodigoInscricao);
            this.groupComfirmacaoDados.Controls.Add(this.label6);
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
            // dgvCancelarEvento
            // 
            this.dgvCancelarEvento.AllowUserToAddRows = false;
            this.dgvCancelarEvento.AllowUserToDeleteRows = false;
            this.dgvCancelarEvento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCancelarEvento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCancelarEvento.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCancelarEvento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCancelarEvento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCancelarEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancelarEvento.Location = new System.Drawing.Point(6, 55);
            this.dgvCancelarEvento.Name = "dgvCancelarEvento";
            this.dgvCancelarEvento.ReadOnly = true;
            this.dgvCancelarEvento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCancelarEvento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCancelarEvento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCancelarEvento.Size = new System.Drawing.Size(848, 454);
            this.dgvCancelarEvento.TabIndex = 34;
            this.dgvCancelarEvento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCancelarEvento_CellClick);
            // 
            // textBuscaEventoCancelar
            // 
            this.textBuscaEventoCancelar.Enabled = false;
            this.textBuscaEventoCancelar.Location = new System.Drawing.Point(469, 24);
            this.textBuscaEventoCancelar.Name = "textBuscaEventoCancelar";
            this.textBuscaEventoCancelar.Size = new System.Drawing.Size(185, 26);
            this.textBuscaEventoCancelar.TabIndex = 44;
            this.textBuscaEventoCancelar.TextChanged += new System.EventHandler(this.textBuscaEventoCancelar_TextChanged);
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
            // calendarioEventos
            // 
            this.calendarioEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarioEventos.Location = new System.Drawing.Point(634, 50);
            this.calendarioEventos.Name = "calendarioEventos";
            this.calendarioEventos.TabIndex = 40;
            this.calendarioEventos.Visible = false;
            this.calendarioEventos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.calendarioEventos_MouseDown);
            this.calendarioEventos.MouseLeave += new System.EventHandler(this.calendarioEventos_MouseLeave);
            // 
            // FormExcluirEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 664);
            this.Controls.Add(this.calendarioEventos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonSairCancelaEvento);
            this.Controls.Add(this.buttonExcluirEvento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExcluirEvento";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelamento de  Evento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupComfirmacaoDados.ResumeLayout(false);
            this.groupComfirmacaoDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelarEvento)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNomeExcluirCadastro;
        public System.Windows.Forms.TextBox textCodigoInscricao;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonExcluirEvento;
        private System.Windows.Forms.Button buttonSairCancelaEvento;
        public System.Windows.Forms.GroupBox groupComfirmacaoDados;
        internal System.Windows.Forms.DataGridView dgvCancelarEvento;
        private System.Windows.Forms.Button buttonProcuraExcluirCadastro;
        private System.Windows.Forms.MaskedTextBox maskedCpfCnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPessoaTipoExcluir;
        private System.Windows.Forms.Label labelCpfCnpj;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.MonthCalendar calendarioEventos;
        private System.Windows.Forms.Button btnDataInicio;
        private System.Windows.Forms.RadioButton radioButtonMes;
        private System.Windows.Forms.RadioButton radioButtonDia;
        private System.Windows.Forms.TextBox textBuscaEventoCancelar;
    }
}