using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Classes.TableSets
{
    internal class Stock
    {
        [Key]
        public int StockID { get; set; }
        public int ProductID { get; set; }
        public int Number { get; set; }
        public Stock() { }
    }
}
