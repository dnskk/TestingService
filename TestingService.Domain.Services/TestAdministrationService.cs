using System.Threading;
using System.Threading.Tasks;
using TestingService.Domain.Entities.TestInfo;
using TestingService.Domain.Repositories;

namespace TestingService.Domain.Services
{
    /// <inheritdoc cref="ITestAdministrationService"/>
    public class TestAdministrationService : ITestAdministrationService
    {
        private readonly ITestRepository _testRepository;

        public TestAdministrationService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        /// <inheritdoc />
        public async Task<TestInfo> GetTestAsync(string testId, CancellationToken token)
        {
            var result = await _testRepository.GetAsync(testId, token);

            return result;
        }

        /// <inheritdoc />
        public async Task<TestInfo> CreateTestAsync(TestInfo newTestInfo, CancellationToken token)
        {
            var result = await _testRepository.CreateAsync(newTestInfo, token);

            return result;
        }

        /// <inheritdoc />
        public async Task<TestInfo> UpdateTestAsync(TestInfo testInfo, CancellationToken token)
        {
            var result = await _testRepository.UpdateAsync(testInfo, token);

            return result;
        }
    }
}
