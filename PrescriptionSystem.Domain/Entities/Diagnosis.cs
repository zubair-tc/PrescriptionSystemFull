namespace PrescriptionSystem.Domain.Entities
{
    public class Diagnosis
    {
        public int Id { get; set; }
        public DateTime DiagnosisDate { get; set; } = DateTime.Now;
        public string DiagnosisDetails { get; set; }
        public string? Notes { get; set; }

        // Foreign keys
        public int PatientId { get; set; }

        // Navigation properties
        public Patient Patient { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
    }
}
