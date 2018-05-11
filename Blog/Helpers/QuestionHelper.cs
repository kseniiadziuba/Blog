using System.Web.Mvc;
using Blog.Domain.Core;

namespace Blog.Helpers
{
    /// <summary>
    /// Creates a Question Helper class.
    /// </summary>
    public static class QuestionHelper
    {
        /// <summary>
        /// Expansion method, that creates a question list.
        /// </summary>
        /// <param name="html">Supports the rendering of HTML controls in the view.</param>
        /// <param name="item">Question item</param>
        /// <returns></returns>
        public static MvcHtmlString QuestionList(this HtmlHelper html, Question item)
        {
            TagBuilder ul = new TagBuilder("ul");
            TagBuilder li = new TagBuilder("li");
            li.SetInnerText(item.Name);
            ul.InnerHtml += li.ToString();
            return new MvcHtmlString(ul.ToString());
        }
    }
}