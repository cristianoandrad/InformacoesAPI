using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacoesAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private string usuario = "admin";
        private string senha = "admin";
        private string info;
             
                
        /// <summary>
        /// Informe Usuario "admin" e Senha "admin" 
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        [HttpPost]

        public ActionResult Post(string usuario, string senha)
        {
            info = (usuario == "admin" && senha == "admin" ? "Seja bem vindo!" : "Usuario e senha inválidos.");           
            return Ok(info);
        }

    }
}
