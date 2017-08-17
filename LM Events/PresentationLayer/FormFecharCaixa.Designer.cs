namespace LM_Events.PresentationLayer
{
    partial class FormFecharCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFecharCaixa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonSairCaixa = new System.Windows.Forms.Button();
            this.buttonFinalizarCaixa = new System.Windows.Forms.Button();
            this.groupBoxDescontos = new System.Windows.Forms.GroupBox();
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.groupBoxDescontos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSairCaixa
            // 
            this.buttonSairCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSairCaixa.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonSairCaixa.Image = ((System.Drawing.Image)(resources.GetObject("buttonSairCaixa.Image")));
            this.buttonSairCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSairCaixa.Location = new System.Drawing.Point(322, 159);
            this.buttonSairCaixa.Name = "buttonSairCaixa";
            this.buttonSairCaixa.Size = new System.Drawing.Size(100, 30);
            this.buttonSairCaixa.TabIndex = 9;
            this.buttonSairCaixa.Tag = "Voltar para forma de pagamento";
            this.buttonSairCaixa.Text = "&Sair";
            this.buttonSairCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSairCaixa.UseVisualStyleBackColor = true;
            this.buttonSairCaixa.Click += new System.EventHandler(this.buttonSairCaixa_Click);
            // 
            // buttonFinalizarCaixa
            // 
            this.buttonFinalizarCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizarCaixa.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonFinalizarCaixa.Image = ((System.Drawing.Image)(resources.GetObject("buttonFinalizarCaixa.Image")));
            this.buttonFinalizarCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFinalizarCaixa.Location = new System.Drawing.Point(216, 159);
            this.buttonFinalizarCaixa.Name = "buttonFinalizarCaixa";
            this.buttonFinalizarCaixa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonFinalizarCaixa.Size = new System.Drawing.Size(100, 30);
            this.buttonFinalizarCaixa.TabIndex = 8;
            this.buttonFinalizarCaixa.Tag = "Inserir novo tipo de desconto";
            this.buttonFinalizarCaixa.Text = "&Finalizar";
            this.buttonFinalizarCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFinalizarCaixa.UseVisualStyleBackColor = true;
            this.buttonFinalizarCaixa.Click += new System.EventHandler(this.buttonFinalizarCaixa_Click);
            // 
            // groupBoxDescontos
            // 
            this.groupBoxDescontos.Controls.Add(this.dgvCaixa);
            this.groupBoxDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDescontos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDescontos.Name = "groupBoxDescontos";
            this.groupBoxDescontos.Size = new System.Drawing.Size(410, 141);
            this.groupBoxDescontos.TabIndex = 7;
            this.groupBoxDescontos.TabStop = false;
            this.groupBoxDescontos.Text = "Total em Caixa";
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.AllowUserToAddRows = false;
            this.dgvCaixa.AllowUserToDeleteRows = false;
            this.dgvCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaixa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCaixa.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCaixa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Location = new System.Drawing.Point(6, 25);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.ReadOnly = true;
            this.dgvCaixa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCaixa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCaixa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCaixa.Size = new System.Drawing.Size(398, 110);
            this.dgvCaixa.TabIndex = 7;
            // 
            // FormFecharCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(434, 200);
            this.Controls.Add(this.buttonSairCaixa);
            this.Controls.Add(this.buttonFinalizarCaixa);
            this.Controls.Add(this.groupBoxDescontos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFecharCaixa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechamento de Caixa";
            this.Load += new System.EventHandler(this.FormFecharCaixa_Load);
            this.groupBoxDescontos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSairCaixa;
        private System.Windows.Forms.Button buttonFinalizarCaixa;
        private System.Windows.Forms.GroupBox groupBoxDescontos;
        internal System.Windows.Forms.DataGridView dgvCaixa;
    }
}