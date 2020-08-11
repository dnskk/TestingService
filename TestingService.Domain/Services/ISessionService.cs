using System.Threading;
using System.Threading.Tasks;
using TestingService.Domain.Entities.Session;
using TestingService.Domain.Entities.Test;

namespace TestingService.Domain.Services
{
    /// <summary>
    /// Test session service.
    /// </summary>
    public interface ISessionService
    {
        /// <summary>
        /// Get test session by ID.
        /// </summary>
        Task<Session> GetSessionAsync(string sessionId, CancellationToken token);

        /// <summary>
        /// Create new test session.
        /// </summary>
        Task<Session> CreateSessionAsync(Session newSession, CancellationToken token);

        /// <summary>
        /// Get test by session ID.
        /// </summary>
        Task<Test> GetTestAsync(string sessionId, CancellationToken token);

        /// <summary>
        /// Complete test session.
        /// </summary>
        Task<Session> CompleteSessionAsync(Session session, CancellationToken token);
    }
}
