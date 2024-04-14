using ControleDeContatos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Threading.Tasks;

namespace ControleDeContatos.ViewComponents
{
    public class Menu : ViewComponent
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Menu(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessaoUsuario = _httpContextAccessor.HttpContext.Session.GetString("sessaoUsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario))
            {
                return View((UsuarioModel)null);
            }

            UsuarioModel usuario = JsonSerializer.Deserialize<UsuarioModel>(sessaoUsuario);

            return View(usuario);
        }
    }
}
