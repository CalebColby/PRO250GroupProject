using System.Net;

namespace CAHP_ASP.Models
{
    public class Player
    {
        public string Name { get; set; }
        public IPAddress playerAddress { get; set; }
        public bool cardCzar { get; set; } = false;
        public Player(string name)
        {
            this.Name = name;
            this.playerAddress = Dns.GetHostAddresses("")[0];
        }
        public Player(string name, IPAddress playerAddress)
        {
            this.Name = name;
            this.playerAddress = playerAddress;
        }
    }
}
