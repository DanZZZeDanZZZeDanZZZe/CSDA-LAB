using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class SettingsForm : Form
    {
     
        public SettingsForm(mainForm f)
        {
            InitializeComponent();
            string[] DBNameArr = f.DBName.Split('=');
            dBNameTextBox.Text = DBNameArr[1];
            string[] ServerNameArr = f.ServerName.Split('=');
            serverNameTextBox.Text = ServerNameArr[1];
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = (SettingsForm)Application.OpenForms["SettingsForm"];
            settingsForm.Close();
        }

        private void aBNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
