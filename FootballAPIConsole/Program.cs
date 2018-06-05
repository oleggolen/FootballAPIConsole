using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FootballAPIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = ConfigurationSettings.AppSettings["apikey"];
            HttpClient client = new HttpClient();
            var json =client.GetStringAsync("https://apifootball.com/api/?action=get_countries&APIkey=" + key).Result;
            var countries = JsonConvert.DeserializeObject<IEnumerable<County>>(json);
            json = client.GetStringAsync("https://apifootball.com/api/?action=get_leagues&country_id=169&APIkey=" +
                key).Result;
            var leagues = JsonConvert.DeserializeObject<IEnumerable<League>>(json);
            json = client.GetStringAsync(
                "https://apifootball.com/api/?action=get_events&from=2018-05-13&to=2018-05-13&league_id=169&APIkey=" +
                key).Result;
                var match = JsonConvert.DeserializeObject<IEnumerable<Match>>(json);

        }
    }
}
