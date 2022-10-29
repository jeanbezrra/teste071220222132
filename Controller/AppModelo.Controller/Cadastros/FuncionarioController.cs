using AppModelo.Model.Infra.Repositories;

namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {
        public bool Cadastrar()
        {
            var repositorio = new FuncionarioRepository();

            var funcionrio = repositorio.Iserir();
            
        }
    }
}
