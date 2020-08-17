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
    public class SumaController : ControllerBase
    {
        [HttpGet]
        [Route("Add")]//Para que el postman sepa que Get mostrar
        //en el buscador se pone: /api/suma?a=4&b=6
        //4 y 6 son ejemplos, suma viene del nombre de la class "
        public int Add(int a, int b)
        {
            return a + b; 
        }
        [HttpPost]
        [Route("Add")]
        public int Add2([FromHeader] int a, [FromHeader] int b)
        {
            return a + b+1;
        }
        [HttpGet]
        [Route("Multiply")]
        public int Mul(int a, int b)
        {
            
            return a * b;
        }
        [HttpPost]
        [Route("Multiply")]
        //Get y Post son dos rutas diferentes no son iguales 
        //una cosa es la rutamiento y otra cosa es la funcion
        public int Mul2([FromHeader] int a, [FromHeader] int b)
        {
            return a * b;
        }
    }
}
