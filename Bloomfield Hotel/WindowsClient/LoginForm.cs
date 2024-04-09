using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace WindowsClient
{
    public partial class LoginForm : Form
    {
        private IModel Model;
        public static string userName = null;
        public static bool isLockClicked = false;
        public LoginForm(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;           
        }

        private void FormLoaded(object sender, EventArgs e)
        {            
            txtPassword.PasswordChar = '*';
            if (isLockClicked)
            {
                txtUserName.Text = userName;
                lblLockClicked.Text = "Your account is locked, please Login again.";
                txtUserName.Enabled = false;
                txtPassword.Select();
            }
        }

        private void LoginBtn(object sender, EventArgs e)
        {
            bool validUser;
            if (isLockClicked)            
                validUser = Model.loginAfterLock(txtUserName.Text, txtPassword.Text);                
            else
                validUser = Model.login(txtUserName.Text, txtPassword.Text);

            if (validUser)
                Close();
            else
            {
                MessageBox.Show("Invalid name or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (isLockClicked)
                {
                    txtPassword.Clear();
                    txtPassword.Select();
                }
                else
                {
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Select();
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
