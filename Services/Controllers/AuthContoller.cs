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
    public class AuthContoller
    {
        private static readonly string baseURL = "https://backoffice-support-tpt.herokuapp.com/api/";

        private static readonly HttpClient httpClient;
        static AuthContoller ()
        {
            httpClient = new HttpClient();
        }


        public static async Task<LoginResponse> Login(string email, string password)
        {
            var lr = new LoginResponse();
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lr.status_code = "400";
                return lr;
            }
            var creds = new { email = email, password = password };
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "");
                HttpResponseMessage Res = await client.PostAsJsonAsync("auth/login/", creds);
                lr.status_code = Res.StatusCode.ToString();

                if (Res.IsSuccessStatusCode)
                {
                    var result = Res.Content.ReadAsStringAsync().Result;
                    var jsonData = (JObject)JsonConvert.DeserializeObject(result);
                    lr.access_token = jsonData["data"][0]["access_token"].Value<string>();
                    lr.refresh_token = jsonData["data"][0]["refresh_token"].Value<string>();
                }
                return lr;

            }
        }


        /*public async Task<string> AddNews(string title, string description, DateTime date, string image)
        {
            string dateString = date.ToString();
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                errorLabel = "Please fill in the missing field(s)";
                return "400";
            }
            var newsToAdd = new { title = title, description = description, date = date, image = image };
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", DataStored.accessToken);
                HttpResponseMessage Res = await client.PostAsJsonAsync("news/", newsToAdd);
                if (Res.IsSuccessStatusCode)
                {
                    var result = Res.Content.ReadAsStringAsync().Result;
                    var jsonData = (JObject)JsonConvert.DeserializeObject(result);
                    News news = new News();
                    news.Id = jsonData["newNews"]["_id"].Value<string>();
                    news.Title = title;
                    news.Description = description;
                    news.Date = date;
                    news.Picture = image;
                    DataStored.listNewsStored.Add(news);
                    return "200";
                }
                else
                    return Res.StatusCode.ToString();
            }
        }*/

    }
}
