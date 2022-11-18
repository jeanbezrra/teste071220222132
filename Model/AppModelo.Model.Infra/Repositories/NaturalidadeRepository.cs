using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class NaturalidadeRepository
    {
        // insert (create) - select (read) - update (update) - delete (delete)
        public bool Inserir(string descricao, bool status)
        {
            var agora = DateTime.Now.ToString("u");

            //string interpolation $
            var sql = $"INSERT INTO naturalidades (descricao, dataCriacao, dataAlteracao, ativo) VALUES ('{descricao}', '{agora}', '{agora}', {status})";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        public bool Atualizar(string descricao, string id)
        {
            var sql = $"UPDATE naturalidades SET descricao = '{descricao}' WHERE id = '{id}'";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        public bool Remover(string id)
        {
            var sql = $"DELETE FROM naturalidades WHERE id = '{id}'";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        public IEnumerable<NaturalidadeEntity> ObterTodos()
        {
            var sql = "SELECT id, descricao FROM naturalidades";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            //todo comando select usa-se .Query<>
            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;
        }
        public IEnumerable<NaturalidadeEntity> ObterTodosAtivos()
        {
            var sql = "SELECT id, descricao FROM naturalidades ativo = true";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            //todo comando select usa-se .Query<>
            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;
        }
        public NaturalidadeEntity ObterPorId()
        {
            return new NaturalidadeEntity();
        }
        public NaturalidadeEntity ObterPorDescricao(string descricao)
        {
            var sql = $"SELECT id, descricao FROM naturalidades WHERE descricao = '{descricao}' ";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            //todo comando select usa-se .Query<>
            var resultado = conexaoBd.QuerySingleOrDefault<NaturalidadeEntity>(sql);
            //QuerySingleOrDefault retorna uma dado da tabela / Query retorna todos os dados da tabela selecionada
            return resultado;
        }
    }
}
