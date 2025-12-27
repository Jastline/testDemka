using testDemka.Data;


namespace testDemka
{
    // Класс для основного окна (логика)
    public partial class MainForm : Form
    {
        public MainForm()
        {
            // Через конструктор вызываем дизайн всей страницы
            InitializeComponent();
            SetupUIByRole(); // Прячем то, что не должен видеть пользователь
            ChangeTextMainForm();
            ProductCard productCard = new ProductCard();
            productCard.Visible = true;
            panelCatalog.Controls.Add(productCard);
        }

        private void SetupUIByRole()
        {
            // Пока что просто сообщение
        }

        private void ChangeTextMainForm()
        {
            if (Session.CurrentUser != null)
            {
                this.Text = Text += $" - {Session.CurrentUser.roleName}";
                buttonLogout.Text = Session.CurrentUser.fullName;
            }
            else
            {
                buttonLogout.Text = "Выйти";
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            RegistrationForm loginForm = new RegistrationForm();
            loginForm.Show();
            this.Close();
        }
    }
}