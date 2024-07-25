using Microsoft.AspNetCore.Mvc;
using Student;
 

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SudentsController : ControllerBase
    {
        static List<StudentClass> students = new List<StudentClass>();
        // GET: api/<SudentsController>
        [HttpGet]
        public IEnumerable<StudentClass> Get()
        {
            return students;
        }

        // GET api/<SudentsController>/5
        [HttpGet("{id}")]
        public StudentClass Get(int id)
        {
            return students.FirstOrDefault(s => s.Student_id == id);
        }

        // POST api/<SudentsController>
        [HttpPost]
        public void Post([FromBody] StudentClass value)
        {
            students.Add(value);
        }

        // PUT api/<SudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StudentClass value)
        {
            students.FindIndex(s => s.Student_id == id);
        }

        // DELETE api/<SudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            students.RemoveAll(s => s.Student_id == id);
        }
    }
}
