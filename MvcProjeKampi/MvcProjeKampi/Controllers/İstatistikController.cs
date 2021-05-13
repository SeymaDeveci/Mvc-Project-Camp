using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class İstatistikController : Controller
    {
        // GET: İstatistik
        Context context = new Context();
        public ActionResult Index()
        {
            //Toplam kategori
            var totalcategory = context.Categories.Count();
            ViewBag.numberOfCategories = totalcategory;

            //Başlık tablosunda "yazılım" kategorisine ait başlık sayısı
            var softwareCategoryTitles = context.Headings.Count(x=>x.CategoryID==9);
            ViewBag.numberOfSoftwareTitles = softwareCategoryTitles;

            //Yazar adında 'a' harfi geçen yazar sayısı
            var writerNameContainA = context.Writers.Count(x => x.WriterName.Contains("a"));
            ViewBag.writerNameContainA = writerNameContainA;

            //En fazla başlığa sahip kategori adı
            var mostTitles = context.Headings.GroupBy(x => x.CategoryID).OrderByDescending(z => z.Count()).Select(s => s.Key).FirstOrDefault();
            var mostTitlesCategoryName = context.Categories.Where(x => x.CategoryID == mostTitles).Select(s => s.CategoryName).FirstOrDefault().ToString();
            ViewBag.mostTitlesCategoryName = mostTitlesCategoryName;

            //Kategori tablosunda durumu true olan kategoriler
            var categoryStatusTrue = context.Categories.Count(x => x.CategoryStatus == true);
            ViewBag.categoryStatusTrue = categoryStatusTrue;

            //Kategori tablosunda durumu false olan kategoriler
            var categoryStatusFalse = context.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.categoryStatusFalse = categoryStatusFalse;

            //True ile false olanların farkı
            var differenceStatus = categoryStatusTrue - categoryStatusFalse;
            ViewBag.differenceStatus = differenceStatus;

            return View();
        }
    }
}