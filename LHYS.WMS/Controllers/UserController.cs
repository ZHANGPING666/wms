using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBModel;

namespace LHYS.WMS.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult GetData()
        {
            DBContainer Db = new DBContainer();
            string sql = " select UserCode,UserName from [dbo].[User]";
            System.Data.Entity.Infrastructure.DbRawSqlQuery<Models.User> list= Db.Database.SqlQuery<Models.User>(sql);
            return Json(list);
        }
    }
}