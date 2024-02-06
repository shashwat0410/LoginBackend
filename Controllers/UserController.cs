/*using Microsoft.AspNetCore.Mvc;

namespace LoginBackend.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
*/
using LoginBackend.Models;
using LoginBackend.Services;
using Microsoft.AspNetCore.Mvc;

public class UserController : Controller
{
    private UserManager _userManager = new UserManager();

    [Route("[controller]")]
    [HttpPost]
    public ActionResult Login(UserModel user)
    {
        if (_userManager.ValidateUser(user))
        {
            return Ok("Login successful");
        }
        else
        {
            return BadRequest("Invalid credentials");
        }
    }
}
