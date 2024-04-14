using ControleDeContatos.Models;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace ControleDeContatos.Helper
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpContext;

        public Sessao(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public UsuarioModel BuscarSessaoDoUsuario()
        {
            if (!_httpContext.HttpContext.Session.TryGetValue("sessaoUsuarioLogado", out byte[] sessaoUsuarioBytes))
            {
                return null;
            }

            var sessaoUsuarioString = System.Text.Encoding.UTF8.GetString(sessaoUsuarioBytes);

            if (string.IsNullOrEmpty(sessaoUsuarioString))
            {
                return null;
            }

            return JsonSerializer.Deserialize<UsuarioModel>(sessaoUsuarioString);
        }

        public void CriarSessaoDoUsuario(UsuarioModel usuario)
        {
            var valor = JsonSerializer.Serialize(usuario);

            _httpContext.HttpContext.Session.SetString("sessaoUsuarioLogado", valor);
        }

        public void RemoverSessaoUsuario()
        {
            _httpContext.HttpContext.Session.Remove("sessaoUsuarioLogado");
        }
    }
}
