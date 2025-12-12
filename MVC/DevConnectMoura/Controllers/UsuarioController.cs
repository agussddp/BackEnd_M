using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevConnectMoura.Contexts;
using DevConnectMoura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevConnectMoura.Controllers
{
    // [Route("[controller]")]
    public class UsuarioController : Controller
    {

        private readonly DevConnectContext _context;
        private readonly ILogger<UsuarioController> _logger;




        public UsuarioController(ILogger<UsuarioController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
        }



        //Cadastro usuario
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.UsuarioNovoCadastrado = "";
            TempData["UsuarioNovoCadastrado"] = "";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {
            TbUsuario novoUsuario = new TbUsuario()
            {
                Nomecompleto = form ["NomeCompleto"].ToString(),
                Nomeusuario = form ["Nomeusuario"].ToString(),
                Email = form ["Email"].ToString(),
                Senha = form ["Senha"].ToString()
            };
            
            if (form.Files.Count > 0)
            {
                // Se selecionou uma imagem entra dentro do if

                IFormFile file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                //caminho da imagem que sera salvo
                string path = Path.Combine(folder, file.FileName );

                //salva a imagem na pasta wwwrot/images
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                //passa o nome da imagem
                novoUsuario.Fotoperfilurl = file.FileName;
                }

            else
            {
                //foto padrao
                novoUsuario.Fotoperfilurl = "";
                }

            try
            {
                _context.TbUsuario.Add(novoUsuario);

                await _context.SaveChangesAsync();

                TempData["UsuarioNovoCadastrado"] = "Cadastrado";

               return RedirectToAction("Index", "Home");

              
                }

            catch (System.Exception)
            {
                ViewBag.UsuarioNovoCadastrado = "Nao cadastrado";
                TempData["UsuarioNovoCadastrado"] = "";
                return View();
            }

            
        }

        //perfil do usuario
        public IActionResult Perfil()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}