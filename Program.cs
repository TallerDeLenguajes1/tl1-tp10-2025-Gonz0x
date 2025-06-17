// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System.Text.Json;
var tareas = await GetTareas();
foreach (var tarea in tareas)
{
    Console.WriteLine($"TareaID: {tarea.id} - Descripcion: {tarea.titulo}")
}

string textoAGuardar = JsonSerializer.Serialize(tareas);
GuardarArchivoTexto("tareas.json", textoAGuardar);

static async Task<List<Tarea>> GetTareas()
{    
    var url = "https://jsonplaceholder.typicode.com/todos/";
    try
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        List<Tarea> coinDesk = JsonSerializer.Deserialize<List<Tarea>>(responseBody);
        return coinDesk;   
    }

}
catch (HttpRequestException e)
{
    Console.WriteLine("Problemas de acceso a la API");
    Console.WriteLine("Message :{0} ", e.Message);
    return null;
}


void GuardarArchivoTexto(string nombreArchivo, string datos)    
using(var archivo = new FileStream(nombreArchivo, FileMode.Create)){
    using(var strWriter = new StramWriter(archivo))
    {
        strWriter.WriteLine("{0}", datos)
        strWriter.Close();  
    }
}
//ej codigo tallerhistorico
