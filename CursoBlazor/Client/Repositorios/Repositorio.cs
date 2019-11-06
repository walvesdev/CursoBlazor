using CursoBlazor.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBlazor.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Filme> GetAllFilmes()
        {
            return new List<Filme>()
    {
                    new Filme(){Titulo = "Senhor dos Aneis",Lancamento = new DateTime(2009, 8, 2) },
                    new Filme(){Titulo = "Homem Aranha",Lancamento = new DateTime(2009, 8, 2) },
                    new Filme(){Titulo = "Marvel",Lancamento = new DateTime(2009, 8, 2) },
                    new Filme(){Titulo = "Ronin",Lancamento = new DateTime(2009, 8, 2) },
                    new Filme(){Titulo = "Ronin",Lancamento = new DateTime(2009, 8, 2) },
                    new Filme(){Titulo = "Ronin",Lancamento = new DateTime(2009, 8, 2) },
                    new Filme(){Titulo = "Ronin",Lancamento = new DateTime(2009, 8, 2) },
                    new Filme(){Titulo = "007",Lancamento = new DateTime(2009, 8, 2) }

                };
        }
    }
}
