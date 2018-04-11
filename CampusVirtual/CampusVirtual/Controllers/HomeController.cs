using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CampusVirtual.Model;
using CampusVirtual.ViewModels.HomeViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CampusVirtual.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private CampusContext _context;

        public HomeController(SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager,
            CampusContext context)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var CurrentUser = await _userManager.GetUserAsync(User);
            IndexViewModel indexViewModel = new IndexViewModel() {
                Id = CurrentUser.Id,
                Nombre = CurrentUser.UserName,
                Clave = CurrentUser.PasswordHash,
                TipoUsuario = _context.TipoUsuarios.SingleOrDefault(u => u.UsuarioId == CurrentUser.Id).Tipo
            };
            return View(indexViewModel);
        }
    }
}