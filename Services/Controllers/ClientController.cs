﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Services.Controllers
{
    public class ClientController : ApiController
    {
        private static readonly HttpClient httpClient;

        static ClientController()
        {
            httpClient = new HttpClient();
        }

        
    }
}
