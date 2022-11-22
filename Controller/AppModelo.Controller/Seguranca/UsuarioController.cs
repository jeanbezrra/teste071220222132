using AppModelo.Model.Infra.Repositories;
using AppModelo.Model.Infra.Services;
using System;

namespace AppModelo.Controller.Seguranca
{
    public class UsuarioController
    {
        public bool EfetuarLogin(string usuario, string senha)
        {
            var repositorio = new UsuarioRepository();
            var usuarioEncontrado = repositorio.Obter(usuario, senha);

            if (usuarioEncontrado is not null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string RecuperarSenha(string email)
        {
            var repository = new UsuarioRepository();
            var usuario = repository.ObterPorEmail(email);
            if(usuario is null)
            {
                return "Usuário não foi encontrado";
            }

            var novaSenha = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            var atualizouSenha = repository.AtualizarSenha(email, novaSenha);
            if(atualizouSenha is false)
            {
                return "Programador errou sql e vc nao pode recuperar sua senha";
            }

            var emailService = new EmailService();
            var mensagemHtml = @"<p><b>Criamos uma nova senha para você</b></p> <pSua nova senha é: <b>" + novaSenha + "</b>/p>";
            var emailEnviado = emailService.EnviarEmail(usuario.Nome, usuario.Email, "Recuperação de senha", mensagemHtml);
            return "";
        }
    }
}
