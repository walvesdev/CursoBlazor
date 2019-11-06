using CursoBlazor.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBlazor.Client.Repositorios
{
    public interface IRepositorio
    {
        List<Filme> GetAllFilmes();
    }
}
