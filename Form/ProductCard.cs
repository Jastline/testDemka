using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDemka
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
            setProductCard("1.jpg", "Обувь для мужчин", "Жопа, 44 размер", "ООО никитосик", "ООО поставщик", "2800.00", "5", "5");
        }

        private void setProductCard(string pictureName, string categoryProductName, string descriptionProductName, 
            string manufacturerProductName, string providerProductName, string costProductName, string inStockProductName, 
            string discountProductName)
        {
            if (pictureBox != null)
            {
                pictureBox.ImageLocation = $"C:/Users/JastLIne/source/repos/testDemka/Images/{pictureName}";
            }
            else
            {
                pictureBox.ImageLocation = "C:/Users/JastLIne/source/repos/testDemka/Images/picture.png";
            }
            categoryProduct.Text = categoryProductName;
            descriptionProduct.Text = descriptionProductName;
            manufacturerProduct.Text = manufacturerProductName;
            providerProduct.Text = providerProductName;
            costProduct.Text = costProductName; 
            unitOfMeasurementProduct.Text = "шт.";
            inStockProduct.Text = inStockProductName;
            discountProduct.Text = discountProductName;
        }
    }
}
