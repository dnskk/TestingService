using TestingService.Domain.Entities.TestInfo;

namespace TestingService.Domain.Services.Validators
{
    /// <summary>
    /// TestInfo validator
    /// </summary>
    public interface ITestInfoValidator
    {
        /// <summary>
        /// Validate TestInfo object.
        /// </summary>
        void Validate(TestInfo testInfo);
    }
}
