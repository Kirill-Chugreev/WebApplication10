using Microsoft.AspNetCore.Mvc;

namespace WebApplication10
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResponseController : ControllerBase
    {
        // Метод для возвращения HTML страницы
        [HttpGet("html")]
        public IActionResult GetHtml()
        {
            string htmlContent = "<html><body><h1>Hello, World!</h1></body></html>";
            return Content(htmlContent, "text/html");
        }

        // Метод для возвращения JSON данных
        [HttpGet("json")]
        public IActionResult GetJson()
        {
            var data = new { Name = "Kirill", Age = 30 };
            return Ok(data);
        }

        // Метод для возвращения файла
        [HttpGet("file")]
        public IActionResult GetFile()
        {
            string filePath = "C:/backend/lab10.txt";
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            return File(fileStream, "text/plain", "lab10.txt");
        }
    }

}
