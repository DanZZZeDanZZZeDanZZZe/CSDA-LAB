using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab2_1_
{
    public partial class fmMain : Form
    {
        private bool flag = true;
        public fmMain()
        {
            InitializeComponent();
        }
        public bool GetConnectionWithDataBase(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            //connection.ConnectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = 744_Car_service_Dasha_on_wheels; Integrated Security = True";
            try
            {
                connection.Open();
                lbInfo.Items.Add("Соединение открыто");
                return true;
            }
            catch (SqlException ex)
            {
                lbInfo.Items.Add("Ошибка соединения");
                string title;
                switch (ex.Number)
                {
                    case -1:
                        title = "Неверное имя сервера";
                        break;
                    case 4060:
                        title = "Неверное название базы данных";
                        break;
                    case 18456:
                        title = "Неверное имя пользователя или пароль";
                        break;
                    default:
                        title = "Ошибка";
                        break;
                }

                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError err in ex.Errors)
                {
                    lbInfo.Items.Add($"Сообщение: {err.Message}");
                    lbInfo.Items.Add($"Код ошибки: {err.Number}");
                }
                return false;
            }
        }
        public bool DeleteConnectionWithDataBase(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Close();
            lbInfo.Items.Add("Подключение закрыто");
            return true;
        }

        bool contactTheDB(bool flag)
        {
            bool res;
            string connectionString = @"Data Source =.\SQLEXPRESS1; Initial Catalog = 744_Car_service_Dasha_on_wheels; Integrated Security = True";
            if (flag)
            {
                res = GetConnectionWithDataBase(connectionString);
            } else
            {
                res = DeleteConnectionWithDataBase(connectionString);
            }
            return res;
        }

        private void btConnection_Click(object sender, EventArgs e)
        {
            bool res;
            btConnection.Enabled = !btConnection.Enabled;
            res = contactTheDB(flag);
       
            if (res)
            {
                if(flag)
                {
                    btConnection.Text = "Отключить";
                }
                else
                {
                    btConnection.Text = "Подключить";
                }
                flag = !flag;
            }
            btConnection.Enabled = !btConnection.Enabled;
        } 
    }
}
