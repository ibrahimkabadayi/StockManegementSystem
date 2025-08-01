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
            string name = nameTextBox.Text;
            string address = adressTextBox.Text;
            string country = countryTextBox.Text;
            string telephoneNumber = telephoneNumberTextBox.Text;
            int number = Convert.ToInt32(numberTextBox.Text);

            if (stockListBox.SelectedIndex < 0) { return; }

            var stock = stockListBox.SelectedItem as Stock;

            if (!(name.Length > 0 && address.Length > 0 && country.Length > 0 && telephoneNumber.Length > 0 && number > 0)) 
            {
                MessageBox.Show("Please fill all textboxes","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlServerDecoder decoder = new SqlServerDecoder();
            decoder.AddCustomer(name, country, address, telephoneNumber);
            int id = decoder.FindCustomer(name);

            decoder.RemoveStock(stock.StockID, number);

            decoder.AddStockMovement(stock.ProductID, "Sell", null, -1, id, number);

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
