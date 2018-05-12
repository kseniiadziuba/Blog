using System.Net.Http;
using System.Web.Mvc;
using Blog.Domain.Interfaces;
using Blog.Infrastructure.Data;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;

        public HomeController()
        {
            _repository = new BlogRepository();
        }

        /// <summary>
        /// Creates the Main page.
        /// </summary>
        /// <returns>Main page View</returns>
        public ActionResult Index(string personName, string vote)
        {
            if (Request.HttpMethod == HttpMethod.Get.Method)
            {
                return View(_repository.GetArticlesList());
            }
            ViewBag.PersonName = personName;
            ViewBag.VoteResult = vote;
            return View("VoteResult");
        }

        public ActionResult FullIndex()
        {
            return View(_repository.GetArticlesList());
        }
    }
}