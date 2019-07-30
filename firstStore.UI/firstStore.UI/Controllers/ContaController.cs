using firstStore.UI.Data;
using firstStore.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstStore.UI.infra;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace firstStore.UI.Controllers
{
    public class ContaController:Controller
    {
        private readonly FirstStoreDataContext _ctx;
        public ContaController(FirstStoreDataContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Login(string returnUrl) => View(new LoginVM { ReturnUrl=returnUrl });

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            var usuario = _ctx.Usuarios.FirstOrDefault(u=> u.Email.ToLower() == model.Email.ToLower());

            if (usuario == null)
                ModelState.AddModelError("Email", "Email não localizado");
            else
            {
                if(usuario.Senha != model.Senha.Encrypt())
                    ModelState.AddModelError("Senha", "Senha Incorreta");
                
            }

            if (ModelState.IsValid)
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, usuario.Email));
                identity.AddClaim(new Claim(ClaimTypes.Name, usuario.Nome));
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    principal,
                    new AuthenticationProperties()
                    {
                        IsPersistent = model.Lembrar
                    }
                    );
                if(!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                {
                    return Redirect(model.ReturnUrl);

                }
                return RedirectToAction("Index", "Produtos");
            }

            return View();
        }
    }
}
