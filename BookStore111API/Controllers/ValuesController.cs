using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore111API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]

        public IEnumerable<string> Get()
        {
            return new string[] { "Value 1", "Value 2", "Value 3", "value 7" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "The Value is " + id;
        }
    }
}
