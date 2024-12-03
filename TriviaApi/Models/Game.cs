using System.Text.Json.Serialization;

namespace TriviaApi.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public string Category { get; set; }

        public int UserId { get; set; }
        [JsonIgnore]
        public User? User { get; set; } = default!;

    }
}
