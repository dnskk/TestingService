using TestingService.Domain.Entities.TestInfo;
using TestingService.Domain.Exceptions;

namespace TestingService.Domain.Services.Validators
{
    /// <inheritdoc cref="ITestInfoValidator"/>
    public class TestInfoValidator : ITestInfoValidator
    {
        /// <inheritdoc />
        public void Validate(TestInfo testInfo)
        {
            if (string.IsNullOrEmpty(testInfo.Title))
            {
                throw new InvalidTestException("Test title cannot be null");
            }

            if (testInfo.Questions == null || testInfo.Questions.Length == 0)
            {
                throw new InvalidTestException("Questions cannot be empty");
            }
        }
    }
}
