using NUnit.Framework;
using TestingService.Domain.Entities.TestInfo;
using TestingService.Domain.Exceptions;
using TestingService.Domain.Services.Validators;

namespace TestingService.Tests
{
    public class TestInfoValidatorTests
    {
        private ITestInfoValidator _testInfoValidator;

        [SetUp]
        public void Setup()
        {
            _testInfoValidator = new TestInfoValidator();
        }

        [Test]
        public void TestInfoWithoutTitleTest()
        {
            var testInfo = new TestInfo
            {
                Id = "123",
                Title = null,
                Questions = new[] {new QuestionInfo()}
            };

            Assert.Throws<InvalidTestException>(() => _testInfoValidator.Validate(testInfo), "Test title cannot be null");
        }

        [Test]
        public void TestInfoWithNullQuestionsTest()
        {
            var testInfo = new TestInfo
            {
                Id = "123",
                Title = "Test title",
                Questions = null
            };

            Assert.Throws<InvalidTestException>(() => _testInfoValidator.Validate(testInfo), "Questions cannot be empty");
        }

        [Test]
        public void TestInfoWithEmptyQuestionsTest()
        {
            var testInfo = new TestInfo
            {
                Id = "123",
                Title = "Test title",
                Questions = new QuestionInfo[0]
            };

            Assert.Throws<InvalidTestException>(() => _testInfoValidator.Validate(testInfo), "Questions cannot be empty");
        }
    }
}