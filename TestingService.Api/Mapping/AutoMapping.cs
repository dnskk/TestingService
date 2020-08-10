using AutoMapper;
using TestInfoMongo = TestingService.Domain.Repositories.Entities.TestInfo.Test;
using TestInfoDomain = TestingService.Domain.Entities.TestInfo.TestInfo;

namespace TestingService.Api.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<TestInfoMongo, TestInfoDomain>();
            CreateMap<TestInfoDomain, TestInfoMongo>();
        }
    }
}
