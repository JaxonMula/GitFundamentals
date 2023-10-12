using IntroToAPI.ConsoleApp.Models;
using Newtonsoft.Json;

HttpClient httpClient = new HttpClient();

var response = httpClient.GetAsync("https://swapi.dev/api/people/1").Result;

if(response.IsSuccessStatusCode)
{
   // var content = response.Content.ReadAsStringAsync().Result;
   // var person = JsonConvert.DeserializeObject<Person>(content);

    var luke = response.Content.ReadAsAsync<Person>().Result;
    Console.WriteLine(luke.Name);

    foreach(string vehicleUrl in luke.Vehicles)
    {
        HttpResponseMessage vehicleResponse = httpClient.GetAsync(vehicleUrl).Result;
        Vehicles vehicle = vehicleResponse.Content.ReadAsAsync<Vehicles>().Result;

        Console.WriteLine(vehicle.Name);
    }

    SwapiService service = new SwapiService();

    Person person = service.GetPersonAsync("https://swapi.dev/api/people/4").Result;

    if (person != null)
        Console.WriteLine(person.Name);

        foreach(string vehicleUrl in person.Vehicles)
        {
            var vehicle = service.GetVehicleAsync(vehicleUrl).Result;
            Console.WriteLine(vehicle.Name);
        }


    var genericResponse = service.GetAsync<Person>("https://swapi.dev/api/people/7").Result;

    if(genericResponse != null)
        Console.WriteLine(genericResponse.Name);
        else
        Console.WriteLine("Requested object not found.");


    SearchResult<Person> skywalkers = service.GetPersonSearchAsync("skywalker").Result;
    foreach(Person p in skywalkers.Results)
    Console.WriteLine(p.Name);


    }



Console.ReadKey();