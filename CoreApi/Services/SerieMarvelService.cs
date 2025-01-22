using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CoreApi.Models;
using Microsoft.Extensions.Options;

namespace CoreApi.Services
{
    public class SerieMarvelService :ISerieMarvelService
    {
        private readonly HttpClient _httpClient;
        //private const string BaseUrl = "https://gateway.marvel.com:443/v1/public/";
        //private const string PublicKey = "c595c4b38d9b1059240163116b790ca1";
        //private const string PrivateKey = "7bec201461bb04d01d19301395fcf55436d89834";
        private readonly MarvelApiOptions _options;
        public SerieMarvelService(HttpClient httpClient, IOptions<MarvelApiOptions> options)
        {
            _httpClient = httpClient;
            _options = options.Value;
        }
        public async Task<SeriesDataWrapper> GetSeriesAsync()
        {
            string ts = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
            string hash = GenerateHash(ts, _options.PrivateKey, _options.PublicKey);

            string url = $"{_options.BaseUrl}series?ts={ts}&apikey={_options.PublicKey}&hash={hash}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<SeriesDataWrapper>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        private static string GenerateHash(string ts, string privateKey, string publicKey)
        {
            using (var md5 = MD5.Create())
            {
                string input = $"{ts}{privateKey}{publicKey}";
                byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder sb = new StringBuilder();
                foreach (var b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
