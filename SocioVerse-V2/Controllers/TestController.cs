using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase {

    [HttpGet]
    public IActionResult Get() {
        var results = new {
            Name = "Chetan Soni",
            Title = "Application Engineer"
        };

        return Ok(results);
    }
}

