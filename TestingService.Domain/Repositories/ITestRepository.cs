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
        Task<TestInfo> Get(string id, CancellationToken token);

        /// <summary>
        /// Create new test.
        /// </summary>
        Task<TestInfo> Create(TestInfo newTestInfo, CancellationToken token);

        /// <summary>
        /// Update test.
        /// </summary>
        Task<TestInfo> Update(TestInfo testInfo, CancellationToken token);
    }
}
