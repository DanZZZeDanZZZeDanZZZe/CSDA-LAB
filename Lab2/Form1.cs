using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;

namespace Lab2
{
    public partial class mainForm : Form
    {
        bool flagConnectionButton = true;
        string serverName = ConfigurationManager.ConnectionStrings["ServerName"].ConnectionString;
        string dBName = ConfigurationManager.ConnectionStrings["DBName"].ConnectionString;
        string settings = ConfigurationManager.ConnectionStrings["Settings"].ConnectionString;
 
        public string ServerName { get => serverName; set => serverName = value; }
        public string DBName { get => dBName; set => dBName = value; }
        public string Settings { get => settings; set => settings = value; }

        bool contactTheDB(bool flag)
        {
            string connectionString = ServerName + DBName + Settings;
            bool chekintConnection;

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                if (flag)
                {
                    con.Open();
                    MessageBox.Show("База данных подключена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    con.Close();
                    MessageBox.Show("База данных отключена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                chekintConnection = true;
                
            }
            catch (SqlException ex)
            {
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
                chekintConnection = false;
            }

            return chekintConnection;
        }
        public mainForm()
        {
            InitializeComponent();
           
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            setEnableButtons();
            //сделать кнопку недоступной в момент загрузки базы
            if (flagConnectionButton)
            {
                connectButton.Text = "Отключить";
            } else
            {
                connectButton.Text = "Подключить";
            }

            contactTheDB(flagConnectionButton);
            setEnableButtons();
            flagConnectionButton = !flagConnectionButton;
        }

        private void setEnableButtons()
        {
            connectButton.Enabled = !connectButton.Enabled;
            settingButton.Enabled = !settingButton.Enabled;
        }
        private void settingButton_Click(object sender, EventArgs e)
        {
            SettingsForm DialogF = new SettingsForm(this);
            DialogF.ShowDialog(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
