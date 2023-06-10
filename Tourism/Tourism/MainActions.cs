using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Tourism
{
    public partial class MainActions : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["tourismDB"].ConnectionString);
        SqlDataAdapter ad = null;
        DataTable table = null;
        DataTable usertable = new DataTable();

        public MainActions()
        {
            InitializeComponent();
            conn.Open();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // UserSearch
            SqlCommand getAllUsers = new SqlCommand("SELECT id, name, surname FROM Users", conn);
            SqlDataReader readAllUsers = getAllUsers.ExecuteReader();

            while (readAllUsers.Read())
            {
                string match = $"{readAllUsers.GetValue(0)}. {readAllUsers.GetValue(1)} {readAllUsers.GetValue(2)}";
                cb_userlist.Items.Add(match);
            }
            readAllUsers.Close();





            // DATAGRIDVIEW
            ad = new SqlDataAdapter($"SELECT action_name, action_summary, action_additionaldate FROM Actions", conn);
            table = new DataTable();

            table.Clear();

            ad.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "Название акции";
            dataGridView1.Columns[1].HeaderText = "Размер скидки";
            dataGridView1.Columns[2].HeaderText = "Дата добавления";
            

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_action_summary_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActionConstructor ActionConstructor = new ActionConstructor();
            ActionConstructor.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            table.Clear();
            ad.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "Название акции";
            dataGridView1.Columns[1].HeaderText = "Размер скидки";
            dataGridView1.Columns[2].HeaderText = "Дата добавления";
        }

        private void btn_delete_actions_all_Click(object sender, EventArgs e)
        {
            table.Clear();

            SqlCommand cmd = new SqlCommand("DELETE FROM Actions", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Все акции успешно удалены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void MainActions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_updateuserlist_Click(object sender, EventArgs e)
        {
            cb_userlist.Items.Clear();
            SqlCommand getAllUsers = new SqlCommand("SELECT id, name, surname FROM Users", conn);
            SqlDataReader readAllUsers = getAllUsers.ExecuteReader();

            while (readAllUsers.Read())
            {
                string match = $"{readAllUsers.GetValue(0)}. {readAllUsers.GetValue(1)} {readAllUsers.GetValue(2)}";
                cb_userlist.Items.Add(match);
            }
            readAllUsers.Close();
        }

        private void btn_edit_action_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int index = dataGridView1.SelectedRows[0].Index;
           ActionInformation actioninfo = new ActionInformation(dataGridView1[0, index].Value.ToString());
           actioninfo.Show();
        }


        private void cb_userlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // сделать анализ акций по ID чела
            usertable.Clear();
            string name = cb_userlist.SelectedItem.ToString();
            string[] _id = name.Split('.');
            int id = int.Parse(_id[0]);
            SqlCommand getstatus = new SqlCommand($"SELECT type FROM Users WHERE id = '{id}'", conn);
            SqlDataReader readstatus = getstatus.ExecuteReader();
            readstatus.Read();
            int userstatus = int.Parse(readstatus.GetValue(0).ToString());
            readstatus.Close();

            SqlDataAdapter ad = new SqlDataAdapter($"SELECT action_name, action_summary, action_ways, action_description FROM Actions WHERE action_category <= '{userstatus}'", conn);
            ad.Fill(usertable);
            dataGridView2.DataSource = usertable;
            dataGridView2.Columns[0].HeaderText = "Название акции";
            dataGridView2.Columns[1].HeaderText = "Сумма скидки";
            dataGridView2.Columns[2].HeaderText = "Пути акции";
            dataGridView2.Columns[3].HeaderText = "Описание акции";

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
