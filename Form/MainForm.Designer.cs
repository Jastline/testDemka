using testDemka.Data;

namespace testDemka
{
    // Класс для основного окна (логика)
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            buttonLogout = new Button();
            SuspendLayout();
            // 
            // buttonLog
            // 
            buttonLogout.Location = new Point(1095, 12);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(75, 25);
            buttonLogout.TabIndex = 0;
            buttonLogout.Text = "Выйти";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(1200, 600);
            Controls.Add(buttonLogout);
            Name = "MainForm";
            ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private Button buttonLogout;
    }
}