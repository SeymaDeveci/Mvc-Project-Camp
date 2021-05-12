using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }

        [HttpGet] //Sayfa yüklendiği zaman çalış Attribute'tü
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost] //Sayfada bir butona tıklandığında çalış Attribute'tü
        public ActionResult AddCategory(Category p)
        {
            //cm.CategoryAddBL(p);
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p); //ValidationResult türündeki results değişkeninin CategoryValidator sınıfında olan değerlere göre p parametresinin kontrolünü yapması
            if (results.IsValid) //results geçerli ise yani kontrol olumlu ise
            {
                cm.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in results.Errors) //results dan gelen hatalardan bir döngü oluştur
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage); //modelin durumuna hangi proporty üzerinde çalışıyorsan ona göre hata ekle
                }
            }
            return View();
        }
    }
}