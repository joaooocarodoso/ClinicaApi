using System.Text.Json.Serialization;

namespace ClinicaApi.Models
{
    public class Consulta 
    {
        public int Id { get; set; }
        public string Motivo { get; set; }
        public int PetId { get; set; }
        public DateTime DataHora { get; set; }
        [JsonIgnore]
        public Pet? Pet { get; set; }

        [JsonIgnore]
        public int VeterinarioId { get; set; }
        public Veterinario? Veterinario { get; set; }
        
    }

}
