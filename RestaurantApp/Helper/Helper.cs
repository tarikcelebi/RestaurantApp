using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.Helper
{
    public class Helper
    {
        public static void Sifirlama(Control.ControlCollection Controls)
        {

            foreach (Control control in Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox item = (ComboBox)control;
                    item.Text = null;
                }
                if (control is FlowLayoutPanel)
                {
                    FlowLayoutPanel flp = (FlowLayoutPanel)control;
                    foreach (Control item in flp.Controls)
                    {
                        if (item is CheckBox)
                        {
                            CheckBox cb = (CheckBox)item;
                            cb.Checked = false;
                        }
                    }
                }
                if (control is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = 0;
                }
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Checked)
                    {
                        radioButton.Checked = false;
                    }

                }
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                }
                if (control is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)control;
                    Sifirlama(groupBox.Controls);
                }
            }


        }
    }
}
