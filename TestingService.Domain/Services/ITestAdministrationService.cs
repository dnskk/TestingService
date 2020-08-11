using System.Threading;
using System.Threading.Tasks;
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
        Task<TestInfo> GetTestAsync(string testId, CancellationToken token);

        /// <summary>
        /// Create new test.
        /// </summary>
        Task<TestInfo> CreateTestAsync(TestInfo newTestInfo, CancellationToken token);

        /// <summary>
        /// Update test.
        /// </summary>
        Task<TestInfo> UpdateTestAsync(TestInfo testInfo, CancellationToken token);
    }
}
