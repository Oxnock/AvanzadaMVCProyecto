using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CampusVirtual.Model;
using CampusVirtual.Model.Entities;
using CampusVirtual.ViewModels.HomeViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CampusVirtual.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private CampusContext _context;

        public HomeController(UserManager<Usuario> userManager,
            RoleManager<IdentityRole> roleManager,
            CampusContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var CurrentUser = await _userManager.GetUserAsync(User);
            var Roles = await _userManager.GetRolesAsync(CurrentUser);

            IndexViewModel indexViewModel = new IndexViewModel() {
                Id = CurrentUser.Id,
                Nombre = CurrentUser.UserName,
                Clave = CurrentUser.PasswordHash,
                TipoUsuario = Roles.FirstOrDefault()
            };
            return View(indexViewModel);
        }
    }
}