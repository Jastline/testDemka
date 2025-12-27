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
            providerProduct = new Label();
            costProduct = new Label();
            unitOfMeasurementProduct = new Label();
            inStockProduct = new Label();
            discountProduct = new Label();
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
            // providerProduct
            // 
            providerProduct.AutoSize = true;
            providerProduct.Location = new Point(398, 48);
            providerProduct.Name = "providerProduct";
            providerProduct.Size = new Size(38, 15);
            providerProduct.TabIndex = 4;
            providerProduct.Text = "label4";
            // 
            // costProduct
            // 
            costProduct.AutoSize = true;
            costProduct.Location = new Point(398, 63);
            costProduct.Name = "costProduct";
            costProduct.Size = new Size(38, 15);
            costProduct.TabIndex = 5;
            costProduct.Text = "label5";
            // 
            // unitOfMeasurementProduct
            // 
            unitOfMeasurementProduct.AutoSize = true;
            unitOfMeasurementProduct.Location = new Point(398, 78);
            unitOfMeasurementProduct.Name = "unitOfMeasurementProduct";
            unitOfMeasurementProduct.Size = new Size(38, 15);
            unitOfMeasurementProduct.TabIndex = 6;
            unitOfMeasurementProduct.Text = "label6";
            // 
            // inStockProduct
            // 
            inStockProduct.AutoSize = true;
            inStockProduct.Location = new Point(398, 93);
            inStockProduct.Name = "inStockProduct";
            inStockProduct.Size = new Size(38, 15);
            inStockProduct.TabIndex = 7;
            inStockProduct.Text = "label7";
            // 
            // discountProduct
            // 
            discountProduct.AutoSize = true;
            discountProduct.Location = new Point(959, 18);
            discountProduct.Name = "discountProduct";
            discountProduct.Size = new Size(38, 15);
            discountProduct.TabIndex = 8;
            discountProduct.Text = "label8";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(discountProduct);
            Controls.Add(inStockProduct);
            Controls.Add(unitOfMeasurementProduct);
            Controls.Add(costProduct);
            Controls.Add(providerProduct);
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
        private Label providerProduct;
        private Label costProduct;
        private Label unitOfMeasurementProduct;
        private Label inStockProduct;
        private Label discountProduct;
    }
}
