namespace TestingService.Contracts.TestInfo
{
    /// <summary>
    /// Question information (for administrator).
    /// </summary>
    public class QuestionInfoDto
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
        /// Answers.
        /// </summary>
        public AnswerInfoDto[] Answers { get; set; }
    }
}
