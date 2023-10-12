using System.Net;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using IntroToAPI.ConsoleApp.Models;

public class SwapiService
{
    private readonly HttpClient _httpClient = new HttpClient();

    public async Task<Person> GetPersonAsync(string url)
    {
        // HttpResponseMessage response = await _httpClient.GetAsync(url);
        // if(response.IsSuccessStatusCode)
        // {
        //     Person person = await response.Content.ReadAsAsync<Person>();
        //     return person;
        // }
        // return null;
        return await GetAsync<Person>(url);

    }
    public async Task<Vehicles> GetVehicleAsync(string url)
    {
        HttpResponseMessage response = await _httpClient.GetAsync(url);
        if(response.IsSuccessStatusCode)
        {
            Vehicles vehicle = await response.Content.ReadAsAsync<Vehicles>();
            return vehicle;
        }
        return null;
    }


    public async Task<T> GetAsync<T> (string url) where T: class
    {
        HttpResponseMessage response = await _httpClient.GetAsync(url);

        if(response.IsSuccessStatusCode)
        {
            T content = await response.Content.ReadAsAsync<T>();
            return content;
        }
        return null;
    }

    public async Task<SearchResult<Person>> GetPersonSearchAsync(string query)
    {
        HttpResponseMessage response = await _httpClient.GetAsync("https://swapi.dev/api/people?search=" + query);

        if(response.IsSuccessStatusCode)
        return await response.Content.ReadAsAsync<SearchResult<Person>>();
        return null;
    }
}