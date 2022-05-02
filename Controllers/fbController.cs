using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication26.Models;

namespace WebApplication26.Controllers
{
    public class fbController : Controller
    {
        private readonly AanchEntities dbcontext;
        public fbController()
        {
            dbcontext = new AanchEntities();
        }
        // GET: fb
        public ActionResult Index()
        {
            //tring message = "mvc!";
            //ewBag.msg = message;


            // viewBag.employees = new List<string>()
            // { "Mohit","Ram","Sita"};

            //String message = "mvc!";
            // viewData["msg"] = message;
            //string message = "This is Viewdata example";
            //ViewData["msg"] = message;
            //ViewData["emp"]=new List<string>()
            //    { "Mohit","Shyam","Sita"};
            //employee obj = new employee()

            //{ Id = 1011, name = "mohan", salary = 12000 };
            //List<employee> obj = new List<employee>()
            //{
            //    new employee(){Id=102,name="lavi",salary=15000},
            //    new employee(){Id=103,name="rakhi",salary=16000},
            //    new employee(){Id=104,name="naman",salary=18000},
            //    new employee(){Id=105,name="ashish",salary=19000}

            //};
            List<Location> obj = dbcontext.Locations.toList();

             return View();
        }
    }
    
    
            
 }
