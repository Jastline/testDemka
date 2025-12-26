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
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(1095, 12);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(75, 25);
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 130);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1158, 440);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // MainForm
            // 
            ClientSize = new Size(1200, 600);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(buttonLogout);
            Name = "MainForm";
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
        private FlowLayoutPanel flowLayoutPanel1;
    }
}