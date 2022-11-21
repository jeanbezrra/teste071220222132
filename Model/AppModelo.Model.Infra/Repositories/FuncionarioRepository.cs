using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class FuncionarioRepository
    {
        public bool Iserir(int naturalidade, int nacionalidade, string nome, DateTime dataNascimento, bool genero, string cpf, string email, string telefone, string telefoneContato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf)
        {
            var dataConvertida = dataNascimento.ToString("yyyy-MM-dd");
            //string interpolation $
            var sql = $"INSERT INTO funcionarios (id_naturalidades, id_nacionalidades, nome, data_nascimento, genero, cpf, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf) VALUES ('{naturalidade}', '{nacionalidade}', '{nome}', '{dataConvertida}', '{genero}', '{cpf}', '{email}', '{telefone}', '{telefoneContato}', '{cep}', '{logradouro}', '{numero}', '{complemento}', '{bairro}', '{municipio}', '{uf}')";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        public IEnumerable<FuncionarioEntity> ObterTodosFuncionarios()
        {
            var sql = "SELECT * FROM funcionarios";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            //todo comando select usa-se .Query<>
            var resultado = conexaoBd.Query<FuncionarioEntity>(sql);

            return resultado;
        }
    }
}
