using foodary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace foodary.Controllers
{
    public class HomeController : Controller
    {
        private Model2 db = new Model2();
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
        //[HttpPost]
        //public async Task OnGetAsync(String SearchString)
        //{
        //    var Food = from f in db.FoodEventSet
        //                 select f;
        //    Food = Food.Where(f => f.Category.Contains(SearchString));
        //    List<FoodEventSet> models = await Food.ToListAsync();
        //}
        [HttpPost]
        public async Task<ActionResult> GetData(String SearchString)
        {
            var Food = from f in db.FoodEventSet
                       select f;
            Food = Food.Where(f => f.Category.Contains(SearchString));
            List<FoodEventSet> models = await Food.ToListAsync();
            return Content(JsonConvert.SerializeObject(models));
        }
        public ActionResult Map()
        {
            List<FoodEventSet> models = db.FoodEventSet.ToList();

            List<List<decimal>> dataList = new List<List<decimal>>();
            List<decimal> latList = new List<decimal>();
            List<decimal> lngList = new List<decimal>();
            List<string> nameList = new List<string>();
            foreach (FoodEventSet item in models)
            {
                latList.Add((decimal)item.Latitude);
                lngList.Add((decimal)item.Longitude);
                nameList.Add(item.Name);
            }
            dataList.Add(latList);
            dataList.Add(lngList);
            ViewBag.name = JsonConvert.SerializeObject(nameList);
            ViewBag.data = JsonConvert.SerializeObject(dataList);
            ViewBag.models = JsonConvert.SerializeObject(models);
            return View(db.FoodEventSet.ToList());
        }

        public ActionResult FoodEventSet()
        {
            return View(db.FoodEventSet.ToList());
        }

        public ActionResult FoodEvents()
        {
            return View(db.FoodEventSet.ToList());
        }

        public ActionResult FoodSpend()
        {
            return View();
        }
    }
}