namespace LM_Events
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textSenha = new LM_Events.GUI.TextBoxLM();
            this.textUsuario = new LM_Events.GUI.TextBoxLM();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSairLogin = new System.Windows.Forms.Button();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textSenha);
            this.groupBox1.Controls.Add(this.textUsuario);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 152);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // textSenha
            // 
            this.textSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textSenha.Location = new System.Drawing.Point(10, 97);
            this.textSenha.Name = "textSenha";
            this.textSenha.Placeholder = "Senha...";
            this.textSenha.Size = new System.Drawing.Size(228, 26);
            this.textSenha.TabIndex = 3;
            this.textSenha.Text = "Senha...";
            this.textSenha.UseSystemPasswordChar = true;
            // 
            // textUsuario
            // 
            this.textUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textUsuario.Location = new System.Drawing.Point(10, 45);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Placeholder = "Digite um usuário...";
            this.textUsuario.Size = new System.Drawing.Size(228, 26);
            this.textUsuario.TabIndex = 2;
            this.textUsuario.Text = "Digite um usuário...";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(10, 129);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Tag = "Mostrar senha";
            this.checkBox1.Text = "Mostrar Senha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário";
            // 
            // buttonSairLogin
            // 
            this.buttonSairLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSairLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonSairLogin.Image")));
            this.buttonSairLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSairLogin.Location = new System.Drawing.Point(181, 170);
            this.buttonSairLogin.Name = "buttonSairLogin";
            this.buttonSairLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSairLogin.Size = new System.Drawing.Size(80, 30);
            this.buttonSairLogin.TabIndex = 6;
            this.buttonSairLogin.Tag = "Sair da tela de Login";
            this.buttonSairLogin.Text = "&Sair";
            this.buttonSairLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSairLogin.UseVisualStyleBackColor = true;
            this.buttonSairLogin.Click += new System.EventHandler(this.buttonSairLogin_Click);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEntrar.Image")));
            this.buttonEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEntrar.Location = new System.Drawing.Point(95, 170);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(80, 30);
            this.buttonEntrar.TabIndex = 7;
            this.buttonEntrar.Tag = "Login em LM Event\'s";
            this.buttonEntrar.Text = "&Entrar";
            this.buttonEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(273, 212);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.buttonSairLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login LM Events";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button buttonEntrar;
        public System.Windows.Forms.Button buttonSairLogin;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public GUI.TextBoxLM textUsuario;
        public GUI.TextBoxLM textSenha;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}