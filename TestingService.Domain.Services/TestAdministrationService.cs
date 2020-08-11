using System.Threading;
using System.Threading.Tasks;
using TestingService.Domain.Entities.TestInfo;
using TestingService.Domain.Repositories;
using TestingService.Domain.Services.Validators;

namespace TestingService.Domain.Services
{
    /// <inheritdoc cref="ITestAdministrationService"/>
    public class TestAdministrationService : ITestAdministrationService
    {
        private readonly ITestRepository _testRepository;
        private readonly ITestInfoValidator _testInfoValidator;

        public TestAdministrationService(ITestRepository testRepository, ITestInfoValidator testInfoValidator)
        {
            _testRepository = testRepository;
            _testInfoValidator = testInfoValidator;
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
            _testInfoValidator.Validate(newTestInfo);

            var result = await _testRepository.CreateAsync(newTestInfo, token);

            return result;
        }

        /// <inheritdoc />
        public async Task<TestInfo> UpdateTestAsync(TestInfo testInfo, CancellationToken token)
        {
            _testInfoValidator.Validate(testInfo);

            var result = await _testRepository.UpdateAsync(testInfo, token);

            return result;
        }
    }
}
