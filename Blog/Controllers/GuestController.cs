using System.Web.Mvc;
using Blog.Domain.Core;
using Blog.Domain.Interfaces;
using Blog.Infrastructure.Data;

namespace Blog.Controllers
{
    public class GuestController : Controller
    {
        private readonly IRepository _repository;

        public GuestController()
        {
            _repository = new BlogRepository();
        }

        /// <summary>
        /// Creates the Guest page on GET method.
        /// </summary>
        /// <returns>Guest page View</returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View(_repository.CreateResponse());
        }

        /// <summary>
        /// Creates the Guest page on POST method.
        /// </summary>
        /// <returns>Guest page View</returns>
        [HttpPost]
        public ActionResult Index(Response response)
        {
            ViewBag.AuthorName = response.AuthorName;
            ViewBag.Text = response.Text;
            return View("GuestResponse");
        }
    }
}