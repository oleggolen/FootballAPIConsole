using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballAPIConsole
{
    class FootballDataOrg
    {
        public class Welcome
        {
            public List<Competition> Competitions { get; set; }
        }

        public class Competition
        {
            public Area Area { get; set; }
            public string Name { get; set; }
            public CurrentSeason CurrentSeason { get; set; }
            public DateTimeOffset LastUpdated { get; set; }
        }

        public class Area
        {
            public long Id { get; set; }
            public string Name { get; set; }
        }

        public class CurrentSeason
        {
            public DateTimeOffset StartDate { get; set; }
            public DateTimeOffset EndDate { get; set; }
        }
    }
}
