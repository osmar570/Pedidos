using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosExercicio.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DateBirth { get; set; }

        public Cliente() { }

        public Cliente (string nome, string email, DateTime dateBirth)
        {
            Nome = nome;
            Email = email;
            DateBirth = dateBirth;
        }
    }
}
