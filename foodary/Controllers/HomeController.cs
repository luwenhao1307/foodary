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
        private Model1Container db = new Model1Container();
        public ActionResult Index()
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
            List<FoodEvent> models = db.FoodEventSet.ToList();
            List<List<decimal>> dataList = new List<List<decimal>>();
            List<decimal> latList = new List<decimal>();
            List<decimal> lngList = new List<decimal>();
            foreach (FoodEvent item in models) {
                latList.Add(item.Latitude);
                lngList.Add(item.Longitude);
            }
            dataList.Add(latList);
            dataList.Add(lngList);
            ViewBag.data = JsonConvert.SerializeObject(dataList);
            return View(db.FoodEventSet.ToList());
        }


    }
}