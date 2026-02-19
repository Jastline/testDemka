namespace testDemka
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Точка входа и инициализации приложения
            ApplicationConfiguration.Initialize();
            Application.Run(new RegistrationForm());
        }
    }
}

/*
BEGIN;


CREATE TABLE IF NOT EXISTS public.category
(
    id serial NOT NULL,
    category character varying COLLATE pg_catalog."default",
    CONSTRAINT category_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.manufacturer
(
    id serial NOT NULL,
    manufacturer character varying COLLATE pg_catalog."default",
    CONSTRAINT manufacturer_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.orderproduct
(
    id serial NOT NULL,
    count integer,
    orderid integer,
    productarticle character varying(6) COLLATE pg_catalog."default",
    CONSTRAINT orderproduct_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.orders
(
    id serial NOT NULL,
    dateorder date,
    datedelivery date,
    code integer,
    pickuppointid integer,
    userid integer,
    statusid integer,
    CONSTRAINT orders_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.pickuppoint
(
    id serial NOT NULL,
    address character varying COLLATE pg_catalog."default",
    CONSTRAINT pickuppoint_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.product
(
    article character varying(6) COLLATE pg_catalog."default" NOT NULL,
    name character varying COLLATE pg_catalog."default",
    unitofmeasurement character varying COLLATE pg_catalog."default" DEFAULT 'шт.'::character varying,
    cost real,
    discount integer,
    instock integer,
    description character varying COLLATE pg_catalog."default",
    photopath character varying COLLATE pg_catalog."default",
    manufacturerid integer,
    categoryid integer,
    providerid integer,
    CONSTRAINT product_pkey PRIMARY KEY(article)
);

CREATE TABLE IF NOT EXISTS public.provider
(
    id serial NOT NULL,
    provider character varying COLLATE pg_catalog."default",
    CONSTRAINT provider_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.roles
(
    id serial NOT NULL,
    role character varying(255) COLLATE pg_catalog."default",
    CONSTRAINT roles_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.status
(
    id serial NOT NULL,
    status character varying COLLATE pg_catalog."default",
    CONSTRAINT status_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.users
(
    id serial NOT NULL,
    firstname character varying COLLATE pg_catalog."default",
    secondname character varying COLLATE pg_catalog."default",
    lastname character varying COLLATE pg_catalog."default",
    login character varying COLLATE pg_catalog."default",
    password character varying COLLATE pg_catalog."default",
    roleid integer,
    CONSTRAINT users_pkey PRIMARY KEY(id)
);

ALTER TABLE IF EXISTS public.orderproduct
    ADD CONSTRAINT orderproduct_orderid_fkey FOREIGN KEY (orderid)
    REFERENCES public.orders(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.orderproduct
    ADD CONSTRAINT orderproduct_productarticle_fkey FOREIGN KEY (productarticle)
    REFERENCES public.product(article) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.orders
    ADD CONSTRAINT orders_pickuppointid_fkey FOREIGN KEY (pickuppointid)
    REFERENCES public.pickuppoint(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.orders
    ADD CONSTRAINT orders_statusid_fkey FOREIGN KEY (statusid)
    REFERENCES public.status(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.orders
    ADD CONSTRAINT orders_userid_fkey FOREIGN KEY (userid)
    REFERENCES public.users(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.product
    ADD CONSTRAINT product_categoryid_fkey FOREIGN KEY (categoryid)
    REFERENCES public.category(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.product
    ADD CONSTRAINT product_manufacturerid_fkey FOREIGN KEY (manufacturerid)
    REFERENCES public.manufacturer(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.product
    ADD CONSTRAINT product_providerid_fkey FOREIGN KEY (providerid)
    REFERENCES public.provider(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.users
    ADD CONSTRAINT users_roleid_fkey FOREIGN KEY (roleid)
    REFERENCES public.roles(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;

END;
*/

/*
INSERT INTO pickUpPoint (address) VALUES
('420151, г. Лесной, ул. Вишневая, 32'),
('125061, г. Лесной, ул. Подгорная, 8'),
('630370, г. Лесной, ул. Шоссейная, 24'),
('400562, г. Лесной, ул. Зеленая, 32'),
('614510, г. Лесной, ул. Маяковского, 47'),
('410542, г. Лесной, ул. Светлая, 46'),
('620839, г. Лесной, ул. Цветочная, 8'),
('443890, г. Лесной, ул. Коммунистическая, 1'),
('603379, г. Лесной, ул. Спортивная, 46'),
('603721, г. Лесной, ул. Гоголя, 41'),
('410172, г. Лесной, ул. Северная, 13'),
('614611, г. Лесной, ул. Молодежная, 50'),
('454311, г. Лесной, ул. Новая, 19'),
('660007, г. Лесной, ул. Октябрьская, 19'),
('603036, г. Лесной, ул. Садовая, 4'),
('394060, г. Лесной, ул. Фрунзе, 43'),
('410661, г. Лесной, ул. Школьная, 50'),
('625590, г. Лесной, ул. Коммунистическая, 20'),
('625683, г. Лесной, ул. 8 Марта'),
('450983, г. Лесной, ул. Комсомольская, 26'),
('394782, г. Лесной, ул. Чехова, 3'),
('603002, г. Лесной, ул. Дзержинского, 28'),
('450558, г. Лесной, ул. Набережная, 30'),
('344288, г. Лесной, ул. Чехова, 1'),
('614164, г. Лесной, ул. Степная, 30'),
('394242, г. Лесной, ул. Коммунистическая, 43'),
('660540, г. Лесной, ул. Солнечная, 25'),
('125837, г. Лесной, ул. Шоссейная, 40'),
('125703, г. Лесной, ул. Партизанская, 49'),
('625283, г. Лесной, ул. Победы, 46'),
('614753, г. Лесной, ул. Полевая, 35'),
('426030, г. Лесной, ул. Маяковского, 44'),
('450375, г. Лесной ул. Клубная, 44'),
('625560, г. Лесной, ул. Некрасова, 12'),
('630201, г. Лесной, ул. Комсомольская, 17'),
('190949, г. Лесной, ул. Мичурина, 26');

-- 3. Заполнение таблицы roles (роли)
INSERT INTO roles (role) VALUES
('Администратор'),
('Менеджер'),
('Авторизированный клиент');

-- 4. Заполнение таблицы status (статусы заказов)
INSERT INTO status (status) VALUES
('Новый'),
('Завершен'),
('Отменен'),
('В обработке');

-- 5. Заполнение таблицы manufacturer (производители)
INSERT INTO manufacturer (manufacturer) VALUES
('Kari'),
('Marco Tozzi'),
('Рос'),
('Rieker'),
('Alessio Nesca'),
('CROSBY');

-- 6. Заполнение таблицы category (категории)
INSERT INTO category (category) VALUES
('Женская обувь'),
('Мужская обувь');

-- 7. Заполнение таблицы provider (поставщики)
INSERT INTO provider (provider) VALUES
('Kari'),
('Обувь для вас');

-- 8. Заполнение таблицы users (пользователи)
-- Сначала получим ID ролей для удобства
DO $$
DECLARE 
    admin_role_id INT;
    manager_role_id INT;
    client_role_id INT;
BEGIN
    SELECT id INTO admin_role_id FROM roles WHERE role = 'Администратор';
    SELECT id INTO manager_role_id FROM roles WHERE role = 'Менеджер';
    SELECT id INTO client_role_id FROM roles WHERE role = 'Авторизированный клиент';

    INSERT INTO users (firstName, secondName, lastName, login, password, roleID) VALUES
    -- Администраторы
    ('Весения', 'Николаевна', 'Никифорова', '94d5ous@gmail.com', 'uzWC67', admin_role_id),
    ('Руслан', 'Германович', 'Сазонов', 'uth4iz@mail.com', '2L6KZG', admin_role_id),
    ('Серафим', 'Артёмович', 'Одинцов', 'yzls62@outlook.com', 'JlFRCZ', admin_role_id),
    
    -- Менеджеры
    ('Михаил', 'Артёмович', 'Степанов', '1diph5e@tutanota.com', '8ntwUp', manager_role_id),
    ('Петр', 'Евгеньевич', 'Ворсин', 'tjde7c@yahoo.com', 'YOyhfR', manager_role_id),
    ('Елена', 'Павловна', 'Старикова', 'wpmrc3do@tutanota.com', 'RSbvHv', manager_role_id),
    
    -- Клиенты
    ('Анна', 'Вячеславовна', 'Михайлюк', '5d4zbu@tutanota.com', 'rwVDh9', client_role_id),
    ('Елена', 'Анатольевна', 'Ситдикова', 'ptec8ym@yahoo.com', 'LdNyos', client_role_id),
    ('Петр', 'Евгеньевич', 'Ворсин', '1qz4kw@mail.com', 'gynQMT', client_role_id),
    ('Елена', 'Павловна', 'Старикова', '4np6se@mail.com', 'AtnDjr', client_role_id);
END $$;

-- 9. Заполнение таблицы product (товары)
-- Сначала получим ID для связей
DO $$
DECLARE 
    kari_man_id INT;
    marco_man_id INT;
    ros_man_id INT;
    rieker_man_id INT;
    alessio_man_id INT;
    crosby_man_id INT;
    
    women_cat_id INT;
    men_cat_id INT;
    
    kari_prov_id INT;
    obuv_prov_id INT;
BEGIN
    -- Получаем ID производителей
    SELECT id INTO kari_man_id FROM manufacturer WHERE manufacturer = 'Kari';
    SELECT id INTO marco_man_id FROM manufacturer WHERE manufacturer = 'Marco Tozzi';
    SELECT id INTO ros_man_id FROM manufacturer WHERE manufacturer = 'Рос';
    SELECT id INTO rieker_man_id FROM manufacturer WHERE manufacturer = 'Rieker';
    SELECT id INTO alessio_man_id FROM manufacturer WHERE manufacturer = 'Alessio Nesca';
    SELECT id INTO crosby_man_id FROM manufacturer WHERE manufacturer = 'CROSBY';
    
    -- Получаем ID категорий
    SELECT id INTO women_cat_id FROM category WHERE category = 'Женская обувь';
    SELECT id INTO men_cat_id FROM category WHERE category = 'Мужская обувь';
    
    -- Получаем ID поставщиков
    SELECT id INTO kari_prov_id FROM provider WHERE provider = 'Kari';
    SELECT id INTO obuv_prov_id FROM provider WHERE provider = 'Обувь для вас';
    
    INSERT INTO product (article, name, unitOfMeasurement, cost, discount, inStock, description, photoPath, manufacturerID, categoryID, providerID) VALUES
    ('А112Т4', 'Ботинки', 'шт.', 4990, 3, 6, 'Женские Ботинки демисезонные kari', '1.jpg', kari_man_id, women_cat_id, kari_prov_id),
    ('F635R4', 'Ботинки', 'шт.', 3244, 2, 13, 'Ботинки Marco Tozzi женские демисезонные, размер 39, цвет бежевый', '2.jpg', marco_man_id, women_cat_id, obuv_prov_id),
    ('H782T5', 'Туфли', 'шт.', 4499, 4, 5, 'Туфли kari мужские классика MYZ21AW-450A, размер 43, цвет: черный', '3.jpg', kari_man_id, men_cat_id, kari_prov_id),
    ('G783F5', 'Ботинки', 'шт.', 5900, 2, 8, 'Мужские ботинки Рос-Обувь кожаные с натуральным мехом', '4.jpg', ros_man_id, men_cat_id, kari_prov_id),
    ('J384T6', 'Ботинки', 'шт.', 3800, 2, 16, 'B3430/14 Полуботинки мужские Rieker', '5.jpg', rieker_man_id, men_cat_id, obuv_prov_id),
    ('D572U8', 'Кроссовки', 'шт.', 4100, 3, 6, '129615-4 Кроссовки мужские', '6.jpg', ros_man_id, men_cat_id, obuv_prov_id),
    ('F572H7', 'Туфли', 'шт.', 2700, 2, 14, 'Туфли Marco Tozzi женские летние, размер 39, цвет черный', '7.jpg', marco_man_id, women_cat_id, kari_prov_id),
    ('D329H3', 'Полуботинки', 'шт.', 1890, 4, 4, 'Полуботинки Alessio Nesca женские 3-30797-47, размер 37, цвет: бордовый', '8.jpg', alessio_man_id, women_cat_id, obuv_prov_id),
    ('B320R5', 'Туфли', 'шт.', 4300, 2, 6, 'Туфли Rieker женские демисезонные, размер 41, цвет коричневый', '9.jpg', rieker_man_id, women_cat_id, kari_prov_id),
    ('G432E4', 'Туфли', 'шт.', 2800, 3, 15, 'Туфли kari женские TR-YR-413017, размер 37, цвет: черный', '10.jpg', kari_man_id, women_cat_id, kari_prov_id),
    ('S213E3', 'Полуботинки', 'шт.', 2156, 3, 6, '407700/01-01 Полуботинки мужские CROSBY', NULL, crosby_man_id, men_cat_id, obuv_prov_id),
    ('E482R4', 'Полуботинки', 'шт.', 1800, 2, 14, 'Полуботинки kari женские MYZ20S-149, размер 41, цвет: черный', NULL, kari_man_id, women_cat_id, kari_prov_id),
    ('S634B5', 'Кеды', 'шт.', 5500, 3, 0, 'Кеды Caprice мужские демисезонные, размер 42, цвет черный', NULL, crosby_man_id, men_cat_id, obuv_prov_id),
    ('K345R4', 'Полуботинки', 'шт.', 2100, 2, 3, '407700/01-02 Полуботинки мужские CROSBY', NULL, crosby_man_id, men_cat_id, obuv_prov_id),
    ('O754F4', 'Туфли', 'шт.', 5400, 4, 18, 'Туфли женские демисезонные Rieker артикул 55073-68/37', NULL, rieker_man_id, women_cat_id, obuv_prov_id),
    ('G531F4', 'Ботинки', 'шт.', 6600, 12, 9, 'Ботинки женские зимние ROMER арт. 893167-01 Черный', NULL, kari_man_id, women_cat_id, kari_prov_id),
    ('J542F5', 'Тапочки', 'шт.', 500, 13, 0, 'Тапочки мужские Арт.70701-55-67син р.41', NULL, kari_man_id, men_cat_id, kari_prov_id),
    ('B431R5', 'Ботинки', 'шт.', 2700, 2, 5, 'Мужские кожаные ботинки/мужские ботинки', NULL, rieker_man_id, men_cat_id, obuv_prov_id),
    ('P764G4', 'Туфли', 'шт.', 6800, 15, 15, 'Туфли женские, ARGO, размер 38', NULL, crosby_man_id, women_cat_id, kari_prov_id),
    ('C436G5', 'Ботинки', 'шт.', 10200, 15, 9, 'Ботинки женские, ARGO, размер 40', NULL, alessio_man_id, women_cat_id, kari_prov_id),
    ('F427R5', 'Ботинки', 'шт.', 11800, 15, 11, 'Ботинки на молнии с декоративной пряжкой FRAU', NULL, rieker_man_id, women_cat_id, obuv_prov_id),
    ('N457T5', 'Полуботинки', 'шт.', 4600, 3, 13, 'Полуботинки Ботинки черные зимние, мех', NULL, crosby_man_id, women_cat_id, kari_prov_id),
    ('D364R4', 'Туфли', 'шт.', 12400, 16, 5, 'Туфли Luiza Belly женские Kate-lazo черные из натуральной замши', NULL, kari_man_id, women_cat_id, kari_prov_id),
    ('S326R5', 'Тапочки', 'шт.', 9900, 17, 15, 'Мужские кожаные тапочки "Профиль С.Дали"', NULL, crosby_man_id, men_cat_id, obuv_prov_id),
    ('L754R4', 'Полуботинки', 'шт.', 1700, 2, 7, 'Полуботинки kari женские WB2020SS-26, размер 38, цвет: черный', NULL, kari_man_id, women_cat_id, kari_prov_id),
    ('M542T5', 'Кроссовки', 'шт.', 2800, 18, 3, 'Кроссовки мужские TOFA', NULL, rieker_man_id, men_cat_id, obuv_prov_id),
    ('D268G5', 'Туфли', 'шт.', 4399, 3, 12, 'Туфли Rieker женские демисезонные, размер 36, цвет коричневый', NULL, rieker_man_id, women_cat_id, obuv_prov_id),
    ('T324F5', 'Сапоги', 'шт.', 4699, 2, 5, 'Сапоги замша Цвет: синий', NULL, crosby_man_id, women_cat_id, kari_prov_id),
    ('K358H6', 'Тапочки', 'шт.', 599, 20, 2, 'Тапочки мужские син р.41', NULL, rieker_man_id, men_cat_id, kari_prov_id),
    ('H535R5', 'Ботинки', 'шт.', 2300, 2, 7, 'Женские Ботинки демисезонные', NULL, rieker_man_id, women_cat_id, obuv_prov_id);
END $$;

-- 10. Заполнение таблицы orders (заказы) и orderProduct (товары в заказах)
DO $$
DECLARE 
    completed_status_id INT;
    new_status_id INT;
    stepanov_user_id INT;
    nikiforova_user_id INT;
    sazonov_user_id INT;
    odintsov_user_id INT;
    
    order_id INT;
BEGIN
    -- Получаем ID статусов
    SELECT id INTO completed_status_id FROM status WHERE status = 'Завершен';
    SELECT id INTO new_status_id FROM status WHERE status = 'Новый';
    
    -- Получаем ID пользователей
    SELECT id INTO stepanov_user_id FROM users WHERE lastName = 'Степанов' AND firstName = 'Михаил';
    SELECT id INTO nikiforova_user_id FROM users WHERE lastName = 'Никифорова' AND firstName = 'Весения';
    SELECT id INTO sazonov_user_id FROM users WHERE lastName = 'Сазонов' AND firstName = 'Руслан';
    SELECT id INTO odintsov_user_id FROM users WHERE lastName = 'Одинцов' AND firstName = 'Серафим';
    
    -- Заказ 1
    INSERT INTO orders (dateOrder, dateDelivery, code, pickUpPointID, userID, statusID) VALUES
    ('2025-02-27', '2025-04-20', 901, 1, stepanov_user_id, completed_status_id)
    RETURNING id INTO order_id;
    
    INSERT INTO orderProduct (orderID, productArticle, count) VALUES
    (order_id, 'А112Т4', 2),
    (order_id, 'F635R4', 2);
    
    -- Заказ 2
    INSERT INTO orders (dateOrder, dateDelivery, code, pickUpPointID, userID, statusID) VALUES
    ('2022-09-28', '2025-04-21', 902, 11, nikiforova_user_id, completed_status_id)
    RETURNING id INTO order_id;
    
    INSERT INTO orderProduct (orderID, productArticle, count) VALUES
    (order_id, 'H782T5', 1),
    (order_id, 'G783F5', 1);
    
    -- Заказ 3
    INSERT INTO orders (dateOrder, dateDelivery, code, pickUpPointID, userID, statusID) VALUES
    ('2025-03-21', '2025-04-22', 903, 2, sazonov_user_id, completed_status_id)
    RETURNING id INTO order_id;
    
    INSERT INTO orderProduct (orderID, productArticle, count) VALUES
    (order_id, 'J384T6', 10),
    (order_id, 'D572U8', 10);
    
    -- Заказ 4
    INSERT INTO orders (dateOrder, dateDelivery, code, pickUpPointID, userID, statusID) VALUES
    ('2025-02-20', '2025-04-23', 904, 11, odintsov_user_id, completed_status_id)
    RETURNING id INTO order_id;
    
    INSERT INTO orderProduct (orderID, productArticle, count) VALUES
    (order_id, 'F572H7', 5),
    (order_id, 'D329H3', 4);
    
    -- Заказ 5
    INSERT INTO orders (dateOrder, dateDelivery, code, pickUpPointID, userID, statusID) VALUES
    ('2025-03-17', '2025-04-24', 905, 2, stepanov_user_id, completed_status_id)
    RETURNING id INTO order_id;
    
    INSERT INTO orderProduct (orderID, productArticle, count) VALUES
    (order_id, 'А112Т4', 2),
    (order_id, 'F635R4', 2);
    
    -- Заказ 6
    INSERT INTO orders (dateOrder, dateDelivery, code, pickUpPointID, userID, statusID) VALUES
    ('2025-03-01', '2025-04-25', 906, 15, nikiforova_user_id, completed_status_id)
    RETURNING id INTO order_id;
    
    INSERT INTO orderProduct (orderID, productArticle, count) VALUES
    (order_id, 'H782T5', 1),
    (order_id, 'G783F5', 1);
    
    -- Заказ 7 (30.02.2025 - некорректная дата, заменяем на 28.02.2025)
    INSERT INTO orders (dateOrder, dateDelivery, code, pickUpPointID, userID, statusID) VALUES
    ('2025-02-28', '2025-04-26', 907, 3, sazonov_user_id, completed_status_id)
    RETURNING id INTO order_id;
    
    INSERT INTO orderProduct (orderID, productArticle, count) VALUES
    (order_id, 'J384T6', 10),
    (order_id, 'D572U8', 10);
    
    -- Заказ 8
    INSERT INTO orders (dateOrder, dateDelivery, code, pickUpPointID, userID, statusID) VALUES
    ('2025-03-31', '2025-04-27', 908, 19, odintsov_user_id, new_status_id)
    RETURNING id INTO order_id;
    
    INSERT INTO orderProduct (orderID, productArticle, count) VALUES
    (order_id, 'F572H7', 5),
    (order_id, 'D329H3', 4);
    
    -- Заказ 9
    INSERT INTO orders (dateOrder, dateDelivery, code, pickUpPointID, userID, statusID) VALUES
    ('2025-04-02', '2025-04-28', 909, 5, stepanov_user_id, new_status_id)
    RETURNING id INTO order_id;
    
    INSERT INTO orderProduct (orderID, productArticle, count) VALUES
    (order_id, 'B320R5', 5),
    (order_id, 'G432E4', 1);
    
    -- Заказ 10
    INSERT INTO orders (dateOrder, dateDelivery, code, pickUpPointID, userID, statusID) VALUES
    ('2025-04-03', '2025-04-29', 910, 19, stepanov_user_id, new_status_id)
    RETURNING id INTO order_id;
    
    INSERT INTO orderProduct (orderID, productArticle, count) VALUES
    (order_id, 'S213E3', 5),
    (order_id, 'E482R4', 5);
END $$;

-- 11. Проверка данных
SELECT 'pickUpPoint' as table_name, COUNT(*) as row_count FROM pickUpPoint
UNION ALL
SELECT 'roles', COUNT(*) FROM roles
UNION ALL
SELECT 'users', COUNT(*) FROM users
UNION ALL
SELECT 'status', COUNT(*) FROM status
UNION ALL
SELECT 'manufacturer', COUNT(*) FROM manufacturer
UNION ALL
SELECT 'category', COUNT(*) FROM category
UNION ALL
SELECT 'provider', COUNT(*) FROM provider
UNION ALL
SELECT 'product', COUNT(*) FROM product
UNION ALL
SELECT 'orders', COUNT(*) FROM orders
UNION ALL
SELECT 'orderProduct', COUNT(*) FROM orderProduct
ORDER BY table_name;
*/