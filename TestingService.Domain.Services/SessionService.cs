using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using TestingService.Domain.Entities.Session;
using TestingService.Domain.Entities.Test;
using TestingService.Domain.Repositories;

namespace TestingService.Domain.Services
{
    /// <inheritdoc cref="ISessionService"/>
    public class SessionService : ISessionService
    {
        private readonly ISessionRepository _sessionRepository;
        private readonly ITestRepository _testRepository;
        private readonly IMapper _mapper;

        public SessionService(ISessionRepository sessionRepository, ITestRepository testRepository, IMapper mapper)
        {
            _sessionRepository = sessionRepository;
            _testRepository = testRepository;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<Session> GetSessionAsync(string sessionId, CancellationToken token)
        {
            var result = await _sessionRepository.GetAsync(sessionId, token);

            return result;
        }

        /// <inheritdoc />
        public async Task<Session> CreateSessionAsync(Session newSession, CancellationToken token)
        {
            var result = await _sessionRepository.CreateAsync(newSession, token);

            return result;
        }

        /// <inheritdoc />
        public async Task<Test> GetTestAsync(string sessionId, CancellationToken token)
        {
            var session = await GetSessionAsync(sessionId, token);

            var result = await _testRepository.GetAsync(session.TestId, token);

            var test =  _mapper.Map<Test>(result);
            test.SessionId = sessionId;

            return test;
        }

        /// <inheritdoc />
        public async Task<Session> CompleteSessionAsync(Session session, CancellationToken token)
        {
            var result = await GetSessionAsync(session.Id, token);
            result.Result = session.Result;

            await CheckAnswers(result, token);

            result = await _sessionRepository.UpdateAsync(result, token);
            return result;
        }

        private async Task CheckAnswers(Session session, CancellationToken token)
        {
            var testInfo = await _testRepository.GetAsync(session.TestId, token);

            var questions = testInfo.Questions.ToDictionary(p => p.Id);

            var questionAnswers = new List<QuestionAnswer>();

            foreach (var question in questions)
            {
                if (session.Result.QuestionAnswers.All(p => p.Id != question.Key))
                {
                    var answer = new QuestionAnswer
                    {
                        Id = question.Key,
                        IsCorrect = false
                    };

                    questionAnswers.Add(answer);
                }
                else
                {
                    var answer = session.Result.QuestionAnswers.First(p => p.Id == question.Key);
                    var correctAnswers = question.Value.Answers.Where(p => p.IsCorrect).Select(p => p.Id).ToArray();
                    Array.Sort(correctAnswers);
                    Array.Sort(answer.SelectedAnswers);
                    answer.IsCorrect = correctAnswers.SequenceEqual(answer.SelectedAnswers);
                    questionAnswers.Add(answer);
                }
            }

            session.Result.QuestionAnswers = questionAnswers.ToArray();
        }
    }
}
