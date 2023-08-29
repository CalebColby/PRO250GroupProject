using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace card_against_humanity_Project.LAN_Muliplayer
{
    public class LANMuliplayerHost
    {

        public IPAddress hostadresss { get; private set; }
        private List<IPAddress> guests { get; set; }
    }

    public class LANMultiplayerGuest
    {
        public IPAddress me { get; private set; }


    }
}
