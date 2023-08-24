using System;
namespace BlazorServer.Services
{
	public class PropertyService
	{
        private readonly HttpClient _http;

        public PropertyService(HttpClient http)
        {
            _http = http;
        }

        public async Task<IEnumerable<Property>> GetProperties()
        {
            return await _http.GetFromJsonAsync<IEnumerable<Property>>("/api/properties");
        }
    }
}

