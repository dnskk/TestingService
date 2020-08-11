using AutoMapper;
using TestingService.Contracts.TestInfo;
using TestInfoDomain = TestingService.Domain.Entities.TestInfo.TestInfo;
using TestInfoMongo = TestingService.Domain.Repositories.Entities.TestInfo.Test;
using QuestionInfoDomain = TestingService.Domain.Entities.TestInfo.QuestionInfo;
using QuestionInfoMongo = TestingService.Domain.Repositories.Entities.TestInfo.Question;
using AnswerInfoDomain = TestingService.Domain.Entities.TestInfo.AnswerInfo;
using AnswerInfoMongo = TestingService.Domain.Repositories.Entities.TestInfo.Answer;

namespace TestingService.Api.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<TestInfoDto, TestInfoDomain>();
            CreateMap<TestInfoDomain, TestInfoDto>();

            CreateMap<TestInfoDomain, TestInfoMongo>();
            CreateMap<TestInfoMongo, TestInfoDomain>();

            CreateMap<QuestionInfoDto, QuestionInfoDomain>();
            CreateMap<QuestionInfoDomain, QuestionInfoDto>();

            CreateMap<QuestionInfoDomain, QuestionInfoMongo>();
            CreateMap<QuestionInfoMongo, QuestionInfoDomain>();

            CreateMap<AnswerInfoDto, AnswerInfoDomain>();
            CreateMap<AnswerInfoDomain, AnswerInfoDto>();

            CreateMap<AnswerInfoDomain, AnswerInfoMongo>();
            CreateMap<AnswerInfoMongo, AnswerInfoDomain>();
        }
    }
}
