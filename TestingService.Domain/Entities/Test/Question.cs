namespace TestingService.Domain.Entities.Test
{
    /// <summary>
    /// Question.
    /// </summary>
    public class Question
    {
        /// <summary>
        /// Question ID.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Question value.
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// Possible answers.
        /// </summary>
        public Answer[] Answers { get; set; }
    }
}
