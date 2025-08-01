using Stocks.Classes.TableSets;

namespace Stocks.Classes
{
    internal class EmployeeService
    {
        public bool checkEmployee(string name, string password, string task, int id) 
        {
            using (var db = new StockDatabase()) 
            {
                 return db.staff.Any(s => s.Name == name && s.Password == password && s.Task == task && s.EmployeeID == id);
            }
        }
    }
}
