using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Classes.TableSets
{
    internal class StockMovement
    {
        [Key]
        public int MovementID { get; set; }
        public int ProductID { get; set; }
        public string MovementType { get; set; }
        public int Number { get; set; }
        public string Date { get; set; }
        public int StaffId { get; set; }
        public int CustomerId { get; set; }

        public string DisplayText => $"Product ID: {ProductID}, Quantity: {Number}, Date: {Date}";

        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public StockMovement() { }
        #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    }
}
