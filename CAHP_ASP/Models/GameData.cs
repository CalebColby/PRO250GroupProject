namespace CAHP_ASP.Models
{
    public class GameData
    {
        public int Id { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
    }
}
