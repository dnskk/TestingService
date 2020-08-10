namespace TestingService.Contracts.TestInfo
{
    /// <summary>
    /// Test information (for administrator).
    /// </summary>
    public class TestInfoDto
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
        public QuestionInfoDto Questions { get; set; }
    }
}
