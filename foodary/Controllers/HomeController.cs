using foodary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace foodary.Controllers
{
    public class HomeController : Controller
    {
        private Model2 db = new Model2();
        private Model3 db1 = new Model3();
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
        public ActionResult Details(int? id)
        {

            FoodEventSet foodEventSet = db.FoodEventSet.Find(id);
            if (foodEventSet == null)
            {
                return HttpNotFound();
            }
            return View(foodEventSet);
        }

        public ActionResult FindRecipe()
        {


            /*
        List<recipe> models = db1.recipes.ToList();
        List<string> nameList = new List<string>();
        List<string> ingredientList = new List<string>();
        List<string> directionList = new List<string>();
        List<int> servingList = new List<int>();
        List<double> costList = new List<double>();
        List<string> urlList = new List<string>();
        List<string> categoryList = new List<string>();
        List<int> totalTimeList = new List<int>();
        List<string> timeList = new List<string>();
        foreach (recipe item in models)
        {
            nameList.Add(item.recipe_name);
            ingredientList.Add(item.ingredients);
            directionList.Add(item.directions);
            servingList.Add((int)item.servings);
            costList.Add((double)item.cost);
            urlList.Add(item.img_url);
            categoryList.Add(item.category);
            totalTimeList.Add((int)item.total_time_min);
            timeList.Add(item.total_time_str);
        }

        ViewBag.nameList = JsonConvert.SerializeObject(nameList);
        ViewBag.ingredientList = JsonConvert.SerializeObject(ingredientList);
        ViewBag.directionList = JsonConvert.SerializeObject(directionList);
        ViewBag.servingList = JsonConvert.SerializeObject(servingList);
        ViewBag.costList = JsonConvert.SerializeObject(costList);
        ViewBag.urlList = JsonConvert.SerializeObject(urlList);
        ViewBag.categoryList = JsonConvert.SerializeObject(categoryList);
        ViewBag.totalTimeList = JsonConvert.SerializeObject(totalTimeList);
        ViewBag.timeList = JsonConvert.SerializeObject(timeList);
        ViewBag.models = JsonConvert.SerializeObject(models);
        db1.recipes.ToList()

        */
            Model3 db = new Model3();
            List<product> meatList = db.products.Where(p => p.category == "Meat").ToList();
            List<product> vegetablesList = db.products.Where(p => p.category == "Vegetables").ToList();
            List<product> othersList = db.products.Where(p => p.category == "Others").ToList();
            ViewBag.MeatList = meatList;
            ViewBag.VegetablesList = vegetablesList;
            ViewBag.OthersList = othersList;

            return View();
        }

        public JsonResult GetFoodaryData(string category, List<string> keys, string sort)
        {
            Model3 db = new Model3();

            Expression<Func<recipe, bool>> exWhere = r => 1 == 1;
            if (keys != null && keys.Count > 0)
            {
                exWhere = r => keys.Any(k => r.directions.Contains(k));
            }

            List<recipe> list = new List<recipe>();
            switch (sort)
            {
                case "cost":
                    list = db.recipes.Where(r => r.category == category).Where(exWhere).OrderBy(r => r.cost).ToList();
                    break;
                case "preparationTime":
                    list = db.recipes.Where(r => r.category == category).Where(exWhere).OrderBy(r => r.total_time_str).ToList();
                    break;
                case "servingSize":
                    list = db.recipes.Where(r => r.category == category).Where(exWhere).OrderBy(r => r.servings).ToList();
                    break;
            }

            return Json(list, JsonRequestBehavior.AllowGet);
        }



    }
}