using System;
using TestingService.Domain.Entities.Session;
using TestingService.Domain.Entities.Test;
using TestingService.Domain.Repositories;

namespace TestingService.Domain.Services
{
    /// <inheritdoc cref="ISessionService"/>
    public class SessionService : ISessionService
    {
        private readonly ISessionRepository _sessionRepository;

        public SessionService(ISessionRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        /// <inheritdoc />
        public Session GetSession(string sessionId)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Session CreateSession(Session newSession)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Session UpdateSession(Session session)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Test GetTest(string sessionId)
        {
            throw new NotImplementedException();
        }
    }
}
