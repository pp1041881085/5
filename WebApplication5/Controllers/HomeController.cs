using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult List(int page)
        {
            string[] data = new string[] {"台风逼近海南",
            "海南大部分学校停课"};
            ViewBag.data = data;
            ViewBag.page = page;
            return View();
        }
        /// <summary>
        /// 添加新闻
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// 保存新闻
        /// </summary>
        /// <returns></returns>
        public ActionResult Save(string title,string content)
        {
            ViewBag.Title = title;
            ViewBag.content = content;
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}