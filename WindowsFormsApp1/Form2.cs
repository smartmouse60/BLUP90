using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox2.Text = ConfigurationManager.AppSettings["database"].ToString();
            textBox1.Text = ConfigurationManager.AppSettings["user"].ToString();
            textBox3.Text = ConfigurationManager.AppSettings["password"].ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private static void UpdateSetting(string key, string value)
        {
            Properties.Settings.Default["connectionString"] = "111";
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            configuration.AppSettings.Settings.Remove(key);
            configuration.AppSettings.Settings.Add(key, value);
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
 }

        private void button1_Click(object sender, EventArgs e)
        {

             //ConfigurationManager.ConnectionStrings["MysqlConStr"].ConnectionString = "Server=129.0.0.1; DataBase=blup; Uid=root; Pwd=123456";     
            UpdateSetting("db", "1221555");
            //ConnectionStringSettings importToConnectionString = ConfigurationManager.ConnectionStrings["MysqlConStr"];

        
               // importToConnectionString = new ConnectionStringSettings();
                //importToConnectionString.ConnectionString = "fffff";
               // importToConnectionString.Name = "dfer";
               //ConfigurationManager.ConnectionStrings.Add(importToConnectionString);
            

            //Properties.Settings.Default.Reload();

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MysqlConStr"].ConnectionString; //Here exception is generating
                                                                                                              // string connectionString = "server=localhost;port=3306;user id=customer;password=hassaan09;database=customer"; //if i directly provide connectionstring it will work fine  
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("Select * from cowmilk", conn))
                    {
                        conn.Open();
                        MessageBox.Show("Соединение прошло успешно!");
                       // MessageBox.Show(cmd.ToString());
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            



        }
    }
}
