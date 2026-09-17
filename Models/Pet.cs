using System.Text.Json.Serialization;

namespace ClinicaApi.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int TutorId { get; set; }
        public string Especie { get; set; }

        [JsonIgnore]

        public Tutor? Tutor { get; set; }


    }

}
