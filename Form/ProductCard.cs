using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testDemka.Data;

namespace testDemka
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        public void setProductCard(Product product)
        {
            if (pictureBox != null && !string.IsNullOrEmpty(product.photoPath))
            {
                string fullPath = Path.Combine("C:/Users/JastLIne/source/repos/testDemka/Images/", product.photoPath);

                if (File.Exists(fullPath))
                {
                    pictureBox.ImageLocation = fullPath;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox.ImageLocation = "C:/Users/JastLIne/source/repos/testDemka/Images/picture.png";
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else if (pictureBox != null)
            {
                pictureBox.ImageLocation = "C:/Users/JastLIne/source/repos/testDemka/Images/picture.png";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            categoryProduct.Text = $"{product.categoryName} | {product.name}";
            descriptionProduct.Text = $"Описание товара: {product.description}";
            manufacturerProduct.Text = $"Производитель: {product.manufacturerName}";
            providerProduct.Text = $"Поставщик: {product.providerName}";
            if (product.discount > 0)
            {
                decimal newPrice = product.cost * (100 - product.discount) / 100;

                costProduct.Text = $"{product.cost:C}";
                costProduct.Font = new Font(costProduct.Font, FontStyle.Strikeout);
                costProduct.ForeColor = Color.Gray;

                newPriceProduct.Text = $"→ {newPrice:C}";
                newPriceProduct.Visible = true;
                newPriceProduct.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                newPriceProduct.ForeColor = Color.Red;
            }
            else
            {
                costProduct.Text = $"Цена: {product.cost:C}";
                costProduct.Font = new Font(costProduct.Font, FontStyle.Regular);
                costProduct.ForeColor = Color.Black;
                newPriceProduct.Visible = false;
            }
            unitOfMeasurementProduct.Text = $"Единица измерения: {product.unitOfMeasurement}" ?? "Единица измерения: шт.";
            inStockProduct.Text = $"Количество на складе: {product.inStock}";
            discountProduct.Text = product.discount > 0 ? $"{product.discount}%" : "Нет скидки";

            // Дополнительно: меняем цвет, если скидка большая
            if (product.hasHighDiscount)
            {
                this.BackColor = Color.FromArgb(0x2E, 0x8B, 0x57);
                discountProduct.ForeColor = Color.White;
                discountProduct.Font = new Font(discountProduct.Font, FontStyle.Bold);
            }
        }
    }
}
