namespace TestingService.Domain.Entities.TestInfo
{
    /// <summary>
    /// Question information (for administrator).
    /// </summary>
    public class QuestionInfo
    {
        /// <summary>
        /// Question ID.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Question value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Answers.
        /// </summary>
        public AnswerInfo[] Answers { get; set; }
    }
}
