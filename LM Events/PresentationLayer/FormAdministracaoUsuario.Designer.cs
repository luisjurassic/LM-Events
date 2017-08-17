namespace LM_Events.PresentationLayer
{
    partial class FormAdministracaoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministracaoUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscaUser = new System.Windows.Forms.Button();
            this.openFileDialogImagem = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxPerfilAdmin = new System.Windows.Forms.PictureBox();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnImpotaImagem = new System.Windows.Forms.Button();
            this.labelLocalImagem = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textUsuarioID = new System.Windows.Forms.TextBox();
            this.comboPermissaoAdmin = new System.Windows.Forms.ComboBox();
            this.maskedDataInscriçãoAdminUsuario = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textEmailAdminUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textConfirmaSenhaAdminUsuario = new System.Windows.Forms.TextBox();
            this.textSenhaAdminUsuario = new System.Windows.Forms.TextBox();
            this.textUsuarioAdminUsuario = new System.Windows.Forms.TextBox();
            this.textNomeAdminUsuario = new System.Windows.Forms.TextBox();
            this.textUsuarioBusca = new LM_Events.GUI.TextBoxLM();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCancelarAdmin = new System.Windows.Forms.Button();
            this.buttonAtualizarUsuario = new System.Windows.Forms.Button();
            this.buttonExcluirUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfilAdmin)).BeginInit();
            this.panelUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Procurar Por";
            // 
            // buttonBuscaUser
            // 
            this.buttonBuscaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscaUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscaUser.Image")));
            this.buttonBuscaUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscaUser.Location = new System.Drawing.Point(667, 43);
            this.buttonBuscaUser.Name = "buttonBuscaUser";
            this.buttonBuscaUser.Size = new System.Drawing.Size(100, 30);
            this.buttonBuscaUser.TabIndex = 32;
            this.buttonBuscaUser.Tag = "Procurar usuários";
            this.buttonBuscaUser.Text = "Procurar";
            this.buttonBuscaUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscaUser.UseVisualStyleBackColor = true;
            this.buttonBuscaUser.Click += new System.EventHandler(this.buttonBuscaUser_Click);
            // 
            // openFileDialogImagem
            // 
            this.openFileDialogImagem.FileName = "openFileDialog1";
            // 
            // pictureBoxPerfilAdmin
            // 
            this.pictureBoxPerfilAdmin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxPerfilAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPerfilAdmin.Location = new System.Drawing.Point(15, 24);
            this.pictureBoxPerfilAdmin.Name = "pictureBoxPerfilAdmin";
            this.pictureBoxPerfilAdmin.Size = new System.Drawing.Size(200, 250);
            this.pictureBoxPerfilAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPerfilAdmin.TabIndex = 51;
            this.pictureBoxPerfilAdmin.TabStop = false;
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.label10);
            this.panelUsuario.Controls.Add(this.btnImpotaImagem);
            this.panelUsuario.Controls.Add(this.labelLocalImagem);
            this.panelUsuario.Controls.Add(this.label9);
            this.panelUsuario.Controls.Add(this.textUsuarioID);
            this.panelUsuario.Controls.Add(this.comboPermissaoAdmin);
            this.panelUsuario.Controls.Add(this.maskedDataInscriçãoAdminUsuario);
            this.panelUsuario.Controls.Add(this.label7);
            this.panelUsuario.Controls.Add(this.label6);
            this.panelUsuario.Controls.Add(this.label5);
            this.panelUsuario.Controls.Add(this.textEmailAdminUsuario);
            this.panelUsuario.Controls.Add(this.pictureBoxPerfilAdmin);
            this.panelUsuario.Controls.Add(this.label4);
            this.panelUsuario.Controls.Add(this.label3);
            this.panelUsuario.Controls.Add(this.label2);
            this.panelUsuario.Controls.Add(this.label8);
            this.panelUsuario.Controls.Add(this.textConfirmaSenhaAdminUsuario);
            this.panelUsuario.Controls.Add(this.textSenhaAdminUsuario);
            this.panelUsuario.Controls.Add(this.textUsuarioAdminUsuario);
            this.panelUsuario.Controls.Add(this.textNomeAdminUsuario);
            this.panelUsuario.Location = new System.Drawing.Point(7, 87);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(759, 333);
            this.panelUsuario.TabIndex = 0;
            this.panelUsuario.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 62;
            this.label10.Text = "Imagem de Perfil";
            // 
            // btnImpotaImagem
            // 
            this.btnImpotaImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpotaImagem.Location = new System.Drawing.Point(15, 277);
            this.btnImpotaImagem.Name = "btnImpotaImagem";
            this.btnImpotaImagem.Size = new System.Drawing.Size(200, 27);
            this.btnImpotaImagem.TabIndex = 61;
            this.btnImpotaImagem.Text = "Importar Imagem";
            this.btnImpotaImagem.UseVisualStyleBackColor = true;
            this.btnImpotaImagem.Click += new System.EventHandler(this.btnImpotaImagem_Click);
            // 
            // labelLocalImagem
            // 
            this.labelLocalImagem.AutoSize = true;
            this.labelLocalImagem.Enabled = false;
            this.labelLocalImagem.Location = new System.Drawing.Point(11, 307);
            this.labelLocalImagem.Name = "labelLocalImagem";
            this.labelLocalImagem.Size = new System.Drawing.Size(109, 20);
            this.labelLocalImagem.TabIndex = 60;
            this.labelLocalImagem.Text = "Local Imagem";
            this.labelLocalImagem.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(455, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Código do Usuário";
            this.label9.Visible = false;
            // 
            // textUsuarioID
            // 
            this.textUsuarioID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuarioID.Location = new System.Drawing.Point(459, 24);
            this.textUsuarioID.Name = "textUsuarioID";
            this.textUsuarioID.ReadOnly = true;
            this.textUsuarioID.Size = new System.Drawing.Size(75, 26);
            this.textUsuarioID.TabIndex = 56;
            this.textUsuarioID.Visible = false;
            // 
            // comboPermissaoAdmin
            // 
            this.comboPermissaoAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPermissaoAdmin.FormattingEnabled = true;
            this.comboPermissaoAdmin.Location = new System.Drawing.Point(229, 24);
            this.comboPermissaoAdmin.Name = "comboPermissaoAdmin";
            this.comboPermissaoAdmin.Size = new System.Drawing.Size(218, 28);
            this.comboPermissaoAdmin.TabIndex = 55;
            // 
            // maskedDataInscriçãoAdminUsuario
            // 
            this.maskedDataInscriçãoAdminUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedDataInscriçãoAdminUsuario.Location = new System.Drawing.Point(630, 78);
            this.maskedDataInscriçãoAdminUsuario.Mask = "00/00/0000";
            this.maskedDataInscriçãoAdminUsuario.Name = "maskedDataInscriçãoAdminUsuario";
            this.maskedDataInscriçãoAdminUsuario.PromptChar = ' ';
            this.maskedDataInscriçãoAdminUsuario.ReadOnly = true;
            this.maskedDataInscriçãoAdminUsuario.Size = new System.Drawing.Size(126, 26);
            this.maskedDataInscriçãoAdminUsuario.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(626, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Data Inscrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Nivel Acesso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Email";
            // 
            // textEmailAdminUsuario
            // 
            this.textEmailAdminUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmailAdminUsuario.Location = new System.Drawing.Point(486, 130);
            this.textEmailAdminUsuario.Name = "textEmailAdminUsuario";
            this.textEmailAdminUsuario.Size = new System.Drawing.Size(270, 26);
            this.textEmailAdminUsuario.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Confirmar Senha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(229, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Nome";
            // 
            // textConfirmaSenhaAdminUsuario
            // 
            this.textConfirmaSenhaAdminUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmaSenhaAdminUsuario.Location = new System.Drawing.Point(486, 189);
            this.textConfirmaSenhaAdminUsuario.Name = "textConfirmaSenhaAdminUsuario";
            this.textConfirmaSenhaAdminUsuario.Size = new System.Drawing.Size(270, 26);
            this.textConfirmaSenhaAdminUsuario.TabIndex = 45;
            // 
            // textSenhaAdminUsuario
            // 
            this.textSenhaAdminUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenhaAdminUsuario.Location = new System.Drawing.Point(229, 189);
            this.textSenhaAdminUsuario.Name = "textSenhaAdminUsuario";
            this.textSenhaAdminUsuario.Size = new System.Drawing.Size(218, 26);
            this.textSenhaAdminUsuario.TabIndex = 44;
            // 
            // textUsuarioAdminUsuario
            // 
            this.textUsuarioAdminUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuarioAdminUsuario.Location = new System.Drawing.Point(229, 130);
            this.textUsuarioAdminUsuario.Name = "textUsuarioAdminUsuario";
            this.textUsuarioAdminUsuario.Size = new System.Drawing.Size(218, 26);
            this.textUsuarioAdminUsuario.TabIndex = 42;
            // 
            // textNomeAdminUsuario
            // 
            this.textNomeAdminUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeAdminUsuario.Location = new System.Drawing.Point(229, 78);
            this.textNomeAdminUsuario.Name = "textNomeAdminUsuario";
            this.textNomeAdminUsuario.Size = new System.Drawing.Size(386, 26);
            this.textNomeAdminUsuario.TabIndex = 41;
            // 
            // textUsuarioBusca
            // 
            this.textUsuarioBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuarioBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textUsuarioBusca.Location = new System.Drawing.Point(7, 45);
            this.textUsuarioBusca.Name = "textUsuarioBusca";
            this.textUsuarioBusca.Placeholder = "";
            this.textUsuarioBusca.Size = new System.Drawing.Size(654, 26);
            this.textUsuarioBusca.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelUsuario);
            this.groupBox1.Controls.Add(this.textUsuarioBusca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonBuscaUser);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 427);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administração de Usuários";
            // 
            // buttonCancelarAdmin
            // 
            this.buttonCancelarAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarAdmin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonCancelarAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelarAdmin.Image")));
            this.buttonCancelarAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarAdmin.Location = new System.Drawing.Point(685, 445);
            this.buttonCancelarAdmin.Name = "buttonCancelarAdmin";
            this.buttonCancelarAdmin.Size = new System.Drawing.Size(100, 30);
            this.buttonCancelarAdmin.TabIndex = 41;
            this.buttonCancelarAdmin.Tag = "Voltar para forma de pagamento";
            this.buttonCancelarAdmin.Text = "Sair";
            this.buttonCancelarAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelarAdmin.UseVisualStyleBackColor = true;
            this.buttonCancelarAdmin.Click += new System.EventHandler(this.buttonCancelarAdmin_Click);
            // 
            // buttonAtualizarUsuario
            // 
            this.buttonAtualizarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizarUsuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonAtualizarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtualizarUsuario.Image")));
            this.buttonAtualizarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAtualizarUsuario.Location = new System.Drawing.Point(473, 445);
            this.buttonAtualizarUsuario.Name = "buttonAtualizarUsuario";
            this.buttonAtualizarUsuario.Size = new System.Drawing.Size(100, 30);
            this.buttonAtualizarUsuario.TabIndex = 39;
            this.buttonAtualizarUsuario.Tag = "Atualizar dados usuário";
            this.buttonAtualizarUsuario.Text = "Atualizar";
            this.buttonAtualizarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAtualizarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAtualizarUsuario.UseVisualStyleBackColor = true;
            this.buttonAtualizarUsuario.Click += new System.EventHandler(this.buttonAtualizarUsuario_Click);
            // 
            // buttonExcluirUsuario
            // 
            this.buttonExcluirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirUsuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonExcluirUsuario.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirUsuario.Image")));
            this.buttonExcluirUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirUsuario.Location = new System.Drawing.Point(579, 445);
            this.buttonExcluirUsuario.Name = "buttonExcluirUsuario";
            this.buttonExcluirUsuario.Size = new System.Drawing.Size(100, 30);
            this.buttonExcluirUsuario.TabIndex = 40;
            this.buttonExcluirUsuario.Tag = "Excluir usuários";
            this.buttonExcluirUsuario.Text = "Excluir";
            this.buttonExcluirUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExcluirUsuario.UseVisualStyleBackColor = true;
            this.buttonExcluirUsuario.Click += new System.EventHandler(this.buttonExcluirUsuario_Click);
            // 
            // FormAdministracaoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(799, 489);
            this.Controls.Add(this.buttonCancelarAdmin);
            this.Controls.Add(this.buttonAtualizarUsuario);
            this.Controls.Add(this.buttonExcluirUsuario);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdministracaoUsuario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administração de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfilAdmin)).EndInit();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagem;
        public System.Windows.Forms.PictureBox pictureBoxPerfilAdmin;
        public System.Windows.Forms.Panel panelUsuario;
        public System.Windows.Forms.Button buttonBuscaUser;
        public GUI.TextBoxLM textUsuarioBusca;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox textUsuarioID;
        public System.Windows.Forms.ComboBox comboPermissaoAdmin;
        public System.Windows.Forms.MaskedTextBox maskedDataInscriçãoAdminUsuario;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textEmailAdminUsuario;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textConfirmaSenhaAdminUsuario;
        public System.Windows.Forms.TextBox textSenhaAdminUsuario;
        public System.Windows.Forms.TextBox textUsuarioAdminUsuario;
        public System.Windows.Forms.TextBox textNomeAdminUsuario;
        public System.Windows.Forms.Label labelLocalImagem;
        private System.Windows.Forms.Button btnImpotaImagem;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCancelarAdmin;
        private System.Windows.Forms.Button buttonAtualizarUsuario;
        private System.Windows.Forms.Button buttonExcluirUsuario;
    }
}