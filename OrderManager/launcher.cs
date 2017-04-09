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
        public Main_form mf;
        public jokeLogisticsForm lf;

        public launcher()
        {
            InitializeComponent();
        }

        private void economicBtn_Click(object sender, EventArgs e)
        {
            mf = new Main_form();
            mf.Show();
        }

        private void logicBtn_Click(object sender, EventArgs e)
        {
            lf = new jokeLogisticsForm();
            lf.Show();
        }
    }
}
