namespace mamix.Services.Base
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Net.Http.Json;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    using GeneralLabSolutions.Domain.Extensions.Helpers.Generics;
    using Microsoft.Extensions.Logging; // Para injeção de ILogger (opcional)

    namespace mamix.Services.Base
    {
        public class ApiService<T> : IDisposable where T : class
        {
            private readonly IHttpClientFactory _httpClientFactory;
            private readonly ILogger<ApiService<T>> _logger; // Opcional, para logs
            private readonly JsonSerializerOptions _jsonSerializerOptions;
            private HttpClient _httpClient;

            public ApiService(IHttpClientFactory httpClientFactory, ILogger<ApiService<T>> logger = null)
            {
                _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
                _logger = logger; // O logger é opcional

                _jsonSerializerOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
            }

            protected void CreateClient(string clientName)
            {
                _httpClient = _httpClientFactory.CreateClient(clientName);
            }

            public async Task<PagedResult<T>?> GetPagedAsync<T>(string endpoint, int pageIndex, int pageSize, string? query = null) where T : class
            {
                CreateClient("CadastroApi"); // Ou o nome do seu cliente configurado

                var urlBuilder = new StringBuilder(endpoint);
                urlBuilder.Append($"?pageIndex={pageIndex}&pageSize={pageSize}");

                if (!string.IsNullOrWhiteSpace(query))
                {
                    urlBuilder.Append($"&query={Uri.EscapeDataString(query)}");
                }

                var url = urlBuilder.ToString();

                try
                {
                    var response = await _httpClient.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        var pagedResult = await response.Content.ReadFromJsonAsync<PagedResult<T>>(_jsonSerializerOptions);

                        // Obtenha os cabeçalhos de paginação da resposta, se existirem
                        if (response.Headers.TryGetValues("X-Pagination", out var paginationValues))
                        {
                            var paginationMetadata = JsonSerializer.Deserialize<PaginationMetadata>(paginationValues.FirstOrDefault(), _jsonSerializerOptions);

                            if (paginationMetadata != null && pagedResult != null)
                            {
                                // Atualize as propriedades de paginação no objeto PagedResult
                                pagedResult.TotalResults = paginationMetadata.TotalResults;
                                pagedResult.TotalPages = paginationMetadata.TotalPages;
                                pagedResult.HasPrevious = paginationMetadata.HasPrevious;
                                pagedResult.HasNext = paginationMetadata.HasNext;
                            }
                        }

                        return pagedResult;
                    } else
                    {
                        _logger?.LogError("Erro ao chamar a API: {StatusCode} - {ReasonPhrase}", response.StatusCode, response.ReasonPhrase);
                        // Tratar erros de acordo com a sua necessidade (lançar exceção, retornar null, etc.)
                        return null;
                    }
                } catch (HttpRequestException ex)
                {
                    _logger?.LogError(ex, "Erro de requisição ao chamar a API");
                    // Tratar exceções de requisição
                    return null;
                } catch (JsonException ex)
                {
                    _logger?.LogError(ex, "Erro ao desserializar a resposta da API");
                    // Tratar exceções de desserialização
                    return null;
                } catch (Exception ex)
                {
                    _logger?.LogError(ex, "Erro desconhecido ao chamar a API");
                    // Tratar outras exceções
                    return null;
                }
            }

            // Outros métodos genéricos para POST, PUT, DELETE, etc. podem ser adicionados aqui

            public void Dispose()
            {
                _httpClient?.Dispose();
            }
        }

        // Classe auxiliar para desserializar os metadados de paginação do cabeçalho X-Pagination
        public class PaginationMetadata
        {
            public int TotalResults { get; set; }
            public int PageIndex { get; set; }
            public int PageSize { get; set; }
            public int TotalPages { get; set; }
            public bool HasPrevious { get; set; }
            public bool HasNext { get; set; }
        }
    }
}
