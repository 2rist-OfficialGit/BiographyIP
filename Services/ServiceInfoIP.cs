using BiographyIP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace BiographyIP.Services
{
    internal class ServiceInfoIP
    {
        private readonly HttpClient _httpClient;
        private const string UrlIP = "https://ipinfo.io";

        public ServiceInfoIP()
        {
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(5);
        }

        public async Task<ModelDataIP> GetModelDataIPAsync(string ip)
        {
            try
            {
                string url = String.IsNullOrEmpty(ip) ? $"{UrlIP}/{ip}/geo" : $"{UrlIP}/{ip}/json";
                var resultApi = await _httpClient.GetAsync(url);
                if(resultApi.IsSuccessStatusCode)
                {
                    var jsonResult = await resultApi.Content.ReadAsStringAsync();
                    var InfoIpfromJSON = JsonSerializer.Deserialize<ModelDataIP>(jsonResult);
                    return InfoIpfromJSON ?? new ModelDataIP();
                }
                throw new Exception($"Ошибка API: {resultApi.StatusCode}");
            }
            catch(Exception ex)
            {
                throw new Exception($"Ошибка API: Не удалось получить информацию: {ex.Message}");
            }
        }
    }
}
