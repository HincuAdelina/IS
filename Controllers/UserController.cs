using MarkIT.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace MarkIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly MarkITContext db;

        public UserController(MarkITContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = db.Users
                            .Select(x => x.FirstName);

            return Ok(users);
        }
    }
}
