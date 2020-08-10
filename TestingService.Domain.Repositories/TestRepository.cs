using TestingService.Domain.Entities.TestInfo;
using TestingService.Domain.Repositories.Entities.TestInfo;

namespace TestingService.Domain.Repositories
{
    /// <inheritdoc cref="ITestRepository"/>
    public class TestRepository : ITestRepository
    {
        private readonly TestRepositoryOptions _testRepositoryOptions;

        public TestRepository(TestRepositoryOptions testRepositoryOptions)
        {
            _testRepositoryOptions = testRepositoryOptions;
        }

        /// <inheritdoc />
        public Test Get(string id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Test Create(Test newTestInfo)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Test Update(Test testInfo)
        {
            throw new System.NotImplementedException();
        }
    }
}
