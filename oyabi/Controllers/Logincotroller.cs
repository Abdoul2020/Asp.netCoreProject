using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using oyabi.Models;

namespace oyabi.Controllers
{
    public class Logincotroller : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GirisYAP()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GirisYAPAsync(Adminn p)
        {
            var bilgiler = c.adminns.FirstOrDefault(x => x.kullanici == p.kullanici && x.sifre == p.sifre);

            if (bilgiler!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.kullanici)
                };
                var Useridentity = new ClaimsIdentity(claims, "Logincotroller");
                ClaimsPrincipal principal = new ClaimsPrincipal(Useridentity);

                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Personel");
            }

            return View();
        }
    }
}
