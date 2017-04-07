using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager
{
    public class OrderInfo
    {
        public int    id;
        public string client_name;
        public string client_phone;
        public string client_email;
        public string product_id;
        public string product_quanity;
        public int    sum;
        public string date;
        public string comment;

        public OrderInfo() { }

        public OrderInfo(int id, string client_name, string client_phone, string client_email, string product_id, string product_quanity, int sum, string date, string comment)
        {
            this.id = id;
            this.client_name = client_name;
            this.client_phone = client_phone;
            this.client_email = client_email;
            this.product_id = product_id;
            this.product_quanity = product_quanity;
            this.sum = sum;
            this.date = date;
            this.comment = comment;
        }

        public OrderInfo(Order order)
        {
            this.id = order.id;
            this.client_name = order.client_name;
            this.client_phone = order.client_phone;
            this.client_email = order.client_email;
            this.product_id = order.product_id;
            this.product_quanity = order.product_quanity;
            this.sum = order.sum;
            this.date = order.date;
            this.comment = order.comment;
        }

        public ArrayList toArrayList()
        {
            ArrayList list = new ArrayList();
            list.Add(id);
            list.Add(client_name);
            list.Add(client_phone);
            list.Add(client_email);
            list.Add(product_id);
            list.Add(product_quanity);
            list.Add(sum);
            list.Add(date);
            list.Add(comment);
            return list;
        }
    }
}
