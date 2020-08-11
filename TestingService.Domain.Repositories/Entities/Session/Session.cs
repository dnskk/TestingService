using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TestingService.Domain.Repositories.Entities.Session
{
    /// <summary>
    /// Test session.
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Session ID.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// Test ID.
        /// </summary>
        public string TestId { get; set; }

        /// <summary>
        /// User name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// User email.
        /// </summary>
        public string UserEmail { get; set; }

        /// <summary>
        /// Test result.
        /// </summary>
        public Result Result { get; set; }
    }
}
