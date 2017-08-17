namespace LM_Events.PresentationLayer
{
    partial class FormNovoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovoUsuario));
            this.comboPermissao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textEmailNovoCadastro = new System.Windows.Forms.TextBox();
            this.buttonSalvarNovoUsuario = new System.Windows.Forms.Button();
            this.pictureBoxPerfil = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textConfirmaSenhaNovoCadastro = new System.Windows.Forms.TextBox();
            this.textSenhaNovoCadastro = new System.Windows.Forms.TextBox();
            this.textUsuarioNovoCadastro = new System.Windows.Forms.TextBox();
            this.textNomeNovoCadastro = new System.Windows.Forms.TextBox();
            this.buttonCancelarAdmin = new System.Windows.Forms.Button();
            this.openFileDialogImagem = new System.Windows.Forms.OpenFileDialog();
            this.maskedDataInscrição = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnImpotaImagem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // comboPermissao
            // 
            this.comboPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPermissao.FormattingEnabled = true;
            this.comboPermissao.Location = new System.Drawing.Point(218, 32);
            this.comboPermissao.Name = "comboPermissao";
            this.comboPermissao.Size = new System.Drawing.Size(223, 28);
            this.comboPermissao.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Permissão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Email";
            // 
            // textEmailNovoCadastro
            // 
            this.textEmailNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmailNovoCadastro.Location = new System.Drawing.Point(447, 138);
            this.textEmailNovoCadastro.Name = "textEmailNovoCadastro";
            this.textEmailNovoCadastro.Size = new System.Drawing.Size(225, 26);
            this.textEmailNovoCadastro.TabIndex = 5;
            this.textEmailNovoCadastro.Leave += new System.EventHandler(this.textEmailNovoCadastro_Leave);
            // 
            // buttonSalvarNovoUsuario
            // 
            this.buttonSalvarNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarNovoUsuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonSalvarNovoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvarNovoUsuario.Image")));
            this.buttonSalvarNovoUsuario.Location = new System.Drawing.Point(466, 285);
            this.buttonSalvarNovoUsuario.Name = "buttonSalvarNovoUsuario";
            this.buttonSalvarNovoUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSalvarNovoUsuario.Size = new System.Drawing.Size(100, 30);
            this.buttonSalvarNovoUsuario.TabIndex = 8;
            this.buttonSalvarNovoUsuario.Tag = "Salvar novo usúario";
            this.buttonSalvarNovoUsuario.Text = "&Salvar";
            this.buttonSalvarNovoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvarNovoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSalvarNovoUsuario.UseVisualStyleBackColor = true;
            this.buttonSalvarNovoUsuario.Click += new System.EventHandler(this.buttonSalvarNovoUsuario_Click);
            // 
            // pictureBoxPerfil
            // 
            this.pictureBoxPerfil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPerfil.Location = new System.Drawing.Point(12, 32);
            this.pictureBoxPerfil.Name = "pictureBoxPerfil";
            this.pictureBoxPerfil.Size = new System.Drawing.Size(200, 250);
            this.pictureBoxPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPerfil.TabIndex = 29;
            this.pictureBoxPerfil.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Confirmar Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome";
            // 
            // textConfirmaSenhaNovoCadastro
            // 
            this.textConfirmaSenhaNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmaSenhaNovoCadastro.Location = new System.Drawing.Point(447, 199);
            this.textConfirmaSenhaNovoCadastro.Name = "textConfirmaSenhaNovoCadastro";
            this.textConfirmaSenhaNovoCadastro.Size = new System.Drawing.Size(225, 26);
            this.textConfirmaSenhaNovoCadastro.TabIndex = 7;
            this.textConfirmaSenhaNovoCadastro.UseSystemPasswordChar = true;
            // 
            // textSenhaNovoCadastro
            // 
            this.textSenhaNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenhaNovoCadastro.Location = new System.Drawing.Point(218, 199);
            this.textSenhaNovoCadastro.Name = "textSenhaNovoCadastro";
            this.textSenhaNovoCadastro.Size = new System.Drawing.Size(223, 26);
            this.textSenhaNovoCadastro.TabIndex = 6;
            this.textSenhaNovoCadastro.UseSystemPasswordChar = true;
            // 
            // textUsuarioNovoCadastro
            // 
            this.textUsuarioNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuarioNovoCadastro.Location = new System.Drawing.Point(218, 138);
            this.textUsuarioNovoCadastro.Name = "textUsuarioNovoCadastro";
            this.textUsuarioNovoCadastro.Size = new System.Drawing.Size(223, 26);
            this.textUsuarioNovoCadastro.TabIndex = 4;
            this.textUsuarioNovoCadastro.Leave += new System.EventHandler(this.textUsuarioNovoCadastro_Leave);
            // 
            // textNomeNovoCadastro
            // 
            this.textNomeNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeNovoCadastro.Location = new System.Drawing.Point(218, 86);
            this.textNomeNovoCadastro.Name = "textNomeNovoCadastro";
            this.textNomeNovoCadastro.Size = new System.Drawing.Size(310, 26);
            this.textNomeNovoCadastro.TabIndex = 3;
            // 
            // buttonCancelarAdmin
            // 
            this.buttonCancelarAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarAdmin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonCancelarAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelarAdmin.Image")));
            this.buttonCancelarAdmin.Location = new System.Drawing.Point(572, 285);
            this.buttonCancelarAdmin.Name = "buttonCancelarAdmin";
            this.buttonCancelarAdmin.Size = new System.Drawing.Size(100, 30);
            this.buttonCancelarAdmin.TabIndex = 9;
            this.buttonCancelarAdmin.Tag = "Voltar para forma de pagamento";
            this.buttonCancelarAdmin.Text = "&Fechar";
            this.buttonCancelarAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelarAdmin.UseVisualStyleBackColor = true;
            this.buttonCancelarAdmin.Click += new System.EventHandler(this.buttonCancelarAdmin_Click);
            // 
            // openFileDialogImagem
            // 
            this.openFileDialogImagem.FileName = "openFileDialog1";
            // 
            // maskedDataInscrição
            // 
            this.maskedDataInscrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedDataInscrição.Location = new System.Drawing.Point(534, 86);
            this.maskedDataInscrição.Mask = "00/00/0000 90:00";
            this.maskedDataInscrição.Name = "maskedDataInscrição";
            this.maskedDataInscrição.ReadOnly = true;
            this.maskedDataInscrição.Size = new System.Drawing.Size(138, 26);
            this.maskedDataInscrição.TabIndex = 10;
            this.maskedDataInscrição.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(530, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Data Inscrição";
            // 
            // btnImpotaImagem
            // 
            this.btnImpotaImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpotaImagem.Location = new System.Drawing.Point(12, 288);
            this.btnImpotaImagem.Name = "btnImpotaImagem";
            this.btnImpotaImagem.Size = new System.Drawing.Size(200, 27);
            this.btnImpotaImagem.TabIndex = 62;
            this.btnImpotaImagem.Text = "Importar Imagem";
            this.btnImpotaImagem.UseVisualStyleBackColor = true;
            this.btnImpotaImagem.Click += new System.EventHandler(this.btnImpotaImagem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Imagem de Perfil";
            // 
            // FormNovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 327);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnImpotaImagem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedDataInscrição);
            this.Controls.Add(this.buttonCancelarAdmin);
            this.Controls.Add(this.comboPermissao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEmailNovoCadastro);
            this.Controls.Add(this.buttonSalvarNovoUsuario);
            this.Controls.Add(this.pictureBoxPerfil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textConfirmaSenhaNovoCadastro);
            this.Controls.Add(this.textSenhaNovoCadastro);
            this.Controls.Add(this.textUsuarioNovoCadastro);
            this.Controls.Add(this.textNomeNovoCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNovoUsuario";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuário";
            this.Load += new System.EventHandler(this.NovoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPermissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textEmailNovoCadastro;
        private System.Windows.Forms.Button buttonSalvarNovoUsuario;
        private System.Windows.Forms.PictureBox pictureBoxPerfil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textConfirmaSenhaNovoCadastro;
        private System.Windows.Forms.TextBox textSenhaNovoCadastro;
        private System.Windows.Forms.TextBox textUsuarioNovoCadastro;
        private System.Windows.Forms.TextBox textNomeNovoCadastro;
        private System.Windows.Forms.Button buttonCancelarAdmin;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagem;
        private System.Windows.Forms.MaskedTextBox maskedDataInscrição;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnImpotaImagem;
        private System.Windows.Forms.Label label8;
    }
}