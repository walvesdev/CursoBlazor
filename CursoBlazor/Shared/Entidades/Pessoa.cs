using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CursoBlazor.Shared.Entidades
{
    public class Pessoa
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="O Campo {0} Precisa Ser Preenchido")]
        public string Nome { get; set; }
        public string Biografia { get; set; }
        public string Foto { get; set; }
        [Required(ErrorMessage = "O Campo {0} Precisa Ser Preenchido")]
        public DateTime? DataNascimento { get; set; }
    }
}
