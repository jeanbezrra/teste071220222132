using System;

namespace AppModelo.Model.Domain.Entities
{
    public class FuncionarioEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Genero { get; set; }
        public DateTime DataNascimento{ get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string TelefoneContato { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }

    }
}
