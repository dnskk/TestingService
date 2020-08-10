using TestingService.Domain.Entities.Session;

namespace TestingService.Domain.Repositories
{
    /// <inheritdoc cref="ISessionRepository"/>
    public class SessionRepository : ISessionRepository
    {
        private readonly SessionRepositoryOptions _sessionRepositoryOptions;

        public SessionRepository(SessionRepositoryOptions sessionRepositoryOptions)
        {
            _sessionRepositoryOptions = sessionRepositoryOptions;
        }

        /// <inheritdoc />
        public Session Get(string id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Session Create(Session newSession)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Session Update(Session session)
        {
            throw new System.NotImplementedException();
        }
    }
}
