using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using oyabi.Models;

namespace oyabi.Controllers
{
    public class Depart : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var deger = c.departmalars.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult yeniDepatman()
        {
            return View();
        }
        [HttpPost]
        public IActionResult yeniDepatman(Departmalar d)
        {
            //tabloya veri ekleme.
            c.departmalars.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult departsil( int id)
        {
            var dep = c.departmalars.Find(id);
            c.departmalars.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult departGetir(int id)
        {
           var dep= c.departmalars.Find(id);
            
            return View("departGetir",dep);
        }
        public IActionResult DepartemanGuncelle(Departmalar d)
        {
            c.departmalars.Update(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult departdetay(int id)
        {
            var deger = c.personels.Where(x => x.DepartmalarID == id).ToList();
            //var baskadeger = c.departmalars.Where(x => x.ID == id).ToList();
            var brmdad = c.departmalars.Where(x => x.ID == id).Select(y => y.DepartmanAD).FirstOrDefault();
            ViewBag.dmr = brmdad;
            return View(deger);
        }
    }
}
