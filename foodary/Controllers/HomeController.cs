using foodary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace foodary.Controllers
{
    public class HomeController : Controller
    {
        private webModel db = new webModel();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Map()
        {
            List<FoodEvent> models = db.FoodEvents.ToList();
            List<List<decimal>> dataList = new List<List<decimal>>();
            List<decimal> latList = new List<decimal>();
            List<decimal> lngList = new List<decimal>();
            List<string> nameList=new List<string>();
            foreach (FoodEvent item in models) {
                latList.Add(item.Latitude);
                lngList.Add(item.Longitude);
                nameList.Add(item.Name);
            }
            dataList.Add(latList);
            dataList.Add(lngList);
            ViewBag.name = JsonConvert.SerializeObject(nameList);
            ViewBag.data = JsonConvert.SerializeObject(dataList);
            ViewBag.models = JsonConvert.SerializeObject(models);
            return View(db.FoodEvents.ToList());
        }

        public ActionResult FoodEvents()
        {
            return View(db.FoodEvents.ToList());
        }


    }
}