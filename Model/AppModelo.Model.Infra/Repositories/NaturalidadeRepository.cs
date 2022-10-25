using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class NaturalidadeRepository
    {
        // insert (create) - select (read) - update (update) - delete (delete)
        public bool Inserir(string descricao)
        {
            var dataCriacao = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
            var dataAlteracao = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");

            //string interpolation $
            var sql = $"INSERT INTO naturalidades (descricao, dataCriacao, dataAlteracao) VALUES ('{descricao}', '{dataCriacao}', '{dataAlteracao}')";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        public bool Atualizar()
        {
            return false;
        }
        public bool Remover()
        {
            return false;
        }
        public IEnumerable<NaturalidadeEntity> ObterTodos()
        {
            var sql = "SELECT id, descricao FROM naturalidades ORDER BY descricao DESC";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            //todo comando select usa-se .Query<>
            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;
        }
        public IEnumerable<NaturalidadeEntity> ObterTodosAtivos()
        {
            var sql = "SELECT id, descricao FROM naturalidades ORDER BY descricao DESC WHERE ativo = true";

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
