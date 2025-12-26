using testDemka.Data;

namespace testDemka
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {

            SuspendLayout();
            // 
            // MainForm
            // 
            ClientSize = new Size(1200, 600);
            Name = "MainForm";
            Text = "Залупа1";
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
    }
}