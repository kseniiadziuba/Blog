using System.Net.Http;
using System.Web.Mvc;
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
        public ActionResult Index(string person, string response)
        {
            if (Request.HttpMethod == HttpMethod.Get.Method)
            {
                return View(_repository.GetResponsesList());
            }
            ViewBag.AuthorName = person;
            ViewBag.Text = response;
            return View("GuestResponse");
        }
    }
}