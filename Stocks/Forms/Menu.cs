using Stocks.Classes;

namespace Stocks
{
    public partial class Menu : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public Menu()
        {
            InitializeComponent();
            var context = new StockDatabase();
            _unitOfWork = new UnitOfWork(context);
        }

        private Form currentForm;
        private void ShowFormAsPanel(Form formToShow)
        {
            if (currentForm != null)
            {
                currentForm.Hide();
                this.Controls.Remove(currentForm);
                currentForm.Close();
                currentForm.Dispose();
                currentForm = null;
            }

            currentForm = formToShow;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;

            this.Controls.Add(currentForm);
            currentForm.BringToFront();
            currentForm.Show();

            this.Text = formToShow.Text;
        }

        public void ShowMainMenu()
        {
            if (currentForm != null)
            {
                currentForm.Hide();
                this.Controls.Remove(currentForm);
                currentForm.Close();
                currentForm.Dispose();
                currentForm = null;
            }

            this.Text = "Main Menu";

            foreach (Control control in this.Controls)
            {
                if (control is Button || control is Label)
                {
                    control.Visible = true;
                }
            }
        }
       
        private async void registerButton_Click(object sender, EventArgs e)
        {
            
            string name = nameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            int id = Convert.ToInt32(idTextBox.Text.Trim());
            string task = SalesmanRadioButton1.Checked ? SalesmanRadioButton1.Text : ConcultantRadioButton2.Text; 

            if (!(name.Length > 0 && password.Length > 0 && id > 0)) 
            {
                return;
            }

            var employees = await _unitOfWork.Staff.FindAsync(s =>
                s.Name == name &&
                s.Password == password &&
                s.Task == task &&
                s.EmployeeID == id);

            if (employees.Count > 0) 
            {
                if (task.Equals("Salesman")) 
                {
                    ShowFormAsPanel(new Marketplace(id));
                }
                else 
                {
                    ShowFormAsPanel(new ConcultantConfirmZone(id));
                }
            }
        }

        private void SalesmanLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowFormAsPanel(new SalesManSignIn());
        }

        private void ConcultantLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowFormAsPanel(new ConcultantSignIn());
        }

        private void CustomerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowFormAsPanel(new CustomerBuyingZone());
        }
    }
}
