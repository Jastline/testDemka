using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;

namespace testDemka.Data
{
    public static class DatabaseService
    {
        private static string _DATABASECONNECTION = "Host=localhost;Port=5439;Database='ObuvDB';Username='postgres';Password='1210'";

        public static NpgsqlConnection GetConnection()
        {
            var dataBaseConnection = new NpgsqlConnection(_DATABASECONNECTION);
            try
            {
                dataBaseConnection.Open();
                return dataBaseConnection;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return null;
            }
        }

        public static DataTable ExecuteQuery(string sql, params NpgsqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();

            using (var connection = GetConnection())
            {
                if (connection == null || connection.State != ConnectionState.Open)
                {
                    MessageBox.Show("Ошибка подключения к БД", "Ошибка");
                    return dataTable;
                }

                try
                {
                    using (var cmd = new NpgsqlCommand(sql, connection))
                    {
                        if (parameters != null && parameters.Length > 0)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}\nSQL: {sql}", "Ошибка");
                }
            }

            return dataTable;
        }

        public static User GetUserWithRole(string login, string password)
        {
            string sql = @"
            SELECT u.*, r.role as role_name 
            FROM users u
            JOIN roles r ON u.roleID = r.id
            WHERE u.login = @login AND u.password = @password";

            var result = ExecuteQuery(sql,
                new NpgsqlParameter("@login", login),
                new NpgsqlParameter("@password", password));

            return result.Rows.Count > 0 ? User.FromDataRow(result.Rows[0]) : null;
        }

        public static List<Product> GetAllProducts(string role = "Гость")
        {
            var products = new List<Product>();

            string sql = "SELECT * FROM product";

            // Для гостя и клиента - только товары в наличии
            if (role == "Гость" || role == "Авторизированный клиент")
            {
                sql += " WHERE inStock > 0";
            }

            sql += " ORDER BY name";

            var dt = ExecuteQuery(sql);

            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    var product = new Product
                    {
                        article = row["article"].ToString(),
                        name = row["name"].ToString(),
                        unitOfMeasurement = row["unitOfMeasurement"].ToString(),
                        cost = Convert.ToDecimal(row["cost"]),
                        discount = Convert.ToInt32(row["discount"]),
                        inStock = Convert.ToInt32(row["inStock"]),
                        description = row["description"]?.ToString(),
                        photoPath = row["photoPath"]?.ToString(),
                        manufacturerID = Convert.ToInt32(row["manufacturerID"]),
                        categoryID = Convert.ToInt32(row["categoryID"]),
                        providerID = Convert.ToInt32(row["providerID"])
                    };

                    // Получаем названия из справочников
                    product.manufacturerName = GetManufacturerName(product.manufacturerID);
                    product.categoryName = GetCategoryName(product.categoryID);
                    product.providerName = GetProviderName(product.providerID);

                    products.Add(product);
                }
                catch (Exception ex)
                {
                    // Пропускаем битые записи
                    Console.WriteLine($"Ошибка при обработке товара: {ex.Message}");
                }
            }

            return products;
        }

        // Методы для получения названий (можно сделать один раз и кэшировать)
        private static Dictionary<int, string> _manufacturerCache = null;
        private static Dictionary<int, string> _categoryCache = null;
        private static Dictionary<int, string> _providerCache = null;

        private static string GetManufacturerName(int id)
        {
            if (_manufacturerCache == null)
            {
                _manufacturerCache = new Dictionary<int, string>();
                var dt = ExecuteQuery("SELECT id, manufacturer FROM manufacturer");
                foreach (DataRow row in dt.Rows)
                {
                    _manufacturerCache[Convert.ToInt32(row["id"])] = row["manufacturer"].ToString();
                }
            }

            return _manufacturerCache.ContainsKey(id) ? _manufacturerCache[id] : "Неизвестно";
        }

        private static string GetCategoryName(int id)
        {
            if (_categoryCache == null)
            {
                _categoryCache = new Dictionary<int, string>();
                var dt = ExecuteQuery("SELECT id, category FROM category");
                foreach (DataRow row in dt.Rows)
                {
                    _categoryCache[Convert.ToInt32(row["id"])] = row["category"].ToString();
                }
            }

            return _categoryCache.ContainsKey(id) ? _categoryCache[id] : "Неизвестно";
        }

        private static string GetProviderName(int id)
        {
            if (_providerCache == null)
            {
                _providerCache = new Dictionary<int, string>();
                var dt = ExecuteQuery("SELECT id, provider FROM provider");
                foreach (DataRow row in dt.Rows)
                {
                    _providerCache[Convert.ToInt32(row["id"])] = row["provider"].ToString();
                }
            }

            return _providerCache.ContainsKey(id) ? _providerCache[id] : "Неизвестно";
        }
    }
}