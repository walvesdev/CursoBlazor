
function TesteJavaScript() {
    DotNet.invokeMethodAsync("CursoBlazor.Client", "TesteJavaScript").then(resultado => {
        console.log("Conteudo C# " + resultado);
    });
}

function TesteJavaScriptMetodoInstancia(dotNetObjectReference) {
    dotNetObjectReference.invokeMethodAsync("IncrementCount");
}