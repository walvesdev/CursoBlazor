using System;
using System.Collections.Generic;
using System.Text;

namespace CursoBlazor.Shared.Entidades
{
    public class VotoFilme
    {
        public int Id { get; set; }
        public int Voto { get; set; }
        public DateTime DataVoto { get; set; }
        public Filme Filme { get; set; }
        public int FilmeId { get; set; }


    }
}
