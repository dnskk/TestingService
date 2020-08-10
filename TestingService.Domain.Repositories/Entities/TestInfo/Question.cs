namespace TestingService.Domain.Repositories.Entities.TestInfo
{
    /// <summary>
    /// Question information (for administrator).
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
        public string Value { get; set; }

        /// <summary>
        /// Answers.
        /// </summary>
        public Answer[] Answers { get; set; }
    }
}
