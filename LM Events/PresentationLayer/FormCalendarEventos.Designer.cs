namespace LM_Events.PresentationLayer
{
    partial class FormCalendarEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendarEventos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calendarioEventos = new System.Windows.Forms.MonthCalendar();
            this.btnDataInicio = new System.Windows.Forms.Button();
            this.radioButtonMes = new System.Windows.Forms.RadioButton();
            this.radioButtonDia = new System.Windows.Forms.RadioButton();
            this.dgvListaEvento = new System.Windows.Forms.DataGridView();
            this.btnSairListaEventos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calendarioEventos);
            this.groupBox1.Controls.Add(this.btnDataInicio);
            this.groupBox1.Controls.Add(this.radioButtonMes);
            this.groupBox1.Controls.Add(this.radioButtonDia);
            this.groupBox1.Controls.Add(this.dgvListaEvento);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 671);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // calendarioEventos
            // 
            this.calendarioEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarioEventos.Location = new System.Drawing.Point(505, 36);
            this.calendarioEventos.Name = "calendarioEventos";
            this.calendarioEventos.TabIndex = 16;
            this.calendarioEventos.Visible = false;
            this.calendarioEventos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.calendarioEventos_MouseDown);
            this.calendarioEventos.MouseLeave += new System.EventHandler(this.calendarioEventos_MouseLeave);
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
            this.btnDataInicio.Location = new System.Drawing.Point(330, 22);
            this.btnDataInicio.Name = "btnDataInicio";
            this.btnDataInicio.Size = new System.Drawing.Size(194, 30);
            this.btnDataInicio.TabIndex = 6;
            this.btnDataInicio.Text = "Calendário de Eventos";
            this.btnDataInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataInicio.UseVisualStyleBackColor = false;
            this.btnDataInicio.Click += new System.EventHandler(this.btnDataInicio_Click);
            // 
            // radioButtonMes
            // 
            this.radioButtonMes.AutoSize = true;
            this.radioButtonMes.Location = new System.Drawing.Point(173, 25);
            this.radioButtonMes.Name = "radioButtonMes";
            this.radioButtonMes.Size = new System.Drawing.Size(151, 24);
            this.radioButtonMes.TabIndex = 17;
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
            this.radioButtonDia.TabIndex = 16;
            this.radioButtonDia.TabStop = true;
            this.radioButtonDia.Text = "Procura Por Dia";
            this.radioButtonDia.UseVisualStyleBackColor = true;
            this.radioButtonDia.CheckedChanged += new System.EventHandler(this.radioButtonDia_CheckedChanged);
            // 
            // dgvListaEvento
            // 
            this.dgvListaEvento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaEvento.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListaEvento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaEvento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEvento.Location = new System.Drawing.Point(6, 55);
            this.dgvListaEvento.Name = "dgvListaEvento";
            this.dgvListaEvento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvListaEvento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvListaEvento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaEvento.Size = new System.Drawing.Size(972, 610);
            this.dgvListaEvento.TabIndex = 15;
            // 
            // btnSairListaEventos
            // 
            this.btnSairListaEventos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSairListaEventos.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSairListaEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairListaEventos.Image = ((System.Drawing.Image)(resources.GetObject("btnSairListaEventos.Image")));
            this.btnSairListaEventos.Location = new System.Drawing.Point(891, 688);
            this.btnSairListaEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSairListaEventos.Name = "btnSairListaEventos";
            this.btnSairListaEventos.Size = new System.Drawing.Size(105, 30);
            this.btnSairListaEventos.TabIndex = 43;
            this.btnSairListaEventos.Text = "&Sair";
            this.btnSairListaEventos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairListaEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSairListaEventos.UseVisualStyleBackColor = true;
            this.btnSairListaEventos.Click += new System.EventHandler(this.btnSairListaEventos_Click);
            // 
            // FormCalendarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnSairListaEventos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalendarEventos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Eventos";
            this.Load += new System.EventHandler(this.FormCalendarEventos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEvento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView dgvListaEvento;
        private System.Windows.Forms.Button btnDataInicio;
        private System.Windows.Forms.MonthCalendar calendarioEventos;
        private System.Windows.Forms.Button btnSairListaEventos;
        private System.Windows.Forms.RadioButton radioButtonMes;
        private System.Windows.Forms.RadioButton radioButtonDia;
    }
}