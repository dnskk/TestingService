using System.Threading;
using System.Threading.Tasks;
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
        Task<Session> GetAsync(string id, CancellationToken token);

        /// <summary>
        /// Create new test session.
        /// </summary>
        Task<Session> CreateAsync(Session newSession, CancellationToken token);

        /// <summary>
        /// Update test session.
        /// </summary>
        Task<Session> UpdateAsync(Session session, CancellationToken token);
    }
}
