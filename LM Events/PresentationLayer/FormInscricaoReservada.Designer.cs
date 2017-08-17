namespace LM_Events.PresentationLayer
{
    partial class FormInscricaoReservada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscricaoReservada));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListaInscricao = new System.Windows.Forms.DataGridView();
            this.btnSairLista = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaInscricao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListaInscricao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 603);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Inscritos";
            // 
            // dgvListaInscricao
            // 
            this.dgvListaInscricao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaInscricao.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListaInscricao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaInscricao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaInscricao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaInscricao.Location = new System.Drawing.Point(6, 25);
            this.dgvListaInscricao.Name = "dgvListaInscricao";
            this.dgvListaInscricao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvListaInscricao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvListaInscricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaInscricao.Size = new System.Drawing.Size(848, 572);
            this.dgvListaInscricao.TabIndex = 44;
            // 
            // btnSairLista
            // 
            this.btnSairLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSairLista.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSairLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairLista.Image = ((System.Drawing.Image)(resources.GetObject("btnSairLista.Image")));
            this.btnSairLista.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairLista.Location = new System.Drawing.Point(767, 619);
            this.btnSairLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSairLista.Name = "btnSairLista";
            this.btnSairLista.Size = new System.Drawing.Size(105, 30);
            this.btnSairLista.TabIndex = 47;
            this.btnSairLista.Text = "&Sair";
            this.btnSairLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSairLista.UseVisualStyleBackColor = true;
            this.btnSairLista.Click += new System.EventHandler(this.btnSairLista_Click);
            // 
            // FormInscricaoReservada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSairLista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInscricaoReservada";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Inscritos";
            this.Load += new System.EventHandler(this.FormInscricaoReservada_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaInscricao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView dgvListaInscricao;
        private System.Windows.Forms.Button btnSairLista;
    }
}