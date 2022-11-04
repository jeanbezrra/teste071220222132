using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Data;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace AppModelo.Model.Infra.Repositories
{
    public class FuncionarioRepository
    {
        public bool Iserir(string nome, DateTime datanascimento, bool genero, string cpf, string email, string telefone, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf)
        {
            //string interpolation $
            var sql = $"INSERT INTO funcionario (nome, data_nascimento, genero, cpf, email, telefone, cep, logradouro, numero, complemento, bairro, municipio, uf) VALUES ('{nome}', '{datanascimento}', '{genero}', '{cpf}', '{email}', '{telefone}', '{cep}', '{logradouro}', '{numero}', '{complemento}', '{bairro}', '{municipio}', '{uf}')";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
    }
}
