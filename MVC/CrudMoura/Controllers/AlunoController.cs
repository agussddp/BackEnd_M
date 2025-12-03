using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CrudMoura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudMoura.Controllers
{
    public class AlunosController : Controller
    {
        private readonly ILogger<AlunosController> _logger;
        public static List<Alunos> ListaDeAlunos = new List<Alunos>
    {
    new Alunos { Id = 1, Nome = "Joe",        Idade = 17, Curso = "DEV"},
    new Alunos{ Id = 2, Nome = "Goldeberg",  Idade = 16, Curso = "Multimidia"},
    new Alunos{Id = 3, Nome = "Will",       Idade = 17, Curso = "Ciber"}
    };

    public AlunosController(ILogger<AlunosController> logger)
    {
        _logger = logger;
    }

   
    public IActionResult Index()
    {
        return View();
    }

     public IActionResult ListarAlunos()
    {
        ViewBag.Alunos = ListaDeAlunos;
        return View();
    }


    [HttpGet]
    public IActionResult Create()
        {
           return View();
        }
    

    [HttpPost]
    public IActionResult Create (Alunos aluno)
    {
        aluno.Id = ListaDeAlunos.Max(a => a.Id) + 1;
        ListaDeAlunos.Add(aluno);

        return RedirectToAction(nameof (ListarAlunos));
    }   


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View("Error!");
        }

        }
    }