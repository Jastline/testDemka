
namespace testDemka
{
    public partial class RegistrationForm : Form
    {
        RegistrationForm registrationForm;

        public RegistrationForm()
        {
            InitializeComponent();
            registrationForm = this;
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            registrationForm.Hide();
            MainForm.mainForm = new MainForm();
            MainForm.mainForm.Show();
        }
    }
}
