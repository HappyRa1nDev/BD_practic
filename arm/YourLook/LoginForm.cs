using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourLook
{
    public partial class LoginForm : Form
    {
        public string _login;
        public string _password;
        public bool isOk = false;
        public LoginForm()
        {
            InitializeComponent();

        }

        public string Login
        {
            get { return txtLogin.Text; }
            
        }

        public string Password
        {
            get { return txtPassword.Text; }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _login = Login;
            _password = Password;
            isOk = true;
            Close();
        
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            var regF = new RegForm();
            regF.ShowDialog();
            //Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
