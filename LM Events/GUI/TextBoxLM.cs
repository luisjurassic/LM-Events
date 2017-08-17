using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM_Events.GUI
{
    public class TextBoxLM : TextBox
    {
        private string _placeholder;

        public string Placeholder
        {
            get { return _placeholder; }
            set
            {
                this.Text = value;
                _placeholder = value;
            }
        }

        public TextBoxLM()
        {
            this.GotFocus += RemoveText;
            this.LostFocus += AddText;
            this.ForeColor = Color.FromArgb(192, 192, 192);
        }

        public void RemoveText(object sender, EventArgs e)
        {
            this.Text = "";
            this.ForeColor = Color.Black;
        }

        public void AddText(object sender, EventArgs e)
        {
            if (this.Text == "")
            {
                this.Text = Placeholder;
                this.ForeColor = Color.FromArgb(192, 192, 192);
            }
        }
    }
}
