using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Classes.TableSets
{
    internal class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public int Number { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }

        public override string ToString()
        {
            return $"{Name} - Qty: {Number} - Price: {SalePrice}";
        }

        #pragma warning disable CS8618 
        public Product() { }
        #pragma warning restore CS8618 
    }
}
