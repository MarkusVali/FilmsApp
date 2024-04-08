using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class TmdbService
    {
        private const string ApiKey = "";
        public const string TmdbHttpClientName = "TmdbClient";

        private readonly IHttpClientFactory _httpClientFactory;

        public TmdbService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        private HttpClient HttpClient => _httpClientFactory.CreateClient(TmdbHttpClientName);
    }
}
