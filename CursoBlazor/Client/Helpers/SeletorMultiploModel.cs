using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBlazor.Client.Helpers
{
    public struct SeletorMultiploModel
    {
        public SeletorMultiploModel(string chave, string valor)
        {
            Chave = chave;
            Valor = valor;
        }

        public string Chave { get; set; }
        public string Valor { get; set; }
    }
}
