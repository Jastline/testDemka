using testDemka.Data;

namespace testDemka
{   
    // Класс для формы регистрации (логика)
    public partial class RegistrationForm : Form
    {   
        // Инициализируем дизайн
        public RegistrationForm()
        {
            InitializeComponent();
        }

        // Метод для кнопки входа (авторизация)
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            // Проверка на заполнение формы
            if (!string.IsNullOrWhiteSpace(login) && !string.IsNullOrWhiteSpace(password))
            {
                // Получаем данные пользователя по логину и паролю
                var user = DatabaseService.GetUserWithRole(login, password);

                // Если пользователь найден
                if (user != null)
                {
                    // Присваиваем текущей сессии юзера
                    Session.CurrentUser = user;

                    // Открываем главную форму
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide(); // Скрываем форму авторизации
                }
                // Если пользователь не найден
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка!");
            }
        }

        // Метод для входа как гость
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