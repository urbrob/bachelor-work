using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ZakupyOnline.Models;
using ZakupyOnline.Data;

namespace ZakupyOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly ZakupyContext _context;

        public HomeController(ZakupyContext context)
        {
            _context = context;
        }

        public IActionResult Zakupy()
        {
            try
            {
                List<Zakupy> zakupy_list = _context.Zakupy.ToList();
                ViewBag.zakupy = zakupy_list;
            }
            catch { };
            return View();
        }

        [HttpGet]
        public IActionResult PrzedmiotyAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ZakupyAdd(Zakupy zakupy)
        {
            try
            {
                _context.Zakupy.Add(zakupy);
                _context.SaveChanges();
            }
            catch { };
            
            return RedirectToAction("Zakupy");
        }

        [HttpGet]
        public IActionResult ZakupyAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PrzedmiotyAdd(Przedmioty przedmioty)
        {
            try
            {
                _context.Przedmioty.Add(przedmioty);
                _context.SaveChanges();
            }
            catch { };
            
            return RedirectToAction("Przedmioty");
        }


        public IActionResult PrzedmiotyDelete(int id)
        {
            try
            {
                Przedmioty przedmiot = _context.Przedmioty.Find(keyValues: id = id);
                if (przedmiot != null)
                {
                    _context.Przedmioty.Remove(przedmiot);
                    _context.SaveChanges();
                }
            }
            catch { };
            
            return RedirectToAction("Przedmioty");
        }

        public IActionResult ZakupyDelete(int id)
        {
            try
            {
                Zakupy zakupy = _context.Zakupy.Find(keyValues: id = id);
                if (zakupy != null)
                {
                    _context.Zakupy.Remove(zakupy);
                    _context.SaveChanges();
                }
            }
            catch { };
            
            return RedirectToAction("Zakupy");
        }
        public IActionResult DodajDoZakupy(int id, int second_id)
        {
            try
            {
                PrzedmiotyWZakupy przedmioty_w_zakupy = new PrzedmiotyWZakupy { in_cart = false, shopping_id = id, item_id = second_id };
                _context.PrzedmiotyWZakupy.Add(przedmioty_w_zakupy);
                _context.SaveChanges();
            }
            catch { };
            
            return RedirectToAction("ZakupyDetails", "Home", new { id = id });
        }

        public IActionResult UsunZZakupy(int id, int second_id)
        {
            try
            {
                int zakupy_id = id;
                _context.PrzedmiotyWZakupy.Remove(_context.PrzedmiotyWZakupy.Find(keyValues: id = second_id));
                _context.SaveChanges();
                return RedirectToAction("ZakupyDetails", "Home", new { id = zakupy_id });
            }
            catch { };

            return View();
        }

        public IActionResult ZakupyDone(int id)
        {
            try
            {
                int zakupy_id = id;
                Zakupy zakupy = _context.Zakupy.Find(keyValues: id = id);
                if (zakupy != null)
                {
                    zakupy.Done = !zakupy.Done;
                    _context.Zakupy.Update(zakupy);
                    _context.SaveChanges();
                }
                return RedirectToAction("ZakupyDetails", "Home", new { id = zakupy_id });
            }
            catch { };

            return View();
            
        }

        public IActionResult DodajDoKoszyka(int id, int second_id)
        {
            try
            {
                int zakupy_id = id;
                PrzedmiotyWZakupy przedmioty_w_zakupy = _context.PrzedmiotyWZakupy.Find(keyValues: id = second_id);
                przedmioty_w_zakupy.in_cart = !przedmioty_w_zakupy.in_cart;
                _context.PrzedmiotyWZakupy.Update(przedmioty_w_zakupy);
                _context.SaveChanges();
                return RedirectToAction("ZakupyDetails", "Home", new { id = zakupy_id });

            }
            catch { };
            return View();
            
        }
        public class PrzedmiotWZakupyShow
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public int ID { get; set; }
            public bool InCart { get; set; }
        }

        public IActionResult ZakupyDetails(int id)
        {
            try
            {
                ViewBag.zakupy = _context.Zakupy.Find(id);
                ViewBag.zakupy_details = _context.Zakupy.Find(id);
                var przedmioty_w_zakupy_query = from przedmiot_w in _context.PrzedmiotyWZakupy
                                                join przedmio in _context.Przedmioty
                                                on przedmiot_w.item_id equals przedmio.ID
                                                where przedmiot_w.shopping_id == id
                                                select new PrzedmiotWZakupyShow { Name = przedmio.Name, Price = przedmio.Price, ID = przedmiot_w.ID, InCart = przedmiot_w.in_cart };

                ViewBag.przedmioty_w_zakupy = przedmioty_w_zakupy_query.ToList();

                List<Przedmioty> przedmioty_list = _context.Przedmioty.ToList();
                ViewBag.przedmioty = przedmioty_list;
                return View(ViewBag.zakupy);
            }
            catch { };

            return View();

        }

        public IActionResult Przedmioty()
        {
            try
            {
                List<Przedmioty> przedmioty_list = _context.Przedmioty.ToList();
                ViewBag.przedmioty = przedmioty_list;
            }
            catch { };
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
