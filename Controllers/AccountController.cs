using LoginApp.Models;
using LoginApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LoginApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILoginRepository _loginRepository;

        public AccountController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginA model)
        {
            if (ModelState.IsValid)
            {
                var user = _loginRepository.ValidateUser(model.Username, model.Password);

            
                if (user != null)
                {
                // User is valid, redirect to a secure page or dashboard
                return RedirectToAction("Index", "Home");
                }
                ViewBag.ErrorMessage = "Invalid username or password.";
            }
            return View(model);
        }
    }
}
