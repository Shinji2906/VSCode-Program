using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QlyCafe.BLL;

namespace QLyCafe.GUI
{
    public partial class Login : Form
    {
        private UserServices userServices;
        public Login()
        {
            InitializeComponent();
            userServices = new UserServices();
        }
        
        //login
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();
            if (userServices.islogin(username, password) == true)
            {
                UserSession.Username = username;
                UserSession.isadmin = userServices.isadmin(username);
                this.DialogResult = DialogResult.OK;
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username hoac password khong dung", "Loi");
            }
        }

        //exit
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
