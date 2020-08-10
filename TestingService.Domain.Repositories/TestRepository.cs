using TestingService.Domain.Entities.TestInfo;

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
        public TestInfo Get(string id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public TestInfo Create(TestInfo newTestInfo)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public TestInfo Update(TestInfo testInfo)
        {
            throw new System.NotImplementedException();
        }
    }
}
