using System.Text.Json;
public static class Api
{
    
    public static async Task<List<Tarea>> GetTareas()
    {    
        var url = "https://jsonplaceholder.typicode.com/todos/";
        try
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            List<Tarea> listaTareas = JsonSerializer.Deserialize<List<Tarea>>(responseBody);
            return listaTareas;   
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("Problemas de acceso a la API");
            Console.WriteLine("Message :{0} ", e.Message);
            return null;
        }   

    }

}