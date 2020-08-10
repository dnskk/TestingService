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
        public async Task<TestInfo> GetTest(string testId, CancellationToken token)
        {
            var result = await _testRepository.Get(testId, token);

            return result;
        }

        /// <inheritdoc />
        public async Task<TestInfo> CreateTest(TestInfo newTestInfo, CancellationToken token)
        {
            var result = await _testRepository.Create(newTestInfo, token);

            return result;
        }

        /// <inheritdoc />
        public async Task<TestInfo> UpdateTest(TestInfo testInfo, CancellationToken token)
        {
            var result = await _testRepository.Update(testInfo, token);

            return result;
        }
    }
}
