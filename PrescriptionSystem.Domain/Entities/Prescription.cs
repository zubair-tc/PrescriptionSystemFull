namespace PrescriptionSystem.Domain.Entities
{
    public class Prescription
    {
        public int Id { get; set; }
        public DateTime PrescriptionDate { get; set; } = DateTime.Now;
        public string? AdditionalNotes { get; set; }

        // Foreign keys
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int? DiagnosisId { get; set; } // Optional

        // Navigation properties
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public Diagnosis Diagnosis { get; set; }
        public ICollection<PrescriptionItem> PrescriptionItems { get; set; } = new List<PrescriptionItem>();
    }
}
