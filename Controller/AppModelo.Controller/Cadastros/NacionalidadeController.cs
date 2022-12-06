using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NacionalidadeController
    {
        /// <summary>
        /// Valida a nacionalidade antes de cadatrar.
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Retorna a requisição feita de validação ao cadastrar uma nova nacionalidade</returns>
        public bool Cadastrar(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Inserir(descricao);
            return resposta;
        }
        /// <summary>
        /// Atualiza a nacionalidade.
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="id"></param>
        /// <returns>Retorna a requsisição feita para atualizar a nacionalidade pela descrição e id</returns>
        public bool Atualizar(string descricao, string id)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Atualizar(descricao, id);
            return resposta;
        }
        /// <summary>
        /// Remove a nacionalidade.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a requsisição feita para remover a nacionalidade pelo id</returns>
        public bool Remover(string id)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Remover(id);
            return resposta;
        }
        /// <summary>
        /// Obtêm todas as nacionalidades.
        /// </summary>
        /// <returns>Retorna a requisição feita para a obter todas as nacionalidades</returns>
        public List<NacionalidadeEntity> ObterTodasNacionalidades()
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NacionalidadeEntity>)resposta;
        }
    }
}
