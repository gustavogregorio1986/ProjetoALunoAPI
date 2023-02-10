using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoALunoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
       [HttpPost]
       public ActionResult Cadastrar()
       {

            return new JsonResult("");
       }
    }
}
