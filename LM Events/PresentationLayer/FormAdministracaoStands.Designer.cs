namespace LM_Events.PresentationLayer
{
    partial class FormAdministracaoStands
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministracaoStands));
            this.groupBoxStands = new System.Windows.Forms.GroupBox();
            this.textValorStand = new System.Windows.Forms.TextBox();
            this.textTamanhoStand = new System.Windows.Forms.TextBox();
            this.dgvStand = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textNomeStand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDeleteStands = new System.Windows.Forms.Button();
            this.buttonAlterarStand = new System.Windows.Forms.Button();
            this.buttonFecharStand = new System.Windows.Forms.Button();
            this.buttonZerar = new System.Windows.Forms.Button();
            this.textid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxStands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStand)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStands
            // 
            this.groupBoxStands.Controls.Add(this.textValorStand);
            this.groupBoxStands.Controls.Add(this.textTamanhoStand);
            this.groupBoxStands.Controls.Add(this.dgvStand);
            this.groupBoxStands.Controls.Add(this.label4);
            this.groupBoxStands.Controls.Add(this.label6);
            this.groupBoxStands.Controls.Add(this.textNomeStand);
            this.groupBoxStands.Controls.Add(this.label3);
            this.groupBoxStands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStands.Location = new System.Drawing.Point(12, 11);
            this.groupBoxStands.Name = "groupBoxStands";
            this.groupBoxStands.Size = new System.Drawing.Size(674, 443);
            this.groupBoxStands.TabIndex = 7;
            this.groupBoxStands.TabStop = false;
            this.groupBoxStands.Text = "Tabela Stands";
            // 
            // textValorStand
            // 
            this.textValorStand.Location = new System.Drawing.Point(573, 411);
            this.textValorStand.Name = "textValorStand";
            this.textValorStand.ReadOnly = true;
            this.textValorStand.Size = new System.Drawing.Size(95, 26);
            this.textValorStand.TabIndex = 11;
            // 
            // textTamanhoStand
            // 
            this.textTamanhoStand.Location = new System.Drawing.Point(460, 411);
            this.textTamanhoStand.Name = "textTamanhoStand";
            this.textTamanhoStand.ReadOnly = true;
            this.textTamanhoStand.Size = new System.Drawing.Size(107, 26);
            this.textTamanhoStand.TabIndex = 10;
            // 
            // dgvStand
            // 
            this.dgvStand.AllowUserToAddRows = false;
            this.dgvStand.AllowUserToDeleteRows = false;
            this.dgvStand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStand.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvStand.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStand.Location = new System.Drawing.Point(6, 25);
            this.dgvStand.Name = "dgvStand";
            this.dgvStand.ReadOnly = true;
            this.dgvStand.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvStand.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvStand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStand.Size = new System.Drawing.Size(662, 360);
            this.dgvStand.TabIndex = 7;
            this.dgvStand.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStand_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tamanho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nome";
            // 
            // textNomeStand
            // 
            this.textNomeStand.Location = new System.Drawing.Point(6, 411);
            this.textNomeStand.Name = "textNomeStand";
            this.textNomeStand.ReadOnly = true;
            this.textNomeStand.Size = new System.Drawing.Size(448, 26);
            this.textNomeStand.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor ";
            // 
            // buttonDeleteStands
            // 
            this.buttonDeleteStands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteStands.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonDeleteStands.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteStands.Image")));
            this.buttonDeleteStands.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteStands.Location = new System.Drawing.Point(374, 460);
            this.buttonDeleteStands.Name = "buttonDeleteStands";
            this.buttonDeleteStands.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDeleteStands.Size = new System.Drawing.Size(100, 30);
            this.buttonDeleteStands.TabIndex = 10;
            this.buttonDeleteStands.Tag = "Deletar tipo de desconto";
            this.buttonDeleteStands.Text = "&Excluir";
            this.buttonDeleteStands.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteStands.UseVisualStyleBackColor = true;
            this.buttonDeleteStands.Click += new System.EventHandler(this.buttonDeleteStands_Click);
            // 
            // buttonAlterarStand
            // 
            this.buttonAlterarStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarStand.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonAlterarStand.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlterarStand.Image")));
            this.buttonAlterarStand.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAlterarStand.Location = new System.Drawing.Point(268, 460);
            this.buttonAlterarStand.Name = "buttonAlterarStand";
            this.buttonAlterarStand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAlterarStand.Size = new System.Drawing.Size(100, 30);
            this.buttonAlterarStand.TabIndex = 9;
            this.buttonAlterarStand.Tag = "Alterar desconto";
            this.buttonAlterarStand.Text = "&Alterar";
            this.buttonAlterarStand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAlterarStand.UseVisualStyleBackColor = true;
            this.buttonAlterarStand.Click += new System.EventHandler(this.buttonAlterarStand_Click);
            // 
            // buttonFecharStand
            // 
            this.buttonFecharStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFecharStand.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonFecharStand.Image = ((System.Drawing.Image)(resources.GetObject("buttonFecharStand.Image")));
            this.buttonFecharStand.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFecharStand.Location = new System.Drawing.Point(586, 460);
            this.buttonFecharStand.Name = "buttonFecharStand";
            this.buttonFecharStand.Size = new System.Drawing.Size(100, 30);
            this.buttonFecharStand.TabIndex = 11;
            this.buttonFecharStand.Tag = "Voltar para forma de pagamento";
            this.buttonFecharStand.Text = "&Sair";
            this.buttonFecharStand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFecharStand.UseVisualStyleBackColor = true;
            this.buttonFecharStand.Click += new System.EventHandler(this.buttonFecharStand_Click);
            // 
            // buttonZerar
            // 
            this.buttonZerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZerar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonZerar.Image = ((System.Drawing.Image)(resources.GetObject("buttonZerar.Image")));
            this.buttonZerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonZerar.Location = new System.Drawing.Point(480, 460);
            this.buttonZerar.Name = "buttonZerar";
            this.buttonZerar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonZerar.Size = new System.Drawing.Size(100, 30);
            this.buttonZerar.TabIndex = 8;
            this.buttonZerar.Tag = "Inserir novo tipo de desconto";
            this.buttonZerar.Text = "&Zerar";
            this.buttonZerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonZerar.UseVisualStyleBackColor = true;
            this.buttonZerar.Click += new System.EventHandler(this.buttonZerar_Click);
            // 
            // textid
            // 
            this.textid.Enabled = false;
            this.textid.Location = new System.Drawing.Point(45, 462);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(95, 20);
            this.textid.TabIndex = 13;
            this.textid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(24, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "id";
            this.label1.Visible = false;
            // 
            // FormAdministracaoStands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(698, 502);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxStands);
            this.Controls.Add(this.buttonDeleteStands);
            this.Controls.Add(this.buttonAlterarStand);
            this.Controls.Add(this.buttonFecharStand);
            this.Controls.Add(this.buttonZerar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdministracaoStands";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administração de Stands";
            this.Load += new System.EventHandler(this.FormStands_Load);
            this.groupBoxStands.ResumeLayout(false);
            this.groupBoxStands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStands;
        internal System.Windows.Forms.DataGridView dgvStand;
        private System.Windows.Forms.Button buttonDeleteStands;
        private System.Windows.Forms.Button buttonAlterarStand;
        private System.Windows.Forms.Button buttonFecharStand;
        private System.Windows.Forms.Button buttonZerar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNomeStand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textValorStand;
        private System.Windows.Forms.TextBox textTamanhoStand;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label1;
    }
}