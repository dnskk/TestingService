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
        TestInfo Get(string testId);

        /// <summary>
        /// Create new test.
        /// </summary>
        TestInfo Create(TestInfo newTestInfo);

        /// <summary>
        /// Update test.
        /// </summary>
        TestInfo Update(TestInfo testInfo);
    }
}
