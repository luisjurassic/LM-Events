namespace LM_Events.PresentationLayer
{
    partial class FormNovoStand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovoStand));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBuscaEventos = new System.Windows.Forms.Button();
            this.textStandEvento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTamanho = new LM_Events.GUI.TextBoxLM();
            this.txtValorStand = new LM_Events.GUI.TextBoxLM();
            this.label3 = new System.Windows.Forms.Label();
            this.textNomeStand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonInserirStand = new System.Windows.Forms.Button();
            this.textIdEvento = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBuscaEventos);
            this.groupBox1.Controls.Add(this.textStandEvento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericQuantidade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textTamanho);
            this.groupBox1.Controls.Add(this.txtValorStand);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textNomeStand);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 185);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Stands";
            // 
            // buttonBuscaEventos
            // 
            this.buttonBuscaEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscaEventos.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscaEventos.Image")));
            this.buttonBuscaEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscaEventos.Location = new System.Drawing.Point(356, 99);
            this.buttonBuscaEventos.Name = "buttonBuscaEventos";
            this.buttonBuscaEventos.Size = new System.Drawing.Size(96, 30);
            this.buttonBuscaEventos.TabIndex = 3;
            this.buttonBuscaEventos.Tag = "Procurar usuários";
            this.buttonBuscaEventos.Text = "Procurar";
            this.buttonBuscaEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscaEventos.UseVisualStyleBackColor = true;
            this.buttonBuscaEventos.Click += new System.EventHandler(this.buttonBuscaEventos_Click);
            // 
            // textStandEvento
            // 
            this.textStandEvento.Location = new System.Drawing.Point(6, 101);
            this.textStandEvento.Name = "textStandEvento";
            this.textStandEvento.Size = new System.Drawing.Size(344, 26);
            this.textStandEvento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Evento";
            // 
            // numericQuantidade
            // 
            this.numericQuantidade.Location = new System.Drawing.Point(6, 153);
            this.numericQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantidade.Name = "numericQuantidade";
            this.numericQuantidade.Size = new System.Drawing.Size(88, 26);
            this.numericQuantidade.TabIndex = 4;
            this.numericQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tamanho(m²)";
            // 
            // textTamanho
            // 
            this.textTamanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textTamanho.Location = new System.Drawing.Point(100, 153);
            this.textTamanho.Name = "textTamanho";
            this.textTamanho.Placeholder = "";
            this.textTamanho.Size = new System.Drawing.Size(108, 26);
            this.textTamanho.TabIndex = 5;
            // 
            // txtValorStand
            // 
            this.txtValorStand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtValorStand.Location = new System.Drawing.Point(214, 153);
            this.txtValorStand.Name = "txtValorStand";
            this.txtValorStand.Placeholder = "";
            this.txtValorStand.Size = new System.Drawing.Size(94, 26);
            this.txtValorStand.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor($)";
            // 
            // textNomeStand
            // 
            this.textNomeStand.Location = new System.Drawing.Point(6, 53);
            this.textNomeStand.Name = "textNomeStand";
            this.textNomeStand.Size = new System.Drawing.Size(446, 26);
            this.textNomeStand.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nome";
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonFechar.Image = ((System.Drawing.Image)(resources.GetObject("buttonFechar.Image")));
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFechar.Location = new System.Drawing.Point(385, 203);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 30);
            this.buttonFechar.TabIndex = 8;
            this.buttonFechar.Tag = "Voltar para forma de pagamento";
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonInserirStand
            // 
            this.buttonInserirStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserirStand.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonInserirStand.Image = ((System.Drawing.Image)(resources.GetObject("buttonInserirStand.Image")));
            this.buttonInserirStand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInserirStand.Location = new System.Drawing.Point(301, 203);
            this.buttonInserirStand.Name = "buttonInserirStand";
            this.buttonInserirStand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonInserirStand.Size = new System.Drawing.Size(78, 30);
            this.buttonInserirStand.TabIndex = 7;
            this.buttonInserirStand.Tag = "Inserir novo tipo de desconto";
            this.buttonInserirStand.Text = "&Inserir";
            this.buttonInserirStand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInserirStand.UseVisualStyleBackColor = true;
            this.buttonInserirStand.Click += new System.EventHandler(this.buttonInserirStand_Click);
            // 
            // textIdEvento
            // 
            this.textIdEvento.Enabled = false;
            this.textIdEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdEvento.Location = new System.Drawing.Point(18, 207);
            this.textIdEvento.Name = "textIdEvento";
            this.textIdEvento.Size = new System.Drawing.Size(45, 26);
            this.textIdEvento.TabIndex = 22;
            this.textIdEvento.Visible = false;
            // 
            // FormNovoStand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(482, 245);
            this.Controls.Add(this.textIdEvento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonInserirStand);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNovoStand";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Stands";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private GUI.TextBoxLM textTamanho;
        private GUI.TextBoxLM txtValorStand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNomeStand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonInserirStand;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonBuscaEventos;
        public System.Windows.Forms.TextBox textStandEvento;
        public System.Windows.Forms.TextBox textIdEvento;
    }
}