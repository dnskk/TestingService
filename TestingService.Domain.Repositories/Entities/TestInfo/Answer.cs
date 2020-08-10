namespace TestingService.Domain.Repositories.Entities.TestInfo
{
    /// <summary>
    /// Answer information (for administrator).
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// Answer ID.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Answer value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Is the answer correct.
        /// </summary>
        public bool IsCorrect { get; set; }
    }
}
