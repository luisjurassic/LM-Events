namespace LM_Events
{
    partial class FormAtualizarCadastroPessoaFisica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtualizarCadastroPessoaFisica));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAtualizarPF = new System.Windows.Forms.Button();
            this.groupProcurarCadastro = new System.Windows.Forms.GroupBox();
            this.textBuscaAtualizarPF = new LM_Events.GUI.TextBoxLM();
            this.label16 = new System.Windows.Forms.Label();
            this.maskedTextAtualizarCEP = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupEndereco = new System.Windows.Forms.GroupBox();
            this.comboAtualizarUF = new System.Windows.Forms.ComboBox();
            this.comboAtualizarCidade = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textAtualizarNumero = new System.Windows.Forms.TextBox();
            this.textAtualizarComplemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textAtualizarBairro = new System.Windows.Forms.TextBox();
            this.textAtualizarRua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextAtualizarTelefoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextAtualizarTelefoneResidencial = new System.Windows.Forms.MaskedTextBox();
            this.comboAtualizarEstadoCivil = new System.Windows.Forms.ComboBox();
            this.groupDadosPessoais = new System.Windows.Forms.GroupBox();
            this.CpfAtualizar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextAtualizarDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.textAtualizarNome = new System.Windows.Forms.TextBox();
            this.comboAtualizarTipoCadastro = new System.Windows.Forms.ComboBox();
            this.buttonSalvarAtualizar = new System.Windows.Forms.Button();
            this.buttonCancelarAtualizar = new System.Windows.Forms.Button();
            this.groupProcurarCadastro.SuspendLayout();
            this.groupEndereco.SuspendLayout();
            this.groupDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Procurar por";
            // 
            // buttonAtualizarPF
            // 
            this.buttonAtualizarPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAtualizarPF.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtualizarPF.Image")));
            this.buttonAtualizarPF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAtualizarPF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAtualizarPF.Location = new System.Drawing.Point(470, 43);
            this.buttonAtualizarPF.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAtualizarPF.Name = "buttonAtualizarPF";
            this.buttonAtualizarPF.Size = new System.Drawing.Size(96, 30);
            this.buttonAtualizarPF.TabIndex = 2;
            this.buttonAtualizarPF.Text = "&Buscar";
            this.buttonAtualizarPF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAtualizarPF.UseVisualStyleBackColor = true;
            this.buttonAtualizarPF.Click += new System.EventHandler(this.botaobuscaratualizar_Click);
            // 
            // groupProcurarCadastro
            // 
            this.groupProcurarCadastro.Controls.Add(this.textBuscaAtualizarPF);
            this.groupProcurarCadastro.Controls.Add(this.label1);
            this.groupProcurarCadastro.Controls.Add(this.buttonAtualizarPF);
            this.groupProcurarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupProcurarCadastro.Location = new System.Drawing.Point(12, 11);
            this.groupProcurarCadastro.Name = "groupProcurarCadastro";
            this.groupProcurarCadastro.Size = new System.Drawing.Size(577, 84);
            this.groupProcurarCadastro.TabIndex = 3;
            this.groupProcurarCadastro.TabStop = false;
            this.groupProcurarCadastro.Text = "Cadastro";
            // 
            // textBuscaAtualizarPF
            // 
            this.textBuscaAtualizarPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBuscaAtualizarPF.Location = new System.Drawing.Point(9, 45);
            this.textBuscaAtualizarPF.Name = "textBuscaAtualizarPF";
            this.textBuscaAtualizarPF.Placeholder = null;
            this.textBuscaAtualizarPF.Size = new System.Drawing.Size(456, 26);
            this.textBuscaAtualizarPF.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(5, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 20);
            this.label16.TabIndex = 1322;
            this.label16.Text = "C.E.P.";
            // 
            // maskedTextAtualizarCEP
            // 
            this.maskedTextAtualizarCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextAtualizarCEP.Location = new System.Drawing.Point(10, 43);
            this.maskedTextAtualizarCEP.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextAtualizarCEP.Mask = "00000-000";
            this.maskedTextAtualizarCEP.Name = "maskedTextAtualizarCEP";
            this.maskedTextAtualizarCEP.Size = new System.Drawing.Size(90, 26);
            this.maskedTextAtualizarCEP.TabIndex = 7;
            this.maskedTextAtualizarCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(502, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 20);
            this.label15.TabIndex = 1319;
            this.label15.Text = "U.F.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(282, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 1318;
            this.label11.Text = "Cidade";
            // 
            // groupEndereco
            // 
            this.groupEndereco.Controls.Add(this.label16);
            this.groupEndereco.Controls.Add(this.maskedTextAtualizarCEP);
            this.groupEndereco.Controls.Add(this.label15);
            this.groupEndereco.Controls.Add(this.label11);
            this.groupEndereco.Controls.Add(this.comboAtualizarUF);
            this.groupEndereco.Controls.Add(this.comboAtualizarCidade);
            this.groupEndereco.Controls.Add(this.label14);
            this.groupEndereco.Controls.Add(this.label13);
            this.groupEndereco.Controls.Add(this.textAtualizarNumero);
            this.groupEndereco.Controls.Add(this.textAtualizarComplemento);
            this.groupEndereco.Controls.Add(this.label12);
            this.groupEndereco.Controls.Add(this.label10);
            this.groupEndereco.Controls.Add(this.textAtualizarBairro);
            this.groupEndereco.Controls.Add(this.textAtualizarRua);
            this.groupEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupEndereco.Location = new System.Drawing.Point(11, 306);
            this.groupEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.groupEndereco.Name = "groupEndereco";
            this.groupEndereco.Padding = new System.Windows.Forms.Padding(2);
            this.groupEndereco.Size = new System.Drawing.Size(578, 184);
            this.groupEndereco.TabIndex = 1620;
            this.groupEndereco.TabStop = false;
            this.groupEndereco.Text = "Endereço";
            this.groupEndereco.Visible = false;
            // 
            // comboAtualizarUF
            // 
            this.comboAtualizarUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboAtualizarUF.FormattingEnabled = true;
            this.comboAtualizarUF.Location = new System.Drawing.Point(506, 93);
            this.comboAtualizarUF.Margin = new System.Windows.Forms.Padding(2);
            this.comboAtualizarUF.Name = "comboAtualizarUF";
            this.comboAtualizarUF.Size = new System.Drawing.Size(61, 28);
            this.comboAtualizarUF.TabIndex = 12;
            // 
            // comboAtualizarCidade
            // 
            this.comboAtualizarCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboAtualizarCidade.FormattingEnabled = true;
            this.comboAtualizarCidade.Location = new System.Drawing.Point(286, 93);
            this.comboAtualizarCidade.Margin = new System.Windows.Forms.Padding(2);
            this.comboAtualizarCidade.Name = "comboAtualizarCidade";
            this.comboAtualizarCidade.Size = new System.Drawing.Size(204, 28);
            this.comboAtualizarCidade.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(6, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 20);
            this.label14.TabIndex = 1317;
            this.label14.Text = "Complemento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(502, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 1316;
            this.label13.Text = "Número";
            // 
            // textAtualizarNumero
            // 
            this.textAtualizarNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textAtualizarNumero.Location = new System.Drawing.Point(506, 43);
            this.textAtualizarNumero.Margin = new System.Windows.Forms.Padding(2);
            this.textAtualizarNumero.Name = "textAtualizarNumero";
            this.textAtualizarNumero.Size = new System.Drawing.Size(61, 26);
            this.textAtualizarNumero.TabIndex = 9;
            // 
            // textAtualizarComplemento
            // 
            this.textAtualizarComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textAtualizarComplemento.Location = new System.Drawing.Point(10, 143);
            this.textAtualizarComplemento.Margin = new System.Windows.Forms.Padding(2);
            this.textAtualizarComplemento.Name = "textAtualizarComplemento";
            this.textAtualizarComplemento.Size = new System.Drawing.Size(557, 26);
            this.textAtualizarComplemento.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(6, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 1315;
            this.label12.Text = "Bairro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(112, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 1314;
            this.label10.Text = "Rua";
            // 
            // textAtualizarBairro
            // 
            this.textAtualizarBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textAtualizarBairro.Location = new System.Drawing.Point(10, 93);
            this.textAtualizarBairro.Margin = new System.Windows.Forms.Padding(2);
            this.textAtualizarBairro.Name = "textAtualizarBairro";
            this.textAtualizarBairro.Size = new System.Drawing.Size(272, 26);
            this.textAtualizarBairro.TabIndex = 10;
            // 
            // textAtualizarRua
            // 
            this.textAtualizarRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textAtualizarRua.Location = new System.Drawing.Point(116, 43);
            this.textAtualizarRua.Margin = new System.Windows.Forms.Padding(2);
            this.textAtualizarRua.Name = "textAtualizarRua";
            this.textAtualizarRua.Size = new System.Drawing.Size(374, 26);
            this.textAtualizarRua.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(5, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(5, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 78;
            this.label3.Text = "Tipo Cadastro";
            // 
            // maskedTextAtualizarTelefoneCelular
            // 
            this.maskedTextAtualizarTelefoneCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextAtualizarTelefoneCelular.Location = new System.Drawing.Point(332, 145);
            this.maskedTextAtualizarTelefoneCelular.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextAtualizarTelefoneCelular.Mask = "(00) 0000-0000";
            this.maskedTextAtualizarTelefoneCelular.Name = "maskedTextAtualizarTelefoneCelular";
            this.maskedTextAtualizarTelefoneCelular.Size = new System.Drawing.Size(119, 26);
            this.maskedTextAtualizarTelefoneCelular.TabIndex = 6;
            this.maskedTextAtualizarTelefoneCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextAtualizarTelefoneResidencial
            // 
            this.maskedTextAtualizarTelefoneResidencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextAtualizarTelefoneResidencial.Location = new System.Drawing.Point(208, 145);
            this.maskedTextAtualizarTelefoneResidencial.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextAtualizarTelefoneResidencial.Mask = "(00) 0000-0000";
            this.maskedTextAtualizarTelefoneResidencial.Name = "maskedTextAtualizarTelefoneResidencial";
            this.maskedTextAtualizarTelefoneResidencial.Size = new System.Drawing.Size(120, 26);
            this.maskedTextAtualizarTelefoneResidencial.TabIndex = 5;
            this.maskedTextAtualizarTelefoneResidencial.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // comboAtualizarEstadoCivil
            // 
            this.comboAtualizarEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboAtualizarEstadoCivil.FormattingEnabled = true;
            this.comboAtualizarEstadoCivil.Location = new System.Drawing.Point(9, 145);
            this.comboAtualizarEstadoCivil.Margin = new System.Windows.Forms.Padding(2);
            this.comboAtualizarEstadoCivil.Name = "comboAtualizarEstadoCivil";
            this.comboAtualizarEstadoCivil.Size = new System.Drawing.Size(195, 28);
            this.comboAtualizarEstadoCivil.TabIndex = 4;
            // 
            // groupDadosPessoais
            // 
            this.groupDadosPessoais.Controls.Add(this.CpfAtualizar);
            this.groupDadosPessoais.Controls.Add(this.label2);
            this.groupDadosPessoais.Controls.Add(this.label9);
            this.groupDadosPessoais.Controls.Add(this.label8);
            this.groupDadosPessoais.Controls.Add(this.maskedTextAtualizarTelefoneCelular);
            this.groupDadosPessoais.Controls.Add(this.maskedTextAtualizarTelefoneResidencial);
            this.groupDadosPessoais.Controls.Add(this.label7);
            this.groupDadosPessoais.Controls.Add(this.comboAtualizarEstadoCivil);
            this.groupDadosPessoais.Controls.Add(this.label6);
            this.groupDadosPessoais.Controls.Add(this.maskedTextAtualizarDataNascimento);
            this.groupDadosPessoais.Controls.Add(this.label4);
            this.groupDadosPessoais.Controls.Add(this.textAtualizarNome);
            this.groupDadosPessoais.Controls.Add(this.label3);
            this.groupDadosPessoais.Controls.Add(this.comboAtualizarTipoCadastro);
            this.groupDadosPessoais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupDadosPessoais.Location = new System.Drawing.Point(12, 100);
            this.groupDadosPessoais.Margin = new System.Windows.Forms.Padding(2);
            this.groupDadosPessoais.Name = "groupDadosPessoais";
            this.groupDadosPessoais.Padding = new System.Windows.Forms.Padding(2);
            this.groupDadosPessoais.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupDadosPessoais.Size = new System.Drawing.Size(577, 202);
            this.groupDadosPessoais.TabIndex = 1619;
            this.groupDadosPessoais.TabStop = false;
            this.groupDadosPessoais.Text = "Dados Pessoais";
            this.groupDadosPessoais.Visible = false;
            // 
            // CpfAtualizar
            // 
            this.CpfAtualizar.Location = new System.Drawing.Point(389, 37);
            this.CpfAtualizar.Name = "CpfAtualizar";
            this.CpfAtualizar.Size = new System.Drawing.Size(121, 26);
            this.CpfAtualizar.TabIndex = 87;
            this.CpfAtualizar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(343, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "CPF";
            this.label2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(328, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 84;
            this.label9.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(204, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 83;
            this.label8.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(5, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 82;
            this.label7.Text = "Estado Civil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(451, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 81;
            this.label6.Text = "D. Nascimento";
            // 
            // maskedTextAtualizarDataNascimento
            // 
            this.maskedTextAtualizarDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextAtualizarDataNascimento.Location = new System.Drawing.Point(455, 95);
            this.maskedTextAtualizarDataNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextAtualizarDataNascimento.Mask = "00/00/0000";
            this.maskedTextAtualizarDataNascimento.Name = "maskedTextAtualizarDataNascimento";
            this.maskedTextAtualizarDataNascimento.Size = new System.Drawing.Size(111, 26);
            this.maskedTextAtualizarDataNascimento.TabIndex = 3;
            this.maskedTextAtualizarDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // textAtualizarNome
            // 
            this.textAtualizarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textAtualizarNome.Location = new System.Drawing.Point(9, 95);
            this.textAtualizarNome.Margin = new System.Windows.Forms.Padding(2);
            this.textAtualizarNome.Name = "textAtualizarNome";
            this.textAtualizarNome.Size = new System.Drawing.Size(442, 26);
            this.textAtualizarNome.TabIndex = 2;
            // 
            // comboAtualizarTipoCadastro
            // 
            this.comboAtualizarTipoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboAtualizarTipoCadastro.FormattingEnabled = true;
            this.comboAtualizarTipoCadastro.Location = new System.Drawing.Point(9, 43);
            this.comboAtualizarTipoCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.comboAtualizarTipoCadastro.Name = "comboAtualizarTipoCadastro";
            this.comboAtualizarTipoCadastro.Size = new System.Drawing.Size(174, 28);
            this.comboAtualizarTipoCadastro.TabIndex = 1;
            // 
            // buttonSalvarAtualizar
            // 
            this.buttonSalvarAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSalvarAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSalvarAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvarAtualizar.Image")));
            this.buttonSalvarAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvarAtualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSalvarAtualizar.Location = new System.Drawing.Point(393, 494);
            this.buttonSalvarAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvarAtualizar.Name = "buttonSalvarAtualizar";
            this.buttonSalvarAtualizar.Size = new System.Drawing.Size(96, 30);
            this.buttonSalvarAtualizar.TabIndex = 14;
            this.buttonSalvarAtualizar.Text = "&Atualizar";
            this.buttonSalvarAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSalvarAtualizar.UseVisualStyleBackColor = true;
            this.buttonSalvarAtualizar.Visible = false;
            this.buttonSalvarAtualizar.Click += new System.EventHandler(this.buttonSalvarAtualizar_Click);
            // 
            // buttonCancelarAtualizar
            // 
            this.buttonCancelarAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancelarAtualizar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelarAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancelarAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelarAtualizar.Image")));
            this.buttonCancelarAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarAtualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancelarAtualizar.Location = new System.Drawing.Point(493, 494);
            this.buttonCancelarAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelarAtualizar.Name = "buttonCancelarAtualizar";
            this.buttonCancelarAtualizar.Size = new System.Drawing.Size(96, 30);
            this.buttonCancelarAtualizar.TabIndex = 15;
            this.buttonCancelarAtualizar.Text = "&Sair";
            this.buttonCancelarAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelarAtualizar.UseVisualStyleBackColor = true;
            this.buttonCancelarAtualizar.Click += new System.EventHandler(this.buttonCancelarAtualizar_Click);
            // 
            // FormAtualizarCadastroPessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(601, 534);
            this.Controls.Add(this.groupProcurarCadastro);
            this.Controls.Add(this.groupEndereco);
            this.Controls.Add(this.groupDadosPessoais);
            this.Controls.Add(this.buttonSalvarAtualizar);
            this.Controls.Add(this.buttonCancelarAtualizar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAtualizarCadastroPessoaFisica";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Cadastro Pessoa  Física";
            this.groupProcurarCadastro.ResumeLayout(false);
            this.groupProcurarCadastro.PerformLayout();
            this.groupEndereco.ResumeLayout(false);
            this.groupEndereco.PerformLayout();
            this.groupDadosPessoais.ResumeLayout(false);
            this.groupDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupEndereco;
        public System.Windows.Forms.GroupBox groupDadosPessoais;
        public System.Windows.Forms.GroupBox groupProcurarCadastro;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.MaskedTextBox maskedTextAtualizarCEP;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox comboAtualizarUF;
        public System.Windows.Forms.ComboBox comboAtualizarCidade;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox textAtualizarNumero;
        public System.Windows.Forms.TextBox textAtualizarComplemento;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox textAtualizarBairro;
        public System.Windows.Forms.TextBox textAtualizarRua;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.MaskedTextBox maskedTextAtualizarTelefoneCelular;
        public System.Windows.Forms.MaskedTextBox maskedTextAtualizarTelefoneResidencial;
        public System.Windows.Forms.ComboBox comboAtualizarEstadoCivil;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox maskedTextAtualizarDataNascimento;
        public System.Windows.Forms.TextBox textAtualizarNome;
        public System.Windows.Forms.ComboBox comboAtualizarTipoCadastro;
        public System.Windows.Forms.Button buttonSalvarAtualizar;
        public System.Windows.Forms.Button buttonCancelarAtualizar;
        public System.Windows.Forms.Button buttonAtualizarPF;
        public GUI.TextBoxLM textBuscaAtualizarPF;
        public System.Windows.Forms.TextBox CpfAtualizar;
        public System.Windows.Forms.Label label2;


    }
}