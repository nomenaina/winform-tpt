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
using System.Web.Http;

namespace Services.Controllers
{
    public class ClientController : ApiController
    {
        private static readonly string baseURL = "https://backoffice-support-tpt.herokuapp.com/api/";
        private static readonly HttpClient httpClient;

        static ClientController()
        {
            httpClient = new HttpClient();
        }

        public static async Task<ClientResponse> GetListClient(int page, int limit)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Global._Access_t);
                HttpResponseMessage Res = await client.GetAsync("users?page=" + page + "&limit=" + limit);
                var status_code = Res.StatusCode.ToString();
                var clients = new List<Client>();
                if (Res.IsSuccessStatusCode)
                {
                    var result = Res.Content.ReadAsStringAsync().Result;
                    var jsonData = (JObject)JsonConvert.DeserializeObject(result);
                    foreach (var x in jsonData["data"])
                    {
                        clients.Add(new Client 
                            { 
                                id = x["id"].Value<string>(),
                                firstname = x["firstname"].Value<string>(),
                                lastname = x["lastname"].Value<string>(),
                                betcredit = x["betcredit"].Value<float>(),
                                email = x["email"].Value<string>(),
                                phone = x["phone"].Value<string>()
                            }
                        );

                    }
                }
                
                return new ClientResponse { status_code = status_code, clients = clients };

            }

        }

        public static async Task<ClientResponse> EditListClient(int page, int limit)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Global._Access_t);
                HttpResponseMessage Res = await client.GetAsync("users?page=" + page + "&limit=" + limit);
                var status_code = Res.StatusCode.ToString();
                var clients = new List<Client>();
                if (Res.IsSuccessStatusCode)
                {
                    var result = Res.Content.ReadAsStringAsync().Result;
                    var jsonData = (JObject)JsonConvert.DeserializeObject(result);
                    foreach (var x in jsonData["data"])
                    {
                        clients.Add(new Client
                        {
                            id = x["id"].Value<string>(),
                            firstname = x["firstname"].Value<string>(),
                            lastname = x["lastname"].Value<string>(),
                            betcredit = x["betcredit"].Value<float>(),
                            email = x["email"].Value<string>(),
                            phone = x["phone"].Value<string>()
                        }
                        );

                    }
                }

                return new ClientResponse { status_code = status_code, clients = clients };

            }

        }
    }
}
