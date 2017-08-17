namespace LM_Events.PresentationLayer
{
    partial class FormPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagamento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonFecharPagamento = new System.Windows.Forms.Button();
            this.buttonConfirmaPagamento = new System.Windows.Forms.Button();
            this.textValorRecebido = new System.Windows.Forms.TextBox();
            this.textValorTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTipoPagamento = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkStands = new System.Windows.Forms.CheckBox();
            this.checkInscricoes = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPagamento = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textValorTroco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFecharPagamento
            // 
            this.buttonFecharPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFecharPagamento.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonFecharPagamento.Image = ((System.Drawing.Image)(resources.GetObject("buttonFecharPagamento.Image")));
            this.buttonFecharPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFecharPagamento.Location = new System.Drawing.Point(751, 601);
            this.buttonFecharPagamento.Name = "buttonFecharPagamento";
            this.buttonFecharPagamento.Size = new System.Drawing.Size(103, 30);
            this.buttonFecharPagamento.TabIndex = 7;
            this.buttonFecharPagamento.Tag = "Voltar para forma de pagamento";
            this.buttonFecharPagamento.Text = "Fechar";
            this.buttonFecharPagamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFecharPagamento.UseVisualStyleBackColor = true;
            this.buttonFecharPagamento.Click += new System.EventHandler(this.buttonFecharPagamento_Click);
            // 
            // buttonConfirmaPagamento
            // 
            this.buttonConfirmaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmaPagamento.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonConfirmaPagamento.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfirmaPagamento.Image")));
            this.buttonConfirmaPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirmaPagamento.Location = new System.Drawing.Point(644, 601);
            this.buttonConfirmaPagamento.Name = "buttonConfirmaPagamento";
            this.buttonConfirmaPagamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonConfirmaPagamento.Size = new System.Drawing.Size(103, 30);
            this.buttonConfirmaPagamento.TabIndex = 6;
            this.buttonConfirmaPagamento.Tag = "Confirmar pagamento";
            this.buttonConfirmaPagamento.Text = "Confirmar";
            this.buttonConfirmaPagamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConfirmaPagamento.UseVisualStyleBackColor = true;
            this.buttonConfirmaPagamento.Click += new System.EventHandler(this.buttonConfirmaPagamento_Click);
            // 
            // textValorRecebido
            // 
            this.textValorRecebido.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValorRecebido.Location = new System.Drawing.Point(468, 546);
            this.textValorRecebido.Multiline = true;
            this.textValorRecebido.Name = "textValorRecebido";
            this.textValorRecebido.Size = new System.Drawing.Size(190, 49);
            this.textValorRecebido.TabIndex = 1;
            this.textValorRecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textValorRecebido.TextChanged += new System.EventHandler(this.textValorRecebido_TextChanged);
            // 
            // textValorTotal
            // 
            this.textValorTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValorTotal.Location = new System.Drawing.Point(272, 546);
            this.textValorTotal.Multiline = true;
            this.textValorTotal.Name = "textValorTotal";
            this.textValorTotal.ReadOnly = true;
            this.textValorTotal.Size = new System.Drawing.Size(190, 49);
            this.textValorTotal.TabIndex = 4;
            this.textValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tipo de Pagamento";
            // 
            // comboTipoPagamento
            // 
            this.comboTipoPagamento.BackColor = System.Drawing.SystemColors.Info;
            this.comboTipoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoPagamento.FormattingEnabled = true;
            this.comboTipoPagamento.Location = new System.Drawing.Point(6, 546);
            this.comboTipoPagamento.Name = "comboTipoPagamento";
            this.comboTipoPagamento.Size = new System.Drawing.Size(160, 28);
            this.comboTipoPagamento.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkStands);
            this.groupBox4.Controls.Add(this.checkInscricoes);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.dgvPagamento);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textValorTroco);
            this.groupBox4.Controls.Add(this.textValorRecebido);
            this.groupBox4.Controls.Add(this.textValorTotal);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.buttonFecharPagamento);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.buttonConfirmaPagamento);
            this.groupBox4.Controls.Add(this.comboTipoPagamento);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(860, 637);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pagamento";
            // 
            // checkStands
            // 
            this.checkStands.AutoSize = true;
            this.checkStands.Location = new System.Drawing.Point(112, 25);
            this.checkStands.Name = "checkStands";
            this.checkStands.Size = new System.Drawing.Size(79, 24);
            this.checkStands.TabIndex = 51;
            this.checkStands.Text = "Stands";
            this.checkStands.UseVisualStyleBackColor = true;
            this.checkStands.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkInscricoes
            // 
            this.checkInscricoes.AutoSize = true;
            this.checkInscricoes.Location = new System.Drawing.Point(6, 25);
            this.checkInscricoes.Name = "checkInscricoes";
            this.checkInscricoes.Size = new System.Drawing.Size(100, 24);
            this.checkInscricoes.TabIndex = 50;
            this.checkInscricoes.Text = "Inscriçoes";
            this.checkInscricoes.UseVisualStyleBackColor = true;
            this.checkInscricoes.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(665, 563);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 31);
            this.label8.TabIndex = 49;
            this.label8.Text = "R$";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(469, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 31);
            this.label7.TabIndex = 48;
            this.label7.Text = "R$";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(273, 563);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 31);
            this.label5.TabIndex = 47;
            this.label5.Text = "R$";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPagamento
            // 
            this.dgvPagamento.AllowUserToAddRows = false;
            this.dgvPagamento.AllowUserToDeleteRows = false;
            this.dgvPagamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagamento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPagamento.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPagamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamento.Location = new System.Drawing.Point(6, 55);
            this.dgvPagamento.Name = "dgvPagamento";
            this.dgvPagamento.ReadOnly = true;
            this.dgvPagamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPagamento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPagamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPagamento.Size = new System.Drawing.Size(848, 465);
            this.dgvPagamento.TabIndex = 34;
            this.dgvPagamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagamento_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(805, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Troco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Valor Recebido";
            // 
            // textValorTroco
            // 
            this.textValorTroco.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValorTroco.Location = new System.Drawing.Point(664, 546);
            this.textValorTroco.Multiline = true;
            this.textValorTroco.Name = "textValorTroco";
            this.textValorTroco.Size = new System.Drawing.Size(190, 49);
            this.textValorTroco.TabIndex = 2;
            this.textValorTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Valor a Receber";
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPagamento";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento de Inscrição";
            this.Load += new System.EventHandler(this.Pagamento_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonFecharPagamento;
        public System.Windows.Forms.Button buttonConfirmaPagamento;
        public System.Windows.Forms.TextBox textValorRecebido;
        public System.Windows.Forms.TextBox textValorTotal;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox comboTipoPagamento;
        public System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textValorTroco;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView dgvPagamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkStands;
        private System.Windows.Forms.CheckBox checkInscricoes;

    }
}