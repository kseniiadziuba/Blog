using System;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "Input your name!")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Your name should be min 2, max 15!")]
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
        [Required(ErrorMessage = "You have to write a response!")]
        public string Text { get; set; }
    }
}