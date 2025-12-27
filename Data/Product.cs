using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing; // Добавь using для Color
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDemka.Data
{
    public class Product
    {
        public string article { get; set; }
        public string name { get; set; }
        public string unitOfMeasurement { get; set; }
        public decimal cost { get; set; }
        public int discount { get; set; }
        public int inStock { get; set; }
        public string description { get; set; }
        public string photoPath { get; set; }

        // Внешние ключи (ID)
        public int manufacturerID { get; set; }
        public int categoryID { get; set; }
        public int providerID { get; set; }

        // Навигационные свойства (будут заполняться JOIN)
        public string manufacturerName { get; set; }
        public string categoryName { get; set; }
        public string providerName { get; set; }

        // Вычисляемые свойства
        public decimal priceWithDiscount => cost * (100 - discount) / 100;
        public bool hasHighDiscount => discount > 15;
        public bool isInStock => inStock > 0;

        // Цвет для отображения
        public Color backgroundColor => hasHighDiscount
            ? Color.FromArgb(0x2E, 0x8B, 0x57) // #2E8B57 для скидки >15%
            : Color.White;

        public static Product FromDataRow(DataRow row)
        {
            return new Product
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
                providerID = Convert.ToInt32(row["providerID"]),
                manufacturerName = row.Table.Columns.Contains("manufacturerName")
                    ? row["manufacturerName"]?.ToString()
                    : null,
                categoryName = row.Table.Columns.Contains("categoryName")
                    ? row["categoryName"]?.ToString()
                    : null,
                providerName = row.Table.Columns.Contains("providerName")
                    ? row["providerName"]?.ToString()
                    : null
            };
        }
    }
}