using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManager
{
    public partial class productPicker : Form
    {
        public List<ProductInfo> products1;
        public ProductInfo prod { get; set; }

        public productPicker()
        {
            InitializeComponent();

            //List<ProductInfo> products = DBManager.getAllProducts();
            products1 = DBManager.getAllProducts();
            string[] row = new string[4];
            foreach (ProductInfo i in products1)
            {
                row[0] = i.id.ToString();
                row[1] = i.name;
                row[2] = i.comment;
                row[3] = i.price.ToString();
                listView1.Items.Add(new ListViewItem(row));
            }
        }


        private void addProductBtn_Click(object sender, EventArgs e)
        {
            DBManager.pushProduct(nameTextBox.Text, int.Parse(priceTextBox.Text), commentTextBox.Text);

            products1 = DBManager.getAllProducts();
            string[] row = new string[4];
            listView1.Items.Clear();
            foreach (ProductInfo i in products1)
            {
                row[0] = i.id.ToString();
                row[1] = i.name;
                row[2] = i.comment;
                row[3] = i.price.ToString();
                listView1.Items.Add(new ListViewItem(row));
            }
        }

        private void addSelectedBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            prod = DBManager.getProductById(int.Parse(listView1.SelectedItems[0].SubItems[0].Text));

            //Program.mf.cof.addProducts(prod);
            this.Close();
        }

        private void productPicker_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void editSelectedBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
