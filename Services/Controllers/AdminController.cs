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
    public class AdminController
    {
        private static readonly string baseURL = "https://backoffice-support-tpt.herokuapp.com/api/";
        private static readonly HttpClient httpClient;

        static AdminController()
        {
            httpClient = new HttpClient();
        }

        public static async Task<AdminResponse> GetListAdmins()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Global._Access_t);
                HttpResponseMessage Res = await client.GetAsync("admins/all");
                var status_code = Res.StatusCode.ToString();
                var admins = new List<Admin>();
                if (Res.IsSuccessStatusCode)
                {
                    var result = Res.Content.ReadAsStringAsync().Result;
                    var jsonData = (JObject)JsonConvert.DeserializeObject(result);
                    foreach (var x in jsonData["data"])
                    {
                        admins.Add(new Admin
                        {
                            id = x["id"].Value<string>(),
                            name = x["name"].Value<string>(),
                            email = x["email"].Value<string>(),
                        }
                        );

                    }
                }

                return new AdminResponse { status_code = status_code, admins = admins };

            }

        }
    }
}
