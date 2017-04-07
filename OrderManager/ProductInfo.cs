using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager
{
    public class ProductInfo
    {
        public int id;
        public string name;
        public int price;
        public string comment;

        public ProductInfo(int id, string name, int price, string comment)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.comment = comment;
        }
        public ProductInfo(Product product)
        {
            this.id = product.id;
            this.name = product.name;
            this.price = product.price;
            this.comment = product.comment;
        }
        public ArrayList toArrayList()
        {
            ArrayList list = new ArrayList();
            list.Add(id);
            list.Add(name);
            list.Add(price);
            list.Add(comment);
            return list;
        }
        
    }
}
