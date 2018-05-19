using System;
using System.Web.Mvc;
using Blog.Domain.Core;
using Blog.Domain.Interfaces;

namespace Blog.Areas.Admin.Controllers
{
    public class AddArticleController : Controller
    {
        private readonly IRepository repository;

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Article article, string[] tags)
        {
            ViewBag.Name = article.Name;
            ViewBag.PublicationDate = DateTime.UtcNow;
            ViewBag.Text = article.Text;

            string result = "";
            foreach (string tag in tags)
            {
                result += tag;
                result += " ";
            }

            ViewBag.Tags = result;
            return View("ArticleAdded");
        }
    }
}