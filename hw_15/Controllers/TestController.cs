using hw_15.Data;
using Microsoft.AspNetCore.Mvc;

namespace hw_15.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly AppDbContext _db;

        public TestController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Check()
        {
            bool canConnect = _db.Database.CanConnect();

            if (canConnect)
            {
                return Ok(new { message = "Успішно! База даних для hw_15 працює." });
            }

            return BadRequest(new { message = "Помилка підключення до бази." });
        }
    }
}