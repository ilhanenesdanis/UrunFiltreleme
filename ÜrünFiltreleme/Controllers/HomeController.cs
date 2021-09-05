using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ÜrünFiltreleme.Models;

namespace ÜrünFiltreleme.Controllers
{
    public class HomeController : Controller
    {
        ÜrünFiltrelemeEntities data = new ÜrünFiltrelemeEntities();
        public ActionResult Index()
        {
            var ürünler = data.Ürünler.ToList();
            var kategori = data.Kategoriler.ToList();
            var model = (ürünler, kategori);
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult getProduct(int cat)
        {
            List<Ürünler> urun = new List<Ürünler>();
            List<Kategoriler> kategori = new List<Kategoriler>();
            var sorgu = (data.Ürünler.Where(x => x.KategoriId == cat)).ToList().OrderBy(x => x.KategoriId);
            urun.AddRange(sorgu);
            ViewBag.prod = urun.ToList();
            return PartialView();
        }


    }
}