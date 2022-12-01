using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NaturalidadeController
    {
        /// <summary>
        /// Valida a naturalidade antes de cadatrar.
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="status"></param>
        /// <returns>Retorna a requisição feita de validação ao cadastrar uma nova naturalidade</returns>
        public bool Cadastrar(string descricao, bool status)
        {
            var repositorio = new NaturalidadeRepository();

            var naturalidade = repositorio.ObterPorDescricao(descricao);
            if (naturalidade is not null) return false;

            var resposta = repositorio.Inserir(descricao, status);
            return resposta;
        }
        /// <summary>
        /// Atualiza a naturalidade.
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="id"></param>
        /// <returns>Retorna a requsisição feita para atualizar a naturalidade pela descrição e id</returns>
        public bool Atualizar(string descricao, string id)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Atualizar(descricao, id);
            return resposta;
        }
        /// <summary>
        /// Remove a naturalidade.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a requsisição feita para remover a naturalidade pelo id</returns>
        public bool Remover(string id)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Remover(id);
            return resposta;
        }
        /// <summary>
        /// Obtêm todas as naturalidades do banco de dados
        /// </summary>
        /// <returns>Retorna a requisição feita para a obter todas as naturalidades</returns>
        public List<NaturalidadeEntity> ObterTodasNaturalidades()
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NaturalidadeEntity>)resposta;
        }
    }
}
