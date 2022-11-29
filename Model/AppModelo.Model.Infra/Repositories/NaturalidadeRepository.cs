using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    /// <summary>
    /// Responsavel pela conexão do banco de dados com o programa.
    /// </summary>
    public class NaturalidadeRepository
    {
        /// <summary>
        /// Inseri uma naturalidade no banco de dados.
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="status"></param>
        /// <returns>Retorna a requisição feita de inserir a naturalidade pela descrição e seu status</returns>
        public bool Inserir(string descricao, bool status)
        {
            var agora = DateTime.Now.ToString("u");

            var sql = $"INSERT INTO naturalidades (descricao, dataCriacao, dataAlteracao, ativo) VALUES ('{descricao}', '{agora}', '{agora}', {status})";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        /// <summary>
        /// Atualiza uma naturalidade existente no banco de dados pelo id.
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="id"></param>
        /// <returns>Retorna a requisição feita de atualizar a descrição pelo id</returns>
        public bool Atualizar(string descricao, string id)
        {
            //var dataAlterada = DateTime.Now.ToString("u");

            var sql = $"UPDATE naturalidades SET descricao = '{descricao}' WHERE id = '{id}'";
            
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        /// <summary>
        /// Remove uma naturalidade existente no banco de dados pelo id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a requisição feita de deletar a naturalidade pelo id</returns>
        public bool Remover(string id)
        {
            var sql = $"DELETE FROM naturalidades WHERE id = '{id}'";
            
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        /// <summary>
        /// Obtêm todas naturalidades existentes no banco de dados.
        /// </summary>
        /// <returns>Retorna a requisição feita de Obter a naturalidade e todos os seus campos</returns>
        public IEnumerable<NaturalidadeEntity> ObterTodos()
        {
            var sql = "SELECT * FROM naturalidades";
            
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;
        }
        /// <summary>
        /// Obtêm a naturalidade pela descrição.
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Retorna a requisição feita de Obter a naturalidade pelo campo de descrição</returns>
        public NaturalidadeEntity ObterPorDescricao(string descricao)
        {
            var sql = $"SELECT id, descricao FROM naturalidades WHERE descricao = '{descricao}' ";
            
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.QuerySingleOrDefault<NaturalidadeEntity>(sql);
            
            return resultado;
        }
    }
}
