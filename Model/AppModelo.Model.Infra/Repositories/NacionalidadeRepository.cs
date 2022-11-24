using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    /// <summary>
    /// Responsavel pela conexão do banco de dados com o programa.
    /// </summary>
    public class NacionalidadeRepository
    {
        /// <summary>
        /// Inseri uma nacionalidade no banco de dados pela sua descrição.
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Retorna a requisição feita de inserir a nacionalidades pela descrição</returns>
        public bool Inserir(string descricao)
        {
            var sql = $"INSERT INTO nacionalidades (descricao) VALUES ('{descricao}')";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        /// <summary>
        /// Remove uma nacionalidade existente no banco de dados pelo seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a requisição de deletar a nacionalidade pelo id</returns>
        public bool Remover(string id) 
        {
            var sql = $"DELETE FROM nacionalidades WHERE id = '{id}'";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        /// <summary>
        /// Atualiza a nacionalidade existente no banco de dados pelo seu id.
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="id"></param>
        /// <returns>Retorna a requisição feita de atualizar a descrição pelo id</returns>
        public bool Atualizar(string descricao, string id)
        {
            var sql = $"UPDATE nacionalidades SET descricao = '{descricao}' WHERE id = '{id}'";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        /// <summary>
        /// Obtêm todas nacionalidades existentes no banco de dados.
        /// </summary>
        /// <returns>Retorna a requisição feita de selecionar todos os dados existentes no banco referente a nacionalidade</returns>
        public IEnumerable<NacionalidadeEntity> ObterTodos()
        {
            var sql = "SELECT * FROM nacionalidades";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Query<NacionalidadeEntity>(sql);

            return resultado;
        }
    }
}
