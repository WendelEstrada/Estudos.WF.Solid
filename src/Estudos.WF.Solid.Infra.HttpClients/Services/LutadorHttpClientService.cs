using Estudos.WF.Solid.Core.Entities;
using Estudos.WF.Solid.Core.Interfaces.HttpClientServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.WF.Solid.Infra.HttpClients.Services
{
    public class LutadorHttpClientService : ILutadorHttpClientService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public LutadorHttpClientService()
        {
            _httpClient.BaseAddress = new Uri(Settings.Default.LutadorApiUrl);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public IEnumerable<Lutador> GetAll()
        {
            var response = _httpClient.GetAsync("api/competidores").Result;

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<IEnumerable<Lutador>>(response.Content.ReadAsStringAsync().Result);

            return new List<Lutador>();
        }
    }
}
