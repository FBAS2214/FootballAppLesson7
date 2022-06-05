using FootballApp.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp.Models
{
    public static class FakeDataService
    {
        public static List<string> GetCountryNames()
            => CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                .Select(c => new RegionInfo(c.Name).EnglishName)
                .Distinct()
                .OrderBy(countryName => countryName)
                .ToList();


        public static List<Player> GetPlayers()
            => new List<Player>() 
            {
                new Player{ Name = "Elgun", Number = 9, Position = Position.F },
                new Player{ Name = "Agametleb", Number = 2, Position = Position.F },
                new Player{ Name = "Nihat", Number = 8, Position = Position.F },
                new Player{ Name = "Ceyhun", Number = 1, Position = Position.MD },
                new Player{ Name = "Nihad", Number = 4, Position = Position.MD },
                new Player{ Name = "Farman", Number = 3, Position = Position.MD },
                new Player{ Name = "Leyla", Number = 7, Position = Position.DD },
                new Player{ Name = "Sebine", Number = 10, Position = Position.DD },
                new Player{ Name = "Cefer", Number = 5, Position = Position.DD },
                new Player{ Name = "Kənan", Number = 6, Position = Position.DD },
                new Player{ Name = "Tural", Number = 11, Position = Position.GK }
            };



        public static List<string> GetTacticFormats()
           => new List<string>
           {
               "4-3-3",
               "4-4-2",
               "4-5-1",
               "3-4-3",
               "3-5-2",
               "2-3-5",
           };
    }
}
