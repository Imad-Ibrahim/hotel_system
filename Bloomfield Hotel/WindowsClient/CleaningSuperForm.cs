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
using BusinessEntities;

namespace WindowsClient
{
    public partial class CleaningSuperForm : Form
    {
        private formContainer fc;
        private IModel Model;
        public CleaningSuperForm(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            LoginForm.isLockClicked = false;
            PopulateCleaners();
            PopulateRoomsToBeCleaned();
            PopulateCleaningAssignments();
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
        private void PopulateCleaners()
        {
            foreach (IUser user in Model.UserList)
            {
                if(Model.getUserType(user).Equals("Cleaner"))
                {
                    comboBoxCleaner1.Items.Add(user.username);
                    comboBoxCleaner2.Items.Add(user.username);
                }
            }
        }
        private void PopulateRoomsToBeCleaned()
        {
            ListViewItem lvi; ListViewItem.ListViewSubItem lvsi1;
            listViewRoomsToClean.Items.Clear();
            listViewRoomsToClean.BeginUpdate();

            foreach (IRoom room in Model.RoomsList)
            {
                if (!room.clean && !room.assigned)
                {
                    lvi = new ListViewItem();
                    lvi.Text = room.roomNumber.ToString();

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = room.floor.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = room.roomType;
                    lvi.SubItems.Add(lvsi1);

                    listViewRoomsToClean.Items.Add(lvi);
                }
            }
            listViewRoomsToClean.EndUpdate();
        }
        private void PopulateCleaningAssignments()
        {
            ListViewItem lvi; ListViewItem.ListViewSubItem lvsi1;
            listViewAssignedRooms.Items.Clear();
            listViewAssignedRooms.BeginUpdate();

            foreach (ICleaningAssignment ca in Model.CleaningAssignmentsList)
            {
                if (!ca.complete)
                {
                    string cleaners = "";
                    foreach (IUser u in ca.cleaners)
                    {
                        cleaners += u.firstName + " " + u.lastName + "  |  ";
                    }
                    lvi = new ListViewItem();
                    lvi.Text = cleaners;

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = ca.room.roomNumber.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = ca.assignedOn.ToShortDateString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = ca.assignedBy.firstName + " " + ca.assignedBy.lastName;
                    lvi.SubItems.Add(lvsi1);

                    listViewAssignedRooms.Items.Add(lvi);
                }
            }
            listViewAssignedRooms.EndUpdate();
        }
        private void buttonAssignRoom_Click(object sender, EventArgs e)
        {
            if (comboBoxCleaner1.Text.Equals(comboBoxCleaner2.Text) || (comboBoxCleaner1.Text.Equals("") || comboBoxCleaner2.Text.Equals("")))
            {
                MessageBox.Show("Select two different cleaners per job.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<IUser> cleaners = new List<IUser>();
                IUser c1 = Model.getUserByUsername(comboBoxCleaner1.Text); cleaners.Add(c1);
                IUser c2 = Model.getUserByUsername(comboBoxCleaner2.Text); cleaners.Add(c2);
                IRoom room = Model.GetRoomByNumber(Convert.ToInt32(listViewRoomsToClean.SelectedItems[0].Text));
                ICleaningAssignment assignment = CleaningAssignmentFactory.CreateAssignment(room, cleaners, Model.CurrentUser);
                Model.MakeNewCleaningAssignment(assignment);
                PopulateCleaningAssignments();
                PopulateRoomsToBeCleaned();
            }
        }

        private void buttonCancelAssignment_Click(object sender, EventArgs e)
        {
            if (listViewAssignedRooms.SelectedItems.Count == 0)
            {
                MessageBox.Show("An assignment must be selected if you wish to cancel it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ICleaningAssignment ca = Model.GetCleaningAssignment(Convert.ToDateTime(listViewAssignedRooms.SelectedItems[0].SubItems[2].Text), Convert.ToInt32(listViewAssignedRooms.SelectedItems[0].SubItems[1].Text));
                if (Model.CancelCleaningAssignment(ca))
                {
                    MessageBox.Show("Assignment has been canceled.", "Cancellation Complete", MessageBoxButtons.OK);
                    PopulateCleaningAssignments();
                    PopulateRoomsToBeCleaned();
                }
            }
        }     
    }
}
