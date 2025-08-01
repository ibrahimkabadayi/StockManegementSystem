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
            if (customerListBox.SelectedIndex == -1 || ordersListBox.SelectedIndex == -1) { return; }
            if (dateTextBox.Text.Length != 16) return;

            var Customer = customerListBox.SelectedItem as Customer;
            var stockMovement = ordersListBox.SelectedItem as StockMovement;

            SqlServerDecoder decoder = new SqlServerDecoder();
            decoder.AddStockMovement(stockMovement.ProductID, "Sell", dateTextBox.Text, id, Customer.CustomerID, stockMovement.Number);
            return;
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

        }
    }
}
