using CursoBlazor.Client.Helpers;
using CursoBlazor.Shared.Entidades;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBlazor.Client.Shared.FilmeComponents
{
    public partial class ListarFilmes
    {
        [Inject] public IJSRuntime js { get; set; }
        [Parameter] public List<Filme> Filmes { get; set; }
        [Parameter] public bool MostrarBotao { get; set; } = false;

        protected override void OnInitialized()
        {
            Console.WriteLine($"OnInitialized - Qtde. de Filmes: {Filmes.Count()}");
        }
        protected override void OnParametersSet()
        {
            Console.WriteLine($"OnParametersSet - Qtde. de Filmes: {Filmes.Count()}");
        }
        protected override void OnAfterRender(bool firstRender)
        {
            Console.WriteLine($"OnAfterRender: Executado pela 1ª vez? {firstRender}");
        }
        protected override bool ShouldRender()
        {
            Console.WriteLine($"ShouldRender");
            return true;
        }
        async Task ExcluirFilme(Filme filme)
        {
            var confirma = await js.Confirm($"Deseja Excluir o Filme {filme.Titulo}?");

            if (confirma)
            {
                Console.WriteLine($"Removendo FIlme: {filme.Titulo}");
                Filmes.Remove(filme);

            }
        }
    }
}
