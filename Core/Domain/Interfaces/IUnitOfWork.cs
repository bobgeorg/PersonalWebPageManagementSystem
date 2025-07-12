namespace PersonalWebPageManagementSystem.Core.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IResumeRepository Resumes { get; }
        Task<int> SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
