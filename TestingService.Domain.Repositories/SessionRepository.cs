using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MongoDB.Driver;
using TestingService.Domain.Entities.Session;
using SessionMongo = TestingService.Domain.Repositories.Entities.Session.Session;

namespace TestingService.Domain.Repositories
{
    /// <inheritdoc cref="ISessionRepository"/>
    public class SessionRepository : ISessionRepository
    {
        private readonly IMongoCollection<SessionMongo> _sessions;
        private readonly IMapper _mapper;

        public SessionRepository(SessionRepositoryOptions sessionRepositoryOptions, IMapper mapper)
        {
            var client = new MongoClient(sessionRepositoryOptions.ConnectionString);
            var database = client.GetDatabase(sessionRepositoryOptions.DatabaseName);

            _sessions = database.GetCollection<SessionMongo>(sessionRepositoryOptions.CollectionName);

            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<Session> GetAsync(string id, CancellationToken token)
        {
            var result = await _sessions.FindAsync(p => p.Id == id, null, token);
            var sessionMongo = result.FirstOrDefault();

            return _mapper.Map<Session>(sessionMongo);
        }

        /// <inheritdoc />
        public async Task<Session> CreateAsync(Session newSession, CancellationToken token)
        {
            var sessionMongo = _mapper.Map<SessionMongo>(newSession);

            var options = new InsertOneOptions
            {
                BypassDocumentValidation = false
            };

            await _sessions.InsertOneAsync(sessionMongo, options, token);

            return _mapper.Map<Session>(sessionMongo);
        }

        /// <inheritdoc />
        public async Task<Session> UpdateAsync(Session session, CancellationToken token)
        {
            var sessionMongo = _mapper.Map<SessionMongo>(session);

            var options = new ReplaceOptions
            {
                BypassDocumentValidation = false
            };

            await _sessions.ReplaceOneAsync(p => p.Id == sessionMongo.Id, sessionMongo, options, token);

            return _mapper.Map<Session>(sessionMongo);
        }
    }
}
