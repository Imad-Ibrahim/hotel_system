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
    public partial class ManagerForm : Form
    {
        private formContainer fc;
        private IModel Model;

        List<IBooking> bookingListWithRange = new List<IBooking>();
        public ManagerForm(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            LoginForm.isLockClicked = false;
        }
        private void btnLogOut_Click(object sender, EventArgs e)
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
        private void tabSelected(object sender, EventArgs e)
        {
            if (tabControlManager.SelectedIndex == 1)
            {
                txtYearVOR.Text = DateTime.Today.Year.ToString();
                txtTotalBookings.Text = "0";
                txtTotalVOR.Text = "€0";
                txtTotalPriceAverage.Text = "€0";
                txtAverageIncomePerDay.Text = "€0";
            }
            if (tabControlManager.SelectedIndex == 2)
            {
                txtYearVBSR.Text = DateTime.Today.Year.ToString();
                txtTotalOrders.Text = "0";
                txtTotalVBSR.Text = "€0";
                txtTotalPriceAverageVBSR.Text = "€0";
                txtAverageIncomePerDayVBSR.Text = "€0";

                foreach (IUser user in Model.UserList)
                {
                    if (Model.getUserType(user).Equals("BarStaff"))
                        comboBoxBarSalesStaffNamesVBSR.Items.Add(user.firstName + " " + user.lastName);
                }
                comboBoxBarSalesStaffNamesVBSR.SelectedIndex = 0;
            }
        }
        #region View Occupancy Records
        private void btnOccupanceTodayDate_Click(object sender, EventArgs e)
        {
            dtpOccupanceFrom.Value = DateTime.Today;
            dtpOccupanceTo.Value = DateTime.Today;
            View_Details_Based_On_Dates(dtpOccupanceFrom.Value.ToString("yyyy-MM-dd"), dtpOccupanceTo.Value.ToString("yyyy-MM-dd"), (dtpOccupanceTo.Value - dtpOccupanceFrom.Value).TotalDays + 1);
        }
        private void btnClearResult_Click(object sender, EventArgs e)
        {
            txtTotalBookings.Text = "0";
            txtTotalVOR.Text = "€0";
            txtTotalPriceAverage.Text = "€0";
            txtAverageIncomePerDay.Text = "€0";
        }
        private void btnOccupanceSearch_Click(object sender, EventArgs e)
        {
            View_Details_Based_On_Dates(dtpOccupanceFrom.Value.ToString("yyyy-MM-dd"), dtpOccupanceTo.Value.ToString("yyyy-MM-dd"), (dtpOccupanceTo.Value - dtpOccupanceFrom.Value).TotalDays + 1);
        }
        private void btnJanuary_Click(object sender, EventArgs e)
        {
            Display_Calculation_Details(1);
        }
        private void btnFebruary_Click(object sender, EventArgs e)
        {
            Display_Calculation_Details(2);
        }
        private void btnMarch_Click(object sender, EventArgs e)
        {
            Display_Calculation_Details(3);
        }
        private void btnApril_Click(object sender, EventArgs e)
        {
            Display_Calculation_Details(4);
        }
        private void btnMay_Click(object sender, EventArgs e)
        {
            Display_Calculation_Details(5);
        }
        private void btnJune_Click(object sender, EventArgs e)
        {
            Display_Calculation_Details(6);
        }
        private void btnJuly_Click(object sender, EventArgs e)
        {
            Display_Calculation_Details(7);
        }
        private void btnAugust_Click(object sender, EventArgs e)
        {
            Display_Calculation_Details(8);
        }
        private void btnSeptember_Click(object sender, EventArgs e)
        {
            Display_Calculation_Details(9);
        }
        private void btnOctober_Click(object sender, EventArgs e)
        {
            Display_Calculation_Details(10);
        }
        private void btnNovember_Click(object sender, EventArgs e)
        {
            Display_Calculation_Details(11);
        }
        private void btnDecember_Click(object sender, EventArgs e)
        {
            Display_Calculation_Details(12);
        }
        private void Display_Calculation_Details(int month)
        {
            DateTime year;
            if (!DateTime.TryParse("01/" + month + "/" + txtYearVOR.Text, out year))
            {
                MessageBox.Show("Enter a valid Year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYearVOR.Focus();
            }
            else
            {
                DateTime firstOfMonth = new DateTime(year.Year, month, 1);
                DateTime endOfMonth = new DateTime(year.Year, month, DateTime.DaysInMonth(year.Month, year.Month));
                View_Details_Based_On_Dates(firstOfMonth.ToString("yyyy-MM-dd"), endOfMonth.ToString("yyyy-MM-dd"), (endOfMonth - firstOfMonth).TotalDays + 1);
            }
        }
        private void View_Details_Based_On_Dates(string from, string to, double totalDays)
        {
            int listSize;
            double total = 0, TotalPriceAverage = 0, AverageIncomePerDay = 0;
            bookingListWithRange = Model.GetBookingWithRange(from, to);
            listSize = bookingListWithRange.Count;
            txtTotalBookings.Text = listSize.ToString();
            bookingListWithRange.ForEach(booking => { total += booking.Total; });
            if (listSize != 0 && total != 0 && totalDays != 0)
            {
                TotalPriceAverage = (total / listSize);
                AverageIncomePerDay = (total / totalDays);
            }
            txtTotalVOR.Text = "€" + Math.Round(total, 2).ToString();
            txtTotalPriceAverage.Text = "€" + Math.Round(TotalPriceAverage, 2).ToString();
            txtAverageIncomePerDay.Text = "€" + Math.Round(AverageIncomePerDay, 2).ToString();
        }
        #endregion
        #region View Bar Sales Records
        private void btnTodayDateVBSR_Click(object sender, EventArgs e)
        {
            dtpFromDateVBSR.Value = DateTime.Today;
            dtpToDateVBSR.Value = DateTime.Today;
            View_Details_Based_On_DatesVBSR(dtpFromDateVBSR.Value.ToString("yyyy-MM-dd"), dtpToDateVBSR.Value.ToString("yyyy-MM-dd"), (dtpToDateVBSR.Value - dtpFromDateVBSR.Value).TotalDays + 1);
        }
        private void btnClearResultVBSR_Click(object sender, EventArgs e)
        {
            txtTotalOrders.Text = "0";
            txtTotalVBSR.Text = "€0";
            txtTotalPriceAverageVBSR.Text = "€0";
            txtAverageIncomePerDayVBSR.Text = "€0";
            radioBtnBarSalesFoodVBSR.Checked = false;
            radioBtnBarSalesDrinksVBSR.Checked = false;
        }
        private void btnSearchVBSR_Click(object sender, EventArgs e)
        {
            View_Details_Based_On_DatesVBSR(dtpFromDateVBSR.Value.ToString("yyyy-MM-dd"), dtpToDateVBSR.Value.ToString("yyyy-MM-dd"), (dtpToDateVBSR.Value - dtpFromDateVBSR.Value).TotalDays + 1);
        }
        private void btnJanuaryVBSR_Click(object sender, EventArgs e)
        {
            Display_Calculation_DetailsVBER(1);
        }
        private void btnFebruaryVBSR_Click(object sender, EventArgs e)
        {
            Display_Calculation_DetailsVBER(2);
        }
        private void btnMarchVBSR_Click(object sender, EventArgs e)
        {
            Display_Calculation_DetailsVBER(3);
        }
        private void btnAprilVBSR_Click(object sender, EventArgs e)
        {
            Display_Calculation_DetailsVBER(4);
        }
        private void btnmayVBSR_Click(object sender, EventArgs e)
        {
            Display_Calculation_DetailsVBER(5);
        }
        private void btnJuneVBSR_Click(object sender, EventArgs e)
        {
            Display_Calculation_DetailsVBER(6);
        }
        private void btnJulyVBSR_Click(object sender, EventArgs e)
        {
            Display_Calculation_DetailsVBER(7);
        }
        private void btnAugustVBSR_Click(object sender, EventArgs e)
        {
            Display_Calculation_DetailsVBER(8);
        }
        private void btnSeptemberVBSR_Click(object sender, EventArgs e)
        {
            Display_Calculation_DetailsVBER(9);
        }
        private void btnOctoberVBSR_Click(object sender, EventArgs e)
        {
            Display_Calculation_DetailsVBER(10);
        }
        private void btnNovemberVBSR_Click(object sender, EventArgs e)
        {
            Display_Calculation_DetailsVBER(11);
        }
        private void btnDecemberVBSR_Click(object sender, EventArgs e)
        {
            Display_Calculation_DetailsVBER(12);
        }
        private void Display_Calculation_DetailsVBER(int month)
        {
            DateTime year;
            if (!DateTime.TryParse("01/" + month + "/" + txtYearVBSR.Text, out year))
            {
                MessageBox.Show("Enter a valid Year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYearVBSR.Focus();
            }
            else
            {
                DateTime firstOfMonth = new DateTime(year.Year, month, 1);
                DateTime endOfMonth = new DateTime(year.Year, month, DateTime.DaysInMonth(year.Month, year.Month));
                View_Details_Based_On_DatesVBSR(firstOfMonth.ToString("yyyy-MM-dd"), endOfMonth.ToString("yyyy-MM-dd"), (endOfMonth - firstOfMonth).TotalDays + 1);
            }

        }
        private void View_Details_Based_On_DatesVBSR(string from, string to, double totalDays)
        {
            List<ISaleLineItem> customerSalesListOfFoodType = new List<ISaleLineItem>();
            List<ISaleLineItem> customerSalesListOfDrinkType = new List<ISaleLineItem>();
            List<ICustomerSale> customerSalesListOfFoodAndDrink = new List<ICustomerSale>();
            IUser user = new User();
            int listSize = 0;
            double total = 0, TotalPriceAverage = 0, AverageIncomePerDay = 0;
            bool foodSelected = false, drinkSelected = false;
            string name, username;

            if (radioBtnBarSalesFoodVBSR.Checked)
                foodSelected = true;
            if (radioBtnBarSalesDrinksVBSR.Checked)
                drinkSelected = true;

            name = comboBoxBarSalesStaffNamesVBSR.SelectedItem.ToString();
            username = (name.Substring(0, 1) + "." + name.Substring(name.LastIndexOf(' ') + 1));
            Model.UserList.ForEach(u => { if (u.username.Equals(username)) user = u; });
            List<ICustomerSale> customerSalesListWithRangeAndName = Model.GetCustomerSalesWithRange(from, to, user);

            foreach (ICustomerSale customerSale in customerSalesListWithRangeAndName)
            {
                foreach (ISaleLineItem saleLineItem in customerSale.saleLineItems)
                {
                    if (foodSelected)
                    {
                        if (saleLineItem.item.unit.Equals("Meal"))
                            customerSalesListOfFoodType.Add(saleLineItem);
                    }
                    else if (drinkSelected)
                    {
                        if (!saleLineItem.item.unit.Equals("Meal"))
                            customerSalesListOfDrinkType.Add(saleLineItem);
                    }
                    else
                    {
                        customerSalesListOfFoodAndDrink.Add(customerSale);
                        break;
                    }
                }
            }

            if (foodSelected)
            {
                listSize = customerSalesListOfFoodType.Count;
                txtTotalOrders.Text = listSize.ToString();
                customerSalesListOfFoodType.ForEach(cSales => { total += cSales.lineCost; });
            }
            else if (drinkSelected)
            {
                listSize = customerSalesListOfDrinkType.Count;
                txtTotalOrders.Text = listSize.ToString();
                customerSalesListOfDrinkType.ForEach(cSales => { total += cSales.lineCost; });
            }
            else
            {
                listSize = customerSalesListOfFoodAndDrink.Count;
                txtTotalOrders.Text = listSize.ToString();
                customerSalesListOfFoodAndDrink.ForEach(cSales => { total += cSales.total; });
            }

            if (listSize != 0 && total != 0 && totalDays != 0)
            {
                TotalPriceAverage = (total / listSize);
                AverageIncomePerDay = (total / totalDays);
            }
            txtTotalVBSR.Text = "€" + Math.Round(total, 2).ToString();
            txtTotalPriceAverageVBSR.Text = "€" + Math.Round(TotalPriceAverage, 2).ToString();
            txtAverageIncomePerDayVBSR.Text = "€" + Math.Round(AverageIncomePerDay, 2).ToString();
        }
        #endregion      
    }
}
