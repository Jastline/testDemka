using testDemka.Data;

namespace testDemka
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text;

            if (!string.IsNullOrWhiteSpace(login) && !string.IsNullOrWhiteSpace(password))
            {
                // Вызываем метод из DatabaseService
                var user = DatabaseService.GetUserWithRole(login, password);

                if (user != null)
                {
                    Session.CurrentUser = user;

                    // Открываем главную форму
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide(); // Скрываем форму авторизации
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка!",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            // Создаем гостевого пользователя
            Session.CurrentUser = new User
            {
                id = 0,
                roleName = "Гость",
                lastName = "Гость",
                firstName = "",
                secondName = ""
            };

            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}