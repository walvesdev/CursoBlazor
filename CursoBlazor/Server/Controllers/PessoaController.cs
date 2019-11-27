using CursoBlazor.Server.Dados;
using CursoBlazor.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public PessoaController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Pessoa pessoa)
        {
            context.Add(pessoa);
            await context.SaveChangesAsync();

            return pessoa.Id;
        }

    }
}
