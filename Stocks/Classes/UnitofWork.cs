using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stocks.Classes.TableSets;

namespace Stocks.Classes
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly StockDatabase _context;
        private IRepository<Product> _products;
        private IRepository<Category> _categorys;
        private IRepository<Customer> _customers;
        private IRepository<Staff> _staff;

        public UnitOfWork(StockDatabase context)
        {
            _context = context;
        }

        public IRepository<Product> Products => _products ??= new Repository<Product>(_context);

        public IRepository<Category> Categories => _categorys ??= new Repository<Category>(_context);

        public IRepository<Customer> Customers => _customers ??= new Repository<Customer>(_context);

        public IRepository<Staff> Staff => _staff ??= new Repository<Staff>(_context);

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
