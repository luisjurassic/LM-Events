namespace LM_Events.PresentationLayer
{
    partial class FormTelaSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaSplash));
            this.progressBarSplash = new System.Windows.Forms.ProgressBar();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.labelIniciando = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.timerPontos = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBarSplash
            // 
            this.progressBarSplash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarSplash.Location = new System.Drawing.Point(12, 263);
            this.progressBarSplash.Maximum = 110;
            this.progressBarSplash.Name = "progressBarSplash";
            this.progressBarSplash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBarSplash.Size = new System.Drawing.Size(476, 10);
            this.progressBarSplash.Step = 3;
            this.progressBarSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarSplash.TabIndex = 0;
            // 
            // timerSplash
            // 
            this.timerSplash.Enabled = true;
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // labelIniciando
            // 
            this.labelIniciando.AutoSize = true;
            this.labelIniciando.BackColor = System.Drawing.Color.Transparent;
            this.labelIniciando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIniciando.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelIniciando.Location = new System.Drawing.Point(12, 243);
            this.labelIniciando.Name = "labelIniciando";
            this.labelIniciando.Size = new System.Drawing.Size(73, 20);
            this.labelIniciando.TabIndex = 1;
            this.labelIniciando.Text = "Iniciando";
            // 
            // labelCopyright
            // 
            this.labelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.Color.DarkGray;
            this.labelCopyright.Location = new System.Drawing.Point(151, 274);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(191, 17);
            this.labelCopyright.TabIndex = 2;
            this.labelCopyright.Text = "Copyright © 2015 LM Event\'s";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerPontos
            // 
            this.timerPontos.Enabled = true;
            this.timerPontos.Interval = 300;
            this.timerPontos.Tick += new System.EventHandler(this.timerPontos_Tick);
            // 
            // FormTelaSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelIniciando);
            this.Controls.Add(this.progressBarSplash);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTelaSplash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaSplash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarSplash;
        private System.Windows.Forms.Timer timerSplash;
        private System.Windows.Forms.Label labelIniciando;
        private System.Windows.Forms.Label labelCopyright;
        public System.Windows.Forms.Timer timerPontos;
    }
}