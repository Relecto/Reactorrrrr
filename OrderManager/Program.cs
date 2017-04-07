using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManager
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// INSERT into orders (client_name, client_phone, client_email, product_id, sum, date, comment) values ('Vasiliy', 88005553535, 'vasya@example.kz', '1,2', '200', '2016-12-18 20:17', 'test')
        public static SQLiteConnection DB;
        public static Main_form mf;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            Application.SetCompatibleTextRenderingDefault(false);
            mf = new Main_form();
            Application.Run(mf);
        }
        static void OnProcessExit(object sender, EventArgs e)
        {
        }
    }
}
