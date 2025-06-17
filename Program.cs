// See https://aka.ms/new-console-template for more information

using System.Text.Json;
var tareas = await Api.GetTareas();
var archivo= new archivo();

foreach (var tarea in tareas)
{
    Console.WriteLine($"TareaID: {tarea.id} - Descripcion: {tarea.titulo}");
}

string textoAGuardar = JsonSerializer.Serialize(tareas);
archivo.GuardarArchivoTexto("tareas.json", textoAGuardar);





//ej codigo tallerhistorico
