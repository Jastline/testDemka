using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDemka.Data
{
    public class Order
    {
        public int id { get; set; }
        public DateTime dateOrder { get; set; }
        public DateTime dateDelivery { get; set; }
        public int code { get; set; }
        public int pickUpPointID { get; set; }
        public int userID { get; set; }
        public int statusID { get; set; }

        // Навигационные свойства
        public string pickupAddress { get; set; }
        public string statusName { get; set; }
        public string clientFullName { get; set; }

        // Коллекция товаров в заказе
        public List<OrderItem> items { get; set; } = new List<OrderItem>();

        // Вычисляемые свойства
        public decimal totalAmount
        {
            get
            {
                decimal total = 0;
                foreach (var item in items)
                {
                    total += item.totalPrice;
                }
                return total;
            }
        }

        public bool isCompleted => statusName == "Close";
        public bool isNew => statusName == "New";

        public static Order FromDataRow(DataRow row)
        {
            return new Order
            {
                id = Convert.ToInt32(row["id"]),
                dateOrder = Convert.ToDateTime(row["dateOrder"]),
                dateDelivery = Convert.ToDateTime(row["dateDelivery"]),
                pickUpPointID = Convert.ToInt32(row["pickUpPointID"]),
                userID = Convert.ToInt32(row["userID"]),
                statusID = Convert.ToInt32(row["statusID"]),
                code = Convert.ToInt32(row["code"]),
                pickupAddress = row.Table.Columns.Contains("pickup_address")
                    ? row["pickup_address"]?.ToString()
                    : null,
                statusName = row.Table.Columns.Contains("status_name")
                    ? row["status_name"]?.ToString()
                    : null,
                clientFullName = row.Table.Columns.Contains("client_full_name")
                    ? row["client_full_name"]?.ToString()
                    : null
            };
        }
    }

    // Вложенный класс для товара в заказе
    public class OrderItem
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public string productArticle { get; set; }
        public int count { get; set; }

        // Навигационные свойства (будут заполняться JOIN)
        public string productName { get; set; }
        public decimal productCost { get; set; }
        public int productDiscount { get; set; }

        // Вычисляемые свойства
        public decimal priceWithDiscount => productCost * (100 - productDiscount) / 100;
        public decimal totalPrice => priceWithDiscount * count;

        public static OrderItem FromDataRow(DataRow row)
        {
            return new OrderItem
            {
                id = Convert.ToInt32(row["id"]),
                orderID = Convert.ToInt32(row["orderID"]),
                productArticle = row["productArticle"].ToString(),
                count = Convert.ToInt32(row["count"]),
                productName = row.Table.Columns.Contains("product_name")
                    ? row["product_name"]?.ToString()
                    : null,
                productCost = row.Table.Columns.Contains("product_cost")
                    ? Convert.ToDecimal(row["product_cost"])
                    : 0,
                productDiscount = row.Table.Columns.Contains("product_discount")
                    ? Convert.ToInt32(row["product_discount"])
                    : 0
            };
        }
    }
}