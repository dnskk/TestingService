namespace TestingService.Contracts.Test
{
    /// <summary>
    /// Available answer for question.
    /// </summary>
    public class AnswerDto
    {
        /// <summary>
        /// Answer ID.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Answer value.
        /// </summary>
        public string Answer { get; set; }
    }
}
