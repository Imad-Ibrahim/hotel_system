using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLayer;

namespace WindowsClient
{
    public partial class AdminForm : Form
    {
        private formContainer fc;
        private IModel Model;
        public AdminForm(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            LoginForm.isLockClicked = false;
            PopulateUserTable();
            LockIfNoActivity();
        }
        async void LockIfNoActivity()
        {
            while (true)
            {
                await Task.Delay(new TimeSpan(0, 0, 0, 5)).ContinueWith(o =>
                {
                    if (TimeToLock.GetIdleTime() >= 5000) //900000
                    {
                        lockAccout();
                    }
                });
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.fc.NewLogin();
            this.Close();
        }
        private void btnLock_Click(object sender, EventArgs e)
        {
            lockAccout();
        }
        private void lockAccout()
        {
            LoginForm.userName = Model.CurrentUser.username;
            LoginForm.isLockClicked = true;
            this.Hide();
            this.fc.NewLogin();
            this.Close();
        }
        private void PopulateUserTable()
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi1;
            listViewUsers.Items.Clear();
            listViewUsers.BeginUpdate();

            foreach (User user in Model.UserList)
            {
                lvi = new ListViewItem();
                lvi.Text = user.userID.ToString();

                lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = user.username;
                lvi.SubItems.Add(lvsi1);

                lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = user.password;
                lvi.SubItems.Add(lvsi1);

                lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = user.firstName;
                lvi.SubItems.Add(lvsi1);

                lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = user.lastName;
                lvi.SubItems.Add(lvsi1);

                lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = user.email;
                lvi.SubItems.Add(lvsi1);

                lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = user.phone;
                lvi.SubItems.Add(lvsi1);

                lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = user.dob.ToShortDateString();
                lvi.SubItems.Add(lvsi1);

                lvsi1 = new ListViewItem.ListViewSubItem();
                string userType = user.GetType().ToString();
                lvsi1.Text = userType.Substring(userType.LastIndexOf('.') + 1);
                lvi.SubItems.Add(lvsi1);

                listViewUsers.Items.Add(lvi);
            }
            listViewUsers.EndUpdate();
            listViewUsers.Enabled = true;
            listViewUsers.FullRowSelect = true;
        }

        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem u in listViewUsers.SelectedItems)
            {
                textBoxUserID.Text = u.SubItems[0].Text;
                textBoxUsername.Text = u.SubItems[1].Text;
                textBoxPassword.Text = u.SubItems[2].Text;
                textBoxFirstName.Text = u.SubItems[3].Text;
                textBoxLastName.Text = u.SubItems[4].Text;
                textBoxEmail.Text = u.SubItems[5].Text;
                textBoxPhone.Text = u.SubItems[6].Text;
                dateTimePickerDateOfBirth.Value = Convert.ToDateTime(u.SubItems[7].Text);
                comboBoxUserType.Text = u.SubItems[8].Text;
            }
        }

        private void ClearFields()
        {
            textBoxUserID.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
            dateTimePickerDateOfBirth.Value = DateTime.Today;
            comboBoxUserType.Text = "";
        }

        private void EnableFields()
        {
            textBoxPassword.ReadOnly = false;
            textBoxFirstName.ReadOnly = false;
            textBoxLastName.ReadOnly = false;
            textBoxEmail.ReadOnly = false;
            textBoxPhone.ReadOnly = false;
            dateTimePickerDateOfBirth.Enabled = true;
            comboBoxUserType.Enabled = true;
        }

        private void DisableFields()
        {
            textBoxUserID.ReadOnly = true;
            textBoxUsername.ReadOnly = true;
            textBoxPassword.ReadOnly = true;
            textBoxFirstName.ReadOnly = true;
            textBoxLastName.ReadOnly = true;
            textBoxEmail.ReadOnly = true;
            textBoxPhone.ReadOnly = true;
            dateTimePickerDateOfBirth.Enabled = false;
            comboBoxUserType.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (buttonAdd.Text == "Add User")
            {
                buttonAdd.Text = "Commit";
                ClearFields();
                EnableFields();
                buttonEdit.Enabled = false;
                buttonDelete.Enabled = false;
            }
            else
            {
                buttonAdd.Text = "Add User";
                Model.addNewUser(textBoxPassword.Text, textBoxFirstName.Text.ToLower(), textBoxLastName.Text.ToLower(), textBoxEmail.Text.ToLower(), textBoxPhone.Text, dateTimePickerDateOfBirth.Value, comboBoxUserType.Text);
                ClearFields();
                DisableFields();
                PopulateUserTable();
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            DisableFields();
            buttonAdd.Text = "Add User";
            buttonEdit.Text = "Edit User";
            buttonDelete.Text = "Delete User";
            buttonAdd.Enabled = true;
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Text == "Edit User")
            {
                EnableFields();
                buttonEdit.Text = "Commit";
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = false;
            }
            else
            {
                int index = 0;
                if (textBoxUserID.Text == "")
                {
                    MessageBox.Show("Select a user to edit.");
                }
                else
                {
                    foreach (User u in Model.UserList)
                    {
                        IUser uEdit;
                        if (u.userID.ToString() == textBoxUserID.Text)
                        {
                            index = Model.UserList.IndexOf(u);
                            uEdit = UserFactory.GetUser(u.userID, textBoxUsername.Text, textBoxPassword.Text, textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, textBoxPhone.Text, dateTimePickerDateOfBirth.Value, comboBoxUserType.Text);
                            Model.editUser(uEdit);
                            buttonEdit.Text = "Edit User";
                            buttonAdd.Enabled = true;
                            buttonDelete.Enabled = true;
                            DisableFields();
                            PopulateUserTable();
                            break;
                        }
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxUserID.Text == "")
            {
                MessageBox.Show("Select a user to edit.");
            }
            else
            {
                if (MessageBox.Show("Delete " + textBoxFirstName.Text + " " + textBoxLastName.Text + " ? ", "Are you sure?", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
                else
                {
                    foreach(User u in Model.UserList)
                    {
                        if(u.username == textBoxUsername.Text)
                        {
                            Model.deleteUser(u);
                            PopulateUserTable();
                            break;
                        }
                    }
                }
            }
        }
    }
}
