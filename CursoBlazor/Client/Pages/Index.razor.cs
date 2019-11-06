using CursoBlazor.Client.Repositorios;
using CursoBlazor.Shared.Entidades;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBlazor.Client.Pages
{
    public partial class Index
    {
        [Inject] protected IRepositorio Repositorio {get; set;}
        public List<Filme> Filmes { get; set; }

        protected override void OnInitialized()
        {
            GetAllFilmes();
        }

        private List<Filme> GetAllFilmes()
        {
            return Filmes = Repositorio.GetAllFilmes();
        }

    }
}
