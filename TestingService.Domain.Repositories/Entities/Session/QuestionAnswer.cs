namespace TestingService.Domain.Repositories.Entities.Session
{
    /// <summary>
    /// Test question answer.
    /// </summary>
    public class QuestionAnswer
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
