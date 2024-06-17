namespace TestApp.Client;

public interface IApiHttpClient
{
    Task<string> GetAsync(string endpoint);
    Task<string> DeleteAsync(string endpoint);
    Task<string> PutAsync<TDto>(string endpoint, TDto dto);
    Task<string> PostAsync<TDto>(string endpoint, TDto dto);
}