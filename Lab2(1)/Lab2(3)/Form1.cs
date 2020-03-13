using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab2_3_
{

       public partial class fmMain : Form
       {
        /*  public fmMain()
          {
              InitializeComponent();
          }

          private void btConnection_Click(object sender, EventArgs e)
          {
              SqlConnection conn = new SqlConnection();
              conn.ConnectionString = ConfigurationManager.ConnectionStrings["Config"].ConnectionString;
              lbInfo.Items.Add("Строка соединения: " + conn.ConnectionString);
              try
              {
                  lbInfo.Items.Add("Соединение открыто");
                  conn.Open();
              }
              catch (SqlException ex)
              {
                  lbInfo.Items.Add("Ошибка соединения");
                  MessageBox.Show(ex.Message);
              }
              finally
              {
                  conn.Close();
                  lbInfo.Items.Add("Соединение закрыто");
              }

          }*/
       private bool flag = true;
       public fmMain()
       {
            InitializeComponent();
       }
       public bool GetConnectionWithDataBase(string connectionString)
       {
            SqlConnection connection = new SqlConnection(connectionString);
            lbInfo.Items.Add("Строка соединения: " + connection.ConnectionString);
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
            string connectionString = ConfigurationManager.ConnectionStrings["Config"].ConnectionString;
            if (flag)
            {
                res = GetConnectionWithDataBase(connectionString);
            }
            else
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
                if (flag)
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
