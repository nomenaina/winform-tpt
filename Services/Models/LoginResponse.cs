using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class LoginResponse : Response
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public LoginResponse() { }
        public LoginResponse(string access_token, string refresh_token, string status_code)
        {
            this.access_token = access_token;
            this.refresh_token = refresh_token;
            this.status_code = status_code;
        }

    }
}
