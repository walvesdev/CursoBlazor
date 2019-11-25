using System;
using System.Collections.Generic;
using System.Text;

namespace CursoBlazor.Shared.Entidades
{
    public class Filme
    {
        public string Titulo { get; set; }
        public DateTime Lancamento { get; set; }
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

    }
}
