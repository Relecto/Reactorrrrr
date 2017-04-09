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
    public partial class createOrderForm : Form
    {

        public int price = 0;

        public createOrderForm()
        {
            InitializeComponent();
        }

        private void createOrderForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("idColumn", "ID");
            dataGridView1.Columns.Add("productColumn", "Название");
            dataGridView1.Columns.Add("commentColumn", "Примечание");
            dataGridView1.Columns.Add("quanityColumn", "Кол-во");
            dataGridView1.Columns.Add("priceColumn", "Цена");
        }


        private void addProductBtn_Click(object sender, EventArgs e)
        {
            using (var pp = new productPicker())
            {
                var result = pp.ShowDialog();
                if (result == DialogResult.OK) {
                    addProducts(pp.prod);
                }
            }
        }

        public void addProducts(ProductInfo p) 
        {
                string[] row;
                row = new string[5];
                row[0] = p.id.ToString();
                row[1] = p.name;
                row[2] = p.comment;
                row[3] = "1";
                row[4] = p.price.ToString();
            dataGridView1.Rows.Add(row);
            update();
        }

        public void update() {
            price = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                var s = row.Cells;
                if (s[4].Value == null) {
                    break;
                }
                price = price + (Int32.Parse(s[4].Value.ToString()) * Int32.Parse(s[3].Value.ToString()));
            }
            priceLabel.Text = price.ToString();
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            string prods = "";
            string quans = "";
            string date = dateTimePicker1.Text;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var s = row.Cells;
                if (s[3].Value == null)
                {
                    break;
                }
                prods = prods + s[0].Value.ToString() + ",";
                quans = quans + s[3].Value.ToString() + ",";
            }

            DBManager.pushOrder(textBox1.Text, phoneTextBox.Text, emailTextBox.Text, prods, quans, price, date, "");
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            update();
        }

        
    }
}
