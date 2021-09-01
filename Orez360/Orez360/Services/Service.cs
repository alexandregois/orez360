using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Orez360.Services
{
    public abstract class Service
    {
        protected HttpClient _client;
        protected string BaseApiUrl = "https://api-dev.orez.com.br";

        public Service()
        {
            _client = new HttpClient();
        }
    }
}
