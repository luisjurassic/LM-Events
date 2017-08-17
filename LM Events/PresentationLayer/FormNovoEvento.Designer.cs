namespace LM_Events.PresentationLayer
{
    partial class FormNovoEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovoEvento));
            this.comboBoxTipoEvento = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorInscricao = new LM_Events.GUI.TextBoxLM();
            this.btnDataFim = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateEventoFim = new System.Windows.Forms.MaskedTextBox();
            this.dateEventoInicio = new System.Windows.Forms.MaskedTextBox();
            this.btnDataInicio = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedHoraFimEvento = new System.Windows.Forms.MaskedTextBox();
            this.maskedHoraInicioEvento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomeEvento = new LM_Events.GUI.TextBoxLM();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboCadastroUFEvento = new System.Windows.Forms.ComboBox();
            this.comboCadastroCidadeEvento = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textCadastroComplementoEvento = new System.Windows.Forms.TextBox();
            this.textCadastroNumeroEvento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textCadastroBairroEvento = new System.Windows.Forms.TextBox();
            this.textCadastroRuaEvento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedCEPEvento = new System.Windows.Forms.MaskedTextBox();
            this.buttonSalvarEvento = new System.Windows.Forms.Button();
            this.buttonCancelarEvento = new System.Windows.Forms.Button();
            this.mCFim = new System.Windows.Forms.MonthCalendar();
            this.mCInicio = new System.Windows.Forms.MonthCalendar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTipoEvento
            // 
            this.comboBoxTipoEvento.FormattingEnabled = true;
            this.comboBoxTipoEvento.Location = new System.Drawing.Point(10, 45);
            this.comboBoxTipoEvento.Name = "comboBoxTipoEvento";
            this.comboBoxTipoEvento.Size = new System.Drawing.Size(192, 28);
            this.comboBoxTipoEvento.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValorInscricao);
            this.groupBox1.Controls.Add(this.btnDataFim);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateEventoFim);
            this.groupBox1.Controls.Add(this.dateEventoInicio);
            this.groupBox1.Controls.Add(this.btnDataInicio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.maskedHoraFimEvento);
            this.groupBox1.Controls.Add(this.maskedHoraInicioEvento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNomeEvento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxTipoEvento);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Eventos";
            // 
            // txtValorInscricao
            // 
            this.txtValorInscricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtValorInscricao.Location = new System.Drawing.Point(467, 99);
            this.txtValorInscricao.Name = "txtValorInscricao";
            this.txtValorInscricao.Placeholder = "";
            this.txtValorInscricao.Size = new System.Drawing.Size(132, 26);
            this.txtValorInscricao.TabIndex = 3;
            // 
            // btnDataFim
            // 
            this.btnDataFim.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.btnDataFim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDataFim.Image = ((System.Drawing.Image)(resources.GetObject("btnDataFim.Image")));
            this.btnDataFim.Location = new System.Drawing.Point(281, 151);
            this.btnDataFim.Name = "btnDataFim";
            this.btnDataFim.Size = new System.Drawing.Size(26, 26);
            this.btnDataFim.TabIndex = 7;
            this.btnDataFim.UseVisualStyleBackColor = true;
            this.btnDataFim.Click += new System.EventHandler(this.btnDataFim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor da Inscrição";
            // 
            // dateEventoFim
            // 
            this.dateEventoFim.Location = new System.Drawing.Point(166, 151);
            this.dateEventoFim.Mask = "00/00/0000";
            this.dateEventoFim.Name = "dateEventoFim";
            this.dateEventoFim.Size = new System.Drawing.Size(109, 26);
            this.dateEventoFim.TabIndex = 6;
            this.dateEventoFim.ValidatingType = typeof(System.DateTime);
            // 
            // dateEventoInicio
            // 
            this.dateEventoInicio.Location = new System.Drawing.Point(10, 151);
            this.dateEventoInicio.Mask = "00/00/0000";
            this.dateEventoInicio.Name = "dateEventoInicio";
            this.dateEventoInicio.Size = new System.Drawing.Size(109, 26);
            this.dateEventoInicio.TabIndex = 4;
            this.dateEventoInicio.ValidatingType = typeof(System.DateTime);
            // 
            // btnDataInicio
            // 
            this.btnDataInicio.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.btnDataInicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDataInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDataInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnDataInicio.Image")));
            this.btnDataInicio.Location = new System.Drawing.Point(125, 151);
            this.btnDataInicio.Name = "btnDataInicio";
            this.btnDataInicio.Size = new System.Drawing.Size(26, 26);
            this.btnDataInicio.TabIndex = 5;
            this.btnDataInicio.UseVisualStyleBackColor = true;
            this.btnDataInicio.Click += new System.EventHandler(this.btnDataInicio_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data Fim";
            // 
            // maskedHoraFimEvento
            // 
            this.maskedHoraFimEvento.Location = new System.Drawing.Point(499, 151);
            this.maskedHoraFimEvento.Mask = "90:00";
            this.maskedHoraFimEvento.Name = "maskedHoraFimEvento";
            this.maskedHoraFimEvento.Size = new System.Drawing.Size(100, 26);
            this.maskedHoraFimEvento.TabIndex = 9;
            this.maskedHoraFimEvento.ValidatingType = typeof(System.DateTime);
            // 
            // maskedHoraInicioEvento
            // 
            this.maskedHoraInicioEvento.Location = new System.Drawing.Point(358, 151);
            this.maskedHoraInicioEvento.Mask = "90:00";
            this.maskedHoraInicioEvento.Name = "maskedHoraInicioEvento";
            this.maskedHoraInicioEvento.Size = new System.Drawing.Size(103, 26);
            this.maskedHoraInicioEvento.TabIndex = 8;
            this.maskedHoraInicioEvento.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hora Termino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hora de Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Inicio";
            // 
            // textBoxNomeEvento
            // 
            this.textBoxNomeEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxNomeEvento.Location = new System.Drawing.Point(10, 99);
            this.textBoxNomeEvento.Name = "textBoxNomeEvento";
            this.textBoxNomeEvento.Placeholder = "";
            this.textBoxNomeEvento.Size = new System.Drawing.Size(451, 26);
            this.textBoxNomeEvento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Evento";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.comboCadastroUFEvento);
            this.groupBox2.Controls.Add(this.comboCadastroCidadeEvento);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textCadastroComplementoEvento);
            this.groupBox2.Controls.Add(this.textCadastroNumeroEvento);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textCadastroBairroEvento);
            this.groupBox2.Controls.Add(this.textCadastroRuaEvento);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.maskedCEPEvento);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(609, 186);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local do Evento";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(534, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "U.F.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(293, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "Cidade";
            // 
            // comboCadastroUFEvento
            // 
            this.comboCadastroUFEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCadastroUFEvento.FormattingEnabled = true;
            this.comboCadastroUFEvento.Location = new System.Drawing.Point(538, 93);
            this.comboCadastroUFEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCadastroUFEvento.Name = "comboCadastroUFEvento";
            this.comboCadastroUFEvento.Size = new System.Drawing.Size(61, 28);
            this.comboCadastroUFEvento.TabIndex = 15;
            // 
            // comboCadastroCidadeEvento
            // 
            this.comboCadastroCidadeEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCadastroCidadeEvento.FormattingEnabled = true;
            this.comboCadastroCidadeEvento.Location = new System.Drawing.Point(297, 93);
            this.comboCadastroCidadeEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCadastroCidadeEvento.Name = "comboCadastroCidadeEvento";
            this.comboCadastroCidadeEvento.Size = new System.Drawing.Size(231, 28);
            this.comboCadastroCidadeEvento.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Complemento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(534, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "Número";
            // 
            // textCadastroComplementoEvento
            // 
            this.textCadastroComplementoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCadastroComplementoEvento.Location = new System.Drawing.Point(10, 143);
            this.textCadastroComplementoEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCadastroComplementoEvento.Name = "textCadastroComplementoEvento";
            this.textCadastroComplementoEvento.Size = new System.Drawing.Size(589, 26);
            this.textCadastroComplementoEvento.TabIndex = 16;
            // 
            // textCadastroNumeroEvento
            // 
            this.textCadastroNumeroEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCadastroNumeroEvento.Location = new System.Drawing.Point(538, 43);
            this.textCadastroNumeroEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCadastroNumeroEvento.Name = "textCadastroNumeroEvento";
            this.textCadastroNumeroEvento.Size = new System.Drawing.Size(61, 26);
            this.textCadastroNumeroEvento.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Bairro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Rua";
            // 
            // textCadastroBairroEvento
            // 
            this.textCadastroBairroEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCadastroBairroEvento.Location = new System.Drawing.Point(10, 93);
            this.textCadastroBairroEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCadastroBairroEvento.Name = "textCadastroBairroEvento";
            this.textCadastroBairroEvento.Size = new System.Drawing.Size(281, 26);
            this.textCadastroBairroEvento.TabIndex = 13;
            // 
            // textCadastroRuaEvento
            // 
            this.textCadastroRuaEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCadastroRuaEvento.Location = new System.Drawing.Point(107, 43);
            this.textCadastroRuaEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCadastroRuaEvento.Name = "textCadastroRuaEvento";
            this.textCadastroRuaEvento.Size = new System.Drawing.Size(421, 26);
            this.textCadastroRuaEvento.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "C.E.P.";
            // 
            // maskedCEPEvento
            // 
            this.maskedCEPEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedCEPEvento.Location = new System.Drawing.Point(10, 43);
            this.maskedCEPEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedCEPEvento.Mask = "00000-000";
            this.maskedCEPEvento.Name = "maskedCEPEvento";
            this.maskedCEPEvento.Size = new System.Drawing.Size(91, 26);
            this.maskedCEPEvento.TabIndex = 10;
            this.maskedCEPEvento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // buttonSalvarEvento
            // 
            this.buttonSalvarEvento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSalvarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarEvento.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvarEvento.Image")));
            this.buttonSalvarEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvarEvento.Location = new System.Drawing.Point(405, 398);
            this.buttonSalvarEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvarEvento.Name = "buttonSalvarEvento";
            this.buttonSalvarEvento.Size = new System.Drawing.Size(105, 30);
            this.buttonSalvarEvento.TabIndex = 17;
            this.buttonSalvarEvento.Text = "&Cadastrar";
            this.buttonSalvarEvento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSalvarEvento.UseVisualStyleBackColor = true;
            this.buttonSalvarEvento.Click += new System.EventHandler(this.buttonSalvarEvento_Click);
            // 
            // buttonCancelarEvento
            // 
            this.buttonCancelarEvento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancelarEvento.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarEvento.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelarEvento.Image")));
            this.buttonCancelarEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarEvento.Location = new System.Drawing.Point(516, 398);
            this.buttonCancelarEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelarEvento.Name = "buttonCancelarEvento";
            this.buttonCancelarEvento.Size = new System.Drawing.Size(105, 30);
            this.buttonCancelarEvento.TabIndex = 18;
            this.buttonCancelarEvento.Text = "&Sair";
            this.buttonCancelarEvento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelarEvento.UseVisualStyleBackColor = true;
            this.buttonCancelarEvento.Click += new System.EventHandler(this.buttonCancelarEvento_Click);
            // 
            // mCFim
            // 
            this.mCFim.BackColor = System.Drawing.SystemColors.Control;
            this.mCFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCFim.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mCFim.Location = new System.Drawing.Point(293, 175);
            this.mCFim.Name = "mCFim";
            this.mCFim.ShowToday = false;
            this.mCFim.TabIndex = 17;
            this.mCFim.TitleBackColor = System.Drawing.SystemColors.Highlight;
            this.mCFim.TrailingForeColor = System.Drawing.SystemColors.InfoText;
            this.mCFim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mCFim_MouseDown);
            this.mCFim.MouseLeave += new System.EventHandler(this.mCFim_MouseLeave);
            // 
            // mCInicio
            // 
            this.mCInicio.BackColor = System.Drawing.SystemColors.Control;
            this.mCInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCInicio.Location = new System.Drawing.Point(137, 175);
            this.mCInicio.Name = "mCInicio";
            this.mCInicio.ShowToday = false;
            this.mCInicio.TabIndex = 17;
            this.mCInicio.TitleBackColor = System.Drawing.SystemColors.Highlight;
            this.mCInicio.TrailingForeColor = System.Drawing.SystemColors.InfoText;
            this.mCInicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mCInicio_MouseDown);
            this.mCInicio.MouseLeave += new System.EventHandler(this.mCInicio_MouseLeave);
            // 
            // FormNovoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(635, 442);
            this.Controls.Add(this.mCInicio);
            this.Controls.Add(this.mCFim);
            this.Controls.Add(this.buttonSalvarEvento);
            this.Controls.Add(this.buttonCancelarEvento);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNovoEvento";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Evento";
            this.Load += new System.EventHandler(this.NovoEvento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipoEvento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private GUI.TextBoxLM textBoxNomeEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedHoraFimEvento;
        private System.Windows.Forms.MaskedTextBox maskedHoraInicioEvento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboCadastroUFEvento;
        private System.Windows.Forms.ComboBox comboCadastroCidadeEvento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textCadastroComplementoEvento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textCadastroBairroEvento;
        private System.Windows.Forms.TextBox textCadastroRuaEvento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedCEPEvento;
        private System.Windows.Forms.Button buttonSalvarEvento;
        private System.Windows.Forms.Button buttonCancelarEvento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDataFim;
        private System.Windows.Forms.MaskedTextBox dateEventoFim;
        private System.Windows.Forms.MaskedTextBox dateEventoInicio;
        private System.Windows.Forms.Button btnDataInicio;
        private System.Windows.Forms.MonthCalendar mCFim;
        private System.Windows.Forms.MonthCalendar mCInicio;
        public System.Windows.Forms.TextBox textCadastroNumeroEvento;
        public GUI.TextBoxLM txtValorInscricao;
    }
}