﻿using TestingService.Domain.Entities.TestInfo;

namespace TestingService.Domain.Repositories
{
    /// <summary>
    /// Test repository.
    /// </summary>
    public interface ITestRepository
    {
        /// <summary>
        /// Get test by ID.
        /// </summary>
        TestInfo Get(string id);

        /// <summary>
        /// Create new test.
        /// </summary>
        TestInfo Create(TestInfo newTestInfo);

        /// <summary>
        /// Update test.
        /// </summary>
        TestInfo Update(TestInfo testInfo);
    }
}
