using InveonOdev2.Data;
using InveonOdev2.Repositories;
using Microsoft.EntityFrameworkCore;

namespace InveonOdev2.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private IBookRepository _bookRepository;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public IBookRepository Books => _bookRepository ??= new BookRepository(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
