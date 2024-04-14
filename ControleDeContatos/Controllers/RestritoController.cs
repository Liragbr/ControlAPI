using ControleDeContatos.Filters;
using Microsoft.AspNetCore.Mvc;
using ControleDeContatos.Models;

namespace ControleDeContatos.Controllers
{
    [PaginaParaUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
