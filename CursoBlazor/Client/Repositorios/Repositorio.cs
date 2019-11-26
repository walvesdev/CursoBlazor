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
                    new Filme(){Titulo = "Senhor dos Anéis",DataLancamento = new DateTime(2002, 12, 27), Imagem = "img/sanel.jpg" },
                    new Filme(){Titulo = "Homem Aranha",DataLancamento = new DateTime(2002, 5, 17) , Imagem = "img/homenaranha.jpg"},
                    new Filme(){Titulo = "Vingadores: Guerra Infinita",DataLancamento = new DateTime(2018, 4, 26) , Imagem = "img/guerrainfinita.jpg"},
                    new Filme(){Titulo = "O Homem de Aço",DataLancamento = new DateTime(2013, 6, 12), Imagem = "img/o-homem-de-aco.jpg" },
                    new Filme(){Titulo = "47 Ronins",DataLancamento = new DateTime(2014, 1, 31) , Imagem = "img/47-ronins.jpg"},
                    new Filme(){Titulo = "Hannibal",DataLancamento = new DateTime(2013, 4, 4) , Imagem = "img/hannibal.jpg"},
                    new Filme(){Titulo = "Hitman: Agente 47",DataLancamento = new DateTime(2015, 8, 27) , Imagem = "img/hitiman47.jpg"},
                    new Filme(){Titulo = "GoldenEye 007",DataLancamento = new DateTime(1995, 12, 15) , Imagem = "img/GoldenEye007.jpg"},
                    new Filme(){Titulo = "Rambo 4",DataLancamento = new DateTime(2019, 9, 19) , Imagem = "img/rambo.jpg"}

                };
        }
    }
}
