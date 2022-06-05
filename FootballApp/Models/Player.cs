using FootballApp.Enums;


namespace FootballApp.Models
{
    public class Player
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public byte Number { get; set; }
        public Position Position { get; set; }
    }
}
