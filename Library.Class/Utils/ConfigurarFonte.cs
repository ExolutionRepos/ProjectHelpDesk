using Library.Class.Models;
using System.Windows.Forms;

namespace Library.Class.Utils
{
    public static class ConfigurarFonte
    {
        public static Control ConfigurarTamanhoFonte(this Control control, ConfigFont Fonte)
        {
            foreach(Control ctrl in control.Controls)
            {
                ctrl.Font = new System.Drawing.Font(Fonte.Fonte, Fonte.Tamanho);
            }

            return control;
        }
    }
}
