using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TestingService.Domain.Repositories.Entities.TestInfo
{
    /// <summary>
    /// Test information (for administrator).
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Test ID.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// Test title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Questions.
        /// </summary>
        public Question Questions { get; set; }
    }
}
