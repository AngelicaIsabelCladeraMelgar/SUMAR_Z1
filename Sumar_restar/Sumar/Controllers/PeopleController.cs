using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sumar.Models;

namespace Sumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet]
        public Person Listar()
        {
            Person person = new Person()
            {
                PersonId = 1,
                //pusimoa solo ',' por es una simplificacion 
                Name = "Isabel Cladera"
                //Esto lo vuelve en formato Json
                //Un objeto en este formato esta entre {}
            };
            return person;
        }
    }
}
