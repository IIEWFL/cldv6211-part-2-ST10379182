// Controllers/AccountController.cs
using Microsoft.AspNetCore.Mvc;
using WebappPart2.Models;
using WebappPart2.Data;

namespace WebappPart2.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new UserAccountAdd
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Username = model.Username,
                    Password = model.Password, // Consider hashing the password before saving
                    Email = model.Username // Assuming Username is the Email
                };

                _context.UserAccountAdds.Add(user);
                _context.SaveChanges();

                // Redirect to login or another page
                return RedirectToAction("Login");
            }

            return View(model);
        }
    }
}
