﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Blog.Domain.Core
{
    /// <summary>
    /// This class represents the article entity.
    /// </summary>
    public class Article
    {
        /// <summary>
        /// ArticleId property represents the unique id of the article.
        /// </summary>
        /// <value>ArticleId gets/sets the int value for id of the article.</value>
        public int ArticleId { get; set; }

        /// <summary>
        /// Name property represents the author's name of the article.
        /// </summary>
        /// <value>Name gets the string value for author's name of the article.</value>
        [Microsoft.Build.Framework.Required]
        public string Name { get; set; }

        /// <summary>
        /// Publication Date property represents the publication date of the article.
        /// </summary>
        /// <value>Publication Date gets the DateTime value for publication date of the article.</value>
        public string PublicationDate { get; set; }

        /// <summary>
        /// Text property represents the text of the article.
        /// </summary>
        /// <value>Text gets the string value for text of the article.</value>
        [Microsoft.Build.Framework.Required]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        /// /// <summary>
        /// Creates the article.
        /// </summary>
        public Article()
        { }

        /// <summary>
        /// Creates the article using parameters.
        /// </summary>
        /// <param name="name">Argument for property Name</param>
        /// <param name="publicationDate">Argument for property PublicationDate</param>
        /// <param name="text">Argument for property Text</param>

        public Article(string name, string publicationDate, string text)
        {
            Name = name;
            PublicationDate = (Convert.ToDateTime(publicationDate)).ToShortDateString();
            Text = text;
        }

        public string SearchTags()
        {
            string text = Text;
            Regex regex = new Regex(@"\s(?<hashTag>\@[\w\-\\_]+)");
            MatchCollection matches = regex.Matches(text);
            text = null;
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    text += match.Value + " ";
                }
                return text;
            }
            return default(string);
        }
    }
}