using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LHYS.WMS.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login


        /// <summary>
        /// 登录界面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 登录提交
        /// </summary>
        /// <returns></returns>
        public string Login()
        {
            string uid = Request.Form["uid"];
            string pwd = Request.Form["pwd"];
            string code = Request.Form["checkcode"];
            if (string.IsNullOrEmpty(code) || (Session["vCode"] == null) || (code.Trim() != Session["vCode"].ToString()))//校验验证码是否正确
            {
                return "4";//验证码错误
            }
            //添加验证用户名密码判断
            // return "1";//用户名不存在
            //return "2";//密码错误
            else
            {
                return "0";//登录成功
            }

        }

        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <returns></returns>
        public ActionResult GetVcode()
        {
            var code = VerifyCode.GenerateCheckCode();
            Session["vCode"] = code;
            var byt = VerifyCode.CreateCheckCodeImage(code);
            return File(byt, "image/jpeg");
        }
    }
}
