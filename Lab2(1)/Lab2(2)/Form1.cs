﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab2_2_
{
    public partial class fmMain : Form
    {
        private string serverName;
        private string baseName;
        private string userName;
        private string password;
        private string stringConnection;
        private bool flag = true;

       /* public fmMain()
        {
            InitializeComponent();
        }

        public void GetConnectionWithDataBase(string connect)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connect;
            try
            {
                connection.Open();
                lbInfo.Items.Add("Соединение открыто");
            }
            catch (SqlException ex)
            {
                lbInfo.Items.Add("Ошибка соединения");
                MessageBox.Show(ex.Message);
                foreach (SqlError err in ex.Errors)
                {
                    lbInfo.Items.Add($"Сообщение: {err.Message}");
                    lbInfo.Items.Add($"Код ошибки: {err.Number}");
                }
            }
        }

        public void DeleteConnectionWithDataBase(string connect)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connect;
            connection.Close();
            lbInfo.Items.Add("Подключение закрыто");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            fmHelp fm = new fmHelp();
            if (fm.ShowDialog(this) == DialogResult.OK)
            {
                serverName = fm.serverName;
                baseName = fm.baseName;
                userName = fm.userName;
                password = fm.password;
                if (password != null || userName !=null)
                {
                    stringConnection = $@"Data Source =.\{serverName}; Initial Catalog = {baseName}; user ID = {userName}; Password = {password}";
                }
                else
                {
                    stringConnection= $@"Data Source =.\{serverName}; Initial Catalog = {baseName}; Integrated Security = True";
                }
                btConnection.Enabled = true;
            }
        }
       // private bool flag = true;
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

        bool contactTheDB(bool flag, string connectionString)
        {
            bool res;
            /*= @"Data Source =.\SQLEXPRESS; Initial Catalog = 744_Car_service_Dasha_on_wheels; Integrated Security = True";*/
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
            res = contactTheDB(flag, stringConnection);

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
        /*   private void btConnection_Click(object sender, EventArgs e)
           {
               if (flag)
               {
                   GetConnectionWithDataBase(stringConnection);
                   btConnection.Text = "Отключить";
               }
               else
               {
                   DeleteConnectionWithDataBase(stringConnection);
                   btConnection.Text = "Подключить";
               }
               flag = !flag;
           }*/
    }
}
