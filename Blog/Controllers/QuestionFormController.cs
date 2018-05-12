using System.Net.Http;
using System.Text;
using System.Web.Mvc;
using Blog.Domain.Interfaces;
using Blog.Infrastructure.Data;

namespace Blog.Controllers
{
    public class QuestionFormController : Controller
    {
        private readonly IRepository _repository;

        public QuestionFormController()
        {
            _repository = new BlogRepository();
        }
        /// <summary>
        /// Creates the Question form page.
        /// </summary>
        /// <param name="name">Question name</param>
        /// <param name="check">Question check-state</param>
        /// <param name="personName">Name of the person who asked the question</param>
        /// <returns>Question Form if HttpMethod is GET</returns>
        /// <returns>ResultQuestion if HttpMethod is POST</returns>
        public ActionResult Index(string name, string[] check, string personName)
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