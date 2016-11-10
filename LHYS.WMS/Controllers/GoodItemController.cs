using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using DBModel;

namespace LHYS.WMS.Controllers
{
    public class GoodItemController : Controller
    {


        // GET: GoodItem
        private  IGoodItemService GoodItemService { get; set; }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData() {
            var goodItemsList = GoodItemService.LoadEntities(a => true);
            return Json(goodItemsList);
        }
    }
}