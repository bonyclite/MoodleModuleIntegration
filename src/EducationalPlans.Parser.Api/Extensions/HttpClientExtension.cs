using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EducationalPlans.Parser.Api.Extensions
{
    public static class HttpClientExtension
    {
        public static async Task<T> SendAsync<T>(this HttpClient client, HttpRequestMessage request, Func<Exception, Exception> exceptionHandler = null, Func<T, Exception> errorHandler = null)
        {
            try
            {
                var response = await client.SendAsync(request);
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(content);

                var exception = errorHandler?.Invoke(result);
                if (exception != null)
                    throw exception;

                return result;
            }
            catch (HttpRequestException httpRequestException)
            {
                if (exceptionHandler == null)
                    throw;

                var exception = exceptionHandler(httpRequestException);
                if (exception != null)
                    throw exception;

                return default(T);
            }
        }
    }
}