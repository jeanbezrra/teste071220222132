using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {
        public bool Cadastrar(int naturalidade, int nacionalidade, string nome, DateTime datanascimento, bool genero, string cpf, string email, string telefone, string telefoneContato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf)
        {
            var repositorio = new FuncionarioRepository();

            var resposta = repositorio.Iserir(naturalidade, nacionalidade, nome, datanascimento, genero, cpf, email, telefone, telefoneContato, cep, logradouro, numero, complemento, bairro, municipio, uf);

            return resposta;
        }
        public List<FuncionarioEntity> ObterTodosFuncionarios()
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterTodosFuncionarios();
            return (List<FuncionarioEntity>)resposta;
        }
    }
}
