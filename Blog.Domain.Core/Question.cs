namespace Blog.Domain.Core
{
    /// <summary>
    /// This class represents the question entity.
    /// </summary>
    public class Question
    {
        private string _name;

        /// <summary>
        /// QuestionId property represents the unique id of the question.
        /// </summary>
        /// <value>QuestionId gets/sets the int value for id of the question.</value>
        public int QuestionId { get; set; }

        /// <summary>
        /// Name property represents the name of the question.
        /// </summary>
        /// <value>Name gets the string value for name of the question.</value>
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// Checks property represents checks of questions.
        /// </summary>
        /// <value>Checks gets/sets the string array for checks of questions.</value>
        public string[] Checks { get; set; }

        /// <summary>
        /// PersonName property represents the author's name of the question.
        /// </summary>
        /// <value>PersonName gets/sets the string value for author's name of the question.</value>
        public string PersonName { get; set; }
    }
}