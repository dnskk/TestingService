using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestingService.Contracts.Session;
using TestingService.Contracts.Test;
using TestingService.Domain.Entities.Session;
using TestingService.Domain.Services;

namespace TestingService.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SessionController : ControllerBase
    {
        private readonly ISessionService _sessionService;
        private readonly IMapper _mapper;
        private readonly ILogger<SessionController> _logger;

        public SessionController(ISessionService sessionService, IMapper mapper, ILogger<SessionController> logger)
        {
            _sessionService = sessionService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [Route("{sessionId}")]
        public async Task<ActionResult<SessionDto>> Get(string sessionId, CancellationToken token)
        {
            var result = await _sessionService.GetSessionAsync(sessionId, token);

            return _mapper.Map<SessionDto>(result);
        }

        [HttpPost]
        public async Task<ActionResult<SessionDto>> Create(SessionDto newSession, CancellationToken token)
        {
            var sessionDomain = _mapper.Map<Session>(newSession);
            var result = await _sessionService.CreateSessionAsync(sessionDomain, token);

            return _mapper.Map<SessionDto>(result);
        }

        [HttpGet]
        [Route("{sessionId}")]
        public async Task<ActionResult<TestDto>> GetTest(string sessionId, CancellationToken token)
        {
            var result = await _sessionService.GetTestAsync(sessionId, token);

            return _mapper.Map<TestDto>(result);
        }

        [HttpPut]
        public async Task<ActionResult<SessionDto>> Complete(SessionDto session, CancellationToken token)
        {
            var sessionDomain = _mapper.Map<Session>(session);
            var result = await _sessionService.CompleteSessionAsync(sessionDomain, token);

            return _mapper.Map<SessionDto>(result);
        }
    }
}
