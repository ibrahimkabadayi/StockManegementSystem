using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stocks.Classes;
using Stocks.Classes.TableSets;

namespace Stocks
{
    public partial class CustomerBuyingZone : Form
    {
        public CustomerBuyingZone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string address = adressTextBox.Text.Trim();
            string country = countryTextBox.Text.Trim();
            string telephoneNumber = telephoneNumberTextBox.Text.Trim();
            int number;

            if (!int.TryParse(numberTextBox.Text.Replace("_", "").Replace(" ", ""), out number) || number <= 0)
            {
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (stockListBox.SelectedIndex < 0) 
            {
                MessageBox.Show("Please select a stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            var stock = stockListBox.SelectedItem as Stock;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) || 
                string.IsNullOrWhiteSpace(country) || string.IsNullOrWhiteSpace(telephoneNumber)) 
            {
                MessageBox.Show("Please fill all textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (stock.Number < number)
            {
                MessageBox.Show("Not enough stock available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new StockDatabase())
            {
                var customer = db.customers.FirstOrDefault(c => c.Name == name && c.TelephoneNumber == telephoneNumber);
                if (customer == null)
                {
                    customer = new Customer
                    {
                        Name = name,
                        Country = country,
                        Address = address,
                        TelephoneNumber = telephoneNumber
                    };
                    db.customers.Add(customer);
                    db.SaveChanges(); // Save to get CustomerID
                }

                var dbStock = db.stocks.FirstOrDefault(s => s.StockID == stock.StockID);
                if (dbStock != null)
                {
                    dbStock.Number -= number;
                }

                var movement = new StockMovement
                {
                    ProductID = stock.ProductID,
                    MovementType = "Buy",
                    Number = number,
                    Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm"),
                    CustomerId = customer.CustomerID,
                    StaffId = -1
                };
                db.stockMovements.Add(movement);

                db.SaveChanges();
                MessageBox.Show("Order request sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Refresh list
                var stocks = db.stocks.ToList();
                stockListBox.DataSource = stocks;
                stockListBox.SelectedIndex = -1;
            }
        }

        private void returnToMenuButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is Menu)
                {
                    Menu mainMenu = (Menu)form;
                    mainMenu.ShowMainMenu();
                    break;
                }
            }
        }

        private void CustomerBuyingZone_Load_1(object sender, EventArgs e)
        {
            StockDatabase stockDatabase = new StockDatabase();
            var stocks = stockDatabase.stocks;
            stockListBox.DataSource = stocks;
            stockListBox.SelectedIndex = -1;
        }
    }
}
