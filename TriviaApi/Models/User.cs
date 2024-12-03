using System.Text.Json.Serialization;

namespace TriviaApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        [JsonIgnore]
        public ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
