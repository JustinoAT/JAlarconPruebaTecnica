using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class DiscoController : Controller
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Disco disco = new ML.Disco();
            var result = BL.Disco.GetAll();

            if (result.Correct = true)
            {
                disco.Discos = result.Objects.ToList();
            }
            return View(disco); 
            
        }

        [HttpPost]
        public ActionResult GetAll(ML.Disco disco)
        {
            ML.Result result = BL.Disco.GetAll();
            disco = new ML.Disco();
            disco.Discos = result.Objects;
            return View(disco);

        }
    }
}