namespace TestingService.Domain.Entities.TestInfo
{
    /// <summary>
    /// Test information (for administrator).
    /// </summary>
    public class TestInfo
    {
        /// <summary>
        /// Test ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Test title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Questions.
        /// </summary>
        public QuestionInfo Questions { get; set; }
    }
}
