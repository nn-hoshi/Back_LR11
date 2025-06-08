using Microsoft.AspNetCore.Mvc;

namespace CorsAndEfDemo.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("��� ������������ ������ 11! ����������� /api/products ��� ������� � ������.");
    }
}