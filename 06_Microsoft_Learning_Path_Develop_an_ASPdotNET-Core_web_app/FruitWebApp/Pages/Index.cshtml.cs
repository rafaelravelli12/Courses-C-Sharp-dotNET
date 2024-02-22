using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitWebApp.Models;
using System.Text.Json;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace FruitWebApp.Pages
{
    public class IndexModel : PageModel
    {        
        private readonly IHttpClientFactory _httpClientFactory; // IHttpClientFactory set using dependency injection 

        public IndexModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        
        [BindProperty] // Add the data model and bind the form data to the page model properties
        public IEnumerable<FruitModel> FruitModels { get; set; } // Enumerable since an array is expected as a response
        
        public async Task OnGet() // Begin GET operation code
        {            
            var httpClient = _httpClientFactory.CreateClient("FruitAPI"); // Create the HTTP client using the FruitAPI named factory
            
            using HttpResponseMessage response = await httpClient.GetAsync(""); // Perform the GET request and store the response. The empty parameter // in GetAsync doesn't modify the base address set in the client factory 
            
            if (response.IsSuccessStatusCode) // If the request is successful deserialize the results into the data model
            {
                using var contentStream = await response.Content.ReadAsStreamAsync();
                FruitModels = await JsonSerializer.DeserializeAsync<IEnumerable<FruitModel>>(contentStream);
            }
        }
    }
}
