using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHousePro.core.util
{
    internal class ValidationHelper
    {
        public static bool hasNull(Control parent, out string msg)
        {
            msg = string.Empty;
            foreach(Control ctrl in parent.Controls)
            {
                if (ctrl.Tag == "nullable") continue;
                switch(ctrl)
                {
                    case TextBox txt when string.IsNullOrWhiteSpace(txt.Text):
                        msg = "Required input is missing or empty";
                        return true;
                    case ComboBox cmb when cmb.SelectedIndex < 0:
                        msg = "No selected value from required dropdown list";
                        return true;
                }
            }
            return false;
        }
    }
}
