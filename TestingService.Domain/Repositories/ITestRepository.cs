using System.Threading;
using System.Threading.Tasks;
using TestingService.Domain.Entities.TestInfo;

namespace TestingService.Domain.Repositories
{
    /// <summary>
    /// Test repository.
    /// </summary>
    public interface ITestRepository
    {
        /// <summary>
        /// Get test by ID.
        /// </summary>
        Task<TestInfo> GetAsync(string id, CancellationToken token);

        /// <summary>
        /// Create new test.
        /// </summary>
        Task<TestInfo> CreateAsync(TestInfo newTestInfo, CancellationToken token);

        /// <summary>
        /// Update test.
        /// </summary>
        Task<TestInfo> UpdateAsync(TestInfo testInfo, CancellationToken token);
    }
}
