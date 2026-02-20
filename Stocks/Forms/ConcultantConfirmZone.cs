using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Stocks.Classes;
using Stocks.Classes.TableSets;

namespace Stocks
{
    public partial class ConcultantConfirmZone : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        int id;
        public ConcultantConfirmZone(int id)
        {
            this.id = id;
            InitializeComponent();
            var context = new StockDatabase();
            _unitOfWork = new UnitOfWork(context);
        }
        private void ConcultantConfirmZone_Load(object sender, EventArgs e)
        {
            StockDatabase db = new StockDatabase();
            var customers = db.customers.ToList();
            customerListBox.DataSource = customers;
            customerListBox.SelectedIndex = -1; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmOrder();
        }

        private void ConfirmOrder()
        {
            if (customerListBox.SelectedIndex == -1 || ordersListBox.SelectedIndex == -1) 
            {
                MessageBox.Show("Please select both a customer and an order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            var Customer = customerListBox.SelectedItem as Customer;
            var stockMovement = ordersListBox.SelectedItem as StockMovement;

            if (stockMovement == null) return;

            using (var db = new StockDatabase())
            {
                // Create the 'Sell' movement
                var newMovement = new StockMovement
                {
                    ProductID = stockMovement.ProductID,
                    MovementType = "Sell", // Confirmed sale
                    Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm"),
                    StaffId = id,
                    CustomerId = Customer.CustomerID,
                    Number = stockMovement.Number
                };
                db.stockMovements.Add(newMovement);

                // Update the original 'Buy' movement to something else or delete it?
                // Let's mark it as 'Processed' so it doesn't show up in the pending list.
                var originalMovement = db.stockMovements.FirstOrDefault(sm => sm.MovementID == stockMovement.MovementID);
                if (originalMovement != null)
                {
                    originalMovement.MovementType = "Confirmed";
                }

                db.SaveChanges();
                MessageBox.Show("Order confirmed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Refresh the orders list
                customerListBox_SelectedIndexChanged(null, null);
            }
        }

        private async void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCustomer = customerListBox.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                int customerId = selectedCustomer.CustomerID;

                using (StockDatabase db = new StockDatabase()) 
                {
                    var stockMovements = db.stockMovements
                    .Join(db.products,
                    sm => sm.ProductID,
                    p => p.ProductId,
                    (sm, p) => new { StockMovement = sm, Product = p })
                    .Where(x => x.StockMovement.CustomerId == customerId && x.StockMovement.MovementType == "Buy")
                    .OrderByDescending(x => x.StockMovement.Date)
                    .Select(x => new StockMovement
                    {
                        MovementID = x.StockMovement.MovementID,
                        Number = x.StockMovement.Number,                        
                        Date = x.StockMovement.Date,
                        MovementType = x.StockMovement.MovementType
                    })
                    .ToList();
                    ordersListBox.DataSource = stockMovements;
                    ordersListBox.DisplayMember = "DisplayText";
                    
                    if (stockMovements.Count == 0)
                    {
                        ordersListBox.DataSource = null;
                    }
                }
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

        private void confirmButton_Click(object sender, EventArgs e)
        {
            ConfirmOrder();
        }
    }
}
