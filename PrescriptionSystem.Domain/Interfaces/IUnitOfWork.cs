using PrescriptionSystem.Domain.Entities;


namespace PrescriptionSystem.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        // Repository Accessors
        IRepository<Patient> Patients { get; }
        IRepository<Medicine> Medicines { get; }
        IRepository<Prescription> Prescriptions { get; }
        IRepository<Diagnosis> Diagnoses { get; }

        // Custom Repositories (if needed)
        //IPatientRepository PatientRepository { get; } // Example of custom repo

        // Transaction Management
        Task<int> CompleteAsync();
        void BeginTransaction();
        Task CommitAsync();
        void Rollback();
    }
}
