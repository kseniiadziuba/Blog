using System.Collections.Generic;
using System.Linq;
using Blog.Domain.Core;
using Blog.Domain.Interfaces;

namespace Blog.Infrastructure.Data
{
    public class BlogRepository : IRepository
    {
        private readonly BlogDbContext _db;

        /// <summary>
        /// Creates the repository.
        /// </summary>
        public BlogRepository()
        {
            _db = new BlogDbContext("Blog");
        }

        /// <summary>
        /// Creates the list of articles.
        /// </summary>
        /// <returns>IEnumerable&lt;Article&gt;</returns>
        public IEnumerable<Article> GetArticlesList()
        {
            return _db.Articles.ToList();
        }

        /// <summary>
        /// Creates the list of questions.
        /// </summary>
        /// <returns>IEnumerable&lt;Question&gt;</returns>
        public IEnumerable<Question> GetQuestionsList()
        {
            return _db.Questions.ToList();
        }

        /// <summary>
        /// Creates the list of responses.
        /// </summary>
        /// <returns>IEnumerable&lt;Response&gt;</returns>
        public IEnumerable<Response> GetResponsesList()
        {
            return _db.Responses.ToList();
        }

        /// <summary>
        /// Creates a response.
        /// </summary>
        /// <returns>Response</returns>
        public Response CreateResponse()
        {
            Response response = new Response();
            _db.Responses.Add(response);
            return response;
        }

        /// <summary>
        /// Gets the article by id.
        /// </summary>
        /// <param name="id">Id of article that is needed to find.</param>
        /// <returns>Article</returns>
        public Article GetArticle(int id)
        {
            Article article = _db.Articles.Find(id);
            return article;
        }
    }
}