using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FINAL_LAB
{
    class limpiar
    {
        public void limpiarCampos(Control control) 
        {
            foreach (var txt in control.Controls) 
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }
            }    
        }
    }
}
