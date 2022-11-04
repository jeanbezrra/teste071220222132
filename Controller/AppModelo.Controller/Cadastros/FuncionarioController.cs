using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;

namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {
        public bool Cadastrar(string nome, string datanascimento, bool genero, string cpf, string email, string telefone, string telefoneContato, string cep, string logradouro, string numero, string complemento, string bairro, string municipio, string uf)
        {
            var repositorio = new FuncionarioRepository();

            var resposta = repositorio.Iserir(nome, datanascimento, genero, cpf, email, telefone, telefoneContato, cep, logradouro, numero, complemento, bairro, municipio, uf);

            return resposta;
        }
    }
}
