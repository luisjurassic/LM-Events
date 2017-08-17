using System.Windows.Forms;

namespace LM_Events.GUI
{
    class FormCleaner
    {
        public static void Clear(Control c)
        {
            foreach (Control item in c.Controls)
            {
                if (item is TextBoxLM)
                {
                    TextBoxLM txtLM = (TextBoxLM)item;
                    txtLM.Clear();
                }
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                else if (item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.SelectedIndex = -1;
                }
                else if (item is MaskedTextBox)
                {
                    MaskedTextBox mask = (MaskedTextBox)item;
                    mask.Clear();
                }
                if (item.HasChildren)
                {
                    Clear(item);
                }
            }
        }
    }
}
