namespace PrescriptionSystem.Domain.Entities
{
    public class PrescriptionItem
    {
        public int Id { get; set; }
        public string Dosage { get; set; } // Can override default medicine dosage
        public string Instructions { get; set; } // e.g., "Take twice daily after meals"
        public string Duration { get; set; } // e.g., "5 days", "2 weeks"

        // Foreign keys
        public int PrescriptionId { get; set; }
        public int MedicineId { get; set; }

        // Navigation properties
        public Prescription Prescription { get; set; }
        public Medicine Medicine { get; set; }
    }
}
