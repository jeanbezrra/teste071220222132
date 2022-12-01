using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    /// <summary>
    /// Responsável pela conexão do banco de dados com o programa.
    /// </summary>
    public class FuncionarioRepository
    {
        /// <summary>
        /// Inseri um funcionario no banco de dados
        /// </summary>
        /// <param name="naturalidade"></param>
        /// <param name="nacionalidade"></param>
        /// <param name="nome"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="genero"></param>
        /// <param name="cpf"></param>
        /// <param name="email"></param>
        /// <param name="telefone"></param>
        /// <param name="telefoneContato"></param>
        /// <param name="cep"></param>
        /// <param name="logradouro"></param>
        /// <param name="numero"></param>
        /// <param name="complemento"></param>
        /// <param name="bairro"></param>
        /// <param name="municipio"></param>
        /// <param name="uf"></param>
        /// <returns>Retorna a requisição feita de inserir um novo funcionário pelos dados parametrizados</returns>
        public bool Iserir(int naturalidade, int nacionalidade, string nome, DateTime dataNascimento, bool genero, string cpf, string email, string telefone, string telefoneContato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf)
        {
            var dataConvertida = dataNascimento.ToString("yyyy-MM-dd");

            var sql = $"INSERT INTO funcionarios (id_naturalidades, id_nacionalidades, nome, data_nascimento, genero, cpf, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf) VALUES ('{naturalidade}', '{nacionalidade}', '{nome}', '{dataConvertida}', '{genero}', '{cpf}', '{email}', '{telefone}', '{telefoneContato}', '{cep}', '{logradouro}', '{numero}', '{complemento}', '{bairro}', '{municipio}', '{uf}')";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        /// <summary>
        /// Obtêm todos os funcionarios existentes no banco de dados.
        /// </summary>
        /// <returns>Retorna a requisição feita de obter todos os funcionários existentes</returns>
        public IEnumerable<FuncionarioEntity> ObterTodosFuncionarios()
        {
            var sql = "SELECT * FROM funcionarios";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Query<FuncionarioEntity>(sql);

            return resultado;
        }
        /// <summary>
        /// Remove um funcionário pelo id informado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a requisição feita de remover o funcionário pelo id</returns>
        public bool Remover(string id)
        {
            var sql = $"DELETE FROM funcionarios WHERE id = '{id}'";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
    }
}
