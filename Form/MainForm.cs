using testDemka.Data;

namespace testDemka
{
    public partial class MainForm : Form
    {
        // Добавь эти контролы в InitializeComponent позже
        private Label lblWelcome;
        private Label lblRole;
        private Button btnLogout;

        public MainForm()
        {
            InitializeComponent();
            SetupUIByRole();
            LoadWelcomeMessage();
        }

        private void SetupUIByRole()
        {
            // Пока что просто сообщение
            // Позже добавишь реальные контролы
        }

        private void LoadWelcomeMessage()
        {
            if (Session.CurrentUser != null)
            {
                this.Text = $"Обувной магазин - {Session.CurrentUser.fullName} ({Session.CurrentUser.roleName})";
            }
            else
            {
                this.Text = "Обувной магазин - Гость";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            RegistrationForm loginForm = new RegistrationForm();
            loginForm.Show();
            this.Close();
        }

        // Обнови InitializeComponent в файле дизайна:
    }
}