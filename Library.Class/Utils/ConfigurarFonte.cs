using Library.Class.Models;
using System.Windows.Forms;

namespace Library.Class.Utils
{
    public static class ConfigurarFonte
    {
        public static Control ConfigurarTamanhoFonte(this Control control
            , ConfigFont Fonte
            )
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl.GetType() == typeof(GroupBox))
                {
                    All((GroupBox)ctrl, Fonte);
                }
                else
                {
                    ctrl.Font = new System.Drawing.Font(Fonte.Fonte, Fonte.Tamanho + 1);
                }
            }

            return control;
        }

        private static void All(GroupBox gbox, ConfigFont Fonte)
        {
            foreach (Control ctrl in gbox.Controls)
            {
                ctrl.Font = new System.Drawing.Font(Fonte.Fonte, Fonte.Tamanho - 2);
            }
        }
    }
}
