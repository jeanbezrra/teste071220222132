using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class FuncionarioRepository
    {
        public bool Iserir(int nacionalidade, int naturalidade, string nome, DateTime datanascimento, bool genero, string cpf, string email, string telefone,string telefoneContato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf)
        {
            //string interpolation $
            var sql = $"INSERT INTO funcionarios (id_nacionalidades, id_naturalidades, nome, data_nascimento, genero, cpf, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf) VALUES ('{nacionalidade}', '{naturalidade}', '{nome}', '{datanascimento}', '{genero}', '{cpf}', '{email}', '{telefone}', '{telefoneContato}', '{cep}', '{logradouro}', '{numero}', '{complemento}', '{bairro}', '{municipio}', '{uf}')";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
    }
}
