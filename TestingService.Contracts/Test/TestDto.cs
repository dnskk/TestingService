namespace TestingService.Contracts.Test
{
    /// <summary>
    /// Test.
    /// </summary>
    public class TestDto
    {
        /// <summary>
        /// Test ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Test session ID.
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Test title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Test questions.
        /// </summary>
        public QuestionDto[] Questions { get; set; }
    }
}
