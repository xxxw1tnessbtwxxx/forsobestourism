using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism
{
    public partial class AdminLogin : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["tourismDB"].ConnectionString);
        public AdminLogin()
        {
            InitializeComponent();
            conn.Open();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> logins = new List<string>();
            SqlCommand givelogin = new SqlCommand($"SELECT * FROM admins", conn);
            SqlDataReader rd = givelogin.ExecuteReader();

            while (rd.Read())
            {
                logins.Add(rd.GetValue(1).ToString());
            }
            rd.Close();
            
            if (logins.Contains(textBox1.Text))
            {
                SqlCommand givepassword = new SqlCommand($"SELECT password FROM admins WHERE login = '{textBox1.Text}'", conn);
                SqlDataReader readpass = givepassword.ExecuteReader();

                readpass.Read();

                if (readpass.GetValue(0).ToString() == textBox2.Text)
                {
                    MessageBox.Show("Actually logged in!");
                    MainActions mainactions = new MainActions();
                    mainactions.Show();
                    Hide();
                    readpass.Close();
                }
                else
                {
                    MessageBox.Show("You wrote a wrong password!");
                    readpass.Close();
                }  

            }
            else
            {
                MessageBox.Show($"User [ --- {textBox1.Text} ---] doesn't exists in tourismDB!");
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Покдлючение к БД установлено.");
            }
        }
    }
}
