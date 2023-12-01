using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using swebapi.Data;
using swebapi.Models;

namespace swebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IdentityContext _context;
        private readonly UserManager<CustomIdentityUser> _userManager;  

        public HomeController(IdentityContext context, UserManager<CustomIdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        //Get: api/<HomeController>
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<IdentityUserViewModel>>> Get()
        {
            var usuarios = new List<IdentityUserViewModel>();
            foreach(var usuario in await _context.CustomIdentities.AsNoTracking().ToListAsync())
            {
                usuarios.Add(new IdentityUserViewModel
                {
                    Id = usuario.Id,
                    Nombrecompleto = usuario.Nombre,
                    Email = usuario.Email,
                    UserName = usuario.UserName,
                    Rol = GetRoles(usuario)
                });
            }
            return usuarios;
        }
        //Get api/<HomeController>/5
        [HttpGet("{correo}")]
        [Authorize]
        public async Task<ActionResult<IdentityUserViewModel>> Get(string correo)
        {
            var usuario = await _userManager.FindByEmailAsync(correo);
            if(usuario == null)
            {
                return NotFound();
            }
            return new IdentityUserViewModel
            {
                Id = usuario.Id,
                Nombrecompleto = usuario.Nombre,
                Email = usuario.Email,
                UserName = usuario.UserName,
                Rol = GetRoles(usuario)
            };
        }
        private string GetRoles(CustomIdentityUser usuario)
        {
            var roles = _userManager.GetRolesAsync(usuario).Result;
            return string.Join(",", roles);
        }
    }
}
