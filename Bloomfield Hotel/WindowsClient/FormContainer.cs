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
    public partial class formContainer : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion  
        #region Constructors
        public formContainer(IModel _Model) // gets passed a reference to the model object
        {
            InitializeComponent();
            Model = _Model;
            NewLogin();
        }
        #endregion
        private void formContainer_Shown(object sender, EventArgs e)
        {
            
        }
        public void NewLogin()
        {
            LoginForm formLgn = new LoginForm(Model);
            formLgn.ShowDialog();

            switch (Model.getUserTypeForCurrentuser())
            {
                case "Chef":
                    ChefForm form1 = new ChefForm(this, Model); // All forms get passed the formContainer and a reference to the model object. 
                    this.Text = "Bloomfield Hotel - Chef";
                    form1.Dock = DockStyle.Fill;
                    form1.Show();
                    break;
                case "Admin":
                    AdminForm form2 = new AdminForm(this, Model);
                    this.Text = "Bloomfield Hotel - Admin";
                    form2.Dock = DockStyle.Fill;
                    form2.Show();
                    break;
                case "Manager":
                    ManagerForm form3 = new ManagerForm(this, Model);
                    this.Text = "Bloomfield Hotel - Manager";
                    form3.Dock = DockStyle.Fill;
                    form3.Show();
                    break;
                case "BarManager":
                    BarManagerForm form4 = new BarManagerForm(this, Model);
                    this.Text = "Bloomfield Hotel - Bar Manager";
                    form4.Dock = DockStyle.Fill;
                    form4.Show();
                    break;
                case "BarStaff":
                    BarStaffForm form5 = new BarStaffForm(this, Model);
                    this.Text = "Bloomfield Hotel - Bar Staff";
                    form5.Dock = DockStyle.Fill;
                    form5.Show();
                    break;
                case "Cleaner":
                    CleanerForm form6 = new CleanerForm(this, Model);
                    this.Text = "Bloomfield Hotel - Cleaner";
                    form6.Dock = DockStyle.Fill;
                    form6.Show();
                    break;
                case "CleaningSuper":
                    CleaningSuperForm form7 = new CleaningSuperForm(this, Model);
                    this.Text = "Bloomfield Hotel - Cleaning Supervisor";
                    form7.Dock = DockStyle.Fill;
                    form7.Show();
                    break;
                case "Receptionist":
                    ReceptionistForm form8 = new ReceptionistForm(this, Model);
                    this.Text = "Bloomfield Hotel - Receptionist";
                    form8.Dock = DockStyle.Fill;
                    form8.Show();
                    break;
            }
        }
    }
}
