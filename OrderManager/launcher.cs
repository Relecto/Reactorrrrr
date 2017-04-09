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
            if (checkedListBox1.GetItemText(checkedListBox1.SelectedItem).Equals("Экономисты"))
            {
                mf = new mainForm();
                mf.Show();
            }
            if (checkedListBox1.GetItemText(checkedListBox1.SelectedItem).Equals("Химики"))
            {
                mf = new mainForm();
                mf.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
