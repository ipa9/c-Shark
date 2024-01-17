using Microsoft.AspNetCore.Mvc;
using PersonManagementWebApi.Data;
using PersonManagementWebApi.Model;

namespace PersonManagementWebApi.Controllers
{
    [ApiController]
    [Route("Api/Persons")]
    public class PersonsController : ControllerBase
    {
        private readonly PersonManagementWebApiDbContext _dbContext;

        public PersonsController(PersonManagementWebApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult AddPerson([FromBody] Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _dbContext.Persons.Add(person);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpGet("Persons")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetPersons()
        {
            var persons = _dbContext.Persons.ToList();
            return Ok(persons);
        }

        [HttpGet("Person/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPersonById(int id)
        {
            var person = _dbContext.Persons.Find(id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }
        [HttpPut("Person/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePerson(int id, [FromBody] Person updatedPerson)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var existingPerson = _dbContext.Persons.Find(id);
            if (existingPerson == null)
            {
                return NotFound();
            }
            existingPerson.Name = updatedPerson.Name;
            existingPerson.Email = updatedPerson.Email;
            existingPerson.PhoneNumber = updatedPerson.PhoneNumber;
            existingPerson.DateOfBirth = updatedPerson.DateOfBirth;

            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete("Person/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeletePerson(int id)
        {
            var person = _dbContext.Persons.Find(id);
            if (person == null)
            {
                return NotFound();
            }

            _dbContext.Persons.Remove(person);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpGet("Persons/find/email/{email}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult FindPersonsByEmail(string email)
        {
            var person = _dbContext.Persons.FirstOrDefault(p => p.Email == email);
            if (person == null)
            {
                return NotFound();
            }
            return Ok();
        }



    }
}
