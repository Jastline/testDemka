using testDemka.Data;


namespace testDemka
{
    // Класс для основного окна (логика)
    public partial class MainForm : Form
    {
        public MainForm()
        {
            // Через конструктор вызываем дизайн всей страницы
            InitializeComponent();
            SetupUIByRole(); // Прячем то, что не должен видеть пользователь
            ChangeTextMainForm();
            ProductCard productCard = new ProductCard();
            productCard.Visible = true;
            panelCatalog.Controls.Add(productCard);
            loadProducts();
        }

        private void SetupUIByRole()
        {
            // Пока что просто сообщение
        }

        private void ChangeTextMainForm()
        {
            if (Session.CurrentUser != null)
            {
                this.Text = Text += $" - {Session.CurrentUser.roleName}";
                buttonLogout.Text = Session.CurrentUser.fullName;
            }
            else
            {
                buttonLogout.Text = "Выйти";
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            RegistrationForm loginForm = new RegistrationForm();
            loginForm.Show();
            this.Close();
        }

        private void loadProducts()
        {
            panelCatalog.Controls.Clear();

            List<Product> products = DatabaseService.GetAllProduct();

            // Начальные координаты
            int x = 10;
            int y = 10;

            // Размеры карточки (ширина на всю панель с отступами)
            int cardWidth = panelCatalog.Width - 20;
            int cardHeight = 300;
            int spacing = 15;

            foreach (Product product in products)
            {
                ProductCard productCard = new ProductCard();
                productCard.setProductCard(product);

                // Настраиваем расположение (одна карточка на строку)
                productCard.Location = new Point(x, y);
                productCard.Size = new Size(cardWidth, cardHeight);

                // Добавляем на панель
                panelCatalog.Controls.Add(productCard);

                // Смещаем по вертикали
                y += cardHeight + spacing;
            }
        }
    }
}