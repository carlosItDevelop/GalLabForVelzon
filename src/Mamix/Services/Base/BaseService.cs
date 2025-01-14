namespace mamix.Services.Base
{
    public abstract class BaseService<T> where T : class
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _apiEndpoint;

        protected BaseService(IHttpClientFactory httpClientFactory, string apiEndpoint)
        {
            _httpClientFactory = httpClientFactory;
            _apiEndpoint = apiEndpoint;
        }

        protected async Task<IEnumerable<T>> GetAsync(string route)
        {
            var client = _httpClientFactory.CreateClient("CadastroApi");
            var response = await client.GetAsync($"{_apiEndpoint}/{route}");

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<IEnumerable<T>>();
                return result ?? Enumerable.Empty<T>();
            }

            // Log ou tratamento de erro
            Console.WriteLine($"Erro na API: {response.StatusCode}");
            return Enumerable.Empty<T>();
        }
    }

}
