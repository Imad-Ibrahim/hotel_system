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
using System.Runtime.InteropServices;

namespace WindowsClient
{
    public partial class ReceptionistForm : Form
    {
        private formContainer fc;
        private IModel Model;        
        public static IGuest ExistingGuest = null;
        public static TextBox guestID = null;
        public static TextBox guestName = null;
        public static TextBox guestAddress = null;
        public static TextBox guestPhoneNumber = null;
        public static TextBox guestEmail = null;
        public static RadioButton guestMarketingConsentYES = null;
        public static RadioButton guestMarketingConsentNO = null;
        public static RadioButton guestSaveCustomerDetailsConsentYES = null;
        public static RadioButton guestSaveCustomerDetailsConsentNO = null;
        public static TextBox guestCreditCardName = null;
        public static TextBox guestCreditCardNumber = null;
        public static DateTimePicker guestCreditCardExpiryDate = null;
        public static TextBox guestCreditCardSecurityCode = null;
        public static RadioButton guestSaveCreditCardDetailsYES = null;
        public static RadioButton guestSaveCreditCardDetailsNO = null;

        bool marketingConsent, saveCustomerDetails, saveCustomerCardDetails, edited = false;
        IGuest editGuest = new Guest();
        public ReceptionistForm(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            LoginForm.isLockClicked = false;            
        }
        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            btnSingleRoomDecrease.Enabled = false;
            btnDoubleRoomDecrease.Enabled = false;
            btnTwinRoomDecrease.Enabled = false;
            btnSingleRoomIncrease.Enabled = false;
            btnDoubleRoomIncrease.Enabled = false;
            btnTwinRoomIncrease.Enabled = false;

            GetBookingDetails();
            SetNewBookingID();
            SetNewGuestID();
            DisableModificationMB();

            GetRoomDetails();
            GetCheckInDetails();
            GetCheckOutDetails();

           //LockIfNoActivity();
        }
        async void LockIfNoActivity()
        {
            while (true)
            {
                await Task.Delay(new TimeSpan(0, 0, 0, 5)).ContinueWith(o =>
                {
                    if (TimeToLock.GetIdleTime() >= 600000)
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetBookTab();
        }
        private void ResetBookTab()
        {
            //Customer Details.
            txtName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            radioBtnMarketingConsentYES.Checked = false;
            radioBtnMarketingConsentNO.Checked = false;
            radioBtnSaveCustomerDetailsYES.Checked = false;
            radioBtnSaveCustomerDetailsNO.Checked = false;
            //Payment Details.
            txtHolderName.Clear();
            txtCardNumber.Clear();
            dtpExpiryDate.Text = DateTime.Now.ToString();
            txtSecurityCode.Clear();
            radioBtnSaveCustomerCardDetailsYES.Checked = false;
            radioBtnSaveCustomerCardDetailsNO.Checked = false;
            //Booking Details.
            dtpCheckInDate.Text = DateTime.Now.ToString();
            dtpCheckOutDate.Text = DateTime.Now.ToString();
            lblSingleRoomAvailabilityNum.Text = "0";
            lblDoubleRoomAvailabilityNum.Text = "0";
            lblTwinRoomAvailabilityNum.Text = "0";
            txtGuestNames.Clear();
            txtAdditionalNotes.Clear();
            lblSingleRoomNumber.Text = "0";
            lblDoubleRoomNumber.Text = "0";
            lblTwinRoomNumber.Text = "0";

            btnSingleRoomDecrease.Enabled = false;
            btnDoubleRoomDecrease.Enabled = false;
            btnTwinRoomDecrease.Enabled = false;
            btnSingleRoomIncrease.Enabled = false;
            btnDoubleRoomIncrease.Enabled = false;
            btnTwinRoomIncrease.Enabled = false;

            SetNewBookingID();
            SetNewGuestID();
        }
        private void btnSingleRoomDecrease_Click(object sender, EventArgs e)
        {
            RoomDecInc("single", "dec");
        }
        private void btnSingleRoomIncrease_Click(object sender, EventArgs e)
        {
            RoomDecInc("single", "inc");
        }
        private void btnDoubleRoomDecrease_Click(object sender, EventArgs e)
        {
            RoomDecInc("double", "dec");
        }
        private void btnDoubleRoomIncrease_Click(object sender, EventArgs e)
        {
            RoomDecInc("double", "inc");
        }
        private void btnTwinRoomDecrease_Click(object sender, EventArgs e)
        {
            RoomDecInc("twin", "dec");
        }
        private void btnTwinRoomIncrease_Click(object sender, EventArgs e)
        {
            RoomDecInc("twin", "inc");
        }
        private void RoomDecInc(string roomType, string option)
        {
            int maxSingle = Convert.ToInt32(lblSingleRoomAvailabilityNum.Text);
            int maxDouble = Convert.ToInt32(lblDoubleRoomAvailabilityNum.Text);
            int maxTwin = Convert.ToInt32(lblTwinRoomAvailabilityNum.Text);

            int singleRoomNum = Convert.ToInt32(lblSingleRoomNumber.Text);
            int doubleRoomNum = Convert.ToInt32(lblDoubleRoomNumber.Text);
            int twinRoomNum = Convert.ToInt32(lblTwinRoomNumber.Text);

            if (roomType == "single" && option == "dec")
            {
                singleRoomNum--;
                btnSingleRoomIncrease.Enabled = true;
            }
            if (roomType == "single" && option == "inc")
            {
                singleRoomNum++;
                btnSingleRoomDecrease.Enabled = true;
            }


            if (roomType == "double" && option == "dec")
            {
                doubleRoomNum--;
                btnDoubleRoomIncrease.Enabled = true;
            }
            if (roomType == "double" && option == "inc")
            {
                doubleRoomNum++;
                btnDoubleRoomDecrease.Enabled = true;
            }


            if (roomType == "twin" && option == "dec")
            {
                twinRoomNum--;
                btnTwinRoomIncrease.Enabled = true;
            }
            if (roomType == "twin" && option == "inc")
            {
                twinRoomNum++;
                btnTwinRoomDecrease.Enabled = true;
            }

            if (singleRoomNum >= 0)
                lblSingleRoomNumber.Text = singleRoomNum.ToString();
            if (doubleRoomNum >= 0)
                lblDoubleRoomNumber.Text = doubleRoomNum.ToString();
            if (twinRoomNum >= 0)
                lblTwinRoomNumber.Text = twinRoomNum.ToString();

            if (singleRoomNum <= 0)
                btnSingleRoomDecrease.Enabled = false;
            if (singleRoomNum >= maxSingle)
                btnSingleRoomIncrease.Enabled = false;

            if (doubleRoomNum <= 0)
                btnDoubleRoomDecrease.Enabled = false;
            if (doubleRoomNum >= maxDouble)
                btnDoubleRoomIncrease.Enabled = false;

            if (twinRoomNum <= 0)
                btnTwinRoomDecrease.Enabled = false;
            if (twinRoomNum >= maxTwin)
                btnTwinRoomIncrease.Enabled = false;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            List<IRoom> rooms = new List<IRoom>();
            bool existingGuest = ExistingCustomerForm.ExistingGuest;
            bool creditCardFound = ExistingCustomerForm.creditCardFound;

            if (IsEmptyBookTab())
            {
                if (IsValidDataBookTab())
                {
                    if (radioBtnMarketingConsentYES.Checked)
                        marketingConsent = true;
                    else
                        marketingConsent = false;
                    if (radioBtnSaveCustomerDetailsYES.Checked)
                        saveCustomerDetails = true;
                    else
                        saveCustomerDetails = false;
                    if (radioBtnSaveCustomerCardDetailsYES.Checked)
                        saveCustomerCardDetails = true;
                    else
                        saveCustomerCardDetails = false;

                    ICreditCard creditCard = CreditCardFactory.GetCreditCard(txtHolderName.Text, dtpExpiryDate.Value, txtCardNumber.Text, txtSecurityCode.Text, saveCustomerCardDetails);
                    IGuest guest = GuestFactory.GetGuest(Convert.ToInt32(txtGuestId.Text),
                        txtName.Text, txtAddress.Text, txtPhoneNumber.Text, txtEmail.Text, marketingConsent, saveCustomerDetails, creditCard);
                    IBooking booking = BookingFactory.GetBooking(
                        Convert.ToInt32(txtBookingID.Text),
                        dtpCheckInDate.Value,
                        dtpCheckOutDate.Value,
                        txtGuestNames.Text,
                        txtAdditionalNotes.Text,
                        Convert.ToInt32(lblSingleRoomNumber.Text),
                        Convert.ToInt32(lblDoubleRoomNumber.Text),
                        Convert.ToInt32(lblTwinRoomNumber.Text),
                        rooms,
                        false,
                        false, guest);

                    if (!creditCardFound && existingGuest)
                    {
                        Model.addNewCreditCard(creditCard);
                        Model.editGuest(guest);
                    }
                    else if (!existingGuest)
                    {
                        Model.addNewCreditCard(creditCard);
                        Model.addNewGuest(guest);
                    }
                    else
                    {
                        Model.editCreditCard(creditCard);
                        Model.editGuest(guest);
                    }

                    Model.addNewBooking(booking);
                    existingGuest = false;
                    creditCardFound = false;
                    MessageBox.Show("The Booking Successfully Done.\n\nTotal: €" + Math.Round(booking.Total, 2).ToString(), "Booking Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetBookTab();
                }
            }
            else
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool IsValidDataBookTab()
        {
            if (txtPhoneNumber.Text.Length == 10)
            {
                if (txtCardNumber.Text.Length == 16)
                {
                    if (txtSecurityCode.Text.Length == 3)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("'Security Code' must be 3 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSecurityCode.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("'Credit Number' must be 16 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCardNumber.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("'Phone Number' must be 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                return false;
            }

        }
        private bool IsEmptyBookTab()
        {
            if (txtName.Text != null &&
                txtAddress.Text != null &&
                txtPhoneNumber.Text != null &&
                txtEmail.Text != null &&
                radioBtnMarketingConsentYES.Checked == false &&
                radioBtnMarketingConsentNO.Checked == false &&
                radioBtnSaveCustomerDetailsNO.Checked == false &&
                radioBtnSaveCustomerDetailsYES.Checked == false &&
                txtHolderName.Text != null && txtCardNumber.Text != null &&
                dtpCardExpityDateMB.Value >= DateTime.Now &&
                txtSecurityCode.Text != null &&
                radioBtnSaveCustomerCardDetailsNO.Checked == false &&
                radioBtnSaveCustomerCardDetailsYES.Checked == false &&
                dtpCheckInDate.Value >= DateTime.Now &&
                dtpCheckOutDate.Value > DateTime.Now ||
                Convert.ToInt32(lblSingleRoomNumber.Text) > 0 ||
                Convert.ToInt32(lblDoubleRoomNumber.Text) > 0 ||
                Convert.ToInt32(lblTwinRoomNumber.Text) > 0)
            {
                return true;
            }
            else
                return false;
        }
        private bool IsEmptyManageBookBookingTab()
        {
            if (txtCustomerNameMB.Text != null &&
                txtCutomerAddressMB.Text != null &&
                txtCustomerPhoneNumMB.Text != null &&
                txtCustomerEmailMB.Text != null &&
                radioBtnMBCustomerMarketingConsentNO.Checked == false &&
                radioBtnMBCustomerMarketingConsentYES.Checked == false &&
                radioBtnMBCustomerSaveDetailsNO.Checked == false &&
                radioBtnMBCustomerSaveDetailsYES.Checked == false &&
                txtCustomerHolderNameMB.Text != null && txtCardNumber.Text != null &&
                dtpCardExpityDateMB.Value >= DateTime.Now &&
                txtCardSecurityCodeMB.Text != null &&
                radioBtnMBSaveCustomerCardDetailsYES.Checked == false &&
                radioBtnMBSaveCustomerCardDetailsNO.Checked == false &&
                dtpCustomerCheckInMB.Value >= DateTime.Now &&
                dtpCustomerCheckOutMB.Value > DateTime.Now ||
                Convert.ToInt32(lblCustomerSingleRoomNumberMB.Text) > 0 ||
                Convert.ToInt32(lblCustomerDoubleRoomNumberMB.Text) > 0 ||
                Convert.ToInt32(lblCustomerTwinRoomNumberMB.Text) > 0)
            {
                return true;
            }
            else
                return false;
        }
        private bool IsValidDataManageBookBookingTab()
        {
            if (txtCustomerPhoneNumMB.Text.Length == 10)
            {
                if (txtCustomerCardNumberMB.Text.Length == 16)
                {
                    if (txtCardSecurityCodeMB.Text.Length == 3)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("'Security Code' must be 3 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCardSecurityCodeMB.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("'Credit Number' must be 16 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerCardNumberMB.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("'Phone Number' must be 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerPhoneNumMB.Focus();
                return false;
            }

        }
        private void btnExistingCustomer_Click(object sender, EventArgs e)
        {
            guestID = txtGuestId;
            guestName = txtName;
            guestAddress = txtAddress;
            guestPhoneNumber = txtPhoneNumber;
            guestEmail = txtEmail;
            guestMarketingConsentYES = radioBtnMarketingConsentYES;
            guestMarketingConsentNO = radioBtnMarketingConsentNO;
            guestSaveCustomerDetailsConsentYES = radioBtnSaveCustomerDetailsYES;
            guestSaveCustomerDetailsConsentNO = radioBtnSaveCustomerDetailsNO;
            guestCreditCardName = txtHolderName;
            guestCreditCardNumber = txtCardNumber;
            guestCreditCardExpiryDate = dtpExpiryDate;
            guestCreditCardSecurityCode = txtSecurityCode;
            guestSaveCreditCardDetailsYES = radioBtnSaveCustomerCardDetailsYES;
            guestSaveCreditCardDetailsNO = radioBtnSaveCustomerCardDetailsNO;

            ExistingCustomerForm existingCustomerForm = new ExistingCustomerForm(Model);
            existingCustomerForm.Show();
        }
        private void btnSeachForBooking_Click(object sender, EventArgs e)
        {
            if (dtpCheckOutDate.Value > dtpCheckInDate.Value)
            {
                lblSingleRoomAvailabilityNum.Text = "0";
                lblDoubleRoomAvailabilityNum.Text = "0";
                lblTwinRoomAvailabilityNum.Text = "0";

                List<int> roomTypeList = Model.CheckForRoomAvailability(dtpCheckInDate.Value, dtpCheckOutDate.Value);

                lblSingleRoomAvailabilityNum.Text = roomTypeList[0].ToString();
                lblDoubleRoomAvailabilityNum.Text = roomTypeList[1].ToString();
                lblTwinRoomAvailabilityNum.Text = roomTypeList[2].ToString();

                if (!Convert.ToInt32(lblSingleRoomAvailabilityNum.Text).Equals(0) && !Convert.ToInt32(lblDoubleRoomAvailabilityNum.Text).Equals(0) &&
                !Convert.ToInt32(lblTwinRoomAvailabilityNum.Text).Equals(0))
                {
                    btnSingleRoomIncrease.Enabled = true;
                    btnDoubleRoomIncrease.Enabled = true;
                    btnTwinRoomIncrease.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("'Check-in' date must be grater then the 'Check-out' date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpCheckOutDate.Focus();
            }
        }
        private void btnSearchMB_Click(object sender, EventArgs e)
        {
            string marketingConsent, SaveCustomerDetails, SaveCardDetails;
            bool found = false;
            if (txtPhoneNumOrBookingIDSearchMB.Text.Length != 0)
            {
                listViewManageBooking.Items.Clear();
                Model.BookingList.ForEach(booking =>
                {
                    if (txtPhoneNumOrBookingIDSearchMB.Text.Equals(booking.Guest.PhoneNumber) || txtPhoneNumOrBookingIDSearchMB.Text.Equals(booking.BookingID.ToString()))
                    {
                        if (((booking.NumSingleRooms != 0) || (booking.NumDoubleRooms != 0) || (booking.NumTwinRooms != 0)) && (booking.CheckedOut.Equals(false)))
                        {
                            found = true;
                            if (booking.Guest.MarketingConsent)
                                marketingConsent = "Yes";
                            else
                                marketingConsent = "No";

                            if (booking.Guest.SaveCustomerDetails)
                                SaveCustomerDetails = "Yes";
                            else
                                SaveCustomerDetails = "No";

                            if (booking.Guest.CreditCard.SaveCardDetails)
                                SaveCardDetails = "Yes";
                            else
                                SaveCardDetails = "No";

                            listViewManageBooking.Items.Add(new ListViewItem(new string[]
                            {
                                booking.Guest.Name,
                                booking.Guest.Address,
                                booking.Guest.PhoneNumber,
                                booking.Guest.Email,
                                marketingConsent,
                                SaveCustomerDetails,
                                booking.Guest.CreditCard.HolderName,
                                booking.Guest.CreditCard.CardNumber,
                                booking.Guest.CreditCard.ExpirDate.ToShortDateString(),
                                booking.Guest.CreditCard.SecurityCode,
                                SaveCardDetails,
                                booking.CheckIn.ToShortDateString(),
                                booking.CheckOut.ToShortDateString(),
                                booking.GuestNames,
                                booking.AdditionalNotes,
                                booking.NumSingleRooms.ToString(),
                                booking.NumDoubleRooms.ToString(),
                                booking.NumTwinRooms.ToString(),
                                booking.BookingID.ToString(),
                                booking.Total.ToString(),
                                booking.Guest.GuestID.ToString()
                            }));
                        }
                    }
                });
                if (!found)
                {
                    GetBookingDetails();
                    MessageBox.Show("Booking not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNumOrBookingIDSearchMB.Clear(); txtPhoneNumOrBookingIDSearchMB.Focus();
                }
                txtPhoneNumOrBookingIDSearchMB.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter a Phone Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumOrBookingIDSearchMB.Focus();
            }
        }
        private void GetBookingDetails()
        {
            string marketingConsent, SaveCustomerDetails, SaveCardDetails;
            listViewManageBooking.Items.Clear();

            if (edited)
            {
                foreach (IBooking booking in Model.BookingList)
                {
                    if (booking.Guest.GuestID.ToString().Equals((txtGuestIdMB.Text)))
                        booking.Guest = editGuest;
                }
            }
            foreach (Booking booking in Model.BookingList)
            {
                if (booking.Guest.MarketingConsent)
                    marketingConsent = "Yes";
                else
                    marketingConsent = "No";

                if (booking.Guest.SaveCustomerDetails)
                    SaveCustomerDetails = "Yes";
                else
                    SaveCustomerDetails = "No";

                if (booking.Guest.CreditCard.SaveCardDetails)
                    SaveCardDetails = "Yes";
                else
                    SaveCardDetails = "No";

                if (((booking.NumSingleRooms != 0) || (booking.NumDoubleRooms != 0) || (booking.NumTwinRooms != 0)) && (booking.CheckedOut.Equals(false)))
                {
                    listViewManageBooking.Items.Add(new ListViewItem(new string[]
                    {
                        booking.Guest.Name,
                        booking.Guest.Address,
                        booking.Guest.PhoneNumber,
                        booking.Guest.Email,
                        marketingConsent,
                        SaveCustomerDetails,
                        booking.Guest.CreditCard.HolderName,
                        booking.Guest.CreditCard.CardNumber,
                        booking.Guest.CreditCard.ExpirDate.ToShortDateString(),
                        booking.Guest.CreditCard.SecurityCode,
                        SaveCardDetails,
                        booking.CheckIn.ToShortDateString(),
                        booking.CheckOut.ToShortDateString(),
                        booking.GuestNames,
                        booking.AdditionalNotes,
                        booking.NumSingleRooms.ToString(),
                        booking.NumDoubleRooms.ToString(),
                        booking.NumTwinRooms.ToString(),
                        booking.BookingID.ToString(),
                        booking.Total.ToString(),
                        booking.Guest.GuestID.ToString()
                    }));
                }
            }
        }
        private void tabSelected(object sender, EventArgs e)
        {
            if (tabControlReceptionist.SelectedIndex == 3)
            {
                GetBookingDetailsrForViewBookingTab(Model.BookingList);
            }
            else if (tabControlReceptionist.SelectedIndex == 4)
            {
                GetBookingDetails();
            }           
        }
        private void SetNewBookingID()
        {
            int id = Model.GetNewBookingID();
            txtBookingID.Text = id.ToString();
        }
        private void SetNewGuestID()
        {
            int id = Model.GetNewGuestID();
            txtGuestId.Text = id.ToString();
        }
        private void listViewManageBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewManageBooking.SelectedItems)
            {
                txtCustomerNameMB.Text = item.SubItems[0].Text;
                txtCutomerAddressMB.Text = item.SubItems[1].Text;
                txtCustomerPhoneNumMB.Text = item.SubItems[2].Text;
                txtCustomerEmailMB.Text = item.SubItems[3].Text;

                if (item.SubItems[4].Text == "Yes")
                    radioBtnMBCustomerMarketingConsentYES.Checked = true;
                if (item.SubItems[4].Text == "No")
                    radioBtnMBCustomerMarketingConsentNO.Checked = true;

                if (item.SubItems[5].Text == "Yes")
                    radioBtnMBCustomerSaveDetailsYES.Checked = true;
                if (item.SubItems[5].Text == "No")
                    radioBtnMBCustomerSaveDetailsNO.Checked = true;

                txtCustomerHolderNameMB.Text = item.SubItems[6].Text;
                txtCustomerCardNumberMB.Text = item.SubItems[7].Text;
                dtpCardExpityDateMB.Value = DateTime.Parse(item.SubItems[8].Text);
                txtCardSecurityCodeMB.Text = item.SubItems[9].Text;

                if (item.SubItems[10].Text == "Yes")
                    radioBtnMBSaveCustomerCardDetailsYES.Checked = true;
                if (item.SubItems[10].Text == "No")
                    radioBtnMBSaveCustomerCardDetailsNO.Checked = true;

                txtBookingIdMB.Text = item.SubItems[18].Text;
                dtpCustomerCheckInMB.Value = DateTime.Parse(item.SubItems[11].Text);
                dtpCustomerCheckOutMB.Value = DateTime.Parse(item.SubItems[12].Text);
                txtCustomerGuestNamesMB.Text = item.SubItems[13].Text;
                txtCustomerAdditionalNotesMB.Text = item.SubItems[14].Text;
                lblCustomerSingleRoomNumberMB.Text = item.SubItems[15].Text;
                lblCustomerDoubleRoomNumberMB.Text = item.SubItems[16].Text;
                lblCustomerTwinRoomNumberMB.Text = item.SubItems[17].Text;
                txtGuestIdMB.Text = item.SubItems[20].Text;
            }
        }
        private void btncancelModificationMB_Click(object sender, EventArgs e)
        {
            ResetManageBooking();
            DisableModificationMB();
        }
        private void btnClearMB_Click(object sender, EventArgs e)
        {
            ResetManageBooking();
        }
        private void btnEditMB_Click(object sender, EventArgs e)
        {
            List<IRoom> rooms = new List<IRoom>();
            if (listViewManageBooking.SelectedItems.Count > 0)
            {
                if (btnEditMB.Text == "Edit")
                {
                    EnableModificationMB();
                    btnEditMB.Text = "Save";
                }
                else
                {
                    if (IsEmptyManageBookBookingTab())
                    {
                        if (IsValidDataManageBookBookingTab())
                        {
                            if (radioBtnMBCustomerMarketingConsentYES.Checked)
                                marketingConsent = true;
                            else
                                marketingConsent = false;

                            if (radioBtnMBCustomerSaveDetailsYES.Checked)
                                saveCustomerDetails = true;
                            else
                                saveCustomerDetails = false;

                            if (radioBtnMBSaveCustomerCardDetailsYES.Checked)
                                saveCustomerCardDetails = true;
                            else
                                saveCustomerCardDetails = false;

                            ICreditCard editCreditCard = CreditCardFactory.GetCreditCard(txtCustomerHolderNameMB.Text, dtpCardExpityDateMB.Value, txtCustomerCardNumberMB.Text, txtCardSecurityCodeMB.Text, saveCustomerCardDetails);

                            editGuest = GuestFactory.GetGuest(Convert.ToInt32(txtGuestIdMB.Text), txtCustomerNameMB.Text, txtCutomerAddressMB.Text, txtCustomerPhoneNumMB.Text, txtCustomerEmailMB.Text,
                                marketingConsent, saveCustomerDetails, editCreditCard);


                            IBooking editBooking = BookingFactory.GetBooking(
                                Convert.ToInt32(txtBookingIdMB.Text), dtpCustomerCheckInMB.Value, dtpCustomerCheckOutMB.Value, txtCustomerGuestNamesMB.Text,
                                txtCustomerAdditionalNotesMB.Text, Convert.ToInt32(lblCustomerSingleRoomNumberMB.Text),
                                Convert.ToInt32(lblCustomerDoubleRoomNumberMB.Text), Convert.ToInt32(lblCustomerTwinRoomNumberMB.Text),
                                rooms, false, false, editGuest);

                            Model.editCreditCard(editCreditCard);
                            Model.editGuest(editGuest);
                            Model.editBooking(editBooking);

                            edited = true;
                            GetBookingDetails();
                            ResetManageBooking();
                            DisableModificationMB();
                            MessageBox.Show("The Modification Successfully Done.\n\nTotal: €" + Math.Round(editBooking.Total, 2).ToString(), "Modification Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnEditMB.Text = "Edit";
                        }
                    }
                    else
                        MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Please select a booking to Edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ResetManageBooking()
        {
            txtGuestIdMB.Clear();
            txtCustomerNameMB.Clear();
            txtCutomerAddressMB.Clear();
            txtCustomerPhoneNumMB.Clear();
            txtCustomerEmailMB.Clear();
            radioBtnMBCustomerMarketingConsentYES.Checked = false;
            radioBtnMBCustomerMarketingConsentNO.Checked = false;
            radioBtnMBCustomerSaveDetailsYES.Checked = false;
            radioBtnMBCustomerSaveDetailsNO.Checked = false;

            txtCustomerHolderNameMB.Clear();
            txtCustomerCardNumberMB.Clear();
            dtpCardExpityDateMB.Value = DateTime.Now;
            txtCardSecurityCodeMB.Clear();
            radioBtnMBSaveCustomerCardDetailsYES.Checked = false;
            radioBtnMBSaveCustomerCardDetailsNO.Checked = false;

            txtBookingIdMB.Clear();
            dtpCustomerCheckInMB.Value = DateTime.Now;
            dtpCustomerCheckOutMB.Value = DateTime.Now;
            txtCustomerGuestNamesMB.Clear();
            txtCustomerAdditionalNotesMB.Clear();
            lblCustomerSingleRoomNumberMB.Text = "0";
            lblCustomerDoubleRoomNumberMB.Text = "0";
            lblCustomerTwinRoomNumberMB.Text = "0";

            lblSingleRoomAvailabilityNumMB.Text = "0";
            lblDoubleRoomAvailabilityNumMB.Text = "0";
            lblTwinRoomAvailabilityNumMB.Text = "0";

            btnEditMB.Text = "Edit";
            txtPhoneNumOrBookingIDSearchMB.Clear();
            listViewManageBooking.Items.Clear();
            GetBookingDetails();
        }
        private void EnableModificationMB()
        {
            txtCustomerNameMB.Enabled = true;
            txtCutomerAddressMB.Enabled = true;
            txtCustomerPhoneNumMB.Enabled = true;
            txtCustomerEmailMB.Enabled = true;
            radioBtnMBCustomerMarketingConsentYES.Enabled = true;
            radioBtnMBCustomerMarketingConsentNO.Enabled = true;
            radioBtnMBCustomerSaveDetailsYES.Enabled = true;
            radioBtnMBCustomerSaveDetailsNO.Enabled = true;

            txtCustomerHolderNameMB.Enabled = true;
            txtCustomerCardNumberMB.Enabled = true;
            dtpCardExpityDateMB.Enabled = true;
            txtCardSecurityCodeMB.Enabled = true;
            radioBtnMBSaveCustomerCardDetailsYES.Enabled = true;
            radioBtnMBSaveCustomerCardDetailsNO.Enabled = true;

            dtpCustomerCheckInMB.Enabled = true;
            dtpCustomerCheckOutMB.Enabled = true;
            txtCustomerGuestNamesMB.Enabled = true;
            txtCustomerAdditionalNotesMB.Enabled = true;
            lblCustomerSingleRoomNumberMB.Enabled = true;
            lblCustomerDoubleRoomNumberMB.Enabled = true;
            lblCustomerTwinRoomNumberMB.Enabled = true;

            btnCancelBookingMB.Enabled = true;

            txtPhoneNumOrBookingIDSearchMB.Enabled = false;
            btnSearchMB.Enabled = false;
            btnCancelBookingMB.Enabled = false;
            btnClearMB.Enabled = false;
            btncancelModificationMB.Visible = true;
            btnSeachForBookingMB.Enabled = true;
        }
        private void btnSeachForBookingMB_Click(object sender, EventArgs e)
        {
            if (dtpCustomerCheckOutMB.Value > dtpCustomerCheckInMB.Value)
            {
                lblSingleRoomAvailabilityNumMB.Text = "0";
                lblDoubleRoomAvailabilityNumMB.Text = "0";
                lblTwinRoomAvailabilityNumMB.Text = "0";

                List<int> roomTypeList = Model.CheckForRoomAvailability(dtpCustomerCheckInMB.Value, dtpCustomerCheckOutMB.Value);
                lblSingleRoomAvailabilityNumMB.Text = roomTypeList[0].ToString();
                lblDoubleRoomAvailabilityNumMB.Text = roomTypeList[1].ToString();
                lblTwinRoomAvailabilityNumMB.Text = roomTypeList[2].ToString();

                if (!Convert.ToInt32(lblSingleRoomAvailabilityNumMB.Text).Equals(0) && !Convert.ToInt32(lblDoubleRoomAvailabilityNumMB.Text).Equals(0) &&
                !Convert.ToInt32(lblTwinRoomAvailabilityNumMB.Text).Equals(0))
                {
                    btnCustomerSingleRoomIncreaseMB.Enabled = true;
                    btnCustomerTwinRoomIncreaseMB.Enabled = true;
                    btnCustomerDoubleRoomIncreaseMB.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("'Check-in' date must be grater then the 'Check-out' date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpCustomerCheckOutMB.Focus();
            }
        }
        private void btnCustomerSingleRoomDecreaseMB_Click(object sender, EventArgs e)
        {
            RoomDecIncMB("single", "dec");
        }
        private void btnCustomerSingleRoomIncreaseMB_Click(object sender, EventArgs e)
        {
            RoomDecIncMB("single", "inc");
        }
        private void btnCustomerDoubleRoomDecreaseMB_Click(object sender, EventArgs e)
        {
            RoomDecIncMB("double", "dec");
        }
        private void btnCustomerDoubleRoomIncreaseMB_Click(object sender, EventArgs e)
        {
            RoomDecIncMB("double", "inc");
        }
        private void btnCustomerTwinRoomDecreaseMB_Click(object sender, EventArgs e)
        {
            RoomDecIncMB("twin", "dec");
        }
        private void btnCustomerTwinRoomIncreaseMB_Click(object sender, EventArgs e)
        {
            RoomDecIncMB("twin", "inc");
        }
        private void RoomDecIncMB(string roomType, string option)
        {
            int maxSingle = Convert.ToInt32(lblSingleRoomAvailabilityNumMB.Text);
            int maxDouble = Convert.ToInt32(lblDoubleRoomAvailabilityNumMB.Text);
            int maxTwin = Convert.ToInt32(lblTwinRoomAvailabilityNumMB.Text);

            int singleRoomNum = Convert.ToInt32(lblCustomerSingleRoomNumberMB.Text);
            int doubleRoomNum = Convert.ToInt32(lblCustomerDoubleRoomNumberMB.Text);
            int twinRoomNum = Convert.ToInt32(lblCustomerTwinRoomNumberMB.Text);

            if (roomType == "single" && option == "dec")
            {
                singleRoomNum--;
                btnCustomerSingleRoomIncreaseMB.Enabled = true;
            }
            if (roomType == "single" && option == "inc")
            {
                singleRoomNum++;
                btnCustomerSingleRoomDecreaseMB.Enabled = true;
            }

            if (roomType == "double" && option == "dec")
            {
                doubleRoomNum--;
                btnCustomerDoubleRoomIncreaseMB.Enabled = true;
            }
            if (roomType == "double" && option == "inc")
            {
                doubleRoomNum++;
                btnCustomerDoubleRoomDecreaseMB.Enabled = true;
            }

            if (roomType == "twin" && option == "dec")
            {
                twinRoomNum--;
                btnCustomerTwinRoomIncreaseMB.Enabled = true;
            }
            if (roomType == "twin" && option == "inc")
            {
                twinRoomNum++;
                btnCustomerTwinRoomDecreaseMB.Enabled = true;
            }

            if (singleRoomNum >= 0)
                lblCustomerSingleRoomNumberMB.Text = singleRoomNum.ToString();
            if (doubleRoomNum >= 0)
                lblCustomerDoubleRoomNumberMB.Text = doubleRoomNum.ToString();
            if (twinRoomNum >= 0)
                lblCustomerTwinRoomNumberMB.Text = twinRoomNum.ToString();

            if (singleRoomNum <= 0)
                btnCustomerSingleRoomDecreaseMB.Enabled = false;
            if (singleRoomNum >= maxSingle)
                btnCustomerSingleRoomIncreaseMB.Enabled = false;

            if (doubleRoomNum <= 0)
                btnCustomerDoubleRoomDecreaseMB.Enabled = false;
            if (doubleRoomNum >= maxDouble)
                btnCustomerDoubleRoomIncreaseMB.Enabled = false;

            if (twinRoomNum <= 0)
                btnCustomerTwinRoomDecreaseMB.Enabled = false;
            if (twinRoomNum >= maxTwin)
                btnCustomerTwinRoomIncreaseMB.Enabled = false;
        }
        private void DisableModificationMB()
        {
            txtCustomerNameMB.Enabled = false;
            txtCutomerAddressMB.Enabled = false;
            txtCustomerPhoneNumMB.Enabled = false;
            txtCustomerEmailMB.Enabled = false;
            radioBtnMBCustomerMarketingConsentYES.Enabled = false;
            radioBtnMBCustomerMarketingConsentNO.Enabled = false;
            radioBtnMBCustomerSaveDetailsYES.Enabled = false;
            radioBtnMBCustomerSaveDetailsNO.Enabled = false;

            txtCustomerHolderNameMB.Enabled = false;
            txtCustomerCardNumberMB.Enabled = false;
            dtpCardExpityDateMB.Enabled = false;
            txtCardSecurityCodeMB.Enabled = false;
            radioBtnMBSaveCustomerCardDetailsYES.Enabled = false;
            radioBtnMBSaveCustomerCardDetailsNO.Enabled = false;

            dtpCustomerCheckInMB.Enabled = false;
            dtpCustomerCheckOutMB.Enabled = false;
            txtCustomerGuestNamesMB.Enabled = false;
            txtCustomerAdditionalNotesMB.Enabled = false;
            lblCustomerSingleRoomNumberMB.Enabled = false;
            lblCustomerDoubleRoomNumberMB.Enabled = false;
            lblCustomerTwinRoomNumberMB.Enabled = false;
            btnCustomerSingleRoomIncreaseMB.Enabled = false;
            btnCustomerSingleRoomDecreaseMB.Enabled = false;
            btnCustomerTwinRoomIncreaseMB.Enabled = false;
            btnCustomerTwinRoomDecreaseMB.Enabled = false;
            btnCustomerDoubleRoomIncreaseMB.Enabled = false;
            btnCustomerDoubleRoomDecreaseMB.Enabled = false;

            btnCancelBookingMB.Enabled = false;

            txtPhoneNumOrBookingIDSearchMB.Enabled = true;
            btnSearchMB.Enabled = true;
            btnCancelBookingMB.Enabled = true;
            btnClearMB.Enabled = true;
            btncancelModificationMB.Visible = false;
            btnSeachForBookingMB.Enabled = false;
        }
        private void btnCancelBookingMB_Click(object sender, EventArgs e)
        {
            if (listViewManageBooking.SelectedItems.Count > 0)
            {
                int index;
                const string message = "Are you sure you want to cancel the Booking?";
                const string caption = "Warning";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                double refund = 0;

                if (result == DialogResult.Yes)
                {
                    foreach (Booking booking in Model.BookingList)
                    {
                        if (booking.BookingID.ToString().Equals(txtBookingIdMB.Text))
                        {
                            index = Model.BookingList.IndexOf(booking);

                            if ((booking.CheckIn - DateTime.Now).TotalDays > 14)
                                refund = booking.Total;
                            if (((booking.CheckIn - DateTime.Now).TotalDays >= 7) && ((booking.CheckIn - DateTime.Now).TotalDays <= 14))
                                refund = booking.Total / 2;
                            if ((booking.CheckIn - DateTime.Now).TotalDays <= 7)
                                refund = 0;

                            int cancelledBookingID = (Model.CancelledBookingList.Count) + 1;

                            ICancelledBooking cancelledBooking = CancelledBookingFactory.GetCancelledBooking(cancelledBookingID,
                                booking.BookingID, booking.Guest.Name, booking.NumSingleRooms,
                                booking.NumDoubleRooms, booking.NumTwinRooms, booking.Total, refund);

                            Model.cancelBooking(cancelledBooking);
                            Model.deleteBooking(booking);
                            if (booking.Guest.CreditCard.SaveCardDetails.Equals(false))
                            {
                                Model.deleteCreditCard(booking.Guest.CreditCard);
                            }
                            if (booking.Guest.SaveCustomerDetails.Equals(false))
                            {
                                Model.deleteGuest(booking.Guest);
                            }
                            break;
                        }
                    }
                    GetBookingDetails();
                    ResetManageBooking();
                    MessageBox.Show("Booking has been Cancelled.\n\nThe refund is €" + Math.Round(refund, 2).ToString(), "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Please select a booking to Cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnSearchVB_Click(object sender, EventArgs e)
        {
            if (dtpToVB.Value > dtpFromVB.Value)
            {
                List<IBooking> bookings = Model.GetBookingWithRange(dtpFromVB.Value.ToString("yyyy-MM-dd"), dtpToVB.Value.ToString("yyyy-MM-dd"));
                GetBookingDetailsrForViewBookingTab(bookings);
            }
            else
            {
                MessageBox.Show("'From' date must be grater then the 'To' date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpCheckOutDate.Focus();
            }
        }
        private void btnResetVB_Click(object sender, EventArgs e)
        {
            dtpFromVB.Value = DateTime.Today;
            dtpToVB.Value = DateTime.Today;
            GetBookingDetailsrForViewBookingTab(Model.BookingList);
        }

        private void GetBookingDetailsrForViewBookingTab(List<IBooking> bookingList)
        {
            string marketingConsent, SaveCustomerDetails, checkedIn, checkedOut;
            listView_ViewBooking.Items.Clear();

            foreach (IBooking booking in bookingList)
            {
                if (booking.Guest.MarketingConsent)
                    marketingConsent = "Yes";
                else
                    marketingConsent = "No";

                if (booking.Guest.SaveCustomerDetails)
                    SaveCustomerDetails = "Yes";
                else
                    SaveCustomerDetails = "No";

                if (booking.CheckedIn)
                    checkedIn = "Yes";
                else
                    checkedIn = "No";

                if (booking.CheckedOut)
                    checkedOut = "Yes";
                else
                    checkedOut = "No";


                string rooms = "";
                foreach (IRoom room in booking.RoomList)                
                    rooms += room.roomType;                
                string roomList = string.Join(", ", rooms.ToArray());


                if (((booking.NumSingleRooms != 0) || (booking.NumDoubleRooms != 0) || (booking.NumTwinRooms != 0)) && (booking.CheckedOut.Equals(false)))
                {
                    listView_ViewBooking.Items.Add(new ListViewItem(new string[]
                    {
                        booking.BookingID.ToString(),
                        booking.CheckIn.ToShortDateString(),
                        booking.CheckOut.ToShortDateString(),
                        booking.GuestNames,
                        booking.AdditionalNotes,
                        booking.NumSingleRooms.ToString(),
                        booking.NumDoubleRooms.ToString(),
                        booking.NumTwinRooms.ToString(),
                        roomList + ".",
                        booking.Total.ToString(),
                        checkedIn,
                        checkedOut,
                        "",
                        booking.Guest.GuestID.ToString(),
                        booking.Guest.Name,
                        booking.Guest.Address,
                        booking.Guest.PhoneNumber,
                        booking.Guest.Email,
                        marketingConsent,
                        SaveCustomerDetails
                    }));
                }
            }
        }
        /// <summary>
        /// /////////////MARTIN//////////////////////
        /// </summary>
        private void GetCheckInDetails()
        {
            listViewCheckIn.Items.Clear();
            List<string> list;

            foreach (IBooking X in Model.BookingList)
            {
                list = new List<string>();
                if (X.NumSingleRooms != 0)
                {
                    list.Add("Single: " + X.NumSingleRooms.ToString());
                }
                if (X.NumDoubleRooms != 0)
                {
                    list.Add("Double: " + X.NumDoubleRooms.ToString());
                }
                if (X.NumTwinRooms != 0)
                {
                    list.Add("Twin: " + X.NumTwinRooms.ToString());
                }

                if (X.CheckedIn == false && X.CheckedOut == false)
                {
                    listViewCheckIn.Items.Add(new ListViewItem(new string[]
                    {
                        X.Guest.GuestID.ToString(),
                        X.BookingID.ToString(),
                        X.Guest.Name,
                        X.Guest.Address,
                        X.Guest.PhoneNumber,
                        X.CheckOut.ToShortDateString(),
                        string.Join(" ",list)
                    }
                    ));
                }

                list = null;

            }

            //foreach (IGuest X in Model.GuestList)
            //{
            //    List<string> list = new List<string>();
            //    if (X.Booking.NumSingleRooms != 0)
            //    {
            //        list.Add("Single: " + X.Booking.NumSingleRooms.ToString());
            //    }
            //    if (X.Booking.NumDoubleRooms != 0)
            //    {
            //        list.Add("Double: " + X.Booking.NumDoubleRooms.ToString());
            //    }
            //    if (X.Booking.NumTwinRooms != 0)
            //    {
            //        list.Add("Twin: " + X.Booking.NumTwinRooms.ToString());
            //    }

            //    if (X.Booking.CheckedIn == false && X.Booking.CheckedOut == false)
            //    {
            //        listViewCheckIn.Items.Add(new ListViewItem(new string[]
            //        {
            //            X.Booking.BookingID.ToString(),
            //            X.Name,
            //            X.Address,
            //            X.PhoneNumber,
            //            X.Booking.CheckOut.ToShortDateString(),
            //            string.Join(" ",list)
            //        }
            //        ));
            //    }
            //    list = null;
            //}
        }
        private void GetCheckOutDetails()
        {
            listViewCheckOut.Items.Clear();
            List<string> list;

            foreach (IBooking X in Model.BookingList)
            {
                list = new List<string>();

                if (X.NumSingleRooms != 0)
                {
                    list.Add("Single: " + X.NumSingleRooms.ToString());
                }
                if (X.NumDoubleRooms != 0)
                {
                    list.Add("Double: " + X.NumDoubleRooms.ToString());
                }
                if (X.NumTwinRooms != 0)
                {
                    list.Add("Twin: " + X.NumTwinRooms.ToString());
                }

                if (X.CheckedIn == true && X.CheckedOut == false)
                {
                    listViewCheckOut.Items.Add(new ListViewItem(new string[]
                        {
                            X.Guest.GuestID.ToString(),
                            X.BookingID.ToString(),
                            X.Guest.Name,
                            X.Guest.Address,
                            X.Guest.PhoneNumber,
                            string.Join(" ",list)
                        }
                        ));
                }
                list = null;

            }

            //foreach (IGuest X in Model.GuestList)
            //{
            //    list = new List<string>();

            //    if (X.Booking.NumSingleRooms != 0)
            //    {
            //        list.Add("Single: " + X.Booking.NumSingleRooms.ToString());
            //    }
            //    if (X.Booking.NumDoubleRooms != 0)
            //    {
            //        list.Add("Double: " + X.Booking.NumDoubleRooms.ToString());
            //    }
            //    if (X.Booking.NumTwinRooms != 0)
            //    {
            //        list.Add("Twin: " + X.Booking.NumTwinRooms.ToString());
            //    }

            //    if (X.Booking.CheckedIn == true && X.Booking.CheckedOut == false)
            //    {
            //        listViewCheckOut.Items.Add(new ListViewItem(new string[]
            //            {
            //                X.Name,
            //                X.Address,
            //                X.PhoneNumber,
            //                string.Join(" ",list)
            //            }
            //            ));
            //    }
            //    list = null;
            //}
        }
        private void CheckOutDetails_PhoneNumber()
        {
            listViewCheckOut.Items.Clear();
            List<string> list;

            foreach (IBooking X in Model.BookingList)
            {
                list = new List<string>();

                if (X.Guest.PhoneNumber == textBox1.Text)
                {
                    if (X.NumSingleRooms != 0)
                    {
                        list.Add("Single: " + X.NumSingleRooms.ToString());
                    }
                    if (X.NumDoubleRooms != 0)
                    {
                        list.Add("Double: " + X.NumDoubleRooms.ToString());
                    }
                    if (X.NumTwinRooms != 0)
                    {
                        list.Add("Twin: " + X.NumTwinRooms.ToString());
                    }

                    if (X.CheckedIn == true && X.CheckedOut == false)
                    {
                        listViewCheckOut.Items.Add(new ListViewItem(new string[]
                        {
                            X.Guest.GuestID.ToString(),
                            X.Guest.Name,
                            X.Guest.Address,
                            X.Guest.PhoneNumber,
                            string.Join(" ",list)
                        }
                        ));
                    }
                }
                list = null;
            }

            //foreach (IGuest X in Model.GuestList)
            //{
            //    list = new List<string>();

            //    if (X.PhoneNumber == textBox1.Text)
            //    {
            //        if (X.Booking.NumSingleRooms != 0)
            //        {
            //            list.Add("Single: " + X.Booking.NumSingleRooms.ToString());
            //        }
            //        if (X.Booking.NumDoubleRooms != 0)
            //        {
            //            list.Add("Double: " + X.Booking.NumDoubleRooms.ToString());
            //        }
            //        if (X.Booking.NumTwinRooms != 0)
            //        {
            //            list.Add("Twin: " + X.Booking.NumTwinRooms.ToString());
            //        }

            //        if (X.Booking.CheckedIn == true && X.Booking.CheckedOut == false)
            //        {
            //            listViewCheckOut.Items.Add(new ListViewItem(new string[]
            //                {
            //                X.Name,
            //                X.Address,
            //                X.PhoneNumber,
            //                string.Join(" ",list)
            //                }
            //                ));
            //        }
            //    }

            //    list = null;
            //}
        }
        private void GetRoomDetails()
        {
            listViewSingleRooms.Items.Clear();
            listViewDoubleRooms.Items.Clear();
            listViewTwinRooms.Items.Clear();
            listViewSelectedRooms.Items.Clear();
            string room;

            foreach (Room X in Model.RoomsList)
            {
                room = X.roomType.ToLower();
                string roomtype = string.Concat(room.Where(c => !char.IsWhiteSpace(c)));

                if (X.available == true)
                {

                    if (roomtype == "single")
                    {

                        listViewSingleRooms.Items.Add(new ListViewItem(new string[]
                        {
                            X.roomNumber.ToString()
                        }
                        ));
                    }
                    if (roomtype == "double")
                    {
                        listViewDoubleRooms.Items.Add(new ListViewItem(new string[]
                            {
                            X.roomNumber.ToString()
                            }
                            ));
                    }
                    if (roomtype == "twin")
                    {
                        listViewTwinRooms.Items.Add(new ListViewItem(new string[]
                            {
                            X.roomNumber.ToString()
                            }
                            ));
                    }
                }
            }
        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            //string ID = listViewCheckIn.SelectedItems[0].Text;
            string BookingID = "";

            foreach (ListViewItem item in listViewCheckIn.SelectedItems)
            {
                BookingID = item.SubItems[1].Text;
            }

            if (BookingID != null)
            {
                Booking Booking = new Booking();
                List<IBooking> list = Model.BookingList;
                List<IRoom> roomList = Model.RoomsList;
                List<IRoom> SelectedRoomList = new List<IRoom>();
                List<int> listofrooms = new List<int>();

                foreach (ListViewItem X in listViewSelectedRooms.SelectedItems)
                {
                    listofrooms.Add(Convert.ToInt32(X.SubItems[0].Text));
                }
                foreach (IRoom room in roomList)
                {
                    foreach (int item in listofrooms)
                    {
                        if (room.roomNumber == item)
                        {
                            SelectedRoomList.Add(room);
                        }
                    }
                }

                foreach (Booking X in list)
                {
                    if (X.BookingID.ToString() == BookingID)
                    {
                        X.RoomList = SelectedRoomList;
                        Booking = X;
                    }
                }

                Model.updateCheckIn(Booking);

                foreach (IRoom X in SelectedRoomList)
                {
                    X.CheckIn();
                }
                GetRoomDetails();
                GetCheckInDetails();
                GetCheckOutDetails();
            }
            else
            {
                MessageBox.Show("Please Selecte An Item");
            }
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //string GuestID = listViewCheckOut.SelectedItems[0].Text;

            string BookingID = "";

            foreach (ListViewItem item in listViewCheckOut.SelectedItems)
            {
                BookingID = item.SubItems[1].Text;
            }

            if (BookingID != null)
            {
                List<IRoom> roomlist;
                int index = 0;

                foreach (IBooking booking in Model.BookingList)
                {
                    if (booking.BookingID.ToString() == BookingID)
                    {
                        Model.updateCheckOut(booking);
                        //MessageBox.Show("Booking Table Was Updated");

                        if (booking.Guest.SaveCustomerDetails == false)
                        {
                            Model.deleteGuest(booking.Guest);
                            //MessageBox.Show("Guest Was Deleted");
                        }
                        if (booking.Guest.CreditCard.SaveCardDetails == false)
                        {
                            Model.deleteCreditCard(booking.Guest.CreditCard);
                            //MessageBox.Show("Credit Card Was Deleted");
                        }

                        roomlist = new List<IRoom>(booking.RoomList);

                        foreach (IRoom Y in roomlist)
                        {
                            Y.CheckOut();
                            //MessageBox.Show("RoomID :" + Y.RoomID + " Is Now Available");
                        }
                        roomlist = null;
                    }
                    index++;
                }
                GetRoomDetails();
                GetCheckInDetails();
                GetCheckOutDetails();
            }
            else
            {
                MessageBox.Show("Please Selecte An Item");
            }

            //string PhoneNumber = "";

            //foreach (ListViewItem listView  in listViewCheckOut.SelectedItems)
            //{
            //    PhoneNumber = listView.SubItems[2].Text;
            //}

            //if (PhoneNumber != null)
            //{
            //    List<IRoom> roomlist;
            //    int index = 0;

            //    foreach (IGuest X in Model.GuestList)
            //    {

            //        if (X.PhoneNumber == PhoneNumber)
            //        {
            //            Model.updateCheckOut(X.Booking);
            //            //MessageBox.Show("Booking Table Was Updated");

            //            if (X.CreditCard.SaveCardDetails == false)
            //            {
            //                Model.deleteCreditCard(X.CreditCard, index);
            //                //MessageBox.Show("Credit Card Was Deleted");
            //            }
            //            if (X.SaveCustomerDetails == false)
            //            {
            //                Model.deleteGuest(X);
            //                //MessageBox.Show("Guest Was Deleted");
            //            }

            //            roomlist = new List<IRoom>(X.Booking.RoomList);

            //            foreach (IRoom Y in roomlist)
            //            {
            //                Model.FreeUpRooms(Y);
            //                //MessageBox.Show("RoomID :" + Y.RoomID + " Is Now Available");
            //            }
            //            roomlist = null;
            //        }
            //        index++;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please Selecte An Item");
            //}

        }
        private void btnAddSingleRoom_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem X in listViewSingleRooms.SelectedItems)
            {
                listViewSingleRooms.Items.RemoveAt(X.Index);
                listViewSelectedRooms.Items.Add(X);
            }

        }
        private void btnAddDoubleRoom_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem Y in listViewDoubleRooms.SelectedItems)
            {
                listViewDoubleRooms.Items.RemoveAt(Y.Index);
                listViewSelectedRooms.Items.Add(Y);
            }

        }
        private void btnAddTwinRoom_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem Z in listViewTwinRooms.SelectedItems)
            {
                listViewTwinRooms.Items.RemoveAt(Z.Index);
                listViewSelectedRooms.Items.Add(Z);
            }

        }      

        private void btnRemoveSelectedRoom_Click(object sender, EventArgs e)
        {
            listViewSelectedRooms.Items.Clear();
            listViewSingleRooms.Items.Clear();
            listViewDoubleRooms.Items.Clear();
            listViewTwinRooms.Items.Clear();

            GetRoomDetails();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            CheckOutDetails_PhoneNumber();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            GetCheckOutDetails();
        }
    }
}
