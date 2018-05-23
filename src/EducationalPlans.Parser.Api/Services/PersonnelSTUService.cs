using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using EducationalPlans.Parser.Api.Extensions;
using EducationalPlans.Parser.Api.Models.Attributes;

namespace EducationalPlans.Parser.Api.Services
{
    public interface IPersonnelSTUService
    {
        Task<IEnumerable<T>> Get<T>();
    }

    public class PersonnelSTUService : IPersonnelSTUService
    {
        private readonly HttpClient _httpClient;

        public PersonnelSTUService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(@"http://localhost:9611/")
            };
        }

        public async Task<IEnumerable<T>> Get<T>()
        {
            var route = typeof(T).GetCustomAttribute<RouteAttribute>().Route;
            var request = new HttpRequestMessage(HttpMethod.Get, $"api/PersonnelSTU/{route}");

            return await _httpClient.SendAsync<IEnumerable<T>>(request);
        }
    }
}