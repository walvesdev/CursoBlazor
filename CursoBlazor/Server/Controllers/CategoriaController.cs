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
    public class CategoriaController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CategoriaController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Categoria categoria)
        {
            context.Add(categoria);
            await context.SaveChangesAsync();

            return categoria.Id;
        }

    }
}
