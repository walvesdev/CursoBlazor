using CursoBlazor.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBlazor.Client.Repositorios
{
    public interface IRepositorio
    {
        Task<HttpResponseWrapper<object>> Delete(string url);
        List<Filme> GetAllFilmes();
        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar);
    }
}
