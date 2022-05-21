
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestDemo.DBLayer;
using TestDemo.Models;

public class GetController : Controller
{
    private DBAccessContext Context { get; }

    public GetController(DBAccessContext _context)
    {
        this.Context = _context;
    }

 public IActionResult Index()
    {
        //List<CrudModel> Crud_Data  new List<CrudModel>;
      //List<CrudModel> Crud_Data = (from CrudModel in this.Context.Crud_Data.Take(10)
                                //   select TBL_TRN_USER).ToList();
    return View();
    }
}