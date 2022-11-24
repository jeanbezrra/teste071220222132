using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NacionalidadeController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns></returns>
        public bool Cadastrar(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Inserir(descricao);
            return resposta;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Atualizar(string descricao, string id)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Atualizar(descricao, id);
            return resposta;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Remover(string id)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Remover(id);
            return resposta;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<NacionalidadeEntity> ObterTodasNacionalidades()
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NacionalidadeEntity>)resposta;
        }
    }
}
