using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Helpers
{
    internal static partial class Componentes
    {
        internal static bool ValidarCamposObrigatorios(Form frm)
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    switch (control)
                    {
                        case TextBox box:
                            {
                                if (String.IsNullOrWhiteSpace(box.Text))
                                {
                                    return;
                                }
                                break;
                            }
                        case ComboBox box:
                            {
                                if (box.SelectedIndex.Equals(-1))
                                {
                                    return; 
                                }
                                break;
                            }
                        case MaskedTextBox box:
                            {
                                if (box.MaskCompleted)
                                {
                                    return;
                                }
                                break;
                            }
                        default:
                            func(control.Controls);
                            break;
                    }
                }
            };
            return true;
        }
    }
}
