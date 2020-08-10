using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MongoDB.Driver;
using TestingService.Domain.Entities.TestInfo;
using TestInfoMongo = TestingService.Domain.Repositories.Entities.TestInfo.Test;

namespace TestingService.Domain.Repositories
{
    /// <inheritdoc cref="ITestRepository"/>
    public class TestRepository : ITestRepository
    {
        private readonly IMongoCollection<TestInfoMongo> _tests;
        private readonly IMapper _mapper;

        public TestRepository(TestRepositoryOptions testRepositoryOptions, IMapper mapper)
        {
            var client = new MongoClient(testRepositoryOptions.ConnectionString);
            var database = client.GetDatabase(testRepositoryOptions.DatabaseName);

            _tests = database.GetCollection<TestInfoMongo>(testRepositoryOptions.CollectionName);

            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<TestInfo> Get(string id, CancellationToken token)
        {
            var result = await _tests.FindAsync(p => p.Id == id, null, token);
            var testInfoMongo = result.FirstOrDefault();

            return _mapper.Map<TestInfo>(testInfoMongo);
        }

        /// <inheritdoc />
        public async Task<TestInfo> Create(TestInfo newTestInfo, CancellationToken token)
        {
            var testInfoMongo = _mapper.Map<TestInfoMongo>(newTestInfo);

            var options = new InsertOneOptions
            {
                BypassDocumentValidation = false
            };

            await _tests.InsertOneAsync(testInfoMongo, options, token);

            return _mapper.Map<TestInfo>(testInfoMongo);
        }

        /// <inheritdoc />
        public async Task<TestInfo> Update(TestInfo testInfo, CancellationToken token)
        {
            var testInfoMongo = _mapper.Map<TestInfoMongo>(testInfo);

            var options = new ReplaceOptions
            {
                BypassDocumentValidation = false
            };

            await _tests.ReplaceOneAsync(p => p.Id == testInfoMongo.Id,testInfoMongo, options, token);

            return _mapper.Map<TestInfo>(testInfoMongo);
        }
    }
}
