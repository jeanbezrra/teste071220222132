namespace AppModelo.Model.Infra.Databases
{
    public static class MySql
    {
        /// <summary>
        /// String de conexão com o banco de dados.
        /// </summary>
        /// <returns>Retorna a requisição de conexão com o banco de dados</returns>
        public static string ConectionString()
        {
            var conn = "server=mysql.wwonline.com.br;database=wwonline05;uid=wwonline05;password=aluno22senai;Convert Zero Datetime=True;";
            return conn;
        }
    }
}
