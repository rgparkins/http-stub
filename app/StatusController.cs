using Microsoft.AspNetCore.Mvc;

namespace rgparkins.HttpStub
{
    public class StatusController : Controller
    {
        [Route("private/ping")]
        public IActionResult Ping()
        {
            return Ok("pong");
        }
    }
}