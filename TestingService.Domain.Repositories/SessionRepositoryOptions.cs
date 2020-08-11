namespace TestingService.Domain.Repositories
{
    /// <summary>
    /// Session repository options.
    /// </summary>
    public class SessionRepositoryOptions
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
