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
        Session GetSession(string sessionId);

        /// <summary>
        /// Create new test session.
        /// </summary>
        Session CreateSession(Session newSession);

        /// <summary>
        /// Update test session.
        /// </summary>
        Session UpdateSession(Session session);

        /// <summary>
        /// Get test by session ID.
        /// </summary>
        Test GetTest(string sessionId);
    }
}
