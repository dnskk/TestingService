using System;
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
        public TestInfo GetTest(string testId)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public TestInfo CreateTest(TestInfo newTestInfo)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public TestInfo UpdateTest(TestInfo testInfo)
        {
            throw new NotImplementedException();
        }
    }
}
