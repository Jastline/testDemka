namespace testDemka
{
    partial class ProductCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            categoryProduct = new Label();
            descriptionProduct = new Label();
            manufacturerProduct = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(389, 609);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // categoryProduct
            // 
            categoryProduct.AutoSize = true;
            categoryProduct.Location = new Point(398, 3);
            categoryProduct.Name = "categoryProduct";
            categoryProduct.Size = new Size(38, 15);
            categoryProduct.TabIndex = 1;
            categoryProduct.Text = "label1";
            // 
            // descriptionProduct
            // 
            descriptionProduct.AutoSize = true;
            descriptionProduct.Location = new Point(398, 18);
            descriptionProduct.Name = "descriptionProduct";
            descriptionProduct.Size = new Size(38, 15);
            descriptionProduct.TabIndex = 2;
            descriptionProduct.Text = "label2";
            // 
            // manufacturerProduct
            // 
            manufacturerProduct.AutoSize = true;
            manufacturerProduct.Location = new Point(398, 33);
            manufacturerProduct.Name = "manufacturerProduct";
            manufacturerProduct.Size = new Size(38, 15);
            manufacturerProduct.TabIndex = 3;
            manufacturerProduct.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 48);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 63);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(398, 78);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(398, 93);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 7;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(959, 18);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 8;
            label8.Text = "label8";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(manufacturerProduct);
            Controls.Add(descriptionProduct);
            Controls.Add(categoryProduct);
            Controls.Add(pictureBox);
            Name = "ProductCard";
            Size = new Size(1122, 615);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox;
        private Label categoryProduct;
        private Label descriptionProduct;
        private Label manufacturerProduct;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
