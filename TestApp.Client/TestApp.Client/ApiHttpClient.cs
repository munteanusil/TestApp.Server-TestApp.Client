using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;
using Newtonsoft.Json;

namespace TestApp.Client;

public class ApiHttpClient : IApiHttpClient
{
    private readonly HttpClient httpClient;

    public ApiHttpClient(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        httpClient.BaseAddress = new Uri("http://localhost:5107/");
    }

    public async Task<string> GetAsync(string endpoint)
    {
        var response = await httpClient.GetAsync(endpoint);
        var responseContent = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
            throw new Exception(responseContent);
        return responseContent;
    }

    public async Task<string> DeleteAsync(string endpoint)
    {
        var response = await httpClient.DeleteAsync(endpoint);
        var responseContent = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
            throw new Exception(responseContent);
        return responseContent;
    }

    public async Task<string> PutAsync<TDto>(string endpoint, TDto dto)
    {
        var content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
        var response = await httpClient.PutAsync(endpoint, content);
        var responseContent = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
            throw new Exception(responseContent);
        return responseContent;
    }

    public async Task<string> PostAsync<TDto>(string endpoint, TDto dto)
    {
        var content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
        var response = await httpClient.PostAsync(endpoint, content);
        var responseContent = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
            throw new Exception(responseContent);
        return responseContent;
    }
}
