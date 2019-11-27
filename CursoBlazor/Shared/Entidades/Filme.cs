using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CursoBlazor.Shared.Entidades
{
    public class Filme
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Campo {0} Precisa Ser Preenchido")]
        public string Titulo { get; set; }
        public string Resumo { get; set; }
        public bool EmCartaz { get; set; }
        public string Trailer { get; set; }
        [Required(ErrorMessage = "O Campo {0} Precisa Ser Preenchido")]
        public DateTime? DataLancamento { get; set; }
        public string Imagem { get; set; }
        public string TituloResumido
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Titulo))
                {
                    return null;
                }
                else if (Titulo.Length > 15)
                {
                    return Titulo.Substring(0, 15) + "...";
                }
                else
                {
                    return Titulo;
                }
            }
        }
        public List<CategoriaFilme> CategoriaFilme { get; set; } = new List<CategoriaFilme>();
        public List<FilmePessoa> FilmePessoas { get; set; } = new List<FilmePessoa>();


    }
}
