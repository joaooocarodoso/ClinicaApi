namespace ClinicaApi.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }
    }

}
