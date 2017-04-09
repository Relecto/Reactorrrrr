using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManager
{
    public partial class mainForm : Form
    {

        public createOrderForm cof;

        public mainForm()
        {
            InitializeComponent();
            createOrderBtn.Click += CreateOrderBtn_Click;
            pickDataBaseBtn.Click += pickDataBaseBtn_Click;

            //update();

            string[] abdya = new string[4];
            abdya[0] = "Повозка";
            abdya[1] = "Abdya Bdya Inc.";
            abdya[2] = "18.12.2016 22:34";
            abdya[3] = "2 0000";
            ListViewItem item = new ListViewItem(abdya);
            orderList.Items.Add(item);
        }

        private void update() {
            orderList.Items.Clear();
            List<OrderInfo> orders = DBManager.getAllOrders();
            foreach (OrderInfo o in orders)
            {
                string[] s = new string[4];
                s[0] = "multiple";
                s[1] = o.client_name;
                s[2] = o.date;
                s[3] = o.sum.ToString();
                ListViewItem item = new ListViewItem(s);
                orderList.Items.Add(item);
            }
        }

        private void CreateOrderBtn_Click(object sender, EventArgs e)
        {
           cof = new createOrderForm();
            cof.Show(this);
        }

        private void pickDataBaseBtn_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            String path = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "DB files (*.db)|*.db|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName; 
                DBManager.startDB(path);
            }   else
            {
                MessageBox.Show("Выбран неверный файл");
            }
            
            
        }

        private void Main_form_Load(object sender, EventArgs e)
        {

        }

        public void setStatusText(string text)
        {
            toolStripStatusLabel1.Text = text;
            statusStrip1.Refresh();
        }

        private void createDataBase_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файл заказов (*.json)|*.json";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DBManager.startDB(Path.GetFullPath(saveFileDialog.FileName));
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
