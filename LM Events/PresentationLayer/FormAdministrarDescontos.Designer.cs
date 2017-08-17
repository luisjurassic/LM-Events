namespace LM_Events.PresentationLayer
{
    partial class FormAdministrarDescontos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrarDescontos));
            this.groupBoxDescontos = new System.Windows.Forms.GroupBox();
            this.textBoxTipoDesconto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDescontos = new System.Windows.Forms.DataGridView();
            this.maskedPorcentDesconto = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCancelarDescontos = new System.Windows.Forms.Button();
            this.buttonInserirDescontos = new System.Windows.Forms.Button();
            this.buttonAlterarDesconto = new System.Windows.Forms.Button();
            this.buttonDeletarDesconto = new System.Windows.Forms.Button();
            this.txtIdDesconto = new System.Windows.Forms.TextBox();
            this.groupBoxDescontos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDescontos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDescontos
            // 
            this.groupBoxDescontos.Controls.Add(this.textBoxTipoDesconto);
            this.groupBoxDescontos.Controls.Add(this.label1);
            this.groupBoxDescontos.Controls.Add(this.dataGridViewDescontos);
            this.groupBoxDescontos.Controls.Add(this.maskedPorcentDesconto);
            this.groupBoxDescontos.Controls.Add(this.label5);
            this.groupBoxDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDescontos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDescontos.Name = "groupBoxDescontos";
            this.groupBoxDescontos.Size = new System.Drawing.Size(509, 414);
            this.groupBoxDescontos.TabIndex = 0;
            this.groupBoxDescontos.TabStop = false;
            this.groupBoxDescontos.Text = "Tabela de Descontos";
            // 
            // textBoxTipoDesconto
            // 
            this.textBoxTipoDesconto.Location = new System.Drawing.Point(6, 378);
            this.textBoxTipoDesconto.Name = "textBoxTipoDesconto";
            this.textBoxTipoDesconto.Size = new System.Drawing.Size(296, 26);
            this.textBoxTipoDesconto.TabIndex = 1;
            this.textBoxTipoDesconto.Leave += new System.EventHandler(this.textBoxTipoDesconto_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Porcentagem(%)";
            // 
            // dataGridViewDescontos
            // 
            this.dataGridViewDescontos.AllowUserToAddRows = false;
            this.dataGridViewDescontos.AllowUserToDeleteRows = false;
            this.dataGridViewDescontos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDescontos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewDescontos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDescontos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDescontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDescontos.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewDescontos.Name = "dataGridViewDescontos";
            this.dataGridViewDescontos.ReadOnly = true;
            this.dataGridViewDescontos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewDescontos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewDescontos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDescontos.Size = new System.Drawing.Size(497, 327);
            this.dataGridViewDescontos.TabIndex = 7;
            this.dataGridViewDescontos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDescontos_CellDoubleClick);
            // 
            // maskedPorcentDesconto
            // 
            this.maskedPorcentDesconto.Location = new System.Drawing.Point(325, 378);
            this.maskedPorcentDesconto.Mask = "000%";
            this.maskedPorcentDesconto.Name = "maskedPorcentDesconto";
            this.maskedPorcentDesconto.PromptChar = ' ';
            this.maskedPorcentDesconto.Size = new System.Drawing.Size(124, 26);
            this.maskedPorcentDesconto.TabIndex = 2;
            this.maskedPorcentDesconto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Desconto Para ";
            // 
            // buttonCancelarDescontos
            // 
            this.buttonCancelarDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarDescontos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonCancelarDescontos.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelarDescontos.Image")));
            this.buttonCancelarDescontos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarDescontos.Location = new System.Drawing.Point(436, 429);
            this.buttonCancelarDescontos.Name = "buttonCancelarDescontos";
            this.buttonCancelarDescontos.Size = new System.Drawing.Size(85, 30);
            this.buttonCancelarDescontos.TabIndex = 6;
            this.buttonCancelarDescontos.Tag = "Voltar para forma de pagamento";
            this.buttonCancelarDescontos.Text = "&Sair";
            this.buttonCancelarDescontos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelarDescontos.UseVisualStyleBackColor = true;
            this.buttonCancelarDescontos.Click += new System.EventHandler(this.buttonCancelarDescontos_Click);
            // 
            // buttonInserirDescontos
            // 
            this.buttonInserirDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserirDescontos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonInserirDescontos.Image = ((System.Drawing.Image)(resources.GetObject("buttonInserirDescontos.Image")));
            this.buttonInserirDescontos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInserirDescontos.Location = new System.Drawing.Point(167, 429);
            this.buttonInserirDescontos.Name = "buttonInserirDescontos";
            this.buttonInserirDescontos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonInserirDescontos.Size = new System.Drawing.Size(78, 30);
            this.buttonInserirDescontos.TabIndex = 3;
            this.buttonInserirDescontos.Tag = "Inserir novo tipo de desconto";
            this.buttonInserirDescontos.Text = "&Inserir";
            this.buttonInserirDescontos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInserirDescontos.UseVisualStyleBackColor = true;
            this.buttonInserirDescontos.Click += new System.EventHandler(this.buttonInserirDescontos_Click);
            // 
            // buttonAlterarDesconto
            // 
            this.buttonAlterarDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarDesconto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonAlterarDesconto.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlterarDesconto.Image")));
            this.buttonAlterarDesconto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAlterarDesconto.Location = new System.Drawing.Point(251, 429);
            this.buttonAlterarDesconto.Name = "buttonAlterarDesconto";
            this.buttonAlterarDesconto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAlterarDesconto.Size = new System.Drawing.Size(87, 30);
            this.buttonAlterarDesconto.TabIndex = 4;
            this.buttonAlterarDesconto.Tag = "Alterar desconto";
            this.buttonAlterarDesconto.Text = "&Alterar";
            this.buttonAlterarDesconto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAlterarDesconto.UseVisualStyleBackColor = true;
            this.buttonAlterarDesconto.Click += new System.EventHandler(this.buttonAlterarDesconto_Click);
            // 
            // buttonDeletarDesconto
            // 
            this.buttonDeletarDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletarDesconto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonDeletarDesconto.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeletarDesconto.Image")));
            this.buttonDeletarDesconto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeletarDesconto.Location = new System.Drawing.Point(344, 429);
            this.buttonDeletarDesconto.Name = "buttonDeletarDesconto";
            this.buttonDeletarDesconto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDeletarDesconto.Size = new System.Drawing.Size(86, 30);
            this.buttonDeletarDesconto.TabIndex = 5;
            this.buttonDeletarDesconto.Tag = "Deletar tipo de desconto";
            this.buttonDeletarDesconto.Text = "&Deletar";
            this.buttonDeletarDesconto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeletarDesconto.UseVisualStyleBackColor = true;
            this.buttonDeletarDesconto.Click += new System.EventHandler(this.buttonDeletarDesconto_Click);
            // 
            // txtIdDesconto
            // 
            this.txtIdDesconto.Enabled = false;
            this.txtIdDesconto.Location = new System.Drawing.Point(33, 436);
            this.txtIdDesconto.Name = "txtIdDesconto";
            this.txtIdDesconto.Size = new System.Drawing.Size(48, 20);
            this.txtIdDesconto.TabIndex = 7;
            this.txtIdDesconto.Visible = false;
            // 
            // FormAdministrarDescontos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 471);
            this.Controls.Add(this.txtIdDesconto);
            this.Controls.Add(this.buttonDeletarDesconto);
            this.Controls.Add(this.buttonAlterarDesconto);
            this.Controls.Add(this.buttonCancelarDescontos);
            this.Controls.Add(this.buttonInserirDescontos);
            this.Controls.Add(this.groupBoxDescontos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdministrarDescontos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administração dos Descontos";
            this.Load += new System.EventHandler(this.AdministrarDescontos_Load);
            this.groupBoxDescontos.ResumeLayout(false);
            this.groupBoxDescontos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDescontos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDescontos;
        private System.Windows.Forms.Button buttonCancelarDescontos;
        private System.Windows.Forms.Button buttonInserirDescontos;
        private System.Windows.Forms.MaskedTextBox maskedPorcentDesconto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAlterarDesconto;
        private System.Windows.Forms.Button buttonDeletarDesconto;
        private System.Windows.Forms.TextBox textBoxTipoDesconto;
        internal System.Windows.Forms.DataGridView dataGridViewDescontos;
        private System.Windows.Forms.TextBox txtIdDesconto;
    }
}