namespace LM_Events.PresentationLayer
{
    partial class FormStandReservado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStandReservado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSairListaEventos = new System.Windows.Forms.Button();
            this.dgvListaReserva = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReserva)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSairListaEventos
            // 
            this.btnSairListaEventos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSairListaEventos.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSairListaEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairListaEventos.Image = ((System.Drawing.Image)(resources.GetObject("btnSairListaEventos.Image")));
            this.btnSairListaEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairListaEventos.Location = new System.Drawing.Point(767, 620);
            this.btnSairListaEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSairListaEventos.Name = "btnSairListaEventos";
            this.btnSairListaEventos.Size = new System.Drawing.Size(105, 30);
            this.btnSairListaEventos.TabIndex = 45;
            this.btnSairListaEventos.Text = "&Sair";
            this.btnSairListaEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSairListaEventos.UseVisualStyleBackColor = true;
            this.btnSairListaEventos.Click += new System.EventHandler(this.btnSairListaEventos_Click);
            // 
            // dgvListaReserva
            // 
            this.dgvListaReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaReserva.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListaReserva.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaReserva.Location = new System.Drawing.Point(6, 25);
            this.dgvListaReserva.Name = "dgvListaReserva";
            this.dgvListaReserva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvListaReserva.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvListaReserva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaReserva.Size = new System.Drawing.Size(848, 572);
            this.dgvListaReserva.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListaReserva);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 603);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Reserva de Stands";
            // 
            // FormStandReservado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSairListaEventos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStandReservado";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stands Reservados";
            this.Load += new System.EventHandler(this.FormStandReservado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReserva)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSairListaEventos;
        internal System.Windows.Forms.DataGridView dgvListaReserva;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}