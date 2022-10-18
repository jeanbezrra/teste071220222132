using AppModelo.Model.Domain.Entities;
using System.Collections.Generic;

namespace AppModelo.Model.Infra.Repositories
{
    public class NacionalidadeRepository
    {
        // insert (create) - select (read) - update (update) - delete (delete)
        public bool Inserir() { }
        public bool Atualizar() { }
        public bool Remover() { }
        public List<NacionalidadeEntity> ObterTodos() 
        {
            var sql = "SELECT * FROM nacionalidades";
        }
        public NacionalidadeEntity ObterPorId() { }
    }
}
