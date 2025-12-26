namespace testDemka
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            labelLogin = new Label();
            labelPassword = new Label();
            buttonSignIn = new Button();
            buttonGuest = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(91, 73);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(41, 15);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(91, 117);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(49, 15);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Пароль";
            // 
            // buttonSignIn
            // 
            buttonSignIn.Location = new Point(91, 178);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(96, 42);
            buttonSignIn.TabIndex = 2;
            buttonSignIn.Text = "Войти";
            buttonSignIn.UseVisualStyleBackColor = true;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // buttonGuest
            // 
            buttonGuest.Location = new Point(197, 12);
            buttonGuest.Name = "buttonGuest";
            buttonGuest.Size = new Size(75, 23);
            buttonGuest.TabIndex = 3;
            buttonGuest.Text = "Гость";
            buttonGuest.UseVisualStyleBackColor = true;
            buttonGuest.Click += buttonGuest_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(91, 91);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(149, 23);
            textBoxLogin.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(91, 135);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(149, 23);
            textBoxPassword.TabIndex = 5;
            // 
            // RegistrationForm
            // 
            ClientSize = new Size(300, 300);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(buttonGuest);
            Controls.Add(buttonSignIn);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Name = "RegistrationForm";
            Text = "Форма регистрации";
            ResumeLayout(false);
            PerformLayout();

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private Label labelLogin;
        private Label labelPassword;
        private Button buttonSignIn;
        private Button buttonGuest;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
    }
}
