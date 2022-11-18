namespace AppModelo.View.Windows.Helpers
{
    /// <summary>
    /// Classe para verificação de existência de numeros no texto.
    /// </summary>
    internal static partial class Componentes
    {
        /// <summary>
        /// Método para verificar se existe numeros em textos formatados, Se não existir número ele retorna "false", caso haja retorna "true".
        /// </summary>
        /// <param name="texto"></param>
        internal static bool ExisteNumeroNoTexto(string texto)
        {
            foreach (var letra in texto)
            {
                if (char.IsNumber(letra))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
