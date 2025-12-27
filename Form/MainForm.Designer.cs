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
            titleCatalog = new Label();
            panelCatalog = new FlowLayoutPanel();
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
            // titleCatalog
            // 
            titleCatalog.AutoSize = true;
            titleCatalog.Font = new Font("Times New Roman", 22F);
            titleCatalog.Location = new Point(12, 12);
            titleCatalog.Name = "titleCatalog";
            titleCatalog.Size = new Size(222, 34);
            titleCatalog.TabIndex = 1;
            titleCatalog.Text = "Каталог товаров";
            // 
            // panelCatalog
            // 
            panelCatalog.Location = new Point(5, 153);
            panelCatalog.Name = "panelCatalog";
            panelCatalog.Size = new Size(1183, 435);
            panelCatalog.TabIndex = 2;
            // 
            // MainForm
            // 
            ClientSize = new Size(1200, 600);
            Controls.Add(panelCatalog);
            Controls.Add(titleCatalog);
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
        private Label titleCatalog;
        private FlowLayoutPanel panelCatalog;
    }
}