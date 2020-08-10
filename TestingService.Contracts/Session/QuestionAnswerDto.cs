namespace TestingService.Contracts.Session
{
    /// <summary>
    /// Test question answer.
    /// </summary>
    public class QuestionAnswerDto
    {
        /// <summary>
        /// Question ID.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// IDs of selected answers.
        /// </summary>
        public long[] SelectedAnswers { get; set; }
    }
}
