using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBlazor.Client.Helpers
{
    public class MostrarMensagens : IMostrarMensagens
    {
        public async Task MostrarMensagemErro(string msg)
        {
            await Task.FromResult(0);
        }
    }
}
