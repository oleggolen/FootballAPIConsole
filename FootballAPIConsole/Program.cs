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
            //var key = ConfigurationSettings.AppSettings["apikey"];
            //HttpClient client = new HttpClient();
            //var json =client.GetStringAsync("https://apifootball.com/api/?action=get_countries&APIkey=" + key).Result;
            //var countries = JsonConvert.DeserializeObject<IEnumerable<County>>(json);
            //json = client.GetStringAsync("https://apifootball.com/api/?action=get_leagues&country_id=169&APIkey=" +
            //    key).Result;
            //var leagues = JsonConvert.DeserializeObject<IEnumerable<League>>(json);
            //json = client.GetStringAsync(
            //    "https://apifootball.com/api/?action=get_events&from=2018-05-13&to=2018-05-13&league_id=169&APIkey=" +
            //    key).Result;
            //    var match = JsonConvert.DeserializeObject<IEnumerable<Match>>(json);

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Auth-Token", "5312257dd48a4aadb0c0dac2cb9e6432");
            var resfootball = client.GetStringAsync($"http://api.football-data.org/v2/competitions/").Result;
            var jsonfootball = JsonConvert.DeserializeObject<FootballDataOrg.Welcome>(resfootball);
            Console.WriteLine($"Name      : {jsonfootball.Competitions[0].Name}");
            Console.WriteLine($"Area      : {jsonfootball.Competitions[0].Area.Name}");
            Console.WriteLine($"Id        : {jsonfootball.Competitions[0].Area.Id}");
            Console.WriteLine($"StartDate : {jsonfootball.Competitions[0].CurrentSeason.StartDate}");
            Console.WriteLine($"EndDate   : {jsonfootball.Competitions[0].CurrentSeason.EndDate}");
            Console.WriteLine($"Updated   : {jsonfootball.Competitions[0].LastUpdated}");

            Console.ReadKey();
        }
    }
}
