namespace musicApp.Data;

public class GetDataFromGeniousAPIService
{
    static readonly HttpClient client = new HttpClient();
    
    public async Task<string> SearchForSongsAsync(string songName)
    {
        try	
        {
            HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            // Above three lines can be replaced with new helper method below
            // string responseBody = await client.GetStringAsync(uri);

            return Task.Run()
        }
        catch(HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");	
            Console.WriteLine("Message :{0} ",e.Message);
        }
    }
}