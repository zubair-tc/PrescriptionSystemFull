namespace PrescriptionSystem.Domain.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public DateTime LastUpdated { get; set; } = DateTime.Now;

        // Navigation properties
        public ICollection<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>();
        public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
    }
}
