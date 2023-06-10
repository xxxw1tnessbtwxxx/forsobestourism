using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Tourism
{
    public partial class ActionConstructor : Form
    {


        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["tourismDB"].ConnectionString);

        public ActionConstructor()
        {
            InitializeComponent();
            conn.Open();
        }

        private void btn_create_action_Click(object sender, EventArgs e)
        {
            string indexes = "";
            
            int type = 0, clientcategory = 0;
            bool forDate = false;
            string desc = tb_action_desc.Text;
            double cost = double.Parse(tb_action_size.Text);
            int isSumary = 0;
            string actionname = tb_action_name.Text;

            if (combobox_action_type.SelectedIndex == 0) type = 1; // 1 - fixed, 2 - percent
            else if (combobox_action_type.SelectedIndex == 1) type = 2;

            if (rb_silver.Checked) clientcategory = 1;
            else if (rb_gold.Checked) clientcategory = 2;
            else if (rb_platinum.Checked) clientcategory = 3;

            if (cb_action_date.Checked) forDate = true;
            else { forDate = false; }

            if (cb_action_summary.Checked)
            {
                isSumary = 1;
            }
            if (cb_action_summary.Checked == false)
            {
                isSumary = 0;
            }

            foreach (var value in cb_cities.CheckedIndices)
            {
                indexes += $"{value}, ";
            }

            if (forDate == true)
            {
                SqlCommand com = new SqlCommand($"INSERT INTO Actions VALUES ('{actionname}', '{clientcategory}', '{type}', '{tb_action_size.Text}', '{indexes}', '{desc}', {isSumary}, '{textBox2.Text}', '{textBox2.Text}', '{DateTime.Now}')", conn);
                com.ExecuteNonQuery();
            }

            if (forDate == false)
            {
                SqlCommand com = new SqlCommand($"INSERT INTO Actions VALUES ('{actionname}', '{clientcategory}', '{type}', '{tb_action_size.Text}', '{indexes}', '{desc}', '{isSumary}', NULL, NULL, '{DateTime.Now}')", conn);
                com.ExecuteNonQuery();
            }

            MessageBox.Show("Акция успешно добавлена!");
            Close();

        }

        private void ActionConstructor_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("SELECT cityname FROM City", conn);
            SqlDataReader rd = com.ExecuteReader();
            int i = 0;
            while (rd.Read())
            {
                cb_cities.Items.Insert(i, rd.GetValue(0).ToString());
                i++;
            }
            rd.Close();
        }

        private void cb_action_date_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = cb_action_date.Checked;
            if (flag)
            {
                textBox2.Visible = true;
                textBox3.Visible = true;
            }
            else if (flag == false)
            {
                textBox2.Visible = false;
                textBox3.Visible = false;
            }

        }

        private void rb_platinum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void combobox_action_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ActionConstructor_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("da");
        }
    }
}
