using System;
using System.Collections.Generic;
using System.Text;

namespace CursoBlazor.Shared.Entidades
{
    public class CategoriaFilme
    {
        public Filme Filme { get; set; }
        public int FilmeId { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}
