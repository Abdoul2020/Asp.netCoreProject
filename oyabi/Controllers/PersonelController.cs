using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using oyabi.Models;

namespace oyabi.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();

        [Authorize]
            public IActionResult Index()
        {
            var deger = c.personels.Include(a => a.depar).ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult yenipersonel()
        {
            List<SelectListItem> deger = (from x in c.departmalars.ToList()select new SelectListItem
                                          {
                                              Text = x.DepartmanAD,
                                              Value = x.DepartmanAD.ToString()
                                          }).ToList();
            ViewBag.dgr = deger;
            return View();
        }
        [HttpPost]
        public IActionResult yenipersonel(Personel p)
        {
            var per = c.departmalars.Where(x => x.ID != p.depar.ID).FirstOrDefault();
            p.depar = per;
            c.personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
            //return View("Index");
        }
    }
}
