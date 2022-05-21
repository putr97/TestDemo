using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestDemo.Models;
using TestDemo.Repository;

namespace TestDemo.Controllers
{
    public class RegisController : Controller
    {
        private readonly IRegisRepository regisRepository;
        public RegisController(IRegisRepository regisRepository)
       {
            this.regisRepository = regisRepository;
        }
        public IActionResult Index()
        {
            ViewBag.ModelList = regisRepository.GetDataREGIS();
            return View();
        }
        [HttpPost]
        public IActionResult Index(TBL_TRN_REGISTRATION tBL_TRN_REGISTRATION)
        {
           try
            {
                if (ModelState.IsValid)
                {
                    // ICrudRepository crudRepository = new CrudRepository();
                    var result = regisRepository.insert(new string[] 
                    { 
 
                        tBL_TRN_REGISTRATION.USERNAME, 
                        tBL_TRN_REGISTRATION.PASSWORD,
                        tBL_TRN_REGISTRATION.CONFIRMPASS,
                        tBL_TRN_REGISTRATION.EMAIL,
                        tBL_TRN_REGISTRATION.SEXID,
                        tBL_TRN_REGISTRATION.MARITALID
                    });
                    ViewBag.ModelList = regisRepository.GetDataREGIS();
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