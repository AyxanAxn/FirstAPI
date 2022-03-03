using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        [HttpGet("get-all-users")]
        public IActionResult GetAllUsers() {
            List<string> people = new List<string>() {
                "Ayxan","Murad","Zaur","Senan"
            };
            return Ok(people);
        }

        [HttpPost("create-json")]
        public async Task<IActionResult> CreatePerson(Person person, [FromHeader] string token) {
            return Ok("new person added");
        }


        [HttpGet]
        public async Task<IActionResult> BadRequestResult() {
            return BadRequest();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age{ get; set; }
        public string Fullname { get; set; }

    }
}