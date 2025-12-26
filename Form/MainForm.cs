using testDemka.Data;
using testDemka.Controls; // Добавляем using для наших контролов

namespace testDemka
{
    public partial class MainForm : Form
    {
        // Наш кастомный контейнер для товаров
        private ProductsContainer _productsContainer;

        public MainForm()
        {
            InitializeComponent();
            SetupUIByRole();
            ChangeTextMainForm();
            SetupProductsContainer(); // Создаём контейнер
            LoadProductsFromDatabase(); // Загружаем товары
        }

        // Создаём и настраиваем контейнер
        private void SetupProductsContainer()
        {
            // Создаём экземпляр нашего контрола
            _productsContainer = new ProductsContainer();

            // Устанавливаем положение и размер
            _productsContainer.Location = new Point(20, 150);
            _productsContainer.Size = new Size(1150, 400);

            // Подписываемся на событие клика по товару
            _productsContainer.ProductClicked += (sender, product) =>
            {
                HandleProductClick(product);
            };

            // Добавляем контейнер на форму
            this.Controls.Add(_productsContainer);
        }

        // Загружаем товары из БД
        private void LoadProductsFromDatabase()
        {
            // Получаем роль текущего пользователя
            string role = Session.CurrentUser?.roleName ?? "Гость";

            // Загружаем товары через DatabaseService
            var products = DatabaseService.GetAllProducts(role);

            // ПЕРЕДАЁМ список товаров в контейнер
            // Контейнер САМ разберётся как их отобразить!
            _productsContainer.LoadProducts(products);
        }

        // Обработка клика по товару
        private void HandleProductClick(Product product)
        {
            string message = $"Выбран товар: {product.name}\n" +
                           $"Цена: {product.priceWithDiscount:C}\n" +
                           $"Скидка: {product.discount}%";

            MessageBox.Show(message, "Информация о товаре");

            // Для админа можно добавить редактирование
            if (Session.IsAdmin)
            {
                // Код редактирования товара
            }
        }

        private void SetupUIByRole()
        {
            // Настраиваем интерфейс в зависимости от роли
            if (Session.IsAdmin || Session.IsManager)
            {
                AddFilterControls(); // Добавляем фильтры для админа/менеджера
            }
        }

        // Добавляем элементы фильтрации
        private void AddFilterControls()
        {
            // ComboBox для сортировки
            var cmbSort = new ComboBox();
            cmbSort.Location = new Point(20, 100);
            cmbSort.Size = new Size(200, 25);
            cmbSort.Items.AddRange(new[]
            {
                "Без сортировки",
                "По цене (возрастание)",
                "По цене (убывание)",
                "По скидке",
                "По названию"
            });
            cmbSort.SelectedIndex = 0;
            cmbSort.SelectedIndexChanged += (s, e) =>
            {
                ApplySorting(cmbSort.SelectedItem.ToString());
            };

            // ComboBox для категорий
            var cmbCategory = new ComboBox();
            cmbCategory.Location = new Point(240, 100);
            cmbCategory.Size = new Size(200, 25);
            cmbCategory.Items.AddRange(new[]
            {
                "Все категории",
                "Женская обувь",
                "Мужская обувь"
            });
            cmbCategory.SelectedIndex = 0;
            cmbCategory.SelectedIndexChanged += (s, e) =>
            {
                ApplyCategoryFilter(cmbCategory.SelectedItem.ToString());
            };

            this.Controls.Add(cmbSort);
            this.Controls.Add(cmbCategory);
        }

        private void ApplySorting(string sortType)
        {
            switch (sortType)
            {
                case "По цене (возрастание)":
                    _productsContainer.SortBy("price_asc");
                    break;
                case "По цене (убывание)":
                    _productsContainer.SortBy("price_desc");
                    break;
                case "По скидке":
                    _productsContainer.SortBy("discount_desc");
                    break;
                case "По названию":
                    _productsContainer.SortBy("name_asc");
                    break;
            }
        }

        private void ApplyCategoryFilter(string category)
        {
            _productsContainer.FilterByCategory(category);
        }

        private void ChangeTextMainForm()
        {
            if (Session.CurrentUser != null)
            {
                this.Text = $"Обувной магазин - {Session.CurrentUser.roleName}";
                buttonLogout.Text = Session.CurrentUser.fullName;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            RegistrationForm loginForm = new RegistrationForm();
            loginForm.Show();
            this.Close();
        }
    }
}