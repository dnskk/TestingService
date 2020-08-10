namespace TestingService.Contracts.Test
{
    /// <summary>
    /// Question.
    /// </summary>
    public class QuestionDto
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
        /// Possible answers.
        /// </summary>
        public AnswerDto[] Answers { get; set; }
    }
}
