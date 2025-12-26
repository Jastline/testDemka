using testDemka.Data;
using System.Collections.Generic;

namespace testDemka.Controls
{
    public partial class ProductsContainer : UserControl
    {
        // Список товаров для отображения
        private List<Product> _products = new List<Product>();

        // Панель, на которой будут карточки
        private FlowLayoutPanel _flowPanel;

        // Конструктор
        public ProductsContainer()
        {
            InitializeComponent();
            SetupContainer();
        }

        // Настройка контейнера
        private void SetupContainer()
        {
            // Создаём FlowLayoutPanel - она сама расставляет элементы
            _flowPanel = new FlowLayoutPanel();
            _flowPanel.Dock = DockStyle.Fill; // Заполняет весь контрол
            _flowPanel.AutoScroll = true;     // Полосы прокрутки при необходимости
            _flowPanel.WrapContents = true;   // Перенос на новую строку
            _flowPanel.BackColor = Color.White;

            // Добавляем панель на наш контрол
            this.Controls.Add(_flowPanel);
        }

        // ОСНОВНОЙ МЕТОД: загружаем товары
        public void LoadProducts(List<Product> products)
        {
            _products = products ?? new List<Product>();
            RefreshDisplay();
        }

        // Очистка
        public void Clear()
        {
            _products.Clear();
            _flowPanel.Controls.Clear();
        }

        // Добавить один товар
        public void AddProduct(Product product)
        {
            if (product != null)
            {
                _products.Add(product);
                AddProductCard(product);
            }
        }

        // Создаём и добавляем карточку
        private void AddProductCard(Product product)
        {
            var card = new ProductCard(product);
            card.Margin = new Padding(10); // Отступы между карточками

            // Подписываемся на клик по карточке
            card.CardClicked += (sender, prod) =>
            {
                OnProductClicked(prod);
            };

            // Добавляем карточку на панель
            _flowPanel.Controls.Add(card);
        }

        // Обновляем отображение
        private void RefreshDisplay()
        {
            _flowPanel.SuspendLayout(); // Приостанавливаем перерисовку
            _flowPanel.Controls.Clear(); // Очищаем старые карточки

            // Создаём новые карточки
            foreach (var product in _products)
            {
                AddProductCard(product);
            }

            _flowPanel.ResumeLayout(); // Возобновляем перерисовку
        }

        // Событие: когда кликают на товар
        public event EventHandler<Product> ProductClicked;

        private void OnProductClicked(Product product)
        {
            ProductClicked?.Invoke(this, product);
        }

        // Сортировка товаров
        public void SortBy(string criteria)
        {
            switch (criteria)
            {
                case "price_asc":
                    _products = _products.OrderBy(p => p.priceWithDiscount).ToList();
                    break;
                case "price_desc":
                    _products = _products.OrderByDescending(p => p.priceWithDiscount).ToList();
                    break;
                case "discount_desc":
                    _products = _products.OrderByDescending(p => p.discount).ToList();
                    break;
                case "name_asc":
                    _products = _products.OrderBy(p => p.name).ToList();
                    break;
                default:
                    break;
            }

            RefreshDisplay();
        }

        // Фильтрация по категории
        public void FilterByCategory(string category)
        {
            if (category == "Все категории")
            {
                RefreshDisplay();
            }
            else
            {
                var filtered = _products.Where(p => p.categoryName == category).ToList();
                ShowFilteredProducts(filtered);
            }
        }

        // Показать отфильтрованные товары
        private void ShowFilteredProducts(List<Product> filteredProducts)
        {
            _flowPanel.SuspendLayout();
            _flowPanel.Controls.Clear();

            foreach (var product in filteredProducts)
            {
                AddProductCard(product);
            }

            _flowPanel.ResumeLayout();
        }
    }
}