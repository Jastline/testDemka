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
            label1 = new Label();
            SuspendLayout();
            //  
            // buttonLogout
            // 
            buttonLogout.Location = new Point(959, 12);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(229, 25);
            buttonLogout.TabIndex = 0;
            buttonLogout.Text = "Выйти";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(222, 34);
            label1.TabIndex = 1;
            label1.Text = "Каталог товаров";
            // 
            // MainForm
            // 
            ClientSize = new Size(1200, 600);
            Controls.Add(label1);
            Controls.Add(buttonLogout);
            Name = "MainForm";
            Text = "Обувной магазин";
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
        private Button buttonLogout;
        private Label label1;
    }
}