using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Classes.TableSets
{
    internal class Category
    {
        [Key]
        public int CatogeryID { get; set; }
        public string CategoryType { get; set; }

        #pragma warning disable CS8618 
        public Category() { }
        #pragma warning restore CS8618 
    }
}
