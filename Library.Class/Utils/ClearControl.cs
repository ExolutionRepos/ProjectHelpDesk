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
                if ((item.GetType() == typeof(TextBox))||  (item.GetType() == typeof(ComboBox)))
                {
                    item.Text = string.Empty;
                }
                if (item.GetType() == typeof(DateTimePicker))
                {
                    item.Text = DateTime.Now.ToLongTimeString();
                }
            }

            return Control;
        }
    }
}
