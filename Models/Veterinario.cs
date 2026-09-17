namespace ClinicaApi.Models
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public string CMRV { get; set; }

        public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
    }

}
