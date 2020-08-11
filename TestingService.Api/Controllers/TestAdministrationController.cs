using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestingService.Contracts.TestInfo;
using TestingService.Domain.Entities.TestInfo;
using TestingService.Domain.Services;

namespace TestingService.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]    
    public class TestAdministrationController : ControllerBase
    {
        private readonly ITestAdministrationService _testAdministrationService;
        private readonly IMapper _mapper;
        private readonly ILogger<TestAdministrationController> _logger;

        public TestAdministrationController(ITestAdministrationService testAdministrationService, IMapper mapper, ILogger<TestAdministrationController> logger)
        {
            _testAdministrationService = testAdministrationService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [Route("{testId}")]
        public async Task<ActionResult<TestInfoDto>> Get(string testId, CancellationToken token)
        {
            var result = await _testAdministrationService.GetTestAsync(testId, token);

            return _mapper.Map<TestInfoDto>(result);
        }

        [HttpPost]
        public async Task<ActionResult<TestInfoDto>> Create(TestInfoDto newTestInfo, CancellationToken token)
        {
            var testInfoDomain = _mapper.Map<TestInfo>(newTestInfo);
            var result = await _testAdministrationService.CreateTestAsync(testInfoDomain, token);

            return _mapper.Map<TestInfoDto>(result);
        }

        [HttpPut]
        public async Task<ActionResult<TestInfoDto>> Update(TestInfoDto testInfo, CancellationToken token)
        {
            var testInfoDomain = _mapper.Map<TestInfo>(testInfo);
            var result = await _testAdministrationService.UpdateTestAsync(testInfoDomain, token);

            return _mapper.Map<TestInfoDto>(result);
        }
    }
}
