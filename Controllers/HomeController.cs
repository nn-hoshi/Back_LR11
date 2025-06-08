using Microsoft.AspNetCore.Mvc;

namespace CorsAndEfDemo.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Это лабораторная работа 11! Используйте /api/products для доступа к данным.");
    }
}