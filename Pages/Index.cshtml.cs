using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FinalExamApplication.Models;
using System.Text.Json;

namespace FinalExamApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public List<Character> Characters { get; set; } = new List<Character>();
        public string? ErrorMessage { get; set; }
        public int TotalCharacters { get; set; }

        public async Task OnGetAsync()
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient();
                var response = await httpClient.GetAsync("https://rickandmortyapi.com/api/character");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    var characterResponse = JsonSerializer.Deserialize<CharacterResponse>(jsonString, options);

                    if (characterResponse != null && characterResponse.Results.Any())
                    {
                        Characters = characterResponse.Results;
                        TotalCharacters = characterResponse.Info.Count;
                    }
                    else
                    {
                        ErrorMessage = "No data available at this time.";
                    }
                }
                else
                {
                    ErrorMessage = "Unable to load data. Please try again later.";
                    _logger.LogError($"API call failed with status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = "Unable to load data. Please try again later.";
                _logger.LogError(ex, "Error fetching data from Rick and Morty API");
            }
        }
    }
}
