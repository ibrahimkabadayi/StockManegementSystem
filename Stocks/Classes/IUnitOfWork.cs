using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stocks.Classes.TableSets;

namespace Stocks.Classes
{
    internal interface IUnitOfWork : IDisposable
    {
        IRepository<Product> Products { get; }
        IRepository<Category> Categories { get; }
        IRepository<Customer> Customers { get; }
        IRepository<Staff> Staff { get; }
        Task<int> SaveChangesAsync();
    }
}
