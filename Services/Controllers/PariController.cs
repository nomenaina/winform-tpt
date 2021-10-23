using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Services.Controllers
{
    public class PariController
    {
        private static readonly string baseURL = "https://backoffice-support-tpt.herokuapp.com/api/";
        private static readonly HttpClient httpClient;

        static PariController()
        {
            httpClient = new HttpClient();
        }

        public static async Task<PariResponse> GetListPari(long client_id, int page, int limit)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Global._Access_t);
                HttpResponseMessage Res = await client.GetAsync("bets/client/"+ client_id + "?page=" + page + "&limit=" + limit);
                var status_code = Res.StatusCode.ToString();
                var paris = new List<Pari>();
                if (Res.IsSuccessStatusCode)
                {
                    var result = Res.Content.ReadAsStringAsync().Result;
                    var jsonData = (JObject)JsonConvert.DeserializeObject(result);
                    foreach (var x in jsonData["data"])
                    {
                        paris.Add(new Pari
                        {
                            id = x["id"].Value<string>(),
                            client_id = x["client_id"].Value<string>(),
                            match_info = new MatchInfo
                            {
                               /* competition = x["match_info"]["comptetion"].Value<int>(),  
                                away_team = x["match_info"]["away_team"].Value<string>(),
                                home_team = x["match_info"]["home_team"].Value<string>(),
                                match_id = x["match_info"]["match_id"].Value<int>()*/
                            },
                            amount_of_bets = x["amount_of_bets"].Value<float>(),
                            sport_category = x["sport_category"].Value<string>(),
                            multiplicator = x["multiplicator"].Value<float>()
                        }
                        );

                    }
                }

                return new PariResponse { status_code = status_code, paris = paris };

            }

        }
    }
}
