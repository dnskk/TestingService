namespace TestingService.Domain.Repositories
{
    /// <summary>
    /// Test repository options.
    /// </summary>
    public class TestRepositoryOptions
    {
        /// <summary>
        /// DB connection string.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// DB name.
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Collection name.
        /// </summary>
        public string CollectionName { get; set; }
    }
}
