using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LM_Events.PresentationLayer
{
    public partial class FormTelaSplash : Form
    {
        public FormTelaSplash()
        {
            InitializeComponent();
        }
        public void TimerSplash()
        {

            Random r = new Random();
            timerSplash.Interval = r.Next(1000);
            if (progressBarSplash.Value != 110)
            {
                progressBarSplash.Value = progressBarSplash.Value + 11;
            }
            else
            {
                timerSplash.Stop();
                this.Hide();
                new FormLogin().Show();
            }
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            TimerSplash();
        }

        private void timerPontos_Tick(object sender, EventArgs e)
        {
            if (progressBarSplash.Value == 110)
            {
                timerPontos.Stop();
            }
            else if (labelIniciando.Text == "Iniciando...")
            {
                labelIniciando.Text ="Iniciando";
            }
            else
            {
                labelIniciando.Text += ".";
            }
        }

    }
}
