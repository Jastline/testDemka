using testDemka.Data;
using System.IO;

namespace testDemka.Controls
{
    // UserControl - это базовый класс для создания своих контролов
    public partial class ProductCard : UserControl
    {
        private Product _product; // Товар, который отображаем

        // Конструктор: принимаем товар и создаём карточку
        public ProductCard(Product product)
        {
            _product = product;
            InitializeComponent(); // Создаём все элементы
            SetupCard();           // Заполняем данными
            ApplyStyles();         // Применяем стили
        }

        // Свойство для доступа к товару
        public Product Product => _product;

        // Событие: когда кликают на карточку
        public event EventHandler<Product> CardClicked;

        // Вызывается при клике на карточку
        private void OnCardClick(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, _product);
        }

        private void SetupCard()
        {
            // Загружаем фото товара
            if (!string.IsNullOrEmpty(_product.photoPath))
            {
                string path = $"Images/{_product.photoPath}";
                if (File.Exists(path))
                {
                    pictureBoxPhoto.Image = Image.FromFile(path);
                }
                else
                {
                    // Заглушка, если фото нет
                    pictureBoxPhoto.Image = LoadDefaultImage();
                }
            }

            // Заполняем текстовые поля
            labelName.Text = _product.name;
            labelCategory.Text = _product.categoryName;
            labelDescription.Text = _product.description;
            labelManufacturer.Text = _product.manufacturerName;
            labelSupplier.Text = _product.providerName;
            labelPrice.Text = $"{_product.cost:C}";
            labelDiscount.Text = $"{_product.discount}%";
            labelStock.Text = $"{_product.inStock} шт.";
            labelUnit.Text = _product.unitOfMeasurement;

            // Если есть скидка, показываем старую и новую цену
            if (_product.discount > 0)
            {
                labelOldPrice.Text = $"{_product.cost:C}";
                labelOldPrice.Visible = true;
                labelFinalPrice.Text = $"{_product.priceWithDiscount:C}";
                labelFinalPrice.Visible = true;
                labelPrice.Visible = false; // Скрываем обычную цену
            }
        }

        private void ApplyStyles()
        {
            // 1. Подсветка скидки >15% (цвет #2E8B57)
            if (_product.discount > 15)
            {
                this.BackColor = Color.FromArgb(0x2E, 0x8B, 0x57); // Конвертируем HEX в Color

                // Меняем цвет текста на белый для читаемости
                foreach (Control control in this.Controls)
                {
                    if (control is Label label)
                    {
                        label.ForeColor = Color.White;
                    }
                }

                // Скидку красим в жёлтый для контраста
                labelDiscount.ForeColor = Color.Yellow;
            }

            // 2. Подсветка отсутствия товара (голубой)
            if (_product.inStock == 0)
            {
                this.BackColor = Color.LightBlue;
            }

            // 3. Устанавливаем шрифт Times New Roman для всех лейблов
            SetFontForAllLabels(this, new Font("Times New Roman", 9F));

            // 4. Жирный шрифт для названия и цены
            labelName.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            labelPrice.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            labelFinalPrice.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
        }

        private void SetFontForAllLabels(Control parent, Font font)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Label label && !label.Font.Bold)
                {
                    label.Font = font;
                }

                // Рекурсивно для вложенных контролов
                if (control.HasChildren)
                {
                    SetFontForAllLabels(control, font);
                }
            }
        }

        private Image LoadDefaultImage()
        {
            // Заглушка picture.png из задания
            if (File.Exists("picture.png"))
            {
                return Image.FromFile("picture.png");
            }

            // Если файла нет, создаём простую заглушку
            Bitmap bmp = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                g.DrawString("Нет фото", new Font("Arial", 10), Brushes.Black, 10, 40);
            }
            return bmp;
        }
    }
}