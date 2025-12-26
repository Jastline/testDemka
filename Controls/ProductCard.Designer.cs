namespace testDemka.Controls
{
    partial class ProductCard
    {
        // Элементы управления, которые будут на карточке
        private PictureBox pictureBoxPhoto;
        private Label labelCategory;
        private Label labelName;
        private Label labelDescription;
        private Label labelManufacturer;
        private Label labelSupplier;
        private Label labelPrice;
        private Label labelOldPrice;
        private Label labelFinalPrice;
        private Label labelUnit;
        private Label labelStock;
        private Label labelDiscount;
        private Panel panelMain;

        // Инициализация компонентов (дизайн)
        private void InitializeComponent()
        {
            // Создаём главную панель
            panelMain = new Panel();
            panelMain.Size = new Size(380, 280);
            panelMain.BackColor = Color.White;
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Padding = new Padding(10);

            // Картинка товара (слева)
            pictureBoxPhoto = new PictureBox();
            pictureBoxPhoto.Location = new Point(10, 10);
            pictureBoxPhoto.Size = new Size(100, 100);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto.BackColor = Color.LightGray;

            // Категория (справа сверху)
            labelCategory = new Label();
            labelCategory.Location = new Point(120, 10);
            labelCategory.Size = new Size(240, 20);
            labelCategory.Text = "Категория товара";
            labelCategory.Font = new Font("Times New Roman", 10, FontStyle.Bold);

            // Название товара
            labelName = new Label();
            labelName.Location = new Point(120, 35);
            labelName.Size = new Size(240, 25);
            labelName.Text = "Наименование товара";
            labelName.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            // Описание
            Label descTitle = new Label();
            descTitle.Location = new Point(120, 65);
            descTitle.Size = new Size(240, 15);
            descTitle.Text = "Описание товара:";
            descTitle.Font = new Font("Times New Roman", 9, FontStyle.Bold);

            labelDescription = new Label();
            labelDescription.Location = new Point(120, 80);
            labelDescription.Size = new Size(240, 40);
            labelDescription.Text = "Здесь будет описание товара";
            labelDescription.AutoSize = false;
            labelDescription.MaximumSize = new Size(240, 40);

            // Производитель
            Label manufTitle = new Label();
            manufTitle.Location = new Point(120, 125);
            manufTitle.Size = new Size(100, 15);
            manufTitle.Text = "Производитель:";
            manufTitle.Font = new Font("Times New Roman", 9, FontStyle.Bold);

            labelManufacturer = new Label();
            labelManufacturer.Location = new Point(220, 125);
            labelManufacturer.Size = new Size(140, 15);
            labelManufacturer.Text = "Производитель";

            // Поставщик
            Label suppTitle = new Label();
            suppTitle.Location = new Point(120, 145);
            suppTitle.Size = new Size(100, 15);
            suppTitle.Text = "Поставщик:";
            suppTitle.Font = new Font("Times New Roman", 9, FontStyle.Bold);

            labelSupplier = new Label();
            labelSupplier.Location = new Point(220, 145);
            labelSupplier.Size = new Size(140, 15);
            labelSupplier.Text = "Поставщик";

            // Цена
            Label priceTitle = new Label();
            priceTitle.Location = new Point(120, 165);
            priceTitle.Size = new Size(100, 15);
            priceTitle.Text = "Цена:";
            priceTitle.Font = new Font("Times New Roman", 9, FontStyle.Bold);

            labelPrice = new Label();
            labelPrice.Location = new Point(220, 163);
            labelPrice.Size = new Size(80, 20);
            labelPrice.Text = "4 990 ₽";
            labelPrice.Font = new Font("Times New Roman", 11, FontStyle.Bold);

            // Старая цена (только при скидке)
            labelOldPrice = new Label();
            labelOldPrice.Location = new Point(180, 165);
            labelOldPrice.Size = new Size(60, 15);
            labelOldPrice.Text = "5 150";
            labelOldPrice.Font = new Font("Times New Roman", 9, FontStyle.Strikeout);
            labelOldPrice.ForeColor = Color.Red;
            labelOldPrice.Visible = false; // По умолчанию скрыта

            // Цена со скидкой
            labelFinalPrice = new Label();
            labelFinalPrice.Location = new Point(220, 163);
            labelFinalPrice.Size = new Size(80, 20);
            labelFinalPrice.Text = "4 990 ₽";
            labelFinalPrice.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            labelFinalPrice.Visible = false; // По умолчанию скрыта

            // Единица измерения
            Label unitTitle = new Label();
            unitTitle.Location = new Point(120, 185);
            unitTitle.Size = new Size(100, 15);
            unitTitle.Text = "Единица измерения:";
            unitTitle.Font = new Font("Times New Roman", 9, FontStyle.Bold);

            labelUnit = new Label();
            labelUnit.Location = new Point(250, 185);
            labelUnit.Size = new Size(50, 15);
            labelUnit.Text = "шт.";

            // Количество на складе
            Label stockTitle = new Label();
            stockTitle.Location = new Point(120, 205);
            stockTitle.Size = new Size(100, 15);
            stockTitle.Text = "На складе:";
            stockTitle.Font = new Font("Times New Roman", 9, FontStyle.Bold);

            labelStock = new Label();
            labelStock.Location = new Point(220, 205);
            labelStock.Size = new Size(50, 15);
            labelStock.Text = "6 шт.";

            // Скидка (в самом низу)
            labelDiscount = new Label();
            labelDiscount.Location = new Point(120, 230);
            labelDiscount.Size = new Size(240, 20);
            labelDiscount.Text = "Действующая скидка: 3%";
            labelDiscount.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            labelDiscount.ForeColor = Color.Red;
            labelDiscount.TextAlign = ContentAlignment.MiddleCenter;

            // Собираем всё вместе
            panelMain.Controls.Add(pictureBoxPhoto);
            panelMain.Controls.Add(labelCategory);
            panelMain.Controls.Add(labelName);
            panelMain.Controls.Add(descTitle);
            panelMain.Controls.Add(labelDescription);
            panelMain.Controls.Add(manufTitle);
            panelMain.Controls.Add(labelManufacturer);
            panelMain.Controls.Add(suppTitle);
            panelMain.Controls.Add(labelSupplier);
            panelMain.Controls.Add(priceTitle);
            panelMain.Controls.Add(labelPrice);
            panelMain.Controls.Add(labelOldPrice);
            panelMain.Controls.Add(labelFinalPrice);
            panelMain.Controls.Add(unitTitle);
            panelMain.Controls.Add(labelUnit);
            panelMain.Controls.Add(stockTitle);
            panelMain.Controls.Add(labelStock);
            panelMain.Controls.Add(labelDiscount);

            // Добавляем панель на наш контрол
            this.Controls.Add(panelMain);
            this.Size = panelMain.Size; // Размер контрола = размер панели

            // Вешаем обработчик клика на всю карточку
            panelMain.Click += OnCardClick;

            // И на все лейблы тоже
            foreach (Control ctrl in panelMain.Controls)
            {
                ctrl.Click += OnCardClick;
            }
        }
    }
}