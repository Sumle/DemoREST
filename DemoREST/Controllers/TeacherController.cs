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
        public Book Post([FromBody] Book value)
        {
            return _manager.Add(value);
        }*/

        // DELETE api/<BooksController>/5
        /*[HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/

        // PUT api/<BooksController>/5
        /*[HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }*/
    }
}
