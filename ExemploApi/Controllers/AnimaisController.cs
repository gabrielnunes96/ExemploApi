using ExemploApi.Controllers.Modelos;
using ExemploApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExemploApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimaisController : ControllerBase
    {
        public AnimaisController()
        {
        }

        [HttpGet(Name = "Animais")]

        public List<Gato> Animais()
        {
            BuscaAnimais xpto = new BuscaAnimais();
            return xpto.busca().ToList();
        }

    }
}
