using System.Text.Json;
var tareas = await Api.GetTareas();
var archivo= new archivo();

List<Tarea> completadas = new List<Tarea>();
List<Tarea> pendientes = new List<Tarea>();

foreach (var tarea in tareas)
{
    if (tarea.completada)
        completadas.Add(tarea);
    else
    {
        pendientes.Add(tarea);
    }
}

Console.WriteLine("\nTAREAS:");//pendientes
foreach (var tarea in pendientes)
{
    Console.WriteLine($"TITULO: {tarea.titulo}, COMPLETA: {tarea.completada}");
}

foreach (var tarea in completadas)//completadas
{
    Console.WriteLine($"TITULO: {tarea.titulo}, COMPLETA: {tarea.completada}");
}




string textoAGuardar = JsonSerializer.Serialize(tareas);
archivo.GuardarArchivoTexto("tareas.json", textoAGuardar);