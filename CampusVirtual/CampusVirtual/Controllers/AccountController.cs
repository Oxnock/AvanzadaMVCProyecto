using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CampusVirtual.Model;
using CampusVirtual.Model.Entities;
using CampusVirtual.ViewModels.AccountViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CampusVirtual.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private CampusContext _context;

        public AccountController(SignInManager<IdentityUser> signInManager, 
            UserManager<IdentityUser> userManager,
            CampusContext context) {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Ingresar()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Ingresar(IngresarViewModel ingresarViewModel)
        {
            if (!ModelState.IsValid) {
                return View(ingresarViewModel);
            }
            var user = await _userManager.FindByNameAsync(ingresarViewModel.Nombre);
            if (user != null) {
                var result = await _signInManager.PasswordSignInAsync(user, ingresarViewModel.Clave, false, false);
                if (result.Succeeded) {
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "El usuario o contraseña son invalidas.");
            return View();
        }

        public IActionResult Registrar() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registrar(RegistrarViewModel registrarViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = registrarViewModel.Nombre };
                var result = await _userManager.CreateAsync(user, registrarViewModel.Clave);
                if (result.Succeeded) {
                    _context.TipoUsuarios.Add(new TipoUsuario() {
                        Tipo = registrarViewModel.TipoUsuario,
                        UsuarioId = user.Id
                    });
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(registrarViewModel);
        }

        public async Task<IActionResult> Salir() {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Ingresar");
        }
    }
}