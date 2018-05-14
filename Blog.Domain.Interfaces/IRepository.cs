using Blog.Domain.Core;
using System.Collections.Generic;

namespace Blog.Domain.Interfaces
{
    public interface IRepository
    {
        /// <summary>
        /// Creates the list of articles.
        /// </summary>
        /// <returns>IEnumerable&lt;Article&gt;</returns>
        IEnumerable<Article> GetArticlesList();

        /// <summary>
        /// Creates the list of questions.
        /// </summary>
        /// <returns>IEnumerable&lt;Question&gt;</returns>
        IEnumerable<Question> GetQuestionsList();

        Response CreateResponse();

        Article GetArticle(int id);
    }
}