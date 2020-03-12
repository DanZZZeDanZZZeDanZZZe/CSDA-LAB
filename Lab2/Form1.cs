using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Lab2
{
    public partial class Form1 : Form
    {
        bool flagConnectionButton = true;
        bool contactTheDB(bool flag)
        {
            string connectionString =  ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            bool chekintConnection;
            try
            {

                SqlConnection con = new SqlConnection(connectionString);
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
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chekintConnection = false;
            }
            return chekintConnection;
        }
        public Form1()
        {
            InitializeComponent();
           
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            //сделать кнопку недоступной в момент загрузки базы
            if (flagConnectionButton)
            {
                connectButton.Text = "Отключить";
            } else
            {
                connectButton.Text = "Подключить";
            }

            contactTheDB(flagConnectionButton);
            flagConnectionButton = !flagConnectionButton;
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            Form2 DialogF = new Form2();
            DialogF.ShowDialog(); 
        }
    }
    
}
