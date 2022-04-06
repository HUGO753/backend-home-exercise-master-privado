using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UKParliament.CodeTest.Services;
using UKParliament.CodeTest.Services.Models;

namespace UKParliament.CodeTest.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        // GET id
        [HttpGet("{personId}")]
        public async Task<ActionResult<PersonInfo>> Get(int personId)
        {
            var iperson = await _personService.GetAsync(personId);
            return iperson;
        }
        // GET name
        [HttpGet("{personName}")]
        public async Task<ActionResult<PersonInfo>> Get(string personName)
        {
            var nperson = await _personService.GetName(personName);
            return nperson;
        }
        // GET birth
        [HttpGet("{personBirth}")]
        public async Task<ActionResult<PersonInfo>> Get(System.DateTime personBirth)
        {
            var bperson = await _personService.GetDate(personBirth);
            return bperson;
        }


    }
}
