using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using quiz_backend.Models;

namespace quiz_backend.Controllers
{
    [Produces("application/json")]
    [Route("api/UserQuestion")]

    public class UserQuestionController : Controller
    {
        private readonly QuizContext _context;
        public UserQuestionController(QuizContext context)
        {
            _context = context;
        }

        // POST: api/UserQuestion
        [HttpPost]
        public async Task<IActionResult> PostUserQuestion([FromBody] UserQuestion userQuestion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.UserQuestion.Add(userQuestion);
            await _context.SaveChangesAsync();

            return Ok(userQuestion);
        }

        [HttpGet]
        public IEnumerable<Models.UserQuestion> Get()
        {
            return _context.UserQuestion;
        }

    }
}