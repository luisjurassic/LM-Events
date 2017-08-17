namespace LM_Events.PresentationLayer
{
    partial class FormAtualizarEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtualizarEventos));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscaEventos = new System.Windows.Forms.Button();
            this.mCFim = new System.Windows.Forms.MonthCalendar();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboCadastroUFEventoupATU = new System.Windows.Forms.ComboBox();
            this.comboCadastroCidadeEventoupATU = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textCadastroComplementoEventoupATu = new System.Windows.Forms.TextBox();
            this.textCadastroNumeroEventoupATU = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textCadastroBairroEventoupATU = new System.Windows.Forms.TextBox();
            this.textCadastroRuaEventoupATU = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedCEPEventoupATU = new System.Windows.Forms.MaskedTextBox();
            this.buttonSalvarEvento = new System.Windows.Forms.Button();
            this.buttonCancelarEvento = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.mCInicio = new System.Windows.Forms.MonthCalendar();
            this.GrupocaxaLocalEventos = new System.Windows.Forms.GroupBox();
            this.btnDataInicio = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedHoraFimEventoATU = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrupocaxadadosEventos = new System.Windows.Forms.GroupBox();
            this.txtValorInscricaoATU = new System.Windows.Forms.TextBox();
            this.EventoIdUp = new System.Windows.Forms.TextBox();
            this.TextNomeEventoATu = new System.Windows.Forms.TextBox();
            this.btnDataFim = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateEventoFimupATU = new System.Windows.Forms.MaskedTextBox();
            this.dateEventoInicioupATU = new System.Windows.Forms.MaskedTextBox();
            this.maskedHoraInicioEventoATU = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EventoId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextTipoEventoATU = new System.Windows.Forms.ComboBox();
            this.textEventoBusca = new LM_Events.GUI.TextBoxLM();
            this.GrupocaxaLocalEventos.SuspendLayout();
            this.GrupocaxadadosEventos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Procurar Por:";
            // 
            // buttonBuscaEventos
            // 
            this.buttonBuscaEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscaEventos.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscaEventos.Image")));
            this.buttonBuscaEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscaEventos.Location = new System.Drawing.Point(497, 30);
            this.buttonBuscaEventos.Name = "buttonBuscaEventos";
            this.buttonBuscaEventos.Size = new System.Drawing.Size(96, 30);
            this.buttonBuscaEventos.TabIndex = 19;
            this.buttonBuscaEventos.Tag = "Procurar usuários";
            this.buttonBuscaEventos.Text = "Procurar";
            this.buttonBuscaEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscaEventos.UseVisualStyleBackColor = true;
            this.buttonBuscaEventos.Click += new System.EventHandler(this.buttonBuscaEventos_Click);
            // 
            // mCFim
            // 
            this.mCFim.BackColor = System.Drawing.SystemColors.Control;
            this.mCFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCFim.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mCFim.Location = new System.Drawing.Point(289, 234);
            this.mCFim.Name = "mCFim";
            this.mCFim.ShowToday = false;
            this.mCFim.TabIndex = 44;
            this.mCFim.TitleBackColor = System.Drawing.SystemColors.Highlight;
            this.mCFim.TrailingForeColor = System.Drawing.SystemColors.InfoText;
            this.mCFim.Visible = false;
            this.mCFim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mCFim_MouseDown);
            this.mCFim.MouseLeave += new System.EventHandler(this.mCFim_MouseLeave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(508, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "U.F.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(306, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "Cidade";
            // 
            // comboCadastroUFEventoupATU
            // 
            this.comboCadastroUFEventoupATU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCadastroUFEventoupATU.FormattingEnabled = true;
            this.comboCadastroUFEventoupATU.Location = new System.Drawing.Point(512, 93);
            this.comboCadastroUFEventoupATU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCadastroUFEventoupATU.Name = "comboCadastroUFEventoupATU";
            this.comboCadastroUFEventoupATU.Size = new System.Drawing.Size(61, 28);
            this.comboCadastroUFEventoupATU.TabIndex = 15;
            // 
            // comboCadastroCidadeEventoupATU
            // 
            this.comboCadastroCidadeEventoupATU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCadastroCidadeEventoupATU.FormattingEnabled = true;
            this.comboCadastroCidadeEventoupATU.Location = new System.Drawing.Point(297, 93);
            this.comboCadastroCidadeEventoupATU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCadastroCidadeEventoupATU.Name = "comboCadastroCidadeEventoupATU";
            this.comboCadastroCidadeEventoupATU.Size = new System.Drawing.Size(209, 28);
            this.comboCadastroCidadeEventoupATU.TabIndex = 14;
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
            this.label12.Location = new System.Drawing.Point(508, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "Número";
            // 
            // textCadastroComplementoEventoupATu
            // 
            this.textCadastroComplementoEventoupATu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCadastroComplementoEventoupATu.Location = new System.Drawing.Point(10, 143);
            this.textCadastroComplementoEventoupATu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCadastroComplementoEventoupATu.Name = "textCadastroComplementoEventoupATu";
            this.textCadastroComplementoEventoupATu.Size = new System.Drawing.Size(563, 26);
            this.textCadastroComplementoEventoupATu.TabIndex = 16;
            // 
            // textCadastroNumeroEventoupATU
            // 
            this.textCadastroNumeroEventoupATU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCadastroNumeroEventoupATU.Location = new System.Drawing.Point(512, 43);
            this.textCadastroNumeroEventoupATU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCadastroNumeroEventoupATU.Name = "textCadastroNumeroEventoupATU";
            this.textCadastroNumeroEventoupATU.Size = new System.Drawing.Size(61, 26);
            this.textCadastroNumeroEventoupATU.TabIndex = 12;
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
            // textCadastroBairroEventoupATU
            // 
            this.textCadastroBairroEventoupATU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCadastroBairroEventoupATU.Location = new System.Drawing.Point(10, 93);
            this.textCadastroBairroEventoupATU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCadastroBairroEventoupATU.Name = "textCadastroBairroEventoupATU";
            this.textCadastroBairroEventoupATU.Size = new System.Drawing.Size(281, 26);
            this.textCadastroBairroEventoupATU.TabIndex = 13;
            // 
            // textCadastroRuaEventoupATU
            // 
            this.textCadastroRuaEventoupATU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCadastroRuaEventoupATU.Location = new System.Drawing.Point(107, 43);
            this.textCadastroRuaEventoupATU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCadastroRuaEventoupATU.Name = "textCadastroRuaEventoupATU";
            this.textCadastroRuaEventoupATU.Size = new System.Drawing.Size(399, 26);
            this.textCadastroRuaEventoupATU.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "C.E.P.";
            // 
            // maskedCEPEventoupATU
            // 
            this.maskedCEPEventoupATU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedCEPEventoupATU.Location = new System.Drawing.Point(10, 43);
            this.maskedCEPEventoupATU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedCEPEventoupATU.Mask = "00000-000";
            this.maskedCEPEventoupATU.Name = "maskedCEPEventoupATU";
            this.maskedCEPEventoupATU.Size = new System.Drawing.Size(91, 26);
            this.maskedCEPEventoupATU.TabIndex = 10;
            this.maskedCEPEventoupATU.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // buttonSalvarEvento
            // 
            this.buttonSalvarEvento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSalvarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarEvento.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvarEvento.Image")));
            this.buttonSalvarEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvarEvento.Location = new System.Drawing.Point(395, 447);
            this.buttonSalvarEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvarEvento.Name = "buttonSalvarEvento";
            this.buttonSalvarEvento.Size = new System.Drawing.Size(96, 30);
            this.buttonSalvarEvento.TabIndex = 17;
            this.buttonSalvarEvento.Text = "Atualizar";
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
            this.buttonCancelarEvento.Location = new System.Drawing.Point(497, 447);
            this.buttonCancelarEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelarEvento.Name = "buttonCancelarEvento";
            this.buttonCancelarEvento.Size = new System.Drawing.Size(96, 30);
            this.buttonCancelarEvento.TabIndex = 18;
            this.buttonCancelarEvento.Text = "&Sair";
            this.buttonCancelarEvento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelarEvento.UseVisualStyleBackColor = true;
            this.buttonCancelarEvento.Click += new System.EventHandler(this.buttonCancelarEvento_Click);
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
            // mCInicio
            // 
            this.mCInicio.BackColor = System.Drawing.SystemColors.Control;
            this.mCInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCInicio.Location = new System.Drawing.Point(136, 234);
            this.mCInicio.Name = "mCInicio";
            this.mCInicio.ShowToday = false;
            this.mCInicio.TabIndex = 45;
            this.mCInicio.TitleBackColor = System.Drawing.SystemColors.Highlight;
            this.mCInicio.TrailingForeColor = System.Drawing.SystemColors.InfoText;
            this.mCInicio.Visible = false;
            this.mCInicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mCInicio_MouseDown);
            this.mCInicio.MouseLeave += new System.EventHandler(this.mCInicio_MouseLeave);
            // 
            // GrupocaxaLocalEventos
            // 
            this.GrupocaxaLocalEventos.BackColor = System.Drawing.Color.Transparent;
            this.GrupocaxaLocalEventos.Controls.Add(this.label15);
            this.GrupocaxaLocalEventos.Controls.Add(this.label14);
            this.GrupocaxaLocalEventos.Controls.Add(this.comboCadastroUFEventoupATU);
            this.GrupocaxaLocalEventos.Controls.Add(this.comboCadastroCidadeEventoupATU);
            this.GrupocaxaLocalEventos.Controls.Add(this.label13);
            this.GrupocaxaLocalEventos.Controls.Add(this.label12);
            this.GrupocaxaLocalEventos.Controls.Add(this.textCadastroComplementoEventoupATu);
            this.GrupocaxaLocalEventos.Controls.Add(this.textCadastroNumeroEventoupATU);
            this.GrupocaxaLocalEventos.Controls.Add(this.label11);
            this.GrupocaxaLocalEventos.Controls.Add(this.label10);
            this.GrupocaxaLocalEventos.Controls.Add(this.textCadastroBairroEventoupATU);
            this.GrupocaxaLocalEventos.Controls.Add(this.textCadastroRuaEventoupATU);
            this.GrupocaxaLocalEventos.Controls.Add(this.label9);
            this.GrupocaxaLocalEventos.Controls.Add(this.maskedCEPEventoupATU);
            this.GrupocaxaLocalEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupocaxaLocalEventos.Location = new System.Drawing.Point(12, 261);
            this.GrupocaxaLocalEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrupocaxaLocalEventos.Name = "GrupocaxaLocalEventos";
            this.GrupocaxaLocalEventos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrupocaxaLocalEventos.Size = new System.Drawing.Size(582, 182);
            this.GrupocaxaLocalEventos.TabIndex = 46;
            this.GrupocaxaLocalEventos.TabStop = false;
            this.GrupocaxaLocalEventos.Text = "Local do Evento";
            this.GrupocaxaLocalEventos.Visible = false;
            // 
            // btnDataInicio
            // 
            this.btnDataInicio.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.btnDataInicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDataInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDataInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnDataInicio.Image")));
            this.btnDataInicio.Location = new System.Drawing.Point(125, 155);
            this.btnDataInicio.Name = "btnDataInicio";
            this.btnDataInicio.Size = new System.Drawing.Size(26, 26);
            this.btnDataInicio.TabIndex = 5;
            this.btnDataInicio.UseVisualStyleBackColor = true;
            this.btnDataInicio.Click += new System.EventHandler(this.btnDataInicio_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 124;
            this.label7.Text = "Data Fim";
            // 
            // maskedHoraFimEventoATU
            // 
            this.maskedHoraFimEventoATU.Location = new System.Drawing.Point(441, 155);
            this.maskedHoraFimEventoATU.Mask = "90:00";
            this.maskedHoraFimEventoATU.Name = "maskedHoraFimEventoATU";
            this.maskedHoraFimEventoATU.Size = new System.Drawing.Size(100, 26);
            this.maskedHoraFimEventoATU.TabIndex = 9;
            this.maskedHoraFimEventoATU.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 744;
            this.label5.Text = "Hora Termino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Hora de Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 425;
            this.label3.Text = "Data Inicio";
            // 
            // GrupocaxadadosEventos
            // 
            this.GrupocaxadadosEventos.Controls.Add(this.txtValorInscricaoATU);
            this.GrupocaxadadosEventos.Controls.Add(this.EventoIdUp);
            this.GrupocaxadadosEventos.Controls.Add(this.TextNomeEventoATu);
            this.GrupocaxadadosEventos.Controls.Add(this.btnDataFim);
            this.GrupocaxadadosEventos.Controls.Add(this.label6);
            this.GrupocaxadadosEventos.Controls.Add(this.dateEventoFimupATU);
            this.GrupocaxadadosEventos.Controls.Add(this.dateEventoInicioupATU);
            this.GrupocaxadadosEventos.Controls.Add(this.btnDataInicio);
            this.GrupocaxadadosEventos.Controls.Add(this.label7);
            this.GrupocaxadadosEventos.Controls.Add(this.maskedHoraFimEventoATU);
            this.GrupocaxadadosEventos.Controls.Add(this.maskedHoraInicioEventoATU);
            this.GrupocaxadadosEventos.Controls.Add(this.label5);
            this.GrupocaxadadosEventos.Controls.Add(this.label4);
            this.GrupocaxadadosEventos.Controls.Add(this.label3);
            this.GrupocaxadadosEventos.Controls.Add(this.label2);
            this.GrupocaxadadosEventos.Controls.Add(this.EventoId);
            this.GrupocaxadadosEventos.Controls.Add(this.label8);
            this.GrupocaxadadosEventos.Controls.Add(this.TextTipoEventoATU);
            this.GrupocaxadadosEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupocaxadadosEventos.Location = new System.Drawing.Point(11, 66);
            this.GrupocaxadadosEventos.Name = "GrupocaxadadosEventos";
            this.GrupocaxadadosEventos.Size = new System.Drawing.Size(582, 190);
            this.GrupocaxadadosEventos.TabIndex = 43;
            this.GrupocaxadadosEventos.TabStop = false;
            this.GrupocaxadadosEventos.Text = "Dados de Eventos";
            this.GrupocaxadadosEventos.Visible = false;
            // 
            // txtValorInscricaoATU
            // 
            this.txtValorInscricaoATU.Location = new System.Drawing.Point(441, 103);
            this.txtValorInscricaoATU.Name = "txtValorInscricaoATU";
            this.txtValorInscricaoATU.Size = new System.Drawing.Size(132, 26);
            this.txtValorInscricaoATU.TabIndex = 3;
            // 
            // EventoIdUp
            // 
            this.EventoIdUp.Location = new System.Drawing.Point(469, 34);
            this.EventoIdUp.Name = "EventoIdUp";
            this.EventoIdUp.Size = new System.Drawing.Size(72, 26);
            this.EventoIdUp.TabIndex = 1366;
            this.EventoIdUp.Visible = false;
            // 
            // TextNomeEventoATu
            // 
            this.TextNomeEventoATu.Location = new System.Drawing.Point(10, 103);
            this.TextNomeEventoATu.Name = "TextNomeEventoATu";
            this.TextNomeEventoATu.Size = new System.Drawing.Size(414, 26);
            this.TextNomeEventoATu.TabIndex = 2;
            // 
            // btnDataFim
            // 
            this.btnDataFim.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.btnDataFim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDataFim.Image = ((System.Drawing.Image)(resources.GetObject("btnDataFim.Image")));
            this.btnDataFim.Location = new System.Drawing.Point(272, 155);
            this.btnDataFim.Name = "btnDataFim";
            this.btnDataFim.Size = new System.Drawing.Size(26, 26);
            this.btnDataFim.TabIndex = 7;
            this.btnDataFim.UseVisualStyleBackColor = true;
            this.btnDataFim.Click += new System.EventHandler(this.btnDataFim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 105;
            this.label6.Text = "Valor da Inscrição";
            // 
            // dateEventoFimupATU
            // 
            this.dateEventoFimupATU.Location = new System.Drawing.Point(157, 155);
            this.dateEventoFimupATU.Mask = "00/00/0000";
            this.dateEventoFimupATU.Name = "dateEventoFimupATU";
            this.dateEventoFimupATU.Size = new System.Drawing.Size(109, 26);
            this.dateEventoFimupATU.TabIndex = 6;
            this.dateEventoFimupATU.ValidatingType = typeof(System.DateTime);
            // 
            // dateEventoInicioupATU
            // 
            this.dateEventoInicioupATU.Location = new System.Drawing.Point(10, 155);
            this.dateEventoInicioupATU.Mask = "00/00/0000";
            this.dateEventoInicioupATU.Name = "dateEventoInicioupATU";
            this.dateEventoInicioupATU.Size = new System.Drawing.Size(109, 26);
            this.dateEventoInicioupATU.TabIndex = 4;
            this.dateEventoInicioupATU.ValidatingType = typeof(System.DateTime);
            // 
            // maskedHoraInicioEventoATU
            // 
            this.maskedHoraInicioEventoATU.Location = new System.Drawing.Point(324, 155);
            this.maskedHoraInicioEventoATU.Mask = "90:00";
            this.maskedHoraInicioEventoATU.Name = "maskedHoraInicioEventoATU";
            this.maskedHoraInicioEventoATU.Size = new System.Drawing.Size(100, 26);
            this.maskedHoraInicioEventoATU.TabIndex = 8;
            this.maskedHoraInicioEventoATU.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 200;
            this.label2.Text = "Nome";
            // 
            // EventoId
            // 
            this.EventoId.AutoSize = true;
            this.EventoId.Location = new System.Drawing.Point(390, 37);
            this.EventoId.Name = "EventoId";
            this.EventoId.Size = new System.Drawing.Size(73, 20);
            this.EventoId.TabIndex = 1;
            this.EventoId.Text = "EventoId";
            this.EventoId.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tipo de Evento";
            // 
            // TextTipoEventoATU
            // 
            this.TextTipoEventoATU.FormattingEnabled = true;
            this.TextTipoEventoATU.Location = new System.Drawing.Point(10, 45);
            this.TextTipoEventoATU.Name = "TextTipoEventoATU";
            this.TextTipoEventoATU.Size = new System.Drawing.Size(192, 28);
            this.TextTipoEventoATU.TabIndex = 1;
            // 
            // textEventoBusca
            // 
            this.textEventoBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEventoBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textEventoBusca.Location = new System.Drawing.Point(20, 32);
            this.textEventoBusca.Name = "textEventoBusca";
            this.textEventoBusca.Placeholder = "";
            this.textEventoBusca.Size = new System.Drawing.Size(471, 26);
            this.textEventoBusca.TabIndex = 1;
            // 
            // FormAtualizarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(606, 493);
            this.Controls.Add(this.mCInicio);
            this.Controls.Add(this.mCFim);
            this.Controls.Add(this.buttonSalvarEvento);
            this.Controls.Add(this.buttonCancelarEvento);
            this.Controls.Add(this.GrupocaxadadosEventos);
            this.Controls.Add(this.textEventoBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscaEventos);
            this.Controls.Add(this.GrupocaxaLocalEventos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAtualizarEventos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Eventos";
            this.Load += new System.EventHandler(this.AtualizarEventos_Load);
            this.GrupocaxaLocalEventos.ResumeLayout(false);
            this.GrupocaxaLocalEventos.PerformLayout();
            this.GrupocaxadadosEventos.ResumeLayout(false);
            this.GrupocaxadadosEventos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public GUI.TextBoxLM textEventoBusca;
        public System.Windows.Forms.Button buttonBuscaEventos;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.MonthCalendar mCFim;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox comboCadastroUFEventoupATU;
        public System.Windows.Forms.ComboBox comboCadastroCidadeEventoupATU;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox textCadastroComplementoEventoupATu;
        public System.Windows.Forms.TextBox textCadastroNumeroEventoupATU;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox textCadastroBairroEventoupATU;
        public System.Windows.Forms.TextBox textCadastroRuaEventoupATU;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.MaskedTextBox maskedCEPEventoupATU;
        public System.Windows.Forms.Button buttonSalvarEvento;
        public System.Windows.Forms.Button buttonCancelarEvento;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.MonthCalendar mCInicio;
        public System.Windows.Forms.GroupBox GrupocaxaLocalEventos;
        public System.Windows.Forms.Button btnDataInicio;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox maskedHoraFimEventoATU;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox GrupocaxadadosEventos;
        public System.Windows.Forms.Button btnDataFim;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox dateEventoFimupATU;
        public System.Windows.Forms.MaskedTextBox dateEventoInicioupATU;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox TextTipoEventoATU;
        public System.Windows.Forms.MaskedTextBox maskedHoraInicioEventoATU;
        public System.Windows.Forms.TextBox txtValorInscricaoATU;
        public System.Windows.Forms.TextBox TextNomeEventoATu;
        public System.Windows.Forms.TextBox EventoIdUp;
        public System.Windows.Forms.Label EventoId;
    }
}