using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager
{
    static class DBManager
    {
        public static SQLiteConnection DB;

        public static void startDB(String pathToDB)
        {
            try
            {
                DB = new SQLiteConnection("data source=" + pathToDB);
                DB.Open();
                Program.mf.setStatusText("Opened successfully");
            }
            catch (SQLiteException e)
            {
                Program.mf.setStatusText("DB open exception");
                Console.WriteLine(e.ErrorCode);
            }

        }
        public static void execCmd(String sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, DB);
            cmd.ExecuteNonQuery();
        }

        public static void pushProduct(string name, int price, string comment)
        {
            string sql = "INSERT INTO products (name, price, comment) values(" + name + "," + price + "," + comment + ")";
        }

        static public void pushOrder(string client_name, string client_phone, string client_email, string product_id, string product_quanity, int sum, string date, string comment)
        {
            string sql = "INSERT into orders (client_name, client_phone, client_email, product_id, product_quanity, sum, date, comment) values('" + client_name + "', '" + client_phone + "', '" + client_email + "', '" + product_id + "', " + product_quanity + ", " + sum + ", '" + date + "', '" + comment + "')";
            execCmd(sql);
        }

        static public ProductInfo getProductById(int id)
        {
            string sql = "SELECT * FROM products WHERE id = " + id;
            SQLiteCommand cmd = new SQLiteCommand(sql, DB);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                ProductInfo product = new ProductInfo((int)reader["id"], reader["name"].ToString(), (int)reader["price"], reader["comment"].ToString());
                return product;
            }
            else
            {
                return null;
            }
        }
        static public List<ProductInfo> getAllProducts()
        {
            string sql = "select * from products";
            SQLiteCommand cmd = new SQLiteCommand(sql, DB);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                List<ProductInfo> products = new List<ProductInfo>();
                while (reader.Read())
                {
                    ProductInfo product = new ProductInfo((int)reader["id"], reader["name"].ToString(), (int)reader["price"], reader["comment"].ToString());
                    products.Add(product);
                }
                return products;
            }
            else
            {
                return null;
            }
        }

        static public OrderInfo getLastOrder()
        {
            string sql = "SELECT * FROM orders WHERE id = (SELECT MAX(id) FROM orders);";
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
}

