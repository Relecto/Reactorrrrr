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
    public partial class launcher : Form
    {
        public mainForm mf;
        public chemistryForm lf;

        public launcher()
        {
            InitializeComponent();
        }

        private void logicBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Экономисты") {
                mf = new mainForm();
                mf.Show();
            }
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Химики")
            {
                lf = new chemistryForm();
                lf.Show();
            }
        }
    }
}
