using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballAPIConsole
{
    class Match
    {
        public int match_id { get; set; }
            
        public string match_hometeam_score { get; set; }
        public string match_awayteam_name { get; set; }
        public string match_awayteam_score { get; set; }

        public Goalscorer goalscorer { get; set; }
    }
}
