using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Classes.TableSets
{
    internal class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name {  get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Customer() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    }
}
