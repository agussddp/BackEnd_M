using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MinhaAcao()
    {
        return View();//  retorna a página minha ação
    }
    public IActionResult ListaNomes()
    {

    string[] nomes = {"Joseph Goldberg", "Will Bettelheim", "Jonathan Moore"};

    ViewBag.Teste = "OLa, vi atraves do ViewBag";
    ViewBag.nomes = nomes; //chama as views passando os dados
    return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
