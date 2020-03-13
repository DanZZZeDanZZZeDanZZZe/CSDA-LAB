using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_2_
{
    public partial class fmHelp : Form
    {
        public string serverName;
        public string baseName;
        public string userName;
        public string password;
        public fmHelp()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            tbServerName.Text = serverName;
            tbBaseName.Text = baseName;
            tbUserName.Text = userName;
            tbPassword.Text = password;
        }

        private void tbServerName_Validated(object sender, EventArgs e)
        {
            serverName = tbServerName.Text;
        }

        private void tbBaseName_Validated(object sender, EventArgs e)
        {
            baseName = tbBaseName.Text;
        }

        private void tbUserName_Validated(object sender, EventArgs e)
        {
            userName = tbUserName.Text;
        }

        private void tbPassword_Validated(object sender, EventArgs e)
        {
            password = tbPassword.Text;
        }
    }
}
