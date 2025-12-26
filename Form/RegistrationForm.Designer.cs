namespace testDemka
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            buttonSignIn = new Button();
            buttonGuest = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 73);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 117);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
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
            // textBox1
            // 
            textBox1.Location = new Point(91, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 5;
            // 
            // RegistrationForm
            // 
            ClientSize = new Size(300, 300);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonGuest);
            Controls.Add(buttonSignIn);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Button buttonSignIn;
        private Button buttonGuest;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
