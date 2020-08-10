using TestingService.Domain.Entities.Session;

namespace TestingService.Domain.Repositories
{
    /// <summary>
    /// Test session repository.
    /// </summary>
    public interface ISessionRepository
    {
        /// <summary>
        /// Get test session by ID.
        /// </summary>
        Session Get(string id);

        /// <summary>
        /// Create new test session.
        /// </summary>
        Session Create(Session newSession);

        /// <summary>
        /// Update test session.
        /// </summary>
        Session Update(Session session);
    }
}
