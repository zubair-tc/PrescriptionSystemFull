namespace PrescriptionSystem.Domain.Entities
{
    public class Doctor
    {
        public int Id { get; set; } = 1; // Only one doctor
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string? ClinicName { get; set; }
        public string? ClinicAddress { get; set; }
        public string? ContactNumber { get; set; }
        public string LicenseNumber { get; set; }

        // Navigation property (1 Doctor → Many Prescriptions)
        public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
    }
}
