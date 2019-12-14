using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplicationTask4.Models;

namespace WebApplicationTask4.Controllers
{
    public class HomeController : Controller
    {
        PerfumeContext db;
        public HomeController(PerfumeContext context)
        {
            db = context;
        }
        
        public IActionResult Index(string searchString)
        {
            if (String.IsNullOrEmpty(searchString))
            {
                return View(db.Perfumes.ToList()); 
            }
            var c = from m in db.Perfumes
                select m;
            c = c.Where(s => s.Name.Contains(searchString));
            return View(c.ToList());
        }
        
        public IActionResult IndexBrand(string searchString)
        {
            if (String.IsNullOrEmpty(searchString))
            {
                return View(db.Brands.ToList());
            }
            var c = from m in db.Brands
                select m;
            c = c.Where(s => s.Name.Contains(searchString));
            return View(c.ToList());
        }
        

        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(string submit, string cancel, Perfume perfume)
        {
            var button = submit ?? cancel;
            if (button == "Cancel")
            {
                return RedirectToAction("Index");
            }

            if (db.Perfumes.Contains(perfume))
            {
                return BadRequest();
            }
            
            db.Perfumes.Add(perfume);
            db.SaveChanges();
            return View(db.Perfumes.ToList());
        }
        
        [HttpGet]
        public IActionResult createBrand()
        {
            return View();
        }
        [HttpPost]
        public IActionResult createBrand(string submit, string cancel, Brand brand)
        {
            var button = submit ?? cancel;
            if (button == "Cancel")
            {
                return RedirectToAction("IndexBrand");
            }

            if (db.Brands.Contains(brand))
            {
                return BadRequest();
            }
            db.Brands.Add(brand);
            db.SaveChanges();
            return RedirectToAction("IndexBrand");
        }
        
        [HttpGet]
        public IActionResult show(int? id)
        {
             if (id == null) return RedirectToAction("Index");
             var p = db.Perfumes.Find(id);
             ViewBag.Name = p.Name;
             ViewBag.Id = p.Id;
             ViewBag.Volume = p.Volume;
             ViewBag.Count = p.Count;
             ViewBag.Price = p.Price;
             ViewBag.BrandName = p.Brand;
             return View();
        }
        
        [HttpGet]
        public IActionResult showBrand(int? id)
        {
            if (id == null) return RedirectToAction("IndexBrand");
            var p = db.Brands.Find(id);
            ViewBag.Name = p.Name;
            ViewBag.Country = p.Country;
            ViewBag.Id = id;
            return View();
        }
        
        [HttpGet]
        public IActionResult edit(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            var perfume = db.Perfumes.Find(id);
            ViewBag.Name = perfume.Name;
            ViewBag.Volume = perfume.Volume;
            ViewBag.Count = perfume.Count;
            ViewBag.Id = id;
            ViewBag.Price = perfume.Price;
            ViewBag.Brand = perfume.Brand;
//            db.Perfumes.Remove(perfume);
//            db.SaveChanges();
            return View();
        }

        [HttpPost]
        public IActionResult edit(string submit, string cancel, Perfume perfume)
        {
            var button = submit ?? cancel;
            if (button == "Cancel")
            {
                return RedirectToAction("Index");
            }
            if (perfume == null)
            {
                return BadRequest();
            }
            if (!db.Perfumes.Any(x => x.Name == perfume.Name))
            {
                return NotFound();
            }

            db.Perfumes.Update(perfume);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult editBrand(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            var br = db.Brands.Find(id);
            ViewBag.Name = br.Name;
            ViewBag.Id = br.Id;
            ViewBag.Country = br.Country;
            return View();
        }
        
        [HttpPost]
        public IActionResult editBrand(string submit, string cancel, Brand brand)
        {
            var button = submit ?? cancel;
            if (button == "Cancel")
            {
                return RedirectToAction("IndexBrand");
            }
            if (brand == null)
            {
                return BadRequest();
            }
            if (!db.Brands.Any(x => x.Id == brand.Id))
            {
                return NotFound();
            }
           
            db.Brands.Update(brand);
            db.SaveChanges();
            return RedirectToAction("IndexBrand");
        }
        
        [HttpGet]
        public IActionResult destroy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            var perfume = db.Perfumes.FirstOrDefault(x => x.Id == id);
            if (perfume == null)
            {
                return NotFound();
            }
            var p = db.Perfumes.Find(id);
            ViewBag.Name = p.Name;
            ViewBag.Id = p.Id;
            ViewBag.Volume = p.Volume;
            ViewBag.Count = p.Count;
            ViewBag.Price = p.Price;
            ViewBag.Brand = p.Brand;
            return View();
        }
        
        [HttpPost]
        public IActionResult destroy(string submit, string cancel, Perfume perfume)
        {
            var button = submit ?? cancel;
            if (button == "Cancel")
            {
                return RedirectToAction("Index");
            }
           
            db.Perfumes.Remove(perfume);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }
        
        [HttpGet]
        public IActionResult destroyBrand(int? id)
        {
            if (id == null) return RedirectToAction("IndexBrand");
            var brand = db.Brands.FirstOrDefault(x => x.Id == id);
            if (brand == null)
            {
                return NotFound();
            }
            var p = db.Brands.Find(id);
            ViewBag.Name = p.Name;
            ViewBag.Id = p.Id;
            ViewBag.Country = p.Country;
            return View();
        }
        
        [HttpPost]
        public IActionResult destroyBrand(string submit, string cancel, Brand brand)
        {
            var button = submit ?? cancel;
            if (button == "Cancel")
            {
                return RedirectToAction("IndexBrand");
            }
           
            db.Brands.Remove(brand);
            db.SaveChanges();
            return RedirectToAction("IndexBrand");
            
        }
    }
}