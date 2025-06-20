using System.Text.Json.Serialization;
public class Tarea
{
    [JsonPropertyName("userId")]
    public int IdUsuario { get; set; }

    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("title")]
    public string titulo { get; set; }

    [JsonPropertyName("completed")]
    public bool completada { get; set; }
}
