﻿using AppModelo.Model.Domain.Entities;
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
            var sql = "SELECT * FROM naturalidades";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            //todo comando select usa-se .Query<>
            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;
        }
        public NaturalidadeEntity ObterPorId()
        {
            return new NaturalidadeEntity();
        }
    }
}
