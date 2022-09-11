using Microsoft.AspNetCore.Mvc;
using quiz_backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace quiz_backend.Controllers
{
    [Produces("application/json")]
    [Route("api/Teacher")]
    public class TeacherController : Controller
    {
        private readonly QuizContext _context;

        public TeacherController(QuizContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostTeacher([FromBody] Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _context.Teacher.Add(teacher);
            await _context.SaveChangesAsync();

            return Ok(teacher);

        }
        [HttpGet("all")]
        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _context.Teacher;
        }

    }


}
