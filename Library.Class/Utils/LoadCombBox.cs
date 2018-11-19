using System.Collections.Generic;
using System.Windows.Forms;

namespace Library.Class.Utils
{
    public static class LoadCombBox
    {
        public static ComboBox CarregarCombo<T>(this ComboBox combo, List<T> datatable, string valuemember, string displaymember)
        {
            combo.Items.Clear();
            combo.ValueMember = valuemember;
            combo.DisplayMember = displaymember;
            combo.Items.Insert(0, "");
            foreach (T objClasse in datatable)
            {
                combo.Items.Add(objClasse);
            }
            combo.SelectedItem = "";
            combo.Refresh();

            return combo;
        }
    }
}
