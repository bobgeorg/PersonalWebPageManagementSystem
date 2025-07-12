using Microsoft.EntityFrameworkCore.Storage;
using PersonalWebPageManagementSystem.Domain.Interfaces;
using PersonalWebPageManagementSystem.Infrastructure.Persistence;

namespace PersonalWebPageManagementSystem.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PersonalWebPageContext _context;
        private IDbContextTransaction _transaction;
        private IResumeRepository _resumeRepository;

        public UnitOfWork(PersonalWebPageContext context)
        {
            _context = context;
        }

        public IResumeRepository Resumes =>
            _resumeRepository ??= new ResumeRepository(_context);

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task BeginTransactionAsync()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.CommitAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }

        public async Task RollbackTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _context?.Dispose();
        }
    }
}
