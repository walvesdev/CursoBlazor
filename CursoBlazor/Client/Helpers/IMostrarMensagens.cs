﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBlazor.Client.Helpers
{
    public interface IMostrarMensagens
    {
        Task MostrarMensagemErro(string msg);
    }
}
