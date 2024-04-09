using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class ExistingCustomerForm : Form
    {
        private formContainer fc;
        private IModel Model;
        public static bool ExistingGuest = false;
        public static bool creditCardFound = false;
        public ExistingCustomerForm(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhoneNum.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhoneNum.Text != "")
            {
                IGuest existingGuest = Model.CheckForExistingCustomer(txtName.Text, txtPhoneNum.Text);
                if (existingGuest != null && existingGuest.CreditCard != null)
                {
                    ExistingGuest = true;
                    ReceptionistForm.guestID.Text = existingGuest.GuestID.ToString();
                    ReceptionistForm.guestName.Text = existingGuest.Name;
                    ReceptionistForm.guestAddress.Text = existingGuest.Address;
                    ReceptionistForm.guestPhoneNumber.Text = existingGuest.PhoneNumber;
                    ReceptionistForm.guestEmail.Text = existingGuest.Email;

                    if (existingGuest.MarketingConsent)
                        ReceptionistForm.guestMarketingConsentYES.Checked = true;
                    else
                        ReceptionistForm.guestMarketingConsentNO.Checked = true;

                    if (existingGuest.SaveCustomerDetails)
                        ReceptionistForm.guestSaveCustomerDetailsConsentYES.Checked = true;
                    else
                        ReceptionistForm.guestSaveCustomerDetailsConsentNO.Checked = true;

                    foreach (CreditCard cc in Model.CreditCardList)
                    {
                        if (cc.CardNumber == existingGuest.CreditCard.CardNumber)
                            creditCardFound = true;
                    }
                    if (creditCardFound)
                    {
                        ReceptionistForm.guestCreditCardName.Text = existingGuest.CreditCard.HolderName;
                        ReceptionistForm.guestCreditCardNumber.Text = existingGuest.CreditCard.CardNumber;
                        ReceptionistForm.guestCreditCardExpiryDate.Value = existingGuest.CreditCard.ExpirDate;
                        ReceptionistForm.guestCreditCardSecurityCode.Text = existingGuest.CreditCard.SecurityCode;

                        if (existingGuest.CreditCard.SaveCardDetails)
                            ReceptionistForm.guestSaveCreditCardDetailsYES.Checked = true;
                        else
                            ReceptionistForm.guestSaveCreditCardDetailsNO.Checked = true;
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Guest does NOT exists.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Name and phone number are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
        }
    }
}
