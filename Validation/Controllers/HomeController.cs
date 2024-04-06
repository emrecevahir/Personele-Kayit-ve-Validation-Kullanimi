using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Validation.DMO;
using Validation.Models;

namespace Validation.Controllers
{
    public class HomeController : Controller
    {
        public PersonelContext _context;
        public HomeController(PersonelContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            AddUser model = new AddUser();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(AddUser model)
        {

            // Modele uygulanan tüm valiasyonlardan her þey okeyse, IsValid True olacaktýr.

            //ModelState üzerinden, validasyon ile ilgili bilgilere ulaþabilirsiniz.
            if (ModelState.IsValid)
            {

                _context.Users.Add(new User
                {
                    IdentityNo = model.IdentityNo,
                    Name = model.Name,
                    LastName = model.LastName,
                    Email = model.Email,
                    Age = model.Age
                });
                _context.SaveChanges();

            }
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
