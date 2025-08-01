using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stocks.Classes.TableSets;

namespace Stocks.Classes
{
    internal class StockDatabase : DbContext
    {
        public DbSet<Staff> staff { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<StockMovement> stockMovements { get; set; }
        public DbSet<Product> products { get; set; }    
        public DbSet<Stock> stocks { get; set; }
        public DbSet<Category> categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=StockDB;Integrated Security=SSPI;");
        }

    }
}
