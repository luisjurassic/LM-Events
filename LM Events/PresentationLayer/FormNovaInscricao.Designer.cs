namespace LM_Events.PresentationLayer
{
    partial class FormNovaInscricao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovaInscricao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEvento = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textInscritoPor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedData = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericItem = new System.Windows.Forms.NumericUpDown();
            this.textCodigoEvento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textProcurarCliente = new System.Windows.Forms.TextBox();
            this.textProcurarEvento = new System.Windows.Forms.TextBox();
            this.buttonCancelarIncricao = new System.Windows.Forms.Button();
            this.buttonConfirmaInscricao = new System.Windows.Forms.Button();
            this.textCodigoCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDescontos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvento
            // 
            this.dgvEvento.AllowUserToAddRows = false;
            this.dgvEvento.AllowUserToDeleteRows = false;
            this.dgvEvento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvento.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvEvento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvento.Location = new System.Drawing.Point(6, 75);
            this.dgvEvento.Name = "dgvEvento";
            this.dgvEvento.ReadOnly = true;
            this.dgvEvento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvEvento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvEvento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEvento.Size = new System.Drawing.Size(848, 200);
            this.dgvEvento.TabIndex = 23;
            this.dgvEvento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvento_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textInscritoPor);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.maskedData);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.numericItem);
            this.groupBox4.Controls.Add(this.textCodigoEvento);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textProcurarCliente);
            this.groupBox4.Controls.Add(this.textProcurarEvento);
            this.groupBox4.Controls.Add(this.buttonCancelarIncricao);
            this.groupBox4.Controls.Add(this.buttonConfirmaInscricao);
            this.groupBox4.Controls.Add(this.textCodigoCliente);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.dgvEvento);
            this.groupBox4.Controls.Add(this.dgvCliente);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.comboDescontos);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(860, 637);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inscrição Evento";
            // 
            // textInscritoPor
            // 
            this.textInscritoPor.Location = new System.Drawing.Point(128, 558);
            this.textInscritoPor.Name = "textInscritoPor";
            this.textInscritoPor.ReadOnly = true;
            this.textInscritoPor.Size = new System.Drawing.Size(114, 26);
            this.textInscritoPor.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 536);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Inscrito Por";
            // 
            // maskedData
            // 
            this.maskedData.Location = new System.Drawing.Point(6, 558);
            this.maskedData.Mask = "00/00/0000";
            this.maskedData.Name = "maskedData";
            this.maskedData.ReadOnly = true;
            this.maskedData.Size = new System.Drawing.Size(112, 26);
            this.maskedData.TabIndex = 50;
            this.maskedData.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Data Inscrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Itens";
            // 
            // numericItem
            // 
            this.numericItem.Enabled = false;
            this.numericItem.Location = new System.Drawing.Point(248, 558);
            this.numericItem.Name = "numericItem";
            this.numericItem.Size = new System.Drawing.Size(48, 26);
            this.numericItem.TabIndex = 47;
            // 
            // textCodigoEvento
            // 
            this.textCodigoEvento.Enabled = false;
            this.textCodigoEvento.Location = new System.Drawing.Point(306, 559);
            this.textCodigoEvento.Name = "textCodigoEvento";
            this.textCodigoEvento.ReadOnly = true;
            this.textCodigoEvento.Size = new System.Drawing.Size(114, 26);
            this.textCodigoEvento.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 537);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Cód. do Evento";
            // 
            // textProcurarCliente
            // 
            this.textProcurarCliente.Location = new System.Drawing.Point(6, 301);
            this.textProcurarCliente.Name = "textProcurarCliente";
            this.textProcurarCliente.Size = new System.Drawing.Size(537, 26);
            this.textProcurarCliente.TabIndex = 44;
            this.textProcurarCliente.TextChanged += new System.EventHandler(this.textProcurarCliente_TextChanged);
            // 
            // textProcurarEvento
            // 
            this.textProcurarEvento.Location = new System.Drawing.Point(6, 45);
            this.textProcurarEvento.Name = "textProcurarEvento";
            this.textProcurarEvento.Size = new System.Drawing.Size(537, 26);
            this.textProcurarEvento.TabIndex = 43;
            this.textProcurarEvento.TextChanged += new System.EventHandler(this.textProcurarEvento_TextChanged);
            // 
            // buttonCancelarIncricao
            // 
            this.buttonCancelarIncricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarIncricao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonCancelarIncricao.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelarIncricao.Image")));
            this.buttonCancelarIncricao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarIncricao.Location = new System.Drawing.Point(750, 601);
            this.buttonCancelarIncricao.Name = "buttonCancelarIncricao";
            this.buttonCancelarIncricao.Size = new System.Drawing.Size(104, 30);
            this.buttonCancelarIncricao.TabIndex = 41;
            this.buttonCancelarIncricao.Tag = "Voltar para forma de pagamento";
            this.buttonCancelarIncricao.Text = "&Sair";
            this.buttonCancelarIncricao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelarIncricao.UseVisualStyleBackColor = true;
            this.buttonCancelarIncricao.Click += new System.EventHandler(this.buttonCancelarIncricao_Click);
            // 
            // buttonConfirmaInscricao
            // 
            this.buttonConfirmaInscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmaInscricao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonConfirmaInscricao.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfirmaInscricao.Image")));
            this.buttonConfirmaInscricao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirmaInscricao.Location = new System.Drawing.Point(640, 601);
            this.buttonConfirmaInscricao.Name = "buttonConfirmaInscricao";
            this.buttonConfirmaInscricao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonConfirmaInscricao.Size = new System.Drawing.Size(104, 30);
            this.buttonConfirmaInscricao.TabIndex = 42;
            this.buttonConfirmaInscricao.Tag = "Confirmar pagamento";
            this.buttonConfirmaInscricao.Text = "&Confirmar";
            this.buttonConfirmaInscricao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConfirmaInscricao.UseVisualStyleBackColor = true;
            this.buttonConfirmaInscricao.Click += new System.EventHandler(this.buttonConfirmaInscricao_Click);
            // 
            // textCodigoCliente
            // 
            this.textCodigoCliente.Enabled = false;
            this.textCodigoCliente.Location = new System.Drawing.Point(430, 559);
            this.textCodigoCliente.Name = "textCodigoCliente";
            this.textCodigoCliente.ReadOnly = true;
            this.textCodigoCliente.Size = new System.Drawing.Size(113, 26);
            this.textCodigoCliente.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Cód. do Cliente";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(6, 333);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCliente.Size = new System.Drawing.Size(848, 200);
            this.dgvCliente.TabIndex = 25;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(6, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Procurar Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Descontos";
            // 
            // comboDescontos
            // 
            this.comboDescontos.BackColor = System.Drawing.SystemColors.Info;
            this.comboDescontos.Enabled = false;
            this.comboDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDescontos.FormattingEnabled = true;
            this.comboDescontos.Location = new System.Drawing.Point(553, 557);
            this.comboDescontos.Name = "comboDescontos";
            this.comboDescontos.Size = new System.Drawing.Size(173, 28);
            this.comboDescontos.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Procurar Evento";
            // 
            // FormInscricaoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInscricaoPagamento";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Inscrição";
            this.Load += new System.EventHandler(this.InscricaoPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvEvento;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboDescontos;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvCliente;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textCodigoCliente;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textCodigoEvento;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown numericItem;
        public System.Windows.Forms.Button buttonCancelarIncricao;
        public System.Windows.Forms.Button buttonConfirmaInscricao;
        public System.Windows.Forms.TextBox textProcurarCliente;
        public System.Windows.Forms.TextBox textProcurarEvento;
        private System.Windows.Forms.MaskedTextBox maskedData;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textInscritoPor;
        public System.Windows.Forms.Label label8;


    }
}