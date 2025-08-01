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
    public partial class Marketplace : Form
    {
        int id;
        public Marketplace(int id)
        {
            this.id = id;
            InitializeComponent();
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

        private void Marketplace_Load(object sender, EventArgs e)
        {
            using (StockDatabase db = new StockDatabase()) 
            {
                var products = db.products;
                productsListBox.DataSource = products;
                productsListBox.SelectedIndex = -1;
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            SqlServerDecoder decoder = new SqlServerDecoder();
            var Product = productsListBox.SelectedItem as Product;
            int number = Convert.ToInt32(numberTextBox.Text.Trim());

            if (Product != null && number > 0 && number <= Product.Number) 
            {
                decoder.AddStock(Product.ProductId, number);
                decoder.removeProduct(Product.ProductId, number);
            }
            else 
            {
                MessageBox.Show("There is not enough product in the marketplace please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
