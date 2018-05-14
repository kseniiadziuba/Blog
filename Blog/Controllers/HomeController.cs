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
        /// Creates the Main page on GET method.
        /// </summary>
        /// <returns>Main page View</returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View(_repository.GetArticlesList());
        }

        /// <summary>
        /// Creates the Main page on POST method.
        /// </summary>
        /// <returns>Main page View</returns>
        [HttpPost]
        public ActionResult Index(string personName, string vote)
        {
            ViewBag.PersonName = personName;
            ViewBag.VoteResult = vote;
            return View("VoteResult");
        }

        /// <summary>
        /// Creates the Main page with full articles on GET method.
        /// </summary>
        /// <returns>Main page View</returns>
        [HttpGet]
        public ActionResult FullArticle(int id, string name, string publicationDate, string text, string tags)
        {
            ViewBag.ArticleId = id;
            ViewBag.Name = name;
            ViewBag.PublicationDate = publicationDate;
            ViewBag.Text = text;
            ViewBag.Tags = tags;
            return View(_repository.GetArticle(id));
        }

        /// <summary>
        /// Creates the Main page with full articles on POST method.
        /// </summary>
        /// <returns>Main page View</returns>
        [HttpPost]
        public ActionResult FullArticle(string personName, string vote)
        {
            ViewBag.PersonName = personName;
            ViewBag.VoteResult = vote;
            return View("VoteResult");
        }
    }
}