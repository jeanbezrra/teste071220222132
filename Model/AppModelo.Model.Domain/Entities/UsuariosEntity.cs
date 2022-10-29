﻿using System;

namespace AppModelo.Model.Domain.Entities
{
    public class UsuariosEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime UltimoLogin { get; set; }
    }
}
