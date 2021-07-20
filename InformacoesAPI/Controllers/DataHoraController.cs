using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace InformacoesAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class DataHoraController : ControllerBase
    {
        public string data = DateTime.Now.ToString("yyyy-MM-dd");
        public string hora = DateTime.Now.ToString("t");
        public List<string> info = new List<string>();
        
                   

        /// <summary>
        /// Informa data e hora.
        /// </summary>
        /// <returns></returns>
        [HttpGet]

        public ActionResult Get()
        {
            
            info.Add(data);
            info.Add(hora);
            return BadRequest(info);
        }

       
    }
}
