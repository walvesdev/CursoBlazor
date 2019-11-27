using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CursoBlazor.Shared.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} precisa ser preenchido!")]
        public string Nome { get; set; }
        public List<CategoriaFilme> CategoriaFilme { get; set; } = new List<CategoriaFilme>();
    }
}
