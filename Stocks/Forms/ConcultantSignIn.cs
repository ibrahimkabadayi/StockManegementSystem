using Stocks.Classes;
using Stocks.Classes.TableSets;

namespace Stocks
{
    public partial class ConcultantSignIn : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public ConcultantSignIn()
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

        private async void registerButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string telephoneNumber = telephoneNumberTextBox.Text;
            string password = passwordTextBox.Text;

            if (!(name.Length > 0 && telephoneNumber.Length == 14 && password.Length > 0 && password.Equals(passwordAgainTextBox.Text)))
            {
                MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurun.");
                return;
            }

            try
            {
                var newEmployee = new Staff
                {
                    Name = name,
                    Password = password,
                    TelephoneNumber = telephoneNumber,
                    Task = "Consultant" // Yazım hatası düzeltildi
                };

                // await kullanarak asenkron çağrı yapıyoruz
                await _unitOfWork.Staff.AddAsync(newEmployee);

                // Değişiklikleri kaydetmek için UnitOfWork'ün SaveChangesAsync metodunu çağırıyoruz
                await _unitOfWork.SaveChangesAsync();

                MessageBox.Show("Personel başarıyla kaydedildi.");

                // Form alanlarını temizle
                nameTextBox.Clear();
                telephoneNumberTextBox.Clear();
                passwordTextBox.Clear();
                passwordAgainTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }
    }
}
