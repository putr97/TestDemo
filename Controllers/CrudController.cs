using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestDemo.DBLayer;
using TestDemo.Models;
using TestDemo.Repository;

namespace TestDemo.Controllers
{
    public class CrudController : Controller
    {
        private readonly ICrudRepository crudRepository;
        public CrudController(ICrudRepository crudRepository)
        {
            this.crudRepository = crudRepository;
        }
        public IActionResult Index()
        {
            ViewBag.ModelList = crudRepository.GetData();
            return View();
        }
        [HttpPost]
        public IActionResult Index(CrudModel crudModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // ICrudRepository crudRepository = new CrudRepository();
                    var result = crudRepository.insert(new string[] { crudModel.Name, crudModel.City, System.DateTime.Now.ToString(), crudModel.FatherName });
                    ViewBag.ModelList = crudRepository.GetData();
                    if (result)
                    {
                        ViewBag.Msg = "Succeed";
                        ViewBag.alertType = "alert alert-success";
                    }
                    else
                    {
                        ViewBag.Msg = "Insertion failed";
                        ViewBag.alertType = "alert alert-danger";
                    }

                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = "Insertion failed";
                ViewBag.alertType = "alert alert-danger";
                ModelState.AddModelError("Message", ex.Message);
            }

            return View();

        }
    }
}
