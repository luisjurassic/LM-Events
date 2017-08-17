namespace LM_Events.PresentationLayer
{
    partial class FormCadastroPessoaJuridica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroPessoaJuridica));
            this.CadastrarEmpresa = new System.Windows.Forms.Button();
            this.CNPJCampoDeTextoEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboEmpresaUF = new System.Windows.Forms.ComboBox();
            this.comboEmpresaCidade = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textEmpresaComplemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextEmpresaCEP = new System.Windows.Forms.MaskedTextBox();
            this.textEmpresaNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textEmpresaBairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textEmpresaRua = new System.Windows.Forms.TextBox();
            this.buttonCancelarCadastro = new System.Windows.Forms.Button();
            this.maskedTextEmpresaTelefoneResidencial = new System.Windows.Forms.MaskedTextBox();
            this.AtividadeCampoComboEmpresa = new System.Windows.Forms.ComboBox();
            this.NomeCampoDeTextoEmpresa = new System.Windows.Forms.TextBox();
            this.EmailCampodeTextoEmpresa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InscricaoEstadualCampoDeTextoPessoaJuridica = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WebsiteCanpodeTextoEmpresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DataFundacaoCampoDeTextoPessoaJuridica = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RazaoSocialCampoDeTextoPessoaJuridica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CadastrarEmpresa
            // 
            this.CadastrarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("CadastrarEmpresa.Image")));
            this.CadastrarEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CadastrarEmpresa.Location = new System.Drawing.Point(430, 460);
            this.CadastrarEmpresa.Name = "CadastrarEmpresa";
            this.CadastrarEmpresa.Size = new System.Drawing.Size(107, 30);
            this.CadastrarEmpresa.TabIndex = 19;
            this.CadastrarEmpresa.Text = "&Cadastrar";
            this.CadastrarEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CadastrarEmpresa.UseVisualStyleBackColor = true;
            this.CadastrarEmpresa.Click += new System.EventHandler(this.CadastrarEmpresa_Click);
            // 
            // CNPJCampoDeTextoEmpresa
            // 
            this.CNPJCampoDeTextoEmpresa.Location = new System.Drawing.Point(460, 45);
            this.CNPJCampoDeTextoEmpresa.Mask = "00.000.000/0000-00";
            this.CNPJCampoDeTextoEmpresa.Name = "CNPJCampoDeTextoEmpresa";
            this.CNPJCampoDeTextoEmpresa.Size = new System.Drawing.Size(170, 26);
            this.CNPJCampoDeTextoEmpresa.TabIndex = 2;
            this.CNPJCampoDeTextoEmpresa.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.CNPJCampoDeTextoEmpresa.Leave += new System.EventHandler(this.CNPJCampoDeTextoEmpresa_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.comboEmpresaUF);
            this.groupBox2.Controls.Add(this.comboEmpresaCidade);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textEmpresaComplemento);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.maskedTextEmpresaCEP);
            this.groupBox2.Controls.Add(this.textEmpresaNumero);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textEmpresaBairro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textEmpresaRua);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 192);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(565, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 20);
            this.label16.TabIndex = 39;
            this.label16.Text = "U.F.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(320, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "Cidade";
            // 
            // comboEmpresaUF
            // 
            this.comboEmpresaUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEmpresaUF.FormattingEnabled = true;
            this.comboEmpresaUF.Location = new System.Drawing.Point(569, 97);
            this.comboEmpresaUF.Name = "comboEmpresaUF";
            this.comboEmpresaUF.Size = new System.Drawing.Size(61, 28);
            this.comboEmpresaUF.TabIndex = 15;
            // 
            // comboEmpresaCidade
            // 
            this.comboEmpresaCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEmpresaCidade.FormattingEnabled = true;
            this.comboEmpresaCidade.Location = new System.Drawing.Point(324, 97);
            this.comboEmpresaCidade.Name = "comboEmpresaCidade";
            this.comboEmpresaCidade.Size = new System.Drawing.Size(237, 28);
            this.comboEmpresaCidade.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Complemento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(565, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Número";
            // 
            // textEmpresaComplemento
            // 
            this.textEmpresaComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmpresaComplemento.Location = new System.Drawing.Point(8, 149);
            this.textEmpresaComplemento.Name = "textEmpresaComplemento";
            this.textEmpresaComplemento.Size = new System.Drawing.Size(622, 26);
            this.textEmpresaComplemento.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "C.E.P.";
            // 
            // maskedTextEmpresaCEP
            // 
            this.maskedTextEmpresaCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextEmpresaCEP.Location = new System.Drawing.Point(8, 45);
            this.maskedTextEmpresaCEP.Mask = "00000-000";
            this.maskedTextEmpresaCEP.Name = "maskedTextEmpresaCEP";
            this.maskedTextEmpresaCEP.Size = new System.Drawing.Size(88, 26);
            this.maskedTextEmpresaCEP.TabIndex = 10;
            this.maskedTextEmpresaCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textEmpresaNumero
            // 
            this.textEmpresaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmpresaNumero.Location = new System.Drawing.Point(569, 45);
            this.textEmpresaNumero.Name = "textEmpresaNumero";
            this.textEmpresaNumero.Size = new System.Drawing.Size(61, 26);
            this.textEmpresaNumero.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Bairro";
            // 
            // textEmpresaBairro
            // 
            this.textEmpresaBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmpresaBairro.Location = new System.Drawing.Point(8, 97);
            this.textEmpresaBairro.Name = "textEmpresaBairro";
            this.textEmpresaBairro.Size = new System.Drawing.Size(310, 26);
            this.textEmpresaBairro.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(102, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Rua";
            // 
            // textEmpresaRua
            // 
            this.textEmpresaRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmpresaRua.Location = new System.Drawing.Point(106, 45);
            this.textEmpresaRua.Name = "textEmpresaRua";
            this.textEmpresaRua.Size = new System.Drawing.Size(457, 26);
            this.textEmpresaRua.TabIndex = 11;
            // 
            // buttonCancelarCadastro
            // 
            this.buttonCancelarCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancelarCadastro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelarCadastro.Image")));
            this.buttonCancelarCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarCadastro.Location = new System.Drawing.Point(543, 460);
            this.buttonCancelarCadastro.Name = "buttonCancelarCadastro";
            this.buttonCancelarCadastro.Size = new System.Drawing.Size(107, 30);
            this.buttonCancelarCadastro.TabIndex = 20;
            this.buttonCancelarCadastro.Text = "&Sair";
            this.buttonCancelarCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelarCadastro.UseVisualStyleBackColor = true;
            this.buttonCancelarCadastro.Click += new System.EventHandler(this.buttonCancelarCadastro_Click);
            // 
            // maskedTextEmpresaTelefoneResidencial
            // 
            this.maskedTextEmpresaTelefoneResidencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextEmpresaTelefoneResidencial.Location = new System.Drawing.Point(460, 149);
            this.maskedTextEmpresaTelefoneResidencial.Mask = "(00) 0000-0000";
            this.maskedTextEmpresaTelefoneResidencial.Name = "maskedTextEmpresaTelefoneResidencial";
            this.maskedTextEmpresaTelefoneResidencial.Size = new System.Drawing.Size(170, 26);
            this.maskedTextEmpresaTelefoneResidencial.TabIndex = 7;
            this.maskedTextEmpresaTelefoneResidencial.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // AtividadeCampoComboEmpresa
            // 
            this.AtividadeCampoComboEmpresa.FormattingEnabled = true;
            this.AtividadeCampoComboEmpresa.Location = new System.Drawing.Point(8, 149);
            this.AtividadeCampoComboEmpresa.Name = "AtividadeCampoComboEmpresa";
            this.AtividadeCampoComboEmpresa.Size = new System.Drawing.Size(324, 28);
            this.AtividadeCampoComboEmpresa.TabIndex = 5;
            // 
            // NomeCampoDeTextoEmpresa
            // 
            this.NomeCampoDeTextoEmpresa.Location = new System.Drawing.Point(8, 45);
            this.NomeCampoDeTextoEmpresa.Name = "NomeCampoDeTextoEmpresa";
            this.NomeCampoDeTextoEmpresa.Size = new System.Drawing.Size(446, 26);
            this.NomeCampoDeTextoEmpresa.TabIndex = 1;
            // 
            // EmailCampodeTextoEmpresa
            // 
            this.EmailCampodeTextoEmpresa.Location = new System.Drawing.Point(338, 203);
            this.EmailCampodeTextoEmpresa.Name = "EmailCampodeTextoEmpresa";
            this.EmailCampodeTextoEmpresa.Size = new System.Drawing.Size(292, 26);
            this.EmailCampodeTextoEmpresa.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.InscricaoEstadualCampoDeTextoPessoaJuridica);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.EmailCampodeTextoEmpresa);
            this.groupBox1.Controls.Add(this.WebsiteCanpodeTextoEmpresa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.maskedTextEmpresaTelefoneResidencial);
            this.groupBox1.Controls.Add(this.DataFundacaoCampoDeTextoPessoaJuridica);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AtividadeCampoComboEmpresa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RazaoSocialCampoDeTextoPessoaJuridica);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CNPJCampoDeTextoEmpresa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NomeCampoDeTextoEmpresa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 246);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Inscrição Estadual";
            // 
            // InscricaoEstadualCampoDeTextoPessoaJuridica
            // 
            this.InscricaoEstadualCampoDeTextoPessoaJuridica.Location = new System.Drawing.Point(460, 97);
            this.InscricaoEstadualCampoDeTextoPessoaJuridica.Mask = "000.000.000";
            this.InscricaoEstadualCampoDeTextoPessoaJuridica.Name = "InscricaoEstadualCampoDeTextoPessoaJuridica";
            this.InscricaoEstadualCampoDeTextoPessoaJuridica.Size = new System.Drawing.Size(170, 26);
            this.InscricaoEstadualCampoDeTextoPessoaJuridica.TabIndex = 4;
            this.InscricaoEstadualCampoDeTextoPessoaJuridica.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "WebSite";
            // 
            // WebsiteCanpodeTextoEmpresa
            // 
            this.WebsiteCanpodeTextoEmpresa.Location = new System.Drawing.Point(8, 203);
            this.WebsiteCanpodeTextoEmpresa.Name = "WebsiteCanpodeTextoEmpresa";
            this.WebsiteCanpodeTextoEmpresa.Size = new System.Drawing.Size(324, 26);
            this.WebsiteCanpodeTextoEmpresa.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Data Fundação";
            // 
            // DataFundacaoCampoDeTextoPessoaJuridica
            // 
            this.DataFundacaoCampoDeTextoPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DataFundacaoCampoDeTextoPessoaJuridica.Location = new System.Drawing.Point(338, 149);
            this.DataFundacaoCampoDeTextoPessoaJuridica.Mask = "00/00/0000";
            this.DataFundacaoCampoDeTextoPessoaJuridica.Name = "DataFundacaoCampoDeTextoPessoaJuridica";
            this.DataFundacaoCampoDeTextoPessoaJuridica.Size = new System.Drawing.Size(116, 26);
            this.DataFundacaoCampoDeTextoPessoaJuridica.TabIndex = 6;
            this.DataFundacaoCampoDeTextoPessoaJuridica.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Atividade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "C.N.P.J.";
            // 
            // RazaoSocialCampoDeTextoPessoaJuridica
            // 
            this.RazaoSocialCampoDeTextoPessoaJuridica.Location = new System.Drawing.Point(8, 97);
            this.RazaoSocialCampoDeTextoPessoaJuridica.Name = "RazaoSocialCampoDeTextoPessoaJuridica";
            this.RazaoSocialCampoDeTextoPessoaJuridica.Size = new System.Drawing.Size(446, 26);
            this.RazaoSocialCampoDeTextoPessoaJuridica.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Razão Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nome";
            // 
            // FormCadastroPessoaJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(661, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CadastrarEmpresa);
            this.Controls.Add(this.buttonCancelarCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroPessoaJuridica";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Pessoa Jurídica";
            this.Load += new System.EventHandler(this.CadastrarEmpresas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CadastrarEmpresa;
        private System.Windows.Forms.MaskedTextBox CNPJCampoDeTextoEmpresa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboEmpresaUF;
        private System.Windows.Forms.ComboBox comboEmpresaCidade;
        private System.Windows.Forms.Button buttonCancelarCadastro;
        private System.Windows.Forms.MaskedTextBox maskedTextEmpresaTelefoneResidencial;
        private System.Windows.Forms.MaskedTextBox maskedTextEmpresaCEP;
        private System.Windows.Forms.TextBox textEmpresaComplemento;
        private System.Windows.Forms.TextBox textEmpresaNumero;
        private System.Windows.Forms.TextBox textEmpresaBairro;
        private System.Windows.Forms.TextBox textEmpresaRua;
        private System.Windows.Forms.ComboBox AtividadeCampoComboEmpresa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox DataFundacaoCampoDeTextoPessoaJuridica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeCampoDeTextoEmpresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailCampodeTextoEmpresa;
        private System.Windows.Forms.TextBox WebsiteCanpodeTextoEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RazaoSocialCampoDeTextoPessoaJuridica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox InscricaoEstadualCampoDeTextoPessoaJuridica;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}