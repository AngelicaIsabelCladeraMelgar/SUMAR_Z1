using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class sumaController : ControllerBase
    {
        [HttpGet]
        //en el buscador se pone: /api/suma?a=4&b=6
        //4 y 6 son ejemplos, suma viene del nombre de la class "
        public int Add(int a, int b)
        {
            return a + b; 
        }
        [HttpPost]
        public int Add2([FromHeader] int a, [FromHeader] int b)
        {
            return a + b;
        }
    }
}
