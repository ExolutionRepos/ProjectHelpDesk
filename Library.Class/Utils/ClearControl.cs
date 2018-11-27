using System;
using System.Windows.Forms;

namespace Library.Class.Utils
{
    public static class ClearControl
    {
        public static Control ClearControlAll(this Control Control)
        {
            foreach (Control item in Control.Controls)
            {
                if ((item.GetType() == typeof(TextBox)) || (item.GetType() == typeof(ComboBox)))
                {
                    item.Text = string.Empty;
                }
                if (item.GetType() == typeof(DateTimePicker))
                {
                    item.Text = DateTime.Now.ToLongTimeString();
                }

                if (item.GetType() == typeof(NumericUpDown))
                {
                    NumericUpDown num = ((NumericUpDown)item);
                    num.Value = 0;
                }

                if (item.GetType() == typeof(GroupBox))
                {
                    ResetAll((GroupBox)item);
                }

                if (item.GetType() == typeof(RichTextBox))
                {
                    item.Text = "";
                }

                if (item.GetType() == typeof(DateTimePicker))
                {
                    ((DateTimePicker)item).Format = DateTimePickerFormat.Custom;
                    ((DateTimePicker)item).CustomFormat = null;
                }

                if (item.GetType() == typeof(TabControl))
                {
                    ClearControlAll(item);
                }

                if (item.GetType() == typeof(TabPage))
                {
                    ClearControlAll(item);
                }
            }

            return Control;
        }

        private static void ResetAll(GroupBox gbox)
        {
            foreach (Control ctrl in gbox.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = null;
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }

                if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Checked = false;
                }

                if (ctrl is RadioButton)
                {
                    ((RadioButton)ctrl).Checked = false;
                }

                if (ctrl is ListBox)
                {
                    ((ListBox)ctrl).ClearSelected();
                }

                if (ctrl is NumericUpDown)
                {
                    ((NumericUpDown)ctrl).Value = 0;
                }

                if (ctrl is DateTimePicker)
                {
                    //((DateTimePicker)ctrl).Text = DateTime.Now.ToLongTimeString();
                    ((DateTimePicker)ctrl).Format = DateTimePickerFormat.Custom;
                    ((DateTimePicker)ctrl).CustomFormat = null;
                }

                if (ctrl is RichTextBox)
                {
                    ((RichTextBox)ctrl).Text = "";
                }
            }
        }
    }
}
