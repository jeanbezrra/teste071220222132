using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {
        /// <summary>
        /// Cadastra o funcioário no banco de dados.
        /// </summary>
        /// <param name="naturalidade"></param>
        /// <param name="nacionalidade"></param>
        /// <param name="nome"></param>
        /// <param name="datanascimento"></param>
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
        /// <returns>Retorna a requisição feita para inserir os dados do funcionário</returns>
        public bool Cadastrar(int naturalidade, int nacionalidade, string nome, DateTime datanascimento, bool genero, string cpf, string email, string telefone, string telefoneContato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Iserir(naturalidade, nacionalidade, nome, datanascimento, genero, cpf, email, telefone, telefoneContato, cep, logradouro, numero, complemento, bairro, municipio, uf);
            return resposta;
        }
        /// <summary>
        /// Obtêm todos os funcionários cadastrados no banco de dados.
        /// </summary>
        /// <returns>Retorna a requisição feita para listar todos os funcionários existentes no banco de dados</returns>
        public List<FuncionarioEntity> ObterTodosFuncionarios()
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterTodosFuncionarios();
            return (List<FuncionarioEntity>)resposta;
        }
        /// <summary>
        /// Remove o funcionário digitado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a requsição feita para remover o funcionário pelo id</returns>
        public bool Remover(string id)
        {
            var repositorio = new FuncionarioRepository();
            var resposta= repositorio.Remover(id);
            return resposta;
        }
    }
}
