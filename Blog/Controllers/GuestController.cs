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
        /// Creates the Guest page.
        /// </summary>
        /// <returns>Guest page View</returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View(_repository.CreateResponse());
        }

        [HttpPost]
        public ActionResult Index(Response response)
        {
            ViewBag.AuthorName = response.AuthorName;
            ViewBag.Text = response.Text;
            return View("GuestResponse");
        }
    }
}