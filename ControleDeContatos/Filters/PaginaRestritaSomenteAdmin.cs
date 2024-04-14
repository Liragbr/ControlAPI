using ControleDeContatos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System.Text.Json;

namespace ControleDeContatos.Filters
{
    public class PaginaRestritaSomenteAdmin : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Session.TryGetValue("sessaoUsuarioLogado", out byte[] sessaoUsuarioBytes))
            {
                context.Result = new RedirectToActionResult("Index", "Login", null);
                return;
            }

            var sessaoUsuarioString = System.Text.Encoding.UTF8.GetString(sessaoUsuarioBytes);

            if (string.IsNullOrEmpty(sessaoUsuarioString))
            {
                context.Result = new RedirectToActionResult("Index", "Login", null);
                return;
            }

            var usuario = JsonSerializer.Deserialize<UsuarioModel>(sessaoUsuarioString);

            if (usuario == null || usuario.Perfil != Enums.PerfilEnum.Admin)
            {
                context.Result = new RedirectToActionResult("Index", "Restrito", null);
                return;
            }

            base.OnActionExecuting(context);
        }
    }
}
