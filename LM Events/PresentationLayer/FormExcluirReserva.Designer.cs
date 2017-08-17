namespace LM_Events.PresentationLayer
{
    partial class FormExcluirReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExcluirReserva));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonExcluirReserva = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textCodigoInscricao = new System.Windows.Forms.TextBox();
            this.dgvExcluirReserva = new System.Windows.Forms.DataGridView();
            this.buttonSairReserva = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcluirReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExcluirReserva
            // 
            this.buttonExcluirReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExcluirReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirReserva.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirReserva.Image")));
            this.buttonExcluirReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirReserva.Location = new System.Drawing.Point(666, 619);
            this.buttonExcluirReserva.Name = "buttonExcluirReserva";
            this.buttonExcluirReserva.Size = new System.Drawing.Size(100, 30);
            this.buttonExcluirReserva.TabIndex = 41;
            this.buttonExcluirReserva.Text = "&Cancelar";
            this.buttonExcluirReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExcluirReserva.UseVisualStyleBackColor = true;
            this.buttonExcluirReserva.Click += new System.EventHandler(this.buttonExcluirReserva_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvExcluirReserva);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 605);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Reservas";
            // 
            // textCodigoInscricao
            // 
            this.textCodigoInscricao.Enabled = false;
            this.textCodigoInscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigoInscricao.Location = new System.Drawing.Point(115, 623);
            this.textCodigoInscricao.Name = "textCodigoInscricao";
            this.textCodigoInscricao.ReadOnly = true;
            this.textCodigoInscricao.Size = new System.Drawing.Size(56, 26);
            this.textCodigoInscricao.TabIndex = 50;
            this.textCodigoInscricao.Visible = false;
            // 
            // dgvExcluirReserva
            // 
            this.dgvExcluirReserva.AllowUserToAddRows = false;
            this.dgvExcluirReserva.AllowUserToDeleteRows = false;
            this.dgvExcluirReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExcluirReserva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvExcluirReserva.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvExcluirReserva.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcluirReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExcluirReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcluirReserva.Location = new System.Drawing.Point(6, 25);
            this.dgvExcluirReserva.Name = "dgvExcluirReserva";
            this.dgvExcluirReserva.ReadOnly = true;
            this.dgvExcluirReserva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvExcluirReserva.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvExcluirReserva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvExcluirReserva.Size = new System.Drawing.Size(848, 574);
            this.dgvExcluirReserva.TabIndex = 34;
            this.dgvExcluirReserva.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExcluirReserva_CellClick);
            // 
            // buttonSairReserva
            // 
            this.buttonSairReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSairReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSairReserva.Image = ((System.Drawing.Image)(resources.GetObject("buttonSairReserva.Image")));
            this.buttonSairReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSairReserva.Location = new System.Drawing.Point(772, 619);
            this.buttonSairReserva.Name = "buttonSairReserva";
            this.buttonSairReserva.Size = new System.Drawing.Size(100, 30);
            this.buttonSairReserva.TabIndex = 40;
            this.buttonSairReserva.Text = "&Sair";
            this.buttonSairReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSairReserva.UseVisualStyleBackColor = true;
            this.buttonSairReserva.Click += new System.EventHandler(this.buttonSairReserva_Click);
            // 
            // FormExcluirReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.buttonExcluirReserva);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textCodigoInscricao);
            this.Controls.Add(this.buttonSairReserva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExcluirReserva";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelamento de Reservas";
            this.Load += new System.EventHandler(this.FormExcluirReserva_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcluirReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExcluirReserva;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox textCodigoInscricao;
        internal System.Windows.Forms.DataGridView dgvExcluirReserva;
        private System.Windows.Forms.Button buttonSairReserva;
    }
}