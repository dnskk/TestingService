namespace TestingService.Contracts.Session
{
    /// <summary>
    /// Test session.
    /// </summary>
    public class SessionDto
    {
        /// <summary>
        /// Session ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Test ID.
        /// </summary>
        public string TestId { get; set; }

        /// <summary>
        /// User name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// User email.
        /// </summary>
        public string UserEmail { get; set; }

        /// <summary>
        /// Test result.
        /// </summary>
        public ResultDto Result { get; set; }
    }
}
