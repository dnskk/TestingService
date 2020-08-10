using TestingService.Domain.Entities.TestInfo;

namespace TestingService.Domain.Services
{
    /// <summary>
    /// Test administration service.
    /// </summary>
    public interface ITestAdministrationService
    {
        /// <summary>
        /// Get test by ID.
        /// </summary>
        TestInfo GetTest(string testId);

        /// <summary>
        /// Create new test.
        /// </summary>
        TestInfo CreateTest(TestInfo newTestInfo);

        /// <summary>
        /// Update test.
        /// </summary>
        TestInfo UpdateTest(TestInfo testInfo);
    }
}
