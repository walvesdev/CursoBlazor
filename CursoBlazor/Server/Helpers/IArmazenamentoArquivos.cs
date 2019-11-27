using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBlazor.Server.Helpers
{
    public interface IArmazenamentoArquivos
    {
        Task<string> EditarArquivo(byte[] conteudo, string extensao, string nomePasta, string rotaArquivoAtual);
        Task ApagarArquivo(string rota, string nomePasta);
        Task<string> SalvarArquivo(byte[] conteudo, string extensao, string nomePasta);
    }
}
