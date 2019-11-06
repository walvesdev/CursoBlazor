using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoBlazor.Shared.Entidades;

namespace CursoBlazor.Client.Shared.FilmeComponents
{
    public partial class FilmeIndividual
    {
        [Parameter] public Filme Filme { get; set; }
        [Parameter] public bool MostrarBotao { get; set; } = false;
        [Parameter] public EventCallback<Filme> ExcluirFilme { get; set; }
    }
}
