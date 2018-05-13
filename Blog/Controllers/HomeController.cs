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
        [HttpGet]
        public ActionResult Index()
        {
            return View(_repository.GetArticlesList());
        }

        [HttpPost]
        public ActionResult Index(string personName, string vote)
        {
            ViewBag.PersonName = personName;
            ViewBag.VoteResult = vote;
            return View("VoteResult");
        }

        [HttpGet]
        public ActionResult FullIndex()
        {
            return View(_repository.GetArticlesList());
        }

        [HttpPost]
        public ActionResult FullIndex(string personName, string vote)
        {
            ViewBag.PersonName = personName;
            ViewBag.VoteResult = vote;
            return View("VoteResult");
        }
    }
}