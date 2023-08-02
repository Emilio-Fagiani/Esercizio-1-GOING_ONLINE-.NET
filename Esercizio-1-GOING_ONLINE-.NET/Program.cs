using System.Net.Http.Json;

var httpClient  = new HttpClient();
Console.WriteLine("Please insert the URL: ");
var inpUrl = Console.ReadLine();
var retriver = new InpUrl();
Console.WriteLine(await retriver.RetriveUrl(inpUrl));

public class InpUrl
{
    public async Task<string> RetriveUrl(string url)
    {
        var Http = new HttpClient();
        var response = await Http.GetAsync(url);
        Console.WriteLine("----HEADERS----");
        Console.WriteLine(response.Headers);
        Console.WriteLine("----CONTENT----");
        Console.WriteLine(await response.Content.ReadAsStringAsync());
        return string.Empty;
    }
}

