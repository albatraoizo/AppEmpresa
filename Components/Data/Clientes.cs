namespace AppEmpresa.Data;
using System.Text.Json.Serialization;
public class Cliente
    {
         [JsonPropertyName("id_cliente")]
        public Int32 Id_cliente { get; set; }
        [JsonPropertyName("nombres")]
        public String? Nombres { get; set; }
        [JsonPropertyName("apellidos")]
        public String? Apellidos { get; set; }
        [JsonPropertyName("direccion")]
        public String? Direccion { get; set; }
        [JsonPropertyName("telefono")]
        public String? Telefono { get; set; }
        [JsonPropertyName("fecha_nacimiento")]
        public DateTime? Fecha_nacimiento { get; set; }
    }