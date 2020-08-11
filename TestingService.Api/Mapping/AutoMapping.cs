using AutoMapper;
using TestingService.Contracts.Session;
using TestingService.Contracts.Test;
using TestingService.Contracts.TestInfo;
using TestInfoDomain = TestingService.Domain.Entities.TestInfo.TestInfo;
using TestInfoMongo = TestingService.Domain.Repositories.Entities.TestInfo.Test;
using QuestionInfoDomain = TestingService.Domain.Entities.TestInfo.QuestionInfo;
using QuestionInfoMongo = TestingService.Domain.Repositories.Entities.TestInfo.Question;
using AnswerInfoDomain = TestingService.Domain.Entities.TestInfo.AnswerInfo;
using AnswerInfoMongo = TestingService.Domain.Repositories.Entities.TestInfo.Answer;

using TestDomain = TestingService.Domain.Entities.Test.Test;
using QuestionDomain = TestingService.Domain.Entities.Test.Question;
using AnswerDomain = TestingService.Domain.Entities.Test.Answer;

using SessionDomain = TestingService.Domain.Entities.Session.Session;
using SessionMongo = TestingService.Domain.Repositories.Entities.Session.Session;
using ResultDomain = TestingService.Domain.Entities.Session.Result;
using ResultMongo = TestingService.Domain.Repositories.Entities.Session.Result;
using QuestionAnswerDomain = TestingService.Domain.Entities.Session.QuestionAnswer;
using QuestionAnswerMongo = TestingService.Domain.Repositories.Entities.Session.QuestionAnswer;

namespace TestingService.Api.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            TestInfoMappings();

            TestMappings();

            SessionMappings();
        }

        private void TestInfoMappings()
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

        private void TestMappings()
        {
            CreateMap<TestDto, TestDomain>();
            CreateMap<TestDomain, TestDto>();

            CreateMap<QuestionDto, QuestionDomain>();
            CreateMap<QuestionDomain, QuestionDto>();

            CreateMap<AnswerDto, AnswerDomain>();
            CreateMap<AnswerDomain, AnswerDto>();

            CreateMap<TestDomain, TestInfoDomain>();
            CreateMap<TestInfoDomain, TestDomain>();
            CreateMap<QuestionDomain, QuestionInfoDomain>();
            CreateMap<QuestionInfoDomain, QuestionDomain>();
            CreateMap<AnswerDomain, AnswerInfoDomain>();
            CreateMap<AnswerInfoDomain, AnswerDomain>();
        }

        private void SessionMappings()
        {
            CreateMap<SessionDto, SessionDomain>();
            CreateMap<SessionDomain, SessionDto>();
            CreateMap<SessionDomain, SessionMongo>();
            CreateMap<SessionMongo, SessionDomain>();

            CreateMap<ResultDto, ResultDomain>();
            CreateMap<ResultDomain, ResultDto>();
            CreateMap<ResultDomain, ResultMongo>();
            CreateMap<ResultMongo, ResultDomain>();

            CreateMap<QuestionAnswerDto, QuestionAnswerDomain>();
            CreateMap<QuestionAnswerDomain, QuestionAnswerDto>();
            CreateMap<QuestionAnswerDomain, QuestionAnswerMongo>();
            CreateMap<QuestionAnswerMongo, QuestionAnswerDomain>();
        }
    }
}
