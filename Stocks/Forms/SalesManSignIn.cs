using Stocks.Classes;
using Stocks.Classes.TableSets;

namespace Stocks
{
    public partial class SalesManSignIn : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public SalesManSignIn()
        {
            InitializeComponent();
            var context = new StockDatabase();
            _unitOfWork = new UnitOfWork(context);
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void registerButton_Click(object sender, EventArgs e)
        {
            _ = RegisterUserAsync();
        }
        private async Task RegisterUserAsync()
        {
            try
            {
                string name = nameTextBox.Text;
                string telephoneNumber = telephoneNumberTextBox.Text;
                string password = passwordTextBox.Text;

                if (!(name.Length > 0 && telephoneNumber.Length == 14 && password.Length > 0 && password.Equals(passwordAgainTextBox.Text)))
                {
                    return;
                }

                var newEmployee = new Staff { Name = name, Password = password, TelephoneNumber = telephoneNumber, Task = "Salesman" };

                await _unitOfWork.Staff.AddAsync(newEmployee);
                await _unitOfWork.SaveChangesAsync(); // ← Veya bu metod

                MessageBox.Show("Kayıt başarıyla tamamlandı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
}
