    using System.Text.Json.Serialization;
    public class Direccion
    {
        [JsonPropertyName("street")]
        public string Calle { get; set; }

        [JsonPropertyName("suite")]
        public string Habitacion { get; set; }

        [JsonPropertyName("city")]
        public string Ciudad { get; set; }

        [JsonPropertyName("zipcode")]
        public string CodigoZip { get; set; }

        [JsonPropertyName("geo")]
        public Geo geo { get; set; }

        public override string ToString()
        {
            // Esto genera una cadena legible
            return $"Calle: {Calle}, Suite: {Habitacion}, Ciudad: {Ciudad}";
        }
    }

    public class Compania
    {
        [JsonPropertyName("name")]
        public string NombreCompania { get; set; }

        [JsonPropertyName("catchPhrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("bs")]
        public string Bs { get; set; }
    }

    public class Geo
    {
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        [JsonPropertyName("lng")]
        public string Lng { get; set; }
    }

    public class Usuario
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Nombre { get; set; }

        [JsonPropertyName("username")]
        public string NombreDeUsuario { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("address")]
        public Direccion Direccion { get; set; }

        [JsonPropertyName("phone")]
        public string Celular { get; set; }

        [JsonPropertyName("website")]
        public string Pagina { get; set; }

        [JsonPropertyName("company")]
        public Compania Compania { get; set; }
    }
