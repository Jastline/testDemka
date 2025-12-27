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
            hScrollBar1 = new HScrollBar();
            flowLayoutPanel1.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(hScrollBar1);
            flowLayoutPanel1.Location = new Point(5, 153);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1183, 435);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(0, 0);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(80, 17);
            hScrollBar1.TabIndex = 0;
            // 
            // MainForm
            // 
            ClientSize = new Size(1200, 600);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(buttonLogout);
            Name = "MainForm";
            Text = "Обувной магазин";
            flowLayoutPanel1.ResumeLayout(false);
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
        private HScrollBar hScrollBar1;
    }
}