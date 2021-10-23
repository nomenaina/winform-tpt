using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Pari
    {
        public string id { get; set; }
        public string client_id {get; set;}
        public MatchInfo match_info { get; set; }
        public string sport_category { get; set; }
        public float amount_of_bets { get; set; }
        public float multiplicator { get; set; }
        public string creation_date { get; set; }
    }
}
