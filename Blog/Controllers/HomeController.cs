using System.Net.Http;
using System.Text;
using System.Web.Mvc;
using Blog.Domain.Interfaces;
using Blog.Infrastructure.Data;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        readonly IRepository _repository;

        public HomeController()
        {
            _repository = new BlogRepository();
        }
        /// <summary>
        /// Creates the Index page.
        /// </summary>
        /// <returns>Index page View</returns>
        public ActionResult Index()
        {
            return View(_repository.GetArticlesList());
        }
        /// <summary>
        /// Creates the Main page.
        /// </summary>
        /// <returns>Main page View</returns>
        public ActionResult MainPage()
        {
            return View(_repository.GetArticlesList());
        }
        /// <summary>
        /// Creates the Guest page.
        /// </summary>
        /// <returns>Guest page View</returns>
        public ActionResult Guest()
        {
            return View(_repository.GetResponsesList());
        }
        /// <summary>
        /// Creates the Question form page.
        /// </summary>
        /// <param name="name">Question name</param>
        /// <param name="check">Question check-state</param>
        /// <param name="personName">Name of the person who asked the question</param>
        /// <returns>Question Form if HttpMethod is GET</returns>
        /// <returns>ResultQuestion if HttpMethod is POST</returns>
        public ActionResult QuestionForm(string name, string[] check, string personName)
        {
            if (Request.HttpMethod == HttpMethod.Get.Method)
            {
                return View(_repository.GetQuestionsList());
            }
            ViewBag.Name = name;
            StringBuilder sb = new StringBuilder();
            foreach (var item in check)
            {
                sb.Append(item + "\n");
            }
            ViewBag.Checks = sb.ToString();
            ViewBag.PersonName = personName;

            return View("ResultQuestion");
        }
    }
}