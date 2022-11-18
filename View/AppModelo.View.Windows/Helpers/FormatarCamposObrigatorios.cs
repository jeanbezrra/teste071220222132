using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Helpers
{
    /// <summary>
    /// Classe para formatação de campos obrigatórios.
    /// </summary>
    internal static partial class Componentes
    {
        /// <summary>
        /// Método que valida campos TextBox, ComboBox e MaskedTextBox de acordo com a tag "Obrigatório" definida nas propriedades 
        /// de cada um. Em qualquer formulário que use essa classe e tenha definida sua tag como "Obrigatório" nos campos de 
        /// citados anteriormente é feita a formatação e adicionado a propriedade "BackColor" com a cor "LightGoldenrodYellow".
        /// </summary>
        /// <param name="frm"></param>
        internal static void FormatarCamposObrigatorios(Form frm)
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
                                if (box.Tag == "Obrigatorio")
                                {
                                    box.BackColor = Color.LightGoldenrodYellow;
                                }
                                break;
                            }
                        case ComboBox box:
                            {
                                if (box.Tag == "Obrigatorio")
                                {
                                    box.BackColor = Color.LightGoldenrodYellow;
                                }
                                break;
                            }
                        case MaskedTextBox box:
                            {
                                if (box.Tag == "Obrigatorio")
                                {
                                    box.BackColor = Color.LightGoldenrodYellow;
                                }
                                break;
                            }
                        default:
                            func(control.Controls);
                            break;
                    }
                }
            };
            func(frm.Controls);
        }
    }
}
