using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dashboard.Models;
using dashboard.Data;

namespace dashboard.Controllers;

public class HomeController : Controller
{
    private readonly ClientesContext _contexto;

    public HomeController(ClientesContext contexto)
    {
        this._contexto = contexto;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
