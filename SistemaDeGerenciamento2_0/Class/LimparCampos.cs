using System;
using System.Collections.Generic;
using DevExpress.Emf;
using DevExpress.XtraEditors.ColorPick.Picker;

using System;
using System.Collections.Generic;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento2_0.Class
{
    internal class LimparCampos
    {
        public static void LimpaCampos(Control.ControlCollection controles)
        {
            foreach (Control item in controles)
            {
                if (item.GetType() == typeof(DevExpress.XtraEditors.TextEdit))
                {
                    item.Text = string.Empty;
                }
                else if (item.GetType() == typeof(DevExpress.XtraEditors.ComboBoxEdit))
                {
                    item.Text = string.Empty;
                }
            }
        }
    }
}