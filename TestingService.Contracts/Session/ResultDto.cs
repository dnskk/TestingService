namespace TestingService.Contracts.Session
{
    /// <summary>
    /// Test result.
    /// </summary>
    public class ResultDto
    {
        /// <summary>
        /// Question answers.
        /// </summary>
        public QuestionAnswerDto[] QuestionAnswers { get; set; }
    }
}
