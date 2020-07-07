using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CrossCutting.Config;

namespace FrontEnd.ApiCaller
{
    public class ApiCaller: IApiCaller
    {

        private readonly HttpClient _httpClient;

        public ApiCaller(string url)
        {

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(url)
            };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        public async Task<T> GetServiceResponse<T>(string controller)
        {
            string url = $"/{controller}";
            var result = default(T);
            using (HttpResponseMessage response = await _httpClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var comic = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<T>(comic);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            return result;
        }

        public async Task<T> GetServiceResponseById<T>(string controller, int id)
        {
            string url = $"/{controller}/{1}";
            var result = default(T);
            using (HttpResponseMessage response = await _httpClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var comic = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<T>(comic);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            return result;
        }

        public async Task<T> PostServiceResponse<T>(string controller, T element)
        {
            string url = $"/{controller}";
            var result = default(T);
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(element), Encoding.UTF8);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using (HttpResponseMessage response = await _httpClient.PostAsync(url, httpContent))
            {
                if (response.IsSuccessStatusCode)
                {
                    var comic = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<T>(comic);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            return result;
        }
    }
}
