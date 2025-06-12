namespace PrescriptionSystem.Domain.Entities
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; } // e.g., "500mg", "10ml"
        public MedicineForm Form { get; set; } // Enum: Tablet, Capsule, Syrup, etc.
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation properties
        public ICollection<PrescriptionItem> PrescriptionItems { get; set; } = new List<PrescriptionItem>();
    }

    public enum MedicineForm
    {
        Tablet,
        Capsule,
        Syrup,
        Injection,
        Ointment,
        Drops
    }
}
