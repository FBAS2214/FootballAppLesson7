using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp.Models
{
    public static class FakeDataService
    {
        public static List<string> GetCountryNames()
            => new List<string>();

        public static List<Player> GetPlayers()
            => new List<Player>();

        public static List<string> GetTacticFormats()
           => new List<string>();
    }
}
