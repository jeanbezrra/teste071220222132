using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace AppModelo.Model.Infra.Repositories
{
    public class FuncionarioRepository
    {
        public bool Iserir(string nome, string datanascimento, bool genero, string cpf, string email, string telefone,string telefoneContato, string cep, string logradouro, string numero, string complemento, string bairro, string municipio, string uf)
        {
            //string interpolation $
            var sql = $"INSERT INTO funcionarios (nome, data_nascimento, genero, cpf, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf) VALUES ('{nome}', '{datanascimento}', '{genero}', '{cpf}', '{email}', '{telefone}', '{cep}', '{logradouro}', '{numero}', '{complemento}', '{bairro}', '{municipio}', '{uf}')";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
    }
}
