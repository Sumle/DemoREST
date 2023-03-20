using DemoREST.Models;

namespace DemoREST.Repositories
{
    public class TeacherRepository
    {
        private static List<Teacher> data = new List<Teacher>()
        {
            new Teacher() {Id = 1, Name = "John"},
            new Teacher() {Id = 2, Name = "Silke"}
        };

        public List<Teacher> GetAll()
        {
            return new List<Teacher> (data);
        }
    }
}
