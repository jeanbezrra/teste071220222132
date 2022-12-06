using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    /// <summary>
    /// Conexão do usuarios com o banco de dados .
    /// </summary>
    public class UsuarioRepository
    {
        /// <summary>
        /// Verifica se o usuário existe no banco de dados por meio email e senha.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        /// <returns>Retorna a requisição feita de obter o usuario pelo email e senha</returns>
        public UsuariosEntity Obter(string usuario, string senha)
        {
            var sql = $"SELECT email, senha FROM usuarios WHERE email = '{usuario}' AND senha = '{senha}';";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.QuerySingleOrDefault<UsuariosEntity>(sql);

            return resultado;
        }
        /// <summary>
        /// Verifica se o email do usuário existe no banco de dados.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Retorna a requisição feita de obter o usuário pelo seu email</returns>
        public UsuariosEntity ObterPorEmail(string email)
        {
            var sql = $"SELECT email, nome FROM usuarios WHERE email = '{email}'";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.QuerySingleOrDefault<UsuariosEntity>(sql);

            return resultado;
        }
        /// <summary>
        /// Atualiza a senha do usuário no banco de dados através do email cadastrado.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="novaSenha"></param>
        /// <returns>Retorna a requisição feita de atualizar a senha do usuário pelo email</returns>
        public bool AtualizarSenha(string email, string novaSenha)
        {
            var sql = $"UPDATE usuarios SET senha = '{novaSenha}' WHERE email = '{email}'; ";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
    }
}
