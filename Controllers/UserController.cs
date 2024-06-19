using IdentityServer3.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication1.Services;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.RegisterAsync(model.Username, model.Password);


            }

            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        /*public async Task<IActionResult> Login(ViewModels.LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.LoginAsync(model.Username, model.Password);

                
            }

            return View(model);
        }*/

        [HttpPost]
        public async Task<IActionResult> Verify(string username, string password)
        {
            var result = await _userService.VerifyUserAsync(username, password);

            

            return Unauthorized("Invalid username or password");
        }

        [HttpGet]
        public async Task<IActionResult> GetRole(string username)
        {
            var role = await _userService.GetUserRoleAsync(username);

            if (role == null)
            {
                return NotFound("User not found");
            }

            return Ok(role);
        }
    }
}
