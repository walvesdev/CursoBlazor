using CursoBlazor.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CursoBlazor.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {

        private readonly HttpClient httpClient;

        public Repositorio(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        private JsonSerializerOptions OpcoesPadraoJSON =>
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);

            if (responseHTTP.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuest<T>(responseHTTP, OpcoesPadraoJSON);
                return new HttpResponseWrapper<T>(response, false, responseHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, responseHTTP);
            }
        }

        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PutAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuest<TResponse>(responseHttp, OpcoesPadraoJSON);
                return new HttpResponseWrapper<TResponse>(response, false, responseHttp);
            }
            else
            {
                return new HttpResponseWrapper<TResponse>(default, true, responseHttp);
            }
        }

        public async Task<HttpResponseWrapper<object>> Delete(string url)
        {
            var responseHTTP = await httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(null, !responseHTTP.IsSuccessStatusCode, responseHTTP);
        }

        private async Task<T> DeserializarRespuest<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        }

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
