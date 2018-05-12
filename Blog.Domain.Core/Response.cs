using System;

namespace Blog.Domain.Core
{
    public class Response
    {
        /// <summary>
        /// ResponseId property represents the unique id of the response.
        /// </summary>
        /// <value>ResponseId gets/sets the int value for id of the response.</value>
        public int ResponseId { get; set; }

        /// <summary>
        /// AuthorName property represents the author's name of the question.
        /// </summary>
        /// <value>AuthorName gets/sets the string value for author's name of the question.</value>
        public string AuthorName { get; set; }

        /// <summary>
        /// ResponseDate property represents the date of the response.
        /// </summary>
        /// <value>ResponseDate gets/sets the DateTime value for date of the response.</value>
        public DateTime ResponseDate { get; set; }

        /// <summary>
        /// Text property represents the text of the response.
        /// </summary>
        /// <value>Text gets/sets the string value for text of the response.</value>
        public string Text { get; set; }
    }
}