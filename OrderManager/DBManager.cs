using LiteDB;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManager
{
    public static class DBManager
    {
        public static SQLiteConnection DB;
        //public static LiteDatabase db;
        private static string currentPath;

        public static void startDB(String path)
        {
            currentPath = path;
            //db = new LiteDatabase(path);
        }

        public static void execCmd(String sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, DB);
            cmd.ExecuteNonQuery();
        }

        public static void pushProduct(string name, int price, string comment)
        {
            //string sql = "INSERT INTO products (name, price, comment) values(" + name + "," + price + "," + comment + ")";
            try
            {
                using (var db = new LiteDatabase(currentPath))
                {
                    var productCollection = db.GetCollection<Product>("products");
                    Product product = new Product();
                    product.name = name;
                    product.price = price;
                    product.comment = comment;
                    productCollection.Insert(product);
                    productCollection.EnsureIndex(x => x.name);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Невозможно открыть файл. Возможно, он был выбран неверно");
            }
        }

        static public void pushOrder(string client_name, string client_phone, string client_email, string product_id, string product_quanity, int sum, string date, string comment)
        {

            try
            {
                using (var db = new LiteDatabase(currentPath))
                {
                    var orderCollection = db.GetCollection<Order>("orders");
                    Order order = new Order();

                    order.client_name = client_name;
                    order.client_phone = client_phone;
                    order.client_email = client_email;
                    order.product_id = product_id;
                    order.product_quanity = product_quanity;
                    order.sum = sum;
                    order.date = date;

                    orderCollection.Insert(order);
                    orderCollection.EnsureIndex(x => x.client_name);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Невозможно открыть файл. Возможно, он был выбран неверно");
            }
        }

        static public ProductInfo getProductById(int id)
        {
            try
            {
                using (var db = new LiteDatabase(currentPath))
                {
                    var productList = db.GetCollection<Product>("products");
                    var product = productList.FindById(id);
                    return new ProductInfo(product);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        static public List<ProductInfo> getAllProducts()
        {
            //string sql = "select * from products";

            try
            {
                using (var db = new LiteDatabase(currentPath))
                {
                    var productList = db.GetCollection<Product>("products");
                    var products = productList.FindAll();
                    List<ProductInfo> pr = new List<ProductInfo>();
                    foreach (Product a in products)
                    {
                        pr.Add(new ProductInfo(a));
                    }

                    return pr;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно открыть файл. Возможно, он был выбран неверно");
                return new List<ProductInfo>();
            }
        }

        static public List<OrderInfo> getAllOrders() {
            try
            {
                using (var db = new LiteDatabase(currentPath))
                {
                    var orderList = db.GetCollection<Order>("orders");
                    var orders = orderList.FindAll();
                    List<OrderInfo> or = new List<OrderInfo>();
                    foreach (Order a in orders)
                    {
                        or.Add(new OrderInfo(a));
                    }

                    return or;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно открыть файл. Возможно, он был выбран неверно");
                return new List<OrderInfo>();
            }

            return null;
        }

        static public OrderInfo getOrderById(int id)
        {
            string sql = "SELECT * FROM orders WHERE id = " + id;
            SQLiteCommand cmd = new SQLiteCommand(sql, DB);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                OrderInfo order = new OrderInfo((int)reader["id"], reader["client_name"].ToString(), reader["client_phone"].ToString(), reader["client_email"].ToString(), reader["product_id"].ToString(), reader["product_quanity"].ToString(), (int)reader["sum"], reader["date"].ToString(), reader["comment"].ToString());
                return order;
            }
            else
            {
                return null;
            }
        }
        static public List<OrderInfo> getOrderByDate(string date)
        {
            string sql = "SELECT * FROM orders WHERE date = '" + date + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, DB);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                List<OrderInfo> orders = new List<OrderInfo>();
                while (reader.Read())
                {
                    OrderInfo order = new OrderInfo((int)reader["id"], reader["client_name"].ToString(), reader["client_phone"].ToString(), reader["client_email"].ToString(), reader["product_id"].ToString(), reader["product_quanity"].ToString(), (int)reader["sum"], reader["date"].ToString(), reader["comment"].ToString());
                    orders.Add(order);
                }
                return orders;
            }
            else
            {
                return null;
            }
        }
        static public List<OrderInfo> getOrderByProduct(string product)
        {
            string sql = "SELECT * FROM orders WHERE product = '" + product + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, DB);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                List<OrderInfo> orders = new List<OrderInfo>();
                while (reader.Read())
                {
                    OrderInfo order = new OrderInfo((int)reader["id"], reader["client_name"].ToString(), reader["client_phone"].ToString(), reader["client_email"].ToString(), reader["product_id"].ToString(), reader["product_quanity"].ToString(), (int)reader["sum"], reader["date"].ToString(), reader["comment"].ToString());
                    orders.Add(order);
                }
                return orders;
            }
            else
            {
                return null;
            }
        }
        static public List<OrderInfo> getOrderByClient(string client)
        {
            string sql = "SELECT * FROM orders WHERE client = '" + client + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, DB);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                List<OrderInfo> orders = new List<OrderInfo>();
                while (reader.Read())
                {
                    OrderInfo order = new OrderInfo((int)reader["id"], reader["client_name"].ToString(), reader["client_phone"].ToString(), reader["client_email"].ToString(), reader["product_id"].ToString(), reader["product_quanity"].ToString(), (int)reader["sum"], reader["date"].ToString(), reader["comment"].ToString());
                    orders.Add(order);
                }
                return orders;
            }
            else
            {
                return null;
            }
        }
        static public List<OrderInfo> getOrderBySum(int summ)
        {
            string sql = "SELECT * FROM orders WHERE sum = '" + summ + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, DB);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                List<OrderInfo> orders = new List<OrderInfo>();
                while (reader.Read())
                {
                    OrderInfo order = new OrderInfo((int)reader["id"], reader["client_name"].ToString(), reader["client_phone"].ToString(), reader["client_email"].ToString(), reader["product_id"].ToString(), reader["product_quanity"].ToString(), (int)reader["sum"], reader["date"].ToString(), reader["comment"].ToString());
                    orders.Add(order);
                }
                return orders;
            }
            else
            {
                return null;
            }
        }


    }
    public class Product {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string comment { get; set; }
    }
    public class Order {
        public int id { get; set; }
        public string client_name { get; set; }
        public string client_phone { get; set; }
        public string client_email { get; set; }
        public string product_id { get; set; }
        public string product_quanity { get; set; }
        public int sum { get; set; }
        public string date { get; set; }
        public string comment { get; set; }
    }
}   