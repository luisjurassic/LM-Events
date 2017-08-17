namespace LM_Events.PresentationLayer
{
    partial class FormReservaStand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservaStand));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textCodigoEvento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textProcurarCliente = new System.Windows.Forms.TextBox();
            this.buttonCancelarReserva = new System.Windows.Forms.Button();
            this.buttonConfirmaReserva = new System.Windows.Forms.Button();
            this.textCodigoCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvStands = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkReserva = new System.Windows.Forms.CheckBox();
            this.dgvExpositor = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStands)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpositor)).BeginInit();
            this.SuspendLayout();
            // 
            // textCodigoEvento
            // 
            this.textCodigoEvento.Enabled = false;
            this.textCodigoEvento.Location = new System.Drawing.Point(6, 518);
            this.textCodigoEvento.Name = "textCodigoEvento";
            this.textCodigoEvento.ReadOnly = true;
            this.textCodigoEvento.Size = new System.Drawing.Size(114, 26);
            this.textCodigoEvento.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Cód. do Evento";
            // 
            // textProcurarCliente
            // 
            this.textProcurarCliente.Location = new System.Drawing.Point(6, 264);
            this.textProcurarCliente.Name = "textProcurarCliente";
            this.textProcurarCliente.Size = new System.Drawing.Size(491, 26);
            this.textProcurarCliente.TabIndex = 44;
            this.textProcurarCliente.TextChanged += new System.EventHandler(this.textProcurarCliente_TextChanged);
            // 
            // buttonCancelarReserva
            // 
            this.buttonCancelarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarReserva.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonCancelarReserva.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelarReserva.Image")));
            this.buttonCancelarReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarReserva.Location = new System.Drawing.Point(752, 550);
            this.buttonCancelarReserva.Name = "buttonCancelarReserva";
            this.buttonCancelarReserva.Size = new System.Drawing.Size(102, 30);
            this.buttonCancelarReserva.TabIndex = 41;
            this.buttonCancelarReserva.Tag = "Voltar para forma de pagamento";
            this.buttonCancelarReserva.Text = "&Sair";
            this.buttonCancelarReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelarReserva.UseVisualStyleBackColor = true;
            this.buttonCancelarReserva.Click += new System.EventHandler(this.buttonCancelarReserva_Click);
            // 
            // buttonConfirmaReserva
            // 
            this.buttonConfirmaReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmaReserva.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonConfirmaReserva.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfirmaReserva.Image")));
            this.buttonConfirmaReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirmaReserva.Location = new System.Drawing.Point(645, 550);
            this.buttonConfirmaReserva.Name = "buttonConfirmaReserva";
            this.buttonConfirmaReserva.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonConfirmaReserva.Size = new System.Drawing.Size(102, 30);
            this.buttonConfirmaReserva.TabIndex = 42;
            this.buttonConfirmaReserva.Tag = "Confirmar pagamento";
            this.buttonConfirmaReserva.Text = "Confirmar";
            this.buttonConfirmaReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConfirmaReserva.UseVisualStyleBackColor = true;
            this.buttonConfirmaReserva.Click += new System.EventHandler(this.buttonConfirmaReserva_Click);
            // 
            // textCodigoCliente
            // 
            this.textCodigoCliente.Enabled = false;
            this.textCodigoCliente.Location = new System.Drawing.Point(126, 518);
            this.textCodigoCliente.Name = "textCodigoCliente";
            this.textCodigoCliente.ReadOnly = true;
            this.textCodigoCliente.Size = new System.Drawing.Size(130, 26);
            this.textCodigoCliente.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Cód. do Expositor";
            // 
            // dgvStands
            // 
            this.dgvStands.AllowUserToAddRows = false;
            this.dgvStands.AllowUserToDeleteRows = false;
            this.dgvStands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStands.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvStands.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStands.Location = new System.Drawing.Point(6, 25);
            this.dgvStands.Name = "dgvStands";
            this.dgvStands.ReadOnly = true;
            this.dgvStands.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvStands.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvStands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStands.Size = new System.Drawing.Size(848, 210);
            this.dgvStands.TabIndex = 23;
            this.dgvStands.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStands_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkReserva);
            this.groupBox4.Controls.Add(this.textCodigoEvento);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textProcurarCliente);
            this.groupBox4.Controls.Add(this.buttonCancelarReserva);
            this.groupBox4.Controls.Add(this.buttonConfirmaReserva);
            this.groupBox4.Controls.Add(this.textCodigoCliente);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.dgvStands);
            this.groupBox4.Controls.Add(this.dgvExpositor);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(860, 586);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reservas";
            // 
            // checkReserva
            // 
            this.checkReserva.AutoSize = true;
            this.checkReserva.Location = new System.Drawing.Point(262, 518);
            this.checkReserva.Name = "checkReserva";
            this.checkReserva.Size = new System.Drawing.Size(134, 24);
            this.checkReserva.TabIndex = 53;
            this.checkReserva.Text = "Reserva Grátis";
            this.checkReserva.UseVisualStyleBackColor = true;
            // 
            // dgvExpositor
            // 
            this.dgvExpositor.AllowUserToAddRows = false;
            this.dgvExpositor.AllowUserToDeleteRows = false;
            this.dgvExpositor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpositor.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvExpositor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpositor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpositor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpositor.Location = new System.Drawing.Point(6, 296);
            this.dgvExpositor.Name = "dgvExpositor";
            this.dgvExpositor.ReadOnly = true;
            this.dgvExpositor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvExpositor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvExpositor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvExpositor.Size = new System.Drawing.Size(848, 196);
            this.dgvExpositor.TabIndex = 25;
            this.dgvExpositor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpositor_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(2, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Procurar Expositor";
            // 
            // FormReservaStand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 610);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReservaStand";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva de Stands";
            this.Load += new System.EventHandler(this.FormReservaStand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStands)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpositor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox textCodigoEvento;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textProcurarCliente;
        public System.Windows.Forms.Button buttonCancelarReserva;
        public System.Windows.Forms.Button buttonConfirmaReserva;
        public System.Windows.Forms.TextBox textCodigoCliente;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dgvStands;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dgvExpositor;
        private System.Windows.Forms.CheckBox checkReserva;
    }
}