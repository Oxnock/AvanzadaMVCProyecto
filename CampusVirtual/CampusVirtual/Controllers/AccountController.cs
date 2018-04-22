using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CampusVirtual.Model;
using CampusVirtual.Model.Entities;
using CampusVirtual.ViewModels.AccountViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace CampusVirtual.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<Usuario> _signInManager;
        private readonly UserManager<Usuario> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private CampusContext _context;

        public AccountController(SignInManager<Usuario> signInManager,
            UserManager<Usuario> userManager,
            RoleManager<IdentityRole> roleManager,
            CampusContext context)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        public async Task<IActionResult> Ingresar()
        {
            var CurrentUser = await _userManager.GetUserAsync(User);
            if (CurrentUser != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Ingresar(IngresarViewModel ingresarViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(ingresarViewModel);
            }
            var user = await _userManager.FindByNameAsync(ingresarViewModel.Nombre);
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, ingresarViewModel.Clave, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "El usuario o contraseña son invalidas.");
            return View();
        }
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> Registrar()
        {
            var CurrentUser = await _userManager.GetUserAsync(User);
            var list = new List<SelectListItem>();
            var Roles = await _userManager.GetRolesAsync(CurrentUser);

            list.Add(new SelectListItem() { Text = "Profesor", Value = "Profesor" });
            list.Add(new SelectListItem() { Text = "Estudiante", Value = "Estudiante" });

            return View(new RegistrarViewModel() { TipoUsuarios = list });
        }
        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public async Task<IActionResult> Registrar(RegistrarViewModel registrarViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new Usuario() { UserName = registrarViewModel.Nombre };
                var result = await _userManager.CreateAsync(user, registrarViewModel.Clave);
                if (result.Succeeded)
                {
                    if (!await _roleManager.RoleExistsAsync(registrarViewModel.TipoUsuario))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(registrarViewModel.TipoUsuario));
                    }
                    await _userManager.AddToRoleAsync(user, registrarViewModel.TipoUsuario);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(registrarViewModel);
        }

        public async Task<IActionResult> Salir()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Ingresar", "Account");
        }

        public IActionResult AccessDenied()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}