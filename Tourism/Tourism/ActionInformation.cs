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
    public partial class ActionInformation : Form
    {
        Dictionary<int, string> ways = new Dictionary<int, string>()
        {
            {0, "Пекин" },
            {1, "Доха" },
            {2, "Пафос" },
            {3, "Мюнхен" },
            {4, "Каир" },
            {5, "Берлин" },
            {6, "Хургада" },
            {7, "Айя-Напа" },
            {8, "Шанхай" },
            {9, "Токио" },
            {10, "Барселона" },
            {11, "Киото"} ,
            {12, "Гуанчжоу" }
        };
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["tourismDB"].ConnectionString);
        private string actionname;
        public ActionInformation(string actionname)
        {
            InitializeComponent();
            this.actionname=actionname;
            conn.Open();
        }

        private void ActionInformation_Load(object sender, EventArgs e)
        {
            string category = "", type = "", description = "", isSumary = "";
            
            lb_actiontitle.Text = actionname;
            SqlCommand giveinfo = new SqlCommand($"SELECT action_id, action_category, action_type, action_issummary, action_ways, action_description FROM Actions WHERE action_name = '{actionname}'", conn);
            SqlDataReader readinfo = giveinfo.ExecuteReader();
            readinfo.Read();

            int id = Convert.ToInt32(readinfo.GetValue(0));
            lb_actionidvalue.Text = id.ToString();
            int _category = Convert.ToInt32(readinfo.GetValue(1));
            
            if (_category == 1)
            {
                category = "Silver";
            }
            else if (_category == 2)
            {
                category = "Gold";
            }
            else if (_category == 3)
            {
                category = "Platinum";
            }

            lb_category.Text = category;

            int _type = Convert.ToInt32(readinfo.GetValue(2));

            if (_type == 1)
            {
                type = "Фиксированная";
            }
            else if (_type == 2)
            {
                type = "Процентная";
            }

            lb_type_value.Text = type;

            int _isSumary = Convert.ToInt32(readinfo.GetValue(3));
            if (_isSumary == 1)
            {
                isSumary = "Да";
            }
            else
            {
                isSumary = "Нет";
            }
            lb_summary_value.Text = isSumary;

            string[] waysArray = readinfo.GetValue(4).ToString().Split(',');
            for (int i = 0; i < waysArray.Length - 1; i++)
            {
                lb_wayslist.Items.Add(ways[int.Parse(waysArray[i])]);
            }

            description = readinfo.GetValue(5).ToString();
            tb_action_desc.Text = description;

            readinfo.Close();
        }


    }
}
