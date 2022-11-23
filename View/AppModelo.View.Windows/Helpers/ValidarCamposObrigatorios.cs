using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Helpers
{
    internal static partial class Componentes
    {
        internal static bool ValidarCamposObrigatorios(string nome, string data, string cpf, string email, string telefone, int numero)
        {          
            if (String.IsNullOrEmpty(nome)) { return true; }

            if (String.IsNullOrEmpty(data)) { return true; }

            if (String.IsNullOrEmpty(cpf)) { return true; }

            if (String.IsNullOrEmpty(email)) { return true; }

            if (String.IsNullOrEmpty(telefone)) { return true; }

            if (String.IsNullOrEmpty(numero.ToString())) { return true; }

            return false;
        }   
    }
}
