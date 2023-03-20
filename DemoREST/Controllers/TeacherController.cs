using DemoREST.Models;
using DemoREST.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DemoREST.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly TeacherRepository repo = new TeacherRepository();

        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return repo.GetAll();
        }

        // GET api/<TeacherController>/5
        /*[HttpGet("{id}")]
        public Teacher Get(int id)
        {
            return repo.GetById(id);
        }

        // POST api/<TeacherController>
        /*[HttpPost]
        public Teacher Post([FromBody] Teacher value)
        {
            return repo.Add(value);
        }*/

        // DELETE api/<TeacherController>/5
        /*[HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/

        // PUT api/<TeacherController>/5
        /*[HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }*/
    }
}
