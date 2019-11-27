using System;
using System.Collections.Generic;
using System.Text;

namespace CursoBlazor.Shared.Entidades
{
    public class FilmePessoa
    {
        public int FilmeId { get; set; }
        public Filme Fime { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public string Personagem { get; set; }
        public int Ordem { get; set; }
    }
}
