
namespace WindowsClient
{
    partial class ReceptionistForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.columnHeaderBookingID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlReceptionist = new System.Windows.Forms.TabControl();
            this.tabPageCheckIn = new System.Windows.Forms.TabPage();
            this.listViewCheckIn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveSelectedRoom = new System.Windows.Forms.Button();
            this.btnAddTwinRoom = new System.Windows.Forms.Button();
            this.btnAddDoubleRoom = new System.Windows.Forms.Button();
            this.btnAddSingleRoom = new System.Windows.Forms.Button();
            this.listViewSelectedRooms = new System.Windows.Forms.ListView();
            this.columnHeaderSelectedRooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDoubleRooms = new System.Windows.Forms.ListView();
            this.columnHeaderDoubleRooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTwinRooms = new System.Windows.Forms.ListView();
            this.columnHeaderTwinRooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSingleRooms = new System.Windows.Forms.ListView();
            this.columnHeaderSingleRooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.tabPageCheckOut = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.listViewCheckOut = new System.Windows.Forms.ListView();
            this.columnHeaderCheckOutGuestID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNameCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddressCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhoneNumberCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRoomTypeCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.btnExistingCustomer = new System.Windows.Forms.Button();
            this.groupBoxBookingDetails = new System.Windows.Forms.GroupBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.btnSeachForBooking = new System.Windows.Forms.Button();
            this.groupBoxRoomaAvailabilityType = new System.Windows.Forms.GroupBox();
            this.lblTwinRoomAvailabilityNum = new System.Windows.Forms.Label();
            this.lblDoubleRoomAvailabilityNum = new System.Windows.Forms.Label();
            this.lblSingleRoomAvailabilityNum = new System.Windows.Forms.Label();
            this.lblTwinRoomAvailability = new System.Windows.Forms.Label();
            this.lblDoubleRoomAvailability = new System.Windows.Forms.Label();
            this.lblSingleRoomAvailability = new System.Windows.Forms.Label();
            this.txtAdditionalNotes = new System.Windows.Forms.TextBox();
            this.lblAdditionalNotes = new System.Windows.Forms.Label();
            this.btnTwinRoomIncrease = new System.Windows.Forms.Button();
            this.btnTwinRoomDecrease = new System.Windows.Forms.Button();
            this.lblTwinRoomNumber = new System.Windows.Forms.Label();
            this.btnDoubleRoomIncrease = new System.Windows.Forms.Button();
            this.btnDoubleRoomDecrease = new System.Windows.Forms.Button();
            this.lblDoubleRoomNumber = new System.Windows.Forms.Label();
            this.btnSingleRoomIncrease = new System.Windows.Forms.Button();
            this.btnSingleRoomDecrease = new System.Windows.Forms.Button();
            this.lblSingleRoomNumber = new System.Windows.Forms.Label();
            this.lblTwinRoom = new System.Windows.Forms.Label();
            this.lblDoubleRoom = new System.Windows.Forms.Label();
            this.lblSingleRoom = new System.Windows.Forms.Label();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.txtGuestNames = new System.Windows.Forms.TextBox();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxPaymentDetails = new System.Windows.Forms.GroupBox();
            this.radioBtnSaveCustomerCardDetailsNO = new System.Windows.Forms.RadioButton();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.radioBtnSaveCustomerCardDetailsYES = new System.Windows.Forms.RadioButton();
            this.lblSaveCustomerCardDetails = new System.Windows.Forms.Label();
            this.txtSecurityCode = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtHolderName = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblSecurityCode = new System.Windows.Forms.Label();
            this.lblHolderName = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.groupBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.txtGuestId = new System.Windows.Forms.TextBox();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.groupBoxSaveCustomerDetails = new System.Windows.Forms.GroupBox();
            this.radioBtnSaveCustomerDetailsNO = new System.Windows.Forms.RadioButton();
            this.radioBtnSaveCustomerDetailsYES = new System.Windows.Forms.RadioButton();
            this.groupBoxMarketingConsent = new System.Windows.Forms.GroupBox();
            this.radioBtnMarketingConsentYES = new System.Windows.Forms.RadioButton();
            this.radioBtnMarketingConsentNO = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tabPageViewBooking = new System.Windows.Forms.TabPage();
            this.groupBoxSearchVB = new System.Windows.Forms.GroupBox();
            this.btnResetVB = new System.Windows.Forms.Button();
            this.btnSearchVB = new System.Windows.Forms.Button();
            this.lblToVB = new System.Windows.Forms.Label();
            this.dtpToVB = new System.Windows.Forms.DateTimePicker();
            this.lblFromVB = new System.Windows.Forms.Label();
            this.dtpFromVB = new System.Windows.Forms.DateTimePicker();
            this.listView_ViewBooking = new System.Windows.Forms.ListView();
            this.columnHeaderBookingIdVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCheckInVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCheckOutVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestNamesVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdditionalNotesVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumSingleVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDoubleRoomVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTwinRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRoomListVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTotalVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCheckedInVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCheckedOutVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmpty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestIDVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestNameVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestAddressVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestPhoneVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestEmailVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestMarketingConsentVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestSaveDetailsVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageCancelBooking = new System.Windows.Forms.TabPage();
            this.btnClearMB = new System.Windows.Forms.Button();
            this.btncancelModificationMB = new System.Windows.Forms.Button();
            this.btnSearchMB = new System.Windows.Forms.Button();
            this.lblPhoneNumberOrBookingiDSearchMB = new System.Windows.Forms.Label();
            this.txtPhoneNumOrBookingIDSearchMB = new System.Windows.Forms.TextBox();
            this.btnCancelBookingMB = new System.Windows.Forms.Button();
            this.btnEditMB = new System.Windows.Forms.Button();
            this.groupBoxCustomerPaymentMB = new System.Windows.Forms.GroupBox();
            this.radioBtnMBSaveCustomerCardDetailsNO = new System.Windows.Forms.RadioButton();
            this.dtpCardExpityDateMB = new System.Windows.Forms.DateTimePicker();
            this.radioBtnMBSaveCustomerCardDetailsYES = new System.Windows.Forms.RadioButton();
            this.lblCustomerSavePaymentMB = new System.Windows.Forms.Label();
            this.txtCardSecurityCodeMB = new System.Windows.Forms.TextBox();
            this.txtCustomerCardNumberMB = new System.Windows.Forms.TextBox();
            this.txtCustomerHolderNameMB = new System.Windows.Forms.TextBox();
            this.lblCustomerCardNumMB = new System.Windows.Forms.Label();
            this.lblCustomerSecurityCodeMB = new System.Windows.Forms.Label();
            this.lblCustomerHolderNameMB = new System.Windows.Forms.Label();
            this.lblCustomerExpiryDateMB = new System.Windows.Forms.Label();
            this.groupBoxCustomerBookingMB = new System.Windows.Forms.GroupBox();
            this.btnSeachForBookingMB = new System.Windows.Forms.Button();
            this.groupBoxRoomaAvailabilityTypeMB = new System.Windows.Forms.GroupBox();
            this.lblTwinRoomAvailabilityNumMB = new System.Windows.Forms.Label();
            this.lblDoubleRoomAvailabilityNumMB = new System.Windows.Forms.Label();
            this.lblSingleRoomAvailabilityNumMB = new System.Windows.Forms.Label();
            this.lblTwinRoomAvailabilityMB = new System.Windows.Forms.Label();
            this.lblDoubleRoomAvailabilityMB = new System.Windows.Forms.Label();
            this.lblSingleRoomAvailabilityMB = new System.Windows.Forms.Label();
            this.txtBookingIdMB = new System.Windows.Forms.TextBox();
            this.lblBookingIdMB = new System.Windows.Forms.Label();
            this.txtCustomerAdditionalNotesMB = new System.Windows.Forms.TextBox();
            this.lblCustomerAdditionalNotesMB = new System.Windows.Forms.Label();
            this.btnCustomerTwinRoomIncreaseMB = new System.Windows.Forms.Button();
            this.btnCustomerTwinRoomDecreaseMB = new System.Windows.Forms.Button();
            this.lblCustomerTwinRoomNumberMB = new System.Windows.Forms.Label();
            this.btnCustomerDoubleRoomIncreaseMB = new System.Windows.Forms.Button();
            this.btnCustomerDoubleRoomDecreaseMB = new System.Windows.Forms.Button();
            this.lblCustomerDoubleRoomNumberMB = new System.Windows.Forms.Label();
            this.btnCustomerSingleRoomIncreaseMB = new System.Windows.Forms.Button();
            this.btnCustomerSingleRoomDecreaseMB = new System.Windows.Forms.Button();
            this.lblCustomerSingleRoomNumberMB = new System.Windows.Forms.Label();
            this.lblCustomerTwinRoomMB = new System.Windows.Forms.Label();
            this.lblCustomerDoubleRoomMB = new System.Windows.Forms.Label();
            this.lblCustomerSingleRoomMB = new System.Windows.Forms.Label();
            this.dtpCustomerCheckOutMB = new System.Windows.Forms.DateTimePicker();
            this.dtpCustomerCheckInMB = new System.Windows.Forms.DateTimePicker();
            this.lblCustomerCheckInMB = new System.Windows.Forms.Label();
            this.txtCustomerGuestNamesMB = new System.Windows.Forms.TextBox();
            this.lblCustomerGuestNamesMB = new System.Windows.Forms.Label();
            this.lblCustomerCheckOutMB = new System.Windows.Forms.Label();
            this.groupBoxCustomerdetailsMB = new System.Windows.Forms.GroupBox();
            this.txtGuestIdMB = new System.Windows.Forms.TextBox();
            this.lblGuestIdMB = new System.Windows.Forms.Label();
            this.groupBoxSaveCustomerDetailsMB = new System.Windows.Forms.GroupBox();
            this.radioBtnMBCustomerSaveDetailsNO = new System.Windows.Forms.RadioButton();
            this.radioBtnMBCustomerSaveDetailsYES = new System.Windows.Forms.RadioButton();
            this.groupBoxMarketingConsentMB = new System.Windows.Forms.GroupBox();
            this.radioBtnMBCustomerMarketingConsentNO = new System.Windows.Forms.RadioButton();
            this.radioBtnMBCustomerMarketingConsentYES = new System.Windows.Forms.RadioButton();
            this.txtCustomerNameMB = new System.Windows.Forms.TextBox();
            this.txtCustomerEmailMB = new System.Windows.Forms.TextBox();
            this.lblCustomerNameMB = new System.Windows.Forms.Label();
            this.txtCustomerPhoneNumMB = new System.Windows.Forms.TextBox();
            this.lblCutomerPhoneNumMB = new System.Windows.Forms.Label();
            this.txtCutomerAddressMB = new System.Windows.Forms.TextBox();
            this.lblCustomerAddressMB = new System.Windows.Forms.Label();
            this.lblCustomerEmailMB = new System.Windows.Forms.Label();
            this.listViewManageBooking = new System.Windows.Forms.ListView();
            this.columnHeaderManageName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderManageAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderManagePhoneNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderManageEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderManageMarktingConsent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderManageSaveCusDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPaymentHolderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPaymentCardNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPaymentExpiryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPaymentSecurityCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPaymentSaveDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookingCheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookingCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookingGusetNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookingAdditionalNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookingSingleRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookingDoubleRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookingTwinRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookingTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGuestID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageLogOut = new System.Windows.Forms.TabPage();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControlReceptionist.SuspendLayout();
            this.tabPageCheckIn.SuspendLayout();
            this.tabPageCheckOut.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            this.groupBoxBookingDetails.SuspendLayout();
            this.groupBoxRoomaAvailabilityType.SuspendLayout();
            this.groupBoxPaymentDetails.SuspendLayout();
            this.groupBoxCustomerDetails.SuspendLayout();
            this.groupBoxSaveCustomerDetails.SuspendLayout();
            this.groupBoxMarketingConsent.SuspendLayout();
            this.tabPageViewBooking.SuspendLayout();
            this.groupBoxSearchVB.SuspendLayout();
            this.tabPageCancelBooking.SuspendLayout();
            this.groupBoxCustomerPaymentMB.SuspendLayout();
            this.groupBoxCustomerBookingMB.SuspendLayout();
            this.groupBoxRoomaAvailabilityTypeMB.SuspendLayout();
            this.groupBoxCustomerdetailsMB.SuspendLayout();
            this.groupBoxSaveCustomerDetailsMB.SuspendLayout();
            this.groupBoxMarketingConsentMB.SuspendLayout();
            this.tabPageLogOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeaderBookingID
            // 
            this.columnHeaderBookingID.Text = "Booking ID";
            this.columnHeaderBookingID.Width = 0;
            // 
            // tabControlReceptionist
            // 
            this.tabControlReceptionist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlReceptionist.Controls.Add(this.tabPageCheckIn);
            this.tabControlReceptionist.Controls.Add(this.tabPageCheckOut);
            this.tabControlReceptionist.Controls.Add(this.tabPageBook);
            this.tabControlReceptionist.Controls.Add(this.tabPageViewBooking);
            this.tabControlReceptionist.Controls.Add(this.tabPageCancelBooking);
            this.tabControlReceptionist.Controls.Add(this.tabPageLogOut);
            this.tabControlReceptionist.Location = new System.Drawing.Point(1, 2);
            this.tabControlReceptionist.Name = "tabControlReceptionist";
            this.tabControlReceptionist.SelectedIndex = 0;
            this.tabControlReceptionist.Size = new System.Drawing.Size(992, 574);
            this.tabControlReceptionist.TabIndex = 0;
            this.tabControlReceptionist.SelectedIndexChanged += new System.EventHandler(this.tabSelected);
            // 
            // tabPageCheckIn
            // 
            this.tabPageCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageCheckIn.Controls.Add(this.listViewCheckIn);
            this.tabPageCheckIn.Controls.Add(this.btnRemoveSelectedRoom);
            this.tabPageCheckIn.Controls.Add(this.btnAddTwinRoom);
            this.tabPageCheckIn.Controls.Add(this.btnAddDoubleRoom);
            this.tabPageCheckIn.Controls.Add(this.btnAddSingleRoom);
            this.tabPageCheckIn.Controls.Add(this.listViewSelectedRooms);
            this.tabPageCheckIn.Controls.Add(this.listViewDoubleRooms);
            this.tabPageCheckIn.Controls.Add(this.listViewTwinRooms);
            this.tabPageCheckIn.Controls.Add(this.listViewSingleRooms);
            this.tabPageCheckIn.Controls.Add(this.btnCheckIn);
            this.tabPageCheckIn.Location = new System.Drawing.Point(4, 22);
            this.tabPageCheckIn.Name = "tabPageCheckIn";
            this.tabPageCheckIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheckIn.Size = new System.Drawing.Size(984, 548);
            this.tabPageCheckIn.TabIndex = 0;
            this.tabPageCheckIn.Text = "Check-in";
            // 
            // listViewCheckIn
            // 
            this.listViewCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCheckIn.BackColor = System.Drawing.Color.White;
            this.listViewCheckIn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeaderID,
            this.columnHeaderName,
            this.columnHeaderAddress,
            this.columnHeaderPhoneNumber,
            this.columnHeaderCheckOut,
            this.columnHeaderRoomType});
            this.listViewCheckIn.FullRowSelect = true;
            this.listViewCheckIn.GridLines = true;
            this.listViewCheckIn.HideSelection = false;
            this.listViewCheckIn.Location = new System.Drawing.Point(0, 0);
            this.listViewCheckIn.MultiSelect = false;
            this.listViewCheckIn.Name = "listViewCheckIn";
            this.listViewCheckIn.Size = new System.Drawing.Size(988, 392);
            this.listViewCheckIn.TabIndex = 38;
            this.listViewCheckIn.UseCompatibleStateImageBehavior = false;
            this.listViewCheckIn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Guest ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "Booking ID";
            this.columnHeaderID.Width = 80;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 150;
            // 
            // columnHeaderAddress
            // 
            this.columnHeaderAddress.Text = "Address";
            this.columnHeaderAddress.Width = 200;
            // 
            // columnHeaderPhoneNumber
            // 
            this.columnHeaderPhoneNumber.Text = "Phone Number";
            this.columnHeaderPhoneNumber.Width = 100;
            // 
            // columnHeaderCheckOut
            // 
            this.columnHeaderCheckOut.Text = "Check-out";
            this.columnHeaderCheckOut.Width = 100;
            // 
            // columnHeaderRoomType
            // 
            this.columnHeaderRoomType.Text = "Room Type";
            this.columnHeaderRoomType.Width = 418;
            // 
            // btnRemoveSelectedRoom
            // 
            this.btnRemoveSelectedRoom.BackColor = System.Drawing.Color.Maroon;
            this.btnRemoveSelectedRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelectedRoom.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelectedRoom.Location = new System.Drawing.Point(511, 436);
            this.btnRemoveSelectedRoom.Name = "btnRemoveSelectedRoom";
            this.btnRemoveSelectedRoom.Size = new System.Drawing.Size(31, 26);
            this.btnRemoveSelectedRoom.TabIndex = 37;
            this.btnRemoveSelectedRoom.Text = "<<";
            this.btnRemoveSelectedRoom.UseVisualStyleBackColor = false;
            this.btnRemoveSelectedRoom.Click += new System.EventHandler(this.btnRemoveSelectedRoom_Click);
            // 
            // btnAddTwinRoom
            // 
            this.btnAddTwinRoom.BackColor = System.Drawing.Color.Maroon;
            this.btnAddTwinRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTwinRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddTwinRoom.Location = new System.Drawing.Point(434, 465);
            this.btnAddTwinRoom.Name = "btnAddTwinRoom";
            this.btnAddTwinRoom.Size = new System.Drawing.Size(31, 26);
            this.btnAddTwinRoom.TabIndex = 36;
            this.btnAddTwinRoom.Text = ">>";
            this.btnAddTwinRoom.UseVisualStyleBackColor = false;
            this.btnAddTwinRoom.Click += new System.EventHandler(this.btnAddTwinRoom_Click);
            // 
            // btnAddDoubleRoom
            // 
            this.btnAddDoubleRoom.BackColor = System.Drawing.Color.Maroon;
            this.btnAddDoubleRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDoubleRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddDoubleRoom.Location = new System.Drawing.Point(279, 465);
            this.btnAddDoubleRoom.Name = "btnAddDoubleRoom";
            this.btnAddDoubleRoom.Size = new System.Drawing.Size(31, 26);
            this.btnAddDoubleRoom.TabIndex = 35;
            this.btnAddDoubleRoom.Text = ">>";
            this.btnAddDoubleRoom.UseVisualStyleBackColor = false;
            this.btnAddDoubleRoom.Click += new System.EventHandler(this.btnAddDoubleRoom_Click);
            // 
            // btnAddSingleRoom
            // 
            this.btnAddSingleRoom.BackColor = System.Drawing.Color.Maroon;
            this.btnAddSingleRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSingleRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddSingleRoom.Location = new System.Drawing.Point(107, 465);
            this.btnAddSingleRoom.Name = "btnAddSingleRoom";
            this.btnAddSingleRoom.Size = new System.Drawing.Size(31, 26);
            this.btnAddSingleRoom.TabIndex = 34;
            this.btnAddSingleRoom.Text = ">>";
            this.btnAddSingleRoom.UseVisualStyleBackColor = false;
            this.btnAddSingleRoom.Click += new System.EventHandler(this.btnAddSingleRoom_Click);
            // 
            // listViewSelectedRooms
            // 
            this.listViewSelectedRooms.BackColor = System.Drawing.Color.White;
            this.listViewSelectedRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSelectedRooms});
            this.listViewSelectedRooms.GridLines = true;
            this.listViewSelectedRooms.HideSelection = false;
            this.listViewSelectedRooms.Location = new System.Drawing.Point(547, 398);
            this.listViewSelectedRooms.Name = "listViewSelectedRooms";
            this.listViewSelectedRooms.Size = new System.Drawing.Size(109, 91);
            this.listViewSelectedRooms.TabIndex = 33;
            this.listViewSelectedRooms.UseCompatibleStateImageBehavior = false;
            this.listViewSelectedRooms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSelectedRooms
            // 
            this.columnHeaderSelectedRooms.Text = "Selected Rooms";
            this.columnHeaderSelectedRooms.Width = 100;
            // 
            // listViewDoubleRooms
            // 
            this.listViewDoubleRooms.BackColor = System.Drawing.Color.White;
            this.listViewDoubleRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDoubleRooms});
            this.listViewDoubleRooms.GridLines = true;
            this.listViewDoubleRooms.HideSelection = false;
            this.listViewDoubleRooms.Location = new System.Drawing.Point(169, 398);
            this.listViewDoubleRooms.Name = "listViewDoubleRooms";
            this.listViewDoubleRooms.Size = new System.Drawing.Size(109, 91);
            this.listViewDoubleRooms.TabIndex = 32;
            this.listViewDoubleRooms.UseCompatibleStateImageBehavior = false;
            this.listViewDoubleRooms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDoubleRooms
            // 
            this.columnHeaderDoubleRooms.Text = "Double Rooms";
            this.columnHeaderDoubleRooms.Width = 95;
            // 
            // listViewTwinRooms
            // 
            this.listViewTwinRooms.BackColor = System.Drawing.Color.White;
            this.listViewTwinRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTwinRooms});
            this.listViewTwinRooms.GridLines = true;
            this.listViewTwinRooms.HideSelection = false;
            this.listViewTwinRooms.Location = new System.Drawing.Point(339, 398);
            this.listViewTwinRooms.Name = "listViewTwinRooms";
            this.listViewTwinRooms.Size = new System.Drawing.Size(93, 91);
            this.listViewTwinRooms.TabIndex = 31;
            this.listViewTwinRooms.UseCompatibleStateImageBehavior = false;
            this.listViewTwinRooms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTwinRooms
            // 
            this.columnHeaderTwinRooms.Text = "Twin Rooms";
            this.columnHeaderTwinRooms.Width = 80;
            // 
            // listViewSingleRooms
            // 
            this.listViewSingleRooms.BackColor = System.Drawing.Color.White;
            this.listViewSingleRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSingleRooms});
            this.listViewSingleRooms.GridLines = true;
            this.listViewSingleRooms.HideSelection = false;
            this.listViewSingleRooms.Location = new System.Drawing.Point(6, 398);
            this.listViewSingleRooms.Name = "listViewSingleRooms";
            this.listViewSingleRooms.Size = new System.Drawing.Size(100, 91);
            this.listViewSingleRooms.TabIndex = 30;
            this.listViewSingleRooms.UseCompatibleStateImageBehavior = false;
            this.listViewSingleRooms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSingleRooms
            // 
            this.columnHeaderSingleRooms.Text = "Single Rooms";
            this.columnHeaderSingleRooms.Width = 85;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Maroon;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(760, 411);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(121, 60);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check-in";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // tabPageCheckOut
            // 
            this.tabPageCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageCheckOut.Controls.Add(this.btnClear);
            this.tabPageCheckOut.Controls.Add(this.btnSearch);
            this.tabPageCheckOut.Controls.Add(this.textBox1);
            this.tabPageCheckOut.Controls.Add(this.label1);
            this.tabPageCheckOut.Controls.Add(this.btnCheckOut);
            this.tabPageCheckOut.Controls.Add(this.listViewCheckOut);
            this.tabPageCheckOut.Location = new System.Drawing.Point(4, 22);
            this.tabPageCheckOut.Name = "tabPageCheckOut";
            this.tabPageCheckOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheckOut.Size = new System.Drawing.Size(984, 548);
            this.tabPageCheckOut.TabIndex = 1;
            this.tabPageCheckOut.Text = "Check-out";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(673, 181);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Maroon;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(797, 181);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(673, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(717, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Phone Number:";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Maroon;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 38F);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(632, 234);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(284, 121);
            this.btnCheckOut.TabIndex = 11;
            this.btnCheckOut.Text = "Check-out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // listViewCheckOut
            // 
            this.listViewCheckOut.BackColor = System.Drawing.Color.White;
            this.listViewCheckOut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCheckOutGuestID,
            this.columnHeader2,
            this.columnHeaderNameCheckOut,
            this.columnHeaderAddressCheckOut,
            this.columnHeaderPhoneNumberCheckOut,
            this.columnHeaderRoomTypeCheckOut});
            this.listViewCheckOut.FullRowSelect = true;
            this.listViewCheckOut.GridLines = true;
            this.listViewCheckOut.HideSelection = false;
            this.listViewCheckOut.Location = new System.Drawing.Point(-3, 0);
            this.listViewCheckOut.MultiSelect = false;
            this.listViewCheckOut.Name = "listViewCheckOut";
            this.listViewCheckOut.Size = new System.Drawing.Size(561, 503);
            this.listViewCheckOut.TabIndex = 10;
            this.listViewCheckOut.UseCompatibleStateImageBehavior = false;
            this.listViewCheckOut.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCheckOutGuestID
            // 
            this.columnHeaderCheckOutGuestID.Text = "Guest ID";
            this.columnHeaderCheckOutGuestID.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Booking ID";
            this.columnHeader2.Width = 80;
            // 
            // columnHeaderNameCheckOut
            // 
            this.columnHeaderNameCheckOut.Text = "Name";
            this.columnHeaderNameCheckOut.Width = 100;
            // 
            // columnHeaderAddressCheckOut
            // 
            this.columnHeaderAddressCheckOut.Text = "Address";
            this.columnHeaderAddressCheckOut.Width = 150;
            // 
            // columnHeaderPhoneNumberCheckOut
            // 
            this.columnHeaderPhoneNumberCheckOut.Text = "Phone Number";
            this.columnHeaderPhoneNumberCheckOut.Width = 100;
            // 
            // columnHeaderRoomTypeCheckOut
            // 
            this.columnHeaderRoomTypeCheckOut.Text = "Room Type";
            this.columnHeaderRoomTypeCheckOut.Width = 418;
            // 
            // tabPageBook
            // 
            this.tabPageBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageBook.Controls.Add(this.btnExistingCustomer);
            this.tabPageBook.Controls.Add(this.groupBoxBookingDetails);
            this.tabPageBook.Controls.Add(this.btnCreate);
            this.tabPageBook.Controls.Add(this.btnCancel);
            this.tabPageBook.Controls.Add(this.groupBoxPaymentDetails);
            this.tabPageBook.Controls.Add(this.groupBoxCustomerDetails);
            this.tabPageBook.Location = new System.Drawing.Point(4, 22);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(984, 548);
            this.tabPageBook.TabIndex = 3;
            this.tabPageBook.Text = "Book";
            // 
            // btnExistingCustomer
            // 
            this.btnExistingCustomer.BackColor = System.Drawing.Color.Maroon;
            this.btnExistingCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExistingCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExistingCustomer.ForeColor = System.Drawing.Color.White;
            this.btnExistingCustomer.Location = new System.Drawing.Point(479, 437);
            this.btnExistingCustomer.Name = "btnExistingCustomer";
            this.btnExistingCustomer.Size = new System.Drawing.Size(139, 48);
            this.btnExistingCustomer.TabIndex = 21;
            this.btnExistingCustomer.Text = "Existing Customer";
            this.btnExistingCustomer.UseVisualStyleBackColor = false;
            this.btnExistingCustomer.Click += new System.EventHandler(this.btnExistingCustomer_Click);
            // 
            // groupBoxBookingDetails
            // 
            this.groupBoxBookingDetails.Controls.Add(this.txtBookingID);
            this.groupBoxBookingDetails.Controls.Add(this.lblBookingID);
            this.groupBoxBookingDetails.Controls.Add(this.btnSeachForBooking);
            this.groupBoxBookingDetails.Controls.Add(this.groupBoxRoomaAvailabilityType);
            this.groupBoxBookingDetails.Controls.Add(this.txtAdditionalNotes);
            this.groupBoxBookingDetails.Controls.Add(this.lblAdditionalNotes);
            this.groupBoxBookingDetails.Controls.Add(this.btnTwinRoomIncrease);
            this.groupBoxBookingDetails.Controls.Add(this.btnTwinRoomDecrease);
            this.groupBoxBookingDetails.Controls.Add(this.lblTwinRoomNumber);
            this.groupBoxBookingDetails.Controls.Add(this.btnDoubleRoomIncrease);
            this.groupBoxBookingDetails.Controls.Add(this.btnDoubleRoomDecrease);
            this.groupBoxBookingDetails.Controls.Add(this.lblDoubleRoomNumber);
            this.groupBoxBookingDetails.Controls.Add(this.btnSingleRoomIncrease);
            this.groupBoxBookingDetails.Controls.Add(this.btnSingleRoomDecrease);
            this.groupBoxBookingDetails.Controls.Add(this.lblSingleRoomNumber);
            this.groupBoxBookingDetails.Controls.Add(this.lblTwinRoom);
            this.groupBoxBookingDetails.Controls.Add(this.lblDoubleRoom);
            this.groupBoxBookingDetails.Controls.Add(this.lblSingleRoom);
            this.groupBoxBookingDetails.Controls.Add(this.dtpCheckOutDate);
            this.groupBoxBookingDetails.Controls.Add(this.dtpCheckInDate);
            this.groupBoxBookingDetails.Controls.Add(this.lblCheckInDate);
            this.groupBoxBookingDetails.Controls.Add(this.txtGuestNames);
            this.groupBoxBookingDetails.Controls.Add(this.lblGuestName);
            this.groupBoxBookingDetails.Controls.Add(this.lblCheckOutDate);
            this.groupBoxBookingDetails.Location = new System.Drawing.Point(413, 9);
            this.groupBoxBookingDetails.Name = "groupBoxBookingDetails";
            this.groupBoxBookingDetails.Size = new System.Drawing.Size(470, 403);
            this.groupBoxBookingDetails.TabIndex = 20;
            this.groupBoxBookingDetails.TabStop = false;
            this.groupBoxBookingDetails.Text = "Booking Details";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Enabled = false;
            this.txtBookingID.Location = new System.Drawing.Point(94, 18);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(370, 20);
            this.txtBookingID.TabIndex = 37;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(7, 21);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(60, 13);
            this.lblBookingID.TabIndex = 36;
            this.lblBookingID.Text = "Booking ID";
            // 
            // btnSeachForBooking
            // 
            this.btnSeachForBooking.BackColor = System.Drawing.Color.Maroon;
            this.btnSeachForBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeachForBooking.ForeColor = System.Drawing.Color.White;
            this.btnSeachForBooking.Location = new System.Drawing.Point(361, 124);
            this.btnSeachForBooking.Name = "btnSeachForBooking";
            this.btnSeachForBooking.Size = new System.Drawing.Size(103, 56);
            this.btnSeachForBooking.TabIndex = 35;
            this.btnSeachForBooking.Text = "Search";
            this.btnSeachForBooking.UseVisualStyleBackColor = false;
            this.btnSeachForBooking.Click += new System.EventHandler(this.btnSeachForBooking_Click);
            // 
            // groupBoxRoomaAvailabilityType
            // 
            this.groupBoxRoomaAvailabilityType.Controls.Add(this.lblTwinRoomAvailabilityNum);
            this.groupBoxRoomaAvailabilityType.Controls.Add(this.lblDoubleRoomAvailabilityNum);
            this.groupBoxRoomaAvailabilityType.Controls.Add(this.lblSingleRoomAvailabilityNum);
            this.groupBoxRoomaAvailabilityType.Controls.Add(this.lblTwinRoomAvailability);
            this.groupBoxRoomaAvailabilityType.Controls.Add(this.lblDoubleRoomAvailability);
            this.groupBoxRoomaAvailabilityType.Controls.Add(this.lblSingleRoomAvailability);
            this.groupBoxRoomaAvailabilityType.Location = new System.Drawing.Point(10, 116);
            this.groupBoxRoomaAvailabilityType.Name = "groupBoxRoomaAvailabilityType";
            this.groupBoxRoomaAvailabilityType.Size = new System.Drawing.Size(344, 62);
            this.groupBoxRoomaAvailabilityType.TabIndex = 22;
            this.groupBoxRoomaAvailabilityType.TabStop = false;
            this.groupBoxRoomaAvailabilityType.Text = "Rooms Availability";
            // 
            // lblTwinRoomAvailabilityNum
            // 
            this.lblTwinRoomAvailabilityNum.AutoSize = true;
            this.lblTwinRoomAvailabilityNum.Location = new System.Drawing.Point(257, 29);
            this.lblTwinRoomAvailabilityNum.Name = "lblTwinRoomAvailabilityNum";
            this.lblTwinRoomAvailabilityNum.Size = new System.Drawing.Size(13, 13);
            this.lblTwinRoomAvailabilityNum.TabIndex = 37;
            this.lblTwinRoomAvailabilityNum.Text = "0";
            // 
            // lblDoubleRoomAvailabilityNum
            // 
            this.lblDoubleRoomAvailabilityNum.AutoSize = true;
            this.lblDoubleRoomAvailabilityNum.Location = new System.Drawing.Point(182, 29);
            this.lblDoubleRoomAvailabilityNum.Name = "lblDoubleRoomAvailabilityNum";
            this.lblDoubleRoomAvailabilityNum.Size = new System.Drawing.Size(13, 13);
            this.lblDoubleRoomAvailabilityNum.TabIndex = 36;
            this.lblDoubleRoomAvailabilityNum.Text = "0";
            // 
            // lblSingleRoomAvailabilityNum
            // 
            this.lblSingleRoomAvailabilityNum.AutoSize = true;
            this.lblSingleRoomAvailabilityNum.Location = new System.Drawing.Point(106, 29);
            this.lblSingleRoomAvailabilityNum.Name = "lblSingleRoomAvailabilityNum";
            this.lblSingleRoomAvailabilityNum.Size = new System.Drawing.Size(13, 13);
            this.lblSingleRoomAvailabilityNum.TabIndex = 35;
            this.lblSingleRoomAvailabilityNum.Text = "0";
            // 
            // lblTwinRoomAvailability
            // 
            this.lblTwinRoomAvailability.AutoSize = true;
            this.lblTwinRoomAvailability.Location = new System.Drawing.Point(209, 29);
            this.lblTwinRoomAvailability.Name = "lblTwinRoomAvailability";
            this.lblTwinRoomAvailability.Size = new System.Drawing.Size(33, 13);
            this.lblTwinRoomAvailability.TabIndex = 35;
            this.lblTwinRoomAvailability.Text = "Twin:";
            // 
            // lblDoubleRoomAvailability
            // 
            this.lblDoubleRoomAvailability.AutoSize = true;
            this.lblDoubleRoomAvailability.Location = new System.Drawing.Point(132, 29);
            this.lblDoubleRoomAvailability.Name = "lblDoubleRoomAvailability";
            this.lblDoubleRoomAvailability.Size = new System.Drawing.Size(44, 13);
            this.lblDoubleRoomAvailability.TabIndex = 35;
            this.lblDoubleRoomAvailability.Text = "Double:";
            // 
            // lblSingleRoomAvailability
            // 
            this.lblSingleRoomAvailability.AutoSize = true;
            this.lblSingleRoomAvailability.Location = new System.Drawing.Point(61, 29);
            this.lblSingleRoomAvailability.Name = "lblSingleRoomAvailability";
            this.lblSingleRoomAvailability.Size = new System.Drawing.Size(39, 13);
            this.lblSingleRoomAvailability.TabIndex = 35;
            this.lblSingleRoomAvailability.Text = "Single:";
            // 
            // txtAdditionalNotes
            // 
            this.txtAdditionalNotes.Location = new System.Drawing.Point(93, 260);
            this.txtAdditionalNotes.Multiline = true;
            this.txtAdditionalNotes.Name = "txtAdditionalNotes";
            this.txtAdditionalNotes.Size = new System.Drawing.Size(371, 92);
            this.txtAdditionalNotes.TabIndex = 34;
            // 
            // lblAdditionalNotes
            // 
            this.lblAdditionalNotes.AutoSize = true;
            this.lblAdditionalNotes.Location = new System.Drawing.Point(6, 263);
            this.lblAdditionalNotes.Name = "lblAdditionalNotes";
            this.lblAdditionalNotes.Size = new System.Drawing.Size(87, 13);
            this.lblAdditionalNotes.TabIndex = 33;
            this.lblAdditionalNotes.Text = "Additional Notes:";
            // 
            // btnTwinRoomIncrease
            // 
            this.btnTwinRoomIncrease.BackColor = System.Drawing.Color.Maroon;
            this.btnTwinRoomIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwinRoomIncrease.ForeColor = System.Drawing.Color.White;
            this.btnTwinRoomIncrease.Location = new System.Drawing.Point(407, 372);
            this.btnTwinRoomIncrease.Name = "btnTwinRoomIncrease";
            this.btnTwinRoomIncrease.Size = new System.Drawing.Size(20, 20);
            this.btnTwinRoomIncrease.TabIndex = 32;
            this.btnTwinRoomIncrease.Text = "+";
            this.btnTwinRoomIncrease.UseVisualStyleBackColor = false;
            this.btnTwinRoomIncrease.Click += new System.EventHandler(this.btnTwinRoomIncrease_Click);
            // 
            // btnTwinRoomDecrease
            // 
            this.btnTwinRoomDecrease.BackColor = System.Drawing.Color.Maroon;
            this.btnTwinRoomDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwinRoomDecrease.ForeColor = System.Drawing.Color.White;
            this.btnTwinRoomDecrease.Location = new System.Drawing.Point(355, 372);
            this.btnTwinRoomDecrease.Name = "btnTwinRoomDecrease";
            this.btnTwinRoomDecrease.Size = new System.Drawing.Size(20, 20);
            this.btnTwinRoomDecrease.TabIndex = 31;
            this.btnTwinRoomDecrease.Text = "-";
            this.btnTwinRoomDecrease.UseVisualStyleBackColor = false;
            this.btnTwinRoomDecrease.Click += new System.EventHandler(this.btnTwinRoomDecrease_Click);
            // 
            // lblTwinRoomNumber
            // 
            this.lblTwinRoomNumber.AutoSize = true;
            this.lblTwinRoomNumber.Location = new System.Drawing.Point(385, 376);
            this.lblTwinRoomNumber.Name = "lblTwinRoomNumber";
            this.lblTwinRoomNumber.Size = new System.Drawing.Size(13, 13);
            this.lblTwinRoomNumber.TabIndex = 30;
            this.lblTwinRoomNumber.Text = "0";
            // 
            // btnDoubleRoomIncrease
            // 
            this.btnDoubleRoomIncrease.BackColor = System.Drawing.Color.Maroon;
            this.btnDoubleRoomIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoubleRoomIncrease.ForeColor = System.Drawing.Color.White;
            this.btnDoubleRoomIncrease.Location = new System.Drawing.Point(244, 372);
            this.btnDoubleRoomIncrease.Name = "btnDoubleRoomIncrease";
            this.btnDoubleRoomIncrease.Size = new System.Drawing.Size(20, 20);
            this.btnDoubleRoomIncrease.TabIndex = 29;
            this.btnDoubleRoomIncrease.Text = "+";
            this.btnDoubleRoomIncrease.UseVisualStyleBackColor = false;
            this.btnDoubleRoomIncrease.Click += new System.EventHandler(this.btnDoubleRoomIncrease_Click);
            // 
            // btnDoubleRoomDecrease
            // 
            this.btnDoubleRoomDecrease.BackColor = System.Drawing.Color.Maroon;
            this.btnDoubleRoomDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoubleRoomDecrease.ForeColor = System.Drawing.Color.White;
            this.btnDoubleRoomDecrease.Location = new System.Drawing.Point(192, 372);
            this.btnDoubleRoomDecrease.Name = "btnDoubleRoomDecrease";
            this.btnDoubleRoomDecrease.Size = new System.Drawing.Size(20, 20);
            this.btnDoubleRoomDecrease.TabIndex = 28;
            this.btnDoubleRoomDecrease.Text = "-";
            this.btnDoubleRoomDecrease.UseVisualStyleBackColor = false;
            this.btnDoubleRoomDecrease.Click += new System.EventHandler(this.btnDoubleRoomDecrease_Click);
            // 
            // lblDoubleRoomNumber
            // 
            this.lblDoubleRoomNumber.AutoSize = true;
            this.lblDoubleRoomNumber.Location = new System.Drawing.Point(222, 376);
            this.lblDoubleRoomNumber.Name = "lblDoubleRoomNumber";
            this.lblDoubleRoomNumber.Size = new System.Drawing.Size(13, 13);
            this.lblDoubleRoomNumber.TabIndex = 27;
            this.lblDoubleRoomNumber.Text = "0";
            // 
            // btnSingleRoomIncrease
            // 
            this.btnSingleRoomIncrease.BackColor = System.Drawing.Color.Maroon;
            this.btnSingleRoomIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleRoomIncrease.ForeColor = System.Drawing.Color.White;
            this.btnSingleRoomIncrease.Location = new System.Drawing.Point(106, 370);
            this.btnSingleRoomIncrease.Name = "btnSingleRoomIncrease";
            this.btnSingleRoomIncrease.Size = new System.Drawing.Size(20, 20);
            this.btnSingleRoomIncrease.TabIndex = 26;
            this.btnSingleRoomIncrease.Text = "+";
            this.btnSingleRoomIncrease.UseVisualStyleBackColor = false;
            this.btnSingleRoomIncrease.Click += new System.EventHandler(this.btnSingleRoomIncrease_Click);
            // 
            // btnSingleRoomDecrease
            // 
            this.btnSingleRoomDecrease.BackColor = System.Drawing.Color.Maroon;
            this.btnSingleRoomDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleRoomDecrease.ForeColor = System.Drawing.Color.White;
            this.btnSingleRoomDecrease.Location = new System.Drawing.Point(54, 370);
            this.btnSingleRoomDecrease.Name = "btnSingleRoomDecrease";
            this.btnSingleRoomDecrease.Size = new System.Drawing.Size(20, 20);
            this.btnSingleRoomDecrease.TabIndex = 25;
            this.btnSingleRoomDecrease.Text = "-";
            this.btnSingleRoomDecrease.UseVisualStyleBackColor = false;
            this.btnSingleRoomDecrease.Click += new System.EventHandler(this.btnSingleRoomDecrease_Click);
            // 
            // lblSingleRoomNumber
            // 
            this.lblSingleRoomNumber.AutoSize = true;
            this.lblSingleRoomNumber.Location = new System.Drawing.Point(84, 373);
            this.lblSingleRoomNumber.Name = "lblSingleRoomNumber";
            this.lblSingleRoomNumber.Size = new System.Drawing.Size(13, 13);
            this.lblSingleRoomNumber.TabIndex = 24;
            this.lblSingleRoomNumber.Text = "0";
            // 
            // lblTwinRoom
            // 
            this.lblTwinRoom.AutoSize = true;
            this.lblTwinRoom.Location = new System.Drawing.Point(308, 376);
            this.lblTwinRoom.Name = "lblTwinRoom";
            this.lblTwinRoom.Size = new System.Drawing.Size(30, 13);
            this.lblTwinRoom.TabIndex = 23;
            this.lblTwinRoom.Text = "Twin";
            // 
            // lblDoubleRoom
            // 
            this.lblDoubleRoom.AutoSize = true;
            this.lblDoubleRoom.Location = new System.Drawing.Point(145, 377);
            this.lblDoubleRoom.Name = "lblDoubleRoom";
            this.lblDoubleRoom.Size = new System.Drawing.Size(41, 13);
            this.lblDoubleRoom.TabIndex = 22;
            this.lblDoubleRoom.Text = "Double";
            // 
            // lblSingleRoom
            // 
            this.lblSingleRoom.AutoSize = true;
            this.lblSingleRoom.Location = new System.Drawing.Point(7, 373);
            this.lblSingleRoom.Name = "lblSingleRoom";
            this.lblSingleRoom.Size = new System.Drawing.Size(36, 13);
            this.lblSingleRoom.TabIndex = 21;
            this.lblSingleRoom.Text = "Single";
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Location = new System.Drawing.Point(93, 86);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(371, 20);
            this.dtpCheckOutDate.TabIndex = 20;
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Location = new System.Drawing.Point(93, 52);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(371, 20);
            this.dtpCheckInDate.TabIndex = 17;
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(7, 57);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(78, 13);
            this.lblCheckInDate.TabIndex = 0;
            this.lblCheckInDate.Text = "Check-in Date:";
            // 
            // txtGuestNames
            // 
            this.txtGuestNames.Location = new System.Drawing.Point(93, 189);
            this.txtGuestNames.Multiline = true;
            this.txtGuestNames.Name = "txtGuestNames";
            this.txtGuestNames.Size = new System.Drawing.Size(371, 65);
            this.txtGuestNames.TabIndex = 11;
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(6, 192);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(72, 13);
            this.lblGuestName.TabIndex = 1;
            this.lblGuestName.Text = "Guest names:";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Location = new System.Drawing.Point(7, 91);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(85, 13);
            this.lblCheckOutDate.TabIndex = 2;
            this.lblCheckOutDate.Text = "Check-out Date:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Maroon;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(638, 440);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 45);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(743, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 45);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBoxPaymentDetails
            // 
            this.groupBoxPaymentDetails.Controls.Add(this.radioBtnSaveCustomerCardDetailsNO);
            this.groupBoxPaymentDetails.Controls.Add(this.dtpExpiryDate);
            this.groupBoxPaymentDetails.Controls.Add(this.radioBtnSaveCustomerCardDetailsYES);
            this.groupBoxPaymentDetails.Controls.Add(this.lblSaveCustomerCardDetails);
            this.groupBoxPaymentDetails.Controls.Add(this.txtSecurityCode);
            this.groupBoxPaymentDetails.Controls.Add(this.txtCardNumber);
            this.groupBoxPaymentDetails.Controls.Add(this.txtHolderName);
            this.groupBoxPaymentDetails.Controls.Add(this.lblCardNumber);
            this.groupBoxPaymentDetails.Controls.Add(this.lblSecurityCode);
            this.groupBoxPaymentDetails.Controls.Add(this.lblHolderName);
            this.groupBoxPaymentDetails.Controls.Add(this.lblExpiryDate);
            this.groupBoxPaymentDetails.Location = new System.Drawing.Point(6, 307);
            this.groupBoxPaymentDetails.Name = "groupBoxPaymentDetails";
            this.groupBoxPaymentDetails.Size = new System.Drawing.Size(401, 201);
            this.groupBoxPaymentDetails.TabIndex = 16;
            this.groupBoxPaymentDetails.TabStop = false;
            this.groupBoxPaymentDetails.Text = "Payment Details";
            // 
            // radioBtnSaveCustomerCardDetailsNO
            // 
            this.radioBtnSaveCustomerCardDetailsNO.AutoSize = true;
            this.radioBtnSaveCustomerCardDetailsNO.Location = new System.Drawing.Point(201, 165);
            this.radioBtnSaveCustomerCardDetailsNO.Name = "radioBtnSaveCustomerCardDetailsNO";
            this.radioBtnSaveCustomerCardDetailsNO.Size = new System.Drawing.Size(39, 17);
            this.radioBtnSaveCustomerCardDetailsNO.TabIndex = 25;
            this.radioBtnSaveCustomerCardDetailsNO.TabStop = true;
            this.radioBtnSaveCustomerCardDetailsNO.Text = "No";
            this.radioBtnSaveCustomerCardDetailsNO.UseVisualStyleBackColor = true;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Location = new System.Drawing.Point(81, 96);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(314, 20);
            this.dtpExpiryDate.TabIndex = 16;
            // 
            // radioBtnSaveCustomerCardDetailsYES
            // 
            this.radioBtnSaveCustomerCardDetailsYES.AutoSize = true;
            this.radioBtnSaveCustomerCardDetailsYES.Location = new System.Drawing.Point(154, 165);
            this.radioBtnSaveCustomerCardDetailsYES.Name = "radioBtnSaveCustomerCardDetailsYES";
            this.radioBtnSaveCustomerCardDetailsYES.Size = new System.Drawing.Size(43, 17);
            this.radioBtnSaveCustomerCardDetailsYES.TabIndex = 24;
            this.radioBtnSaveCustomerCardDetailsYES.TabStop = true;
            this.radioBtnSaveCustomerCardDetailsYES.Text = "Yes";
            this.radioBtnSaveCustomerCardDetailsYES.UseVisualStyleBackColor = true;
            // 
            // lblSaveCustomerCardDetails
            // 
            this.lblSaveCustomerCardDetails.AutoSize = true;
            this.lblSaveCustomerCardDetails.Location = new System.Drawing.Point(7, 168);
            this.lblSaveCustomerCardDetails.Name = "lblSaveCustomerCardDetails";
            this.lblSaveCustomerCardDetails.Size = new System.Drawing.Size(142, 13);
            this.lblSaveCustomerCardDetails.TabIndex = 23;
            this.lblSaveCustomerCardDetails.Text = "Save Customer Card Details:";
            // 
            // txtSecurityCode
            // 
            this.txtSecurityCode.Location = new System.Drawing.Point(83, 130);
            this.txtSecurityCode.Name = "txtSecurityCode";
            this.txtSecurityCode.Size = new System.Drawing.Size(76, 20);
            this.txtSecurityCode.TabIndex = 15;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(81, 62);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(314, 20);
            this.txtCardNumber.TabIndex = 14;
            // 
            // txtHolderName
            // 
            this.txtHolderName.Location = new System.Drawing.Point(81, 26);
            this.txtHolderName.Name = "txtHolderName";
            this.txtHolderName.Size = new System.Drawing.Size(314, 20);
            this.txtHolderName.TabIndex = 13;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(5, 69);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(72, 13);
            this.lblCardNumber.TabIndex = 4;
            this.lblCardNumber.Text = "Card Number:";
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.AutoSize = true;
            this.lblSecurityCode.Location = new System.Drawing.Point(7, 133);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(76, 13);
            this.lblSecurityCode.TabIndex = 6;
            this.lblSecurityCode.Text = "Security Code:";
            // 
            // lblHolderName
            // 
            this.lblHolderName.AutoSize = true;
            this.lblHolderName.Location = new System.Drawing.Point(7, 33);
            this.lblHolderName.Name = "lblHolderName";
            this.lblHolderName.Size = new System.Drawing.Size(72, 13);
            this.lblHolderName.TabIndex = 7;
            this.lblHolderName.Text = "Holder Name:";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(7, 104);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(64, 13);
            this.lblExpiryDate.TabIndex = 5;
            this.lblExpiryDate.Text = "Expiry Date:";
            // 
            // groupBoxCustomerDetails
            // 
            this.groupBoxCustomerDetails.Controls.Add(this.txtGuestId);
            this.groupBoxCustomerDetails.Controls.Add(this.lblGuestID);
            this.groupBoxCustomerDetails.Controls.Add(this.groupBoxSaveCustomerDetails);
            this.groupBoxCustomerDetails.Controls.Add(this.groupBoxMarketingConsent);
            this.groupBoxCustomerDetails.Controls.Add(this.txtName);
            this.groupBoxCustomerDetails.Controls.Add(this.txtEmail);
            this.groupBoxCustomerDetails.Controls.Add(this.lblName);
            this.groupBoxCustomerDetails.Controls.Add(this.txtPhoneNumber);
            this.groupBoxCustomerDetails.Controls.Add(this.lblPhoneNumber);
            this.groupBoxCustomerDetails.Controls.Add(this.txtAddress);
            this.groupBoxCustomerDetails.Controls.Add(this.lblAddress);
            this.groupBoxCustomerDetails.Controls.Add(this.lblEmail);
            this.groupBoxCustomerDetails.Location = new System.Drawing.Point(6, 5);
            this.groupBoxCustomerDetails.Name = "groupBoxCustomerDetails";
            this.groupBoxCustomerDetails.Size = new System.Drawing.Size(401, 296);
            this.groupBoxCustomerDetails.TabIndex = 15;
            this.groupBoxCustomerDetails.TabStop = false;
            this.groupBoxCustomerDetails.Text = "Customer Details";
            // 
            // txtGuestId
            // 
            this.txtGuestId.Enabled = false;
            this.txtGuestId.Location = new System.Drawing.Point(60, 25);
            this.txtGuestId.Name = "txtGuestId";
            this.txtGuestId.Size = new System.Drawing.Size(335, 20);
            this.txtGuestId.TabIndex = 25;
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Location = new System.Drawing.Point(7, 28);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(49, 13);
            this.lblGuestID.TabIndex = 24;
            this.lblGuestID.Text = "Guest ID";
            // 
            // groupBoxSaveCustomerDetails
            // 
            this.groupBoxSaveCustomerDetails.Controls.Add(this.radioBtnSaveCustomerDetailsNO);
            this.groupBoxSaveCustomerDetails.Controls.Add(this.radioBtnSaveCustomerDetailsYES);
            this.groupBoxSaveCustomerDetails.Location = new System.Drawing.Point(220, 239);
            this.groupBoxSaveCustomerDetails.Name = "groupBoxSaveCustomerDetails";
            this.groupBoxSaveCustomerDetails.Size = new System.Drawing.Size(175, 49);
            this.groupBoxSaveCustomerDetails.TabIndex = 23;
            this.groupBoxSaveCustomerDetails.TabStop = false;
            this.groupBoxSaveCustomerDetails.Text = "Save Customer Details";
            // 
            // radioBtnSaveCustomerDetailsNO
            // 
            this.radioBtnSaveCustomerDetailsNO.AutoSize = true;
            this.radioBtnSaveCustomerDetailsNO.Location = new System.Drawing.Point(91, 21);
            this.radioBtnSaveCustomerDetailsNO.Name = "radioBtnSaveCustomerDetailsNO";
            this.radioBtnSaveCustomerDetailsNO.Size = new System.Drawing.Size(39, 17);
            this.radioBtnSaveCustomerDetailsNO.TabIndex = 22;
            this.radioBtnSaveCustomerDetailsNO.TabStop = true;
            this.radioBtnSaveCustomerDetailsNO.Text = "No";
            this.radioBtnSaveCustomerDetailsNO.UseVisualStyleBackColor = true;
            // 
            // radioBtnSaveCustomerDetailsYES
            // 
            this.radioBtnSaveCustomerDetailsYES.AutoSize = true;
            this.radioBtnSaveCustomerDetailsYES.Location = new System.Drawing.Point(36, 21);
            this.radioBtnSaveCustomerDetailsYES.Name = "radioBtnSaveCustomerDetailsYES";
            this.radioBtnSaveCustomerDetailsYES.Size = new System.Drawing.Size(43, 17);
            this.radioBtnSaveCustomerDetailsYES.TabIndex = 21;
            this.radioBtnSaveCustomerDetailsYES.TabStop = true;
            this.radioBtnSaveCustomerDetailsYES.Text = "Yes";
            this.radioBtnSaveCustomerDetailsYES.UseVisualStyleBackColor = true;
            // 
            // groupBoxMarketingConsent
            // 
            this.groupBoxMarketingConsent.Controls.Add(this.radioBtnMarketingConsentYES);
            this.groupBoxMarketingConsent.Controls.Add(this.radioBtnMarketingConsentNO);
            this.groupBoxMarketingConsent.Location = new System.Drawing.Point(10, 236);
            this.groupBoxMarketingConsent.Name = "groupBoxMarketingConsent";
            this.groupBoxMarketingConsent.Size = new System.Drawing.Size(175, 48);
            this.groupBoxMarketingConsent.TabIndex = 23;
            this.groupBoxMarketingConsent.TabStop = false;
            this.groupBoxMarketingConsent.Text = "Marketing Consent";
            // 
            // radioBtnMarketingConsentYES
            // 
            this.radioBtnMarketingConsentYES.AutoSize = true;
            this.radioBtnMarketingConsentYES.Location = new System.Drawing.Point(35, 21);
            this.radioBtnMarketingConsentYES.Name = "radioBtnMarketingConsentYES";
            this.radioBtnMarketingConsentYES.Size = new System.Drawing.Size(43, 17);
            this.radioBtnMarketingConsentYES.TabIndex = 17;
            this.radioBtnMarketingConsentYES.TabStop = true;
            this.radioBtnMarketingConsentYES.Text = "Yes";
            this.radioBtnMarketingConsentYES.UseVisualStyleBackColor = true;
            // 
            // radioBtnMarketingConsentNO
            // 
            this.radioBtnMarketingConsentNO.AutoSize = true;
            this.radioBtnMarketingConsentNO.Location = new System.Drawing.Point(92, 21);
            this.radioBtnMarketingConsentNO.Name = "radioBtnMarketingConsentNO";
            this.radioBtnMarketingConsentNO.Size = new System.Drawing.Size(39, 17);
            this.radioBtnMarketingConsentNO.TabIndex = 19;
            this.radioBtnMarketingConsentNO.TabStop = true;
            this.radioBtnMarketingConsentNO.Text = "No";
            this.radioBtnMarketingConsentNO.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(335, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(90, 169);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(305, 20);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(7, 176);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(60, 87);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(335, 73);
            this.txtAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 89);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 204);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email: ";
            // 
            // tabPageViewBooking
            // 
            this.tabPageViewBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageViewBooking.Controls.Add(this.groupBoxSearchVB);
            this.tabPageViewBooking.Controls.Add(this.listView_ViewBooking);
            this.tabPageViewBooking.Location = new System.Drawing.Point(4, 22);
            this.tabPageViewBooking.Name = "tabPageViewBooking";
            this.tabPageViewBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViewBooking.Size = new System.Drawing.Size(984, 548);
            this.tabPageViewBooking.TabIndex = 4;
            this.tabPageViewBooking.Text = "View Bookings ";
            // 
            // groupBoxSearchVB
            // 
            this.groupBoxSearchVB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchVB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxSearchVB.Controls.Add(this.btnResetVB);
            this.groupBoxSearchVB.Controls.Add(this.btnSearchVB);
            this.groupBoxSearchVB.Controls.Add(this.lblToVB);
            this.groupBoxSearchVB.Controls.Add(this.dtpToVB);
            this.groupBoxSearchVB.Controls.Add(this.lblFromVB);
            this.groupBoxSearchVB.Controls.Add(this.dtpFromVB);
            this.groupBoxSearchVB.Location = new System.Drawing.Point(7, 16);
            this.groupBoxSearchVB.Name = "groupBoxSearchVB";
            this.groupBoxSearchVB.Size = new System.Drawing.Size(968, 62);
            this.groupBoxSearchVB.TabIndex = 8;
            this.groupBoxSearchVB.TabStop = false;
            this.groupBoxSearchVB.Text = "Pick two dates";
            // 
            // btnResetVB
            // 
            this.btnResetVB.BackColor = System.Drawing.Color.Maroon;
            this.btnResetVB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetVB.ForeColor = System.Drawing.Color.White;
            this.btnResetVB.Location = new System.Drawing.Point(780, 14);
            this.btnResetVB.Name = "btnResetVB";
            this.btnResetVB.Size = new System.Drawing.Size(92, 36);
            this.btnResetVB.TabIndex = 8;
            this.btnResetVB.Text = "Reset";
            this.btnResetVB.UseVisualStyleBackColor = false;
            this.btnResetVB.Click += new System.EventHandler(this.btnResetVB_Click);
            // 
            // btnSearchVB
            // 
            this.btnSearchVB.BackColor = System.Drawing.Color.Maroon;
            this.btnSearchVB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchVB.ForeColor = System.Drawing.Color.White;
            this.btnSearchVB.Location = new System.Drawing.Point(674, 14);
            this.btnSearchVB.Name = "btnSearchVB";
            this.btnSearchVB.Size = new System.Drawing.Size(92, 36);
            this.btnSearchVB.TabIndex = 7;
            this.btnSearchVB.Text = "Search";
            this.btnSearchVB.UseVisualStyleBackColor = false;
            this.btnSearchVB.Click += new System.EventHandler(this.btnSearchVB_Click);
            // 
            // lblToVB
            // 
            this.lblToVB.AutoSize = true;
            this.lblToVB.Location = new System.Drawing.Point(399, 28);
            this.lblToVB.Name = "lblToVB";
            this.lblToVB.Size = new System.Drawing.Size(20, 13);
            this.lblToVB.TabIndex = 6;
            this.lblToVB.Text = "To";
            // 
            // dtpToVB
            // 
            this.dtpToVB.CalendarMonthBackground = System.Drawing.Color.Maroon;
            this.dtpToVB.Location = new System.Drawing.Point(435, 25);
            this.dtpToVB.Name = "dtpToVB";
            this.dtpToVB.Size = new System.Drawing.Size(200, 20);
            this.dtpToVB.TabIndex = 5;
            // 
            // lblFromVB
            // 
            this.lblFromVB.AutoSize = true;
            this.lblFromVB.Location = new System.Drawing.Point(119, 28);
            this.lblFromVB.Name = "lblFromVB";
            this.lblFromVB.Size = new System.Drawing.Size(30, 13);
            this.lblFromVB.TabIndex = 4;
            this.lblFromVB.Text = "From";
            // 
            // dtpFromVB
            // 
            this.dtpFromVB.CalendarMonthBackground = System.Drawing.Color.Maroon;
            this.dtpFromVB.Location = new System.Drawing.Point(155, 23);
            this.dtpFromVB.Name = "dtpFromVB";
            this.dtpFromVB.Size = new System.Drawing.Size(200, 20);
            this.dtpFromVB.TabIndex = 3;
            // 
            // listView_ViewBooking
            // 
            this.listView_ViewBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_ViewBooking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBookingIdVB,
            this.columnHeaderCheckInVB,
            this.columnHeaderCheckOutVB,
            this.columnHeaderGuestNamesVB,
            this.columnHeaderAdditionalNotesVB,
            this.columnHeaderNumSingleVB,
            this.columnHeaderDoubleRoomVB,
            this.columnHeaderTwinRoom,
            this.columnHeaderRoomListVB,
            this.columnHeaderTotalVB,
            this.columnHeaderCheckedInVB,
            this.columnHeaderCheckedOutVB,
            this.columnHeaderEmpty,
            this.columnHeaderGuestIDVB,
            this.columnHeaderGuestNameVB,
            this.columnHeaderGuestAddressVB,
            this.columnHeaderGuestPhoneVB,
            this.columnHeaderGuestEmailVB,
            this.columnHeaderGuestMarketingConsentVB,
            this.columnHeaderGuestSaveDetailsVB});
            this.listView_ViewBooking.FullRowSelect = true;
            this.listView_ViewBooking.GridLines = true;
            this.listView_ViewBooking.HideSelection = false;
            this.listView_ViewBooking.Location = new System.Drawing.Point(-1, 90);
            this.listView_ViewBooking.MultiSelect = false;
            this.listView_ViewBooking.Name = "listView_ViewBooking";
            this.listView_ViewBooking.Size = new System.Drawing.Size(985, 462);
            this.listView_ViewBooking.TabIndex = 1;
            this.listView_ViewBooking.UseCompatibleStateImageBehavior = false;
            this.listView_ViewBooking.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderBookingIdVB
            // 
            this.columnHeaderBookingIdVB.Text = "Booking ID";
            this.columnHeaderBookingIdVB.Width = 80;
            // 
            // columnHeaderCheckInVB
            // 
            this.columnHeaderCheckInVB.Text = "Check-in";
            this.columnHeaderCheckInVB.Width = 150;
            // 
            // columnHeaderCheckOutVB
            // 
            this.columnHeaderCheckOutVB.Text = "Check-out";
            this.columnHeaderCheckOutVB.Width = 150;
            // 
            // columnHeaderGuestNamesVB
            // 
            this.columnHeaderGuestNamesVB.Text = "Guest Names";
            this.columnHeaderGuestNamesVB.Width = 200;
            // 
            // columnHeaderAdditionalNotesVB
            // 
            this.columnHeaderAdditionalNotesVB.Text = "Additional Notes";
            this.columnHeaderAdditionalNotesVB.Width = 200;
            // 
            // columnHeaderNumSingleVB
            // 
            this.columnHeaderNumSingleVB.Text = "Single Room";
            this.columnHeaderNumSingleVB.Width = 80;
            // 
            // columnHeaderDoubleRoomVB
            // 
            this.columnHeaderDoubleRoomVB.Text = "Double Room";
            this.columnHeaderDoubleRoomVB.Width = 80;
            // 
            // columnHeaderTwinRoom
            // 
            this.columnHeaderTwinRoom.Text = "Twin Room";
            this.columnHeaderTwinRoom.Width = 80;
            // 
            // columnHeaderRoomListVB
            // 
            this.columnHeaderRoomListVB.Text = "Rooms";
            this.columnHeaderRoomListVB.Width = 100;
            // 
            // columnHeaderTotalVB
            // 
            this.columnHeaderTotalVB.Text = "Total";
            this.columnHeaderTotalVB.Width = 100;
            // 
            // columnHeaderCheckedInVB
            // 
            this.columnHeaderCheckedInVB.Text = "Checked In";
            this.columnHeaderCheckedInVB.Width = 100;
            // 
            // columnHeaderCheckedOutVB
            // 
            this.columnHeaderCheckedOutVB.Text = "Checked Out";
            this.columnHeaderCheckedOutVB.Width = 80;
            // 
            // columnHeaderEmpty
            // 
            this.columnHeaderEmpty.Text = "";
            this.columnHeaderEmpty.Width = 50;
            // 
            // columnHeaderGuestIDVB
            // 
            this.columnHeaderGuestIDVB.Text = "Guest ID";
            this.columnHeaderGuestIDVB.Width = 80;
            // 
            // columnHeaderGuestNameVB
            // 
            this.columnHeaderGuestNameVB.Text = "Name";
            this.columnHeaderGuestNameVB.Width = 100;
            // 
            // columnHeaderGuestAddressVB
            // 
            this.columnHeaderGuestAddressVB.Text = "Address";
            this.columnHeaderGuestAddressVB.Width = 150;
            // 
            // columnHeaderGuestPhoneVB
            // 
            this.columnHeaderGuestPhoneVB.Text = "Phone";
            this.columnHeaderGuestPhoneVB.Width = 80;
            // 
            // columnHeaderGuestEmailVB
            // 
            this.columnHeaderGuestEmailVB.Text = "Email";
            this.columnHeaderGuestEmailVB.Width = 100;
            // 
            // columnHeaderGuestMarketingConsentVB
            // 
            this.columnHeaderGuestMarketingConsentVB.Text = "Marketing Consent";
            this.columnHeaderGuestMarketingConsentVB.Width = 100;
            // 
            // columnHeaderGuestSaveDetailsVB
            // 
            this.columnHeaderGuestSaveDetailsVB.Text = "Save Details";
            this.columnHeaderGuestSaveDetailsVB.Width = 80;
            // 
            // tabPageCancelBooking
            // 
            this.tabPageCancelBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageCancelBooking.Controls.Add(this.btnClearMB);
            this.tabPageCancelBooking.Controls.Add(this.btncancelModificationMB);
            this.tabPageCancelBooking.Controls.Add(this.btnSearchMB);
            this.tabPageCancelBooking.Controls.Add(this.lblPhoneNumberOrBookingiDSearchMB);
            this.tabPageCancelBooking.Controls.Add(this.txtPhoneNumOrBookingIDSearchMB);
            this.tabPageCancelBooking.Controls.Add(this.btnCancelBookingMB);
            this.tabPageCancelBooking.Controls.Add(this.btnEditMB);
            this.tabPageCancelBooking.Controls.Add(this.groupBoxCustomerPaymentMB);
            this.tabPageCancelBooking.Controls.Add(this.groupBoxCustomerBookingMB);
            this.tabPageCancelBooking.Controls.Add(this.groupBoxCustomerdetailsMB);
            this.tabPageCancelBooking.Controls.Add(this.listViewManageBooking);
            this.tabPageCancelBooking.Location = new System.Drawing.Point(4, 22);
            this.tabPageCancelBooking.Name = "tabPageCancelBooking";
            this.tabPageCancelBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCancelBooking.Size = new System.Drawing.Size(984, 548);
            this.tabPageCancelBooking.TabIndex = 5;
            this.tabPageCancelBooking.Text = "Manage Booking";
            // 
            // btnClearMB
            // 
            this.btnClearMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearMB.BackColor = System.Drawing.Color.Maroon;
            this.btnClearMB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearMB.ForeColor = System.Drawing.Color.White;
            this.btnClearMB.Location = new System.Drawing.Point(876, 426);
            this.btnClearMB.Name = "btnClearMB";
            this.btnClearMB.Size = new System.Drawing.Size(64, 35);
            this.btnClearMB.TabIndex = 29;
            this.btnClearMB.Text = "Clear";
            this.btnClearMB.UseVisualStyleBackColor = false;
            this.btnClearMB.Click += new System.EventHandler(this.btnClearMB_Click);
            // 
            // btncancelModificationMB
            // 
            this.btncancelModificationMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncancelModificationMB.BackColor = System.Drawing.Color.Maroon;
            this.btncancelModificationMB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelModificationMB.ForeColor = System.Drawing.Color.White;
            this.btncancelModificationMB.Location = new System.Drawing.Point(753, 466);
            this.btncancelModificationMB.Name = "btncancelModificationMB";
            this.btncancelModificationMB.Size = new System.Drawing.Size(128, 35);
            this.btncancelModificationMB.TabIndex = 28;
            this.btncancelModificationMB.Text = "Cancel Modification";
            this.btncancelModificationMB.UseVisualStyleBackColor = false;
            this.btncancelModificationMB.Click += new System.EventHandler(this.btncancelModificationMB_Click);
            // 
            // btnSearchMB
            // 
            this.btnSearchMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearchMB.BackColor = System.Drawing.Color.Maroon;
            this.btnSearchMB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchMB.ForeColor = System.Drawing.Color.White;
            this.btnSearchMB.Location = new System.Drawing.Point(908, 375);
            this.btnSearchMB.Name = "btnSearchMB";
            this.btnSearchMB.Size = new System.Drawing.Size(70, 29);
            this.btnSearchMB.TabIndex = 27;
            this.btnSearchMB.Text = "Search";
            this.btnSearchMB.UseVisualStyleBackColor = false;
            this.btnSearchMB.Click += new System.EventHandler(this.btnSearchMB_Click);
            // 
            // lblPhoneNumberOrBookingiDSearchMB
            // 
            this.lblPhoneNumberOrBookingiDSearchMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPhoneNumberOrBookingiDSearchMB.AutoSize = true;
            this.lblPhoneNumberOrBookingiDSearchMB.Location = new System.Drawing.Point(669, 356);
            this.lblPhoneNumberOrBookingiDSearchMB.Name = "lblPhoneNumberOrBookingiDSearchMB";
            this.lblPhoneNumberOrBookingiDSearchMB.Size = new System.Drawing.Size(136, 13);
            this.lblPhoneNumberOrBookingiDSearchMB.TabIndex = 26;
            this.lblPhoneNumberOrBookingiDSearchMB.Text = "Phone Number/Booking ID";
            // 
            // txtPhoneNumOrBookingIDSearchMB
            // 
            this.txtPhoneNumOrBookingIDSearchMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPhoneNumOrBookingIDSearchMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumOrBookingIDSearchMB.Location = new System.Drawing.Point(672, 375);
            this.txtPhoneNumOrBookingIDSearchMB.Multiline = true;
            this.txtPhoneNumOrBookingIDSearchMB.Name = "txtPhoneNumOrBookingIDSearchMB";
            this.txtPhoneNumOrBookingIDSearchMB.Size = new System.Drawing.Size(231, 30);
            this.txtPhoneNumOrBookingIDSearchMB.TabIndex = 26;
            // 
            // btnCancelBookingMB
            // 
            this.btnCancelBookingMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelBookingMB.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelBookingMB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelBookingMB.ForeColor = System.Drawing.Color.White;
            this.btnCancelBookingMB.Location = new System.Drawing.Point(767, 425);
            this.btnCancelBookingMB.Name = "btnCancelBookingMB";
            this.btnCancelBookingMB.Size = new System.Drawing.Size(103, 35);
            this.btnCancelBookingMB.TabIndex = 24;
            this.btnCancelBookingMB.Text = "Cancel Booking";
            this.btnCancelBookingMB.UseVisualStyleBackColor = false;
            this.btnCancelBookingMB.Click += new System.EventHandler(this.btnCancelBookingMB_Click);
            // 
            // btnEditMB
            // 
            this.btnEditMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditMB.BackColor = System.Drawing.Color.Maroon;
            this.btnEditMB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditMB.ForeColor = System.Drawing.Color.White;
            this.btnEditMB.Location = new System.Drawing.Point(691, 426);
            this.btnEditMB.Name = "btnEditMB";
            this.btnEditMB.Size = new System.Drawing.Size(70, 35);
            this.btnEditMB.TabIndex = 23;
            this.btnEditMB.Text = "Edit";
            this.btnEditMB.UseVisualStyleBackColor = false;
            this.btnEditMB.Click += new System.EventHandler(this.btnEditMB_Click);
            // 
            // groupBoxCustomerPaymentMB
            // 
            this.groupBoxCustomerPaymentMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxCustomerPaymentMB.Controls.Add(this.radioBtnMBSaveCustomerCardDetailsNO);
            this.groupBoxCustomerPaymentMB.Controls.Add(this.dtpCardExpityDateMB);
            this.groupBoxCustomerPaymentMB.Controls.Add(this.radioBtnMBSaveCustomerCardDetailsYES);
            this.groupBoxCustomerPaymentMB.Controls.Add(this.lblCustomerSavePaymentMB);
            this.groupBoxCustomerPaymentMB.Controls.Add(this.txtCardSecurityCodeMB);
            this.groupBoxCustomerPaymentMB.Controls.Add(this.txtCustomerCardNumberMB);
            this.groupBoxCustomerPaymentMB.Controls.Add(this.txtCustomerHolderNameMB);
            this.groupBoxCustomerPaymentMB.Controls.Add(this.lblCustomerCardNumMB);
            this.groupBoxCustomerPaymentMB.Controls.Add(this.lblCustomerSecurityCodeMB);
            this.groupBoxCustomerPaymentMB.Controls.Add(this.lblCustomerHolderNameMB);
            this.groupBoxCustomerPaymentMB.Controls.Add(this.lblCustomerExpiryDateMB);
            this.groupBoxCustomerPaymentMB.Location = new System.Drawing.Point(669, 135);
            this.groupBoxCustomerPaymentMB.Name = "groupBoxCustomerPaymentMB";
            this.groupBoxCustomerPaymentMB.Size = new System.Drawing.Size(306, 198);
            this.groupBoxCustomerPaymentMB.TabIndex = 22;
            this.groupBoxCustomerPaymentMB.TabStop = false;
            this.groupBoxCustomerPaymentMB.Text = "Payment Details";
            // 
            // radioBtnMBSaveCustomerCardDetailsNO
            // 
            this.radioBtnMBSaveCustomerCardDetailsNO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnMBSaveCustomerCardDetailsNO.AutoSize = true;
            this.radioBtnMBSaveCustomerCardDetailsNO.Location = new System.Drawing.Point(204, 161);
            this.radioBtnMBSaveCustomerCardDetailsNO.Name = "radioBtnMBSaveCustomerCardDetailsNO";
            this.radioBtnMBSaveCustomerCardDetailsNO.Size = new System.Drawing.Size(39, 17);
            this.radioBtnMBSaveCustomerCardDetailsNO.TabIndex = 25;
            this.radioBtnMBSaveCustomerCardDetailsNO.TabStop = true;
            this.radioBtnMBSaveCustomerCardDetailsNO.Text = "No";
            this.radioBtnMBSaveCustomerCardDetailsNO.UseVisualStyleBackColor = true;
            // 
            // dtpCardExpityDateMB
            // 
            this.dtpCardExpityDateMB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCardExpityDateMB.Location = new System.Drawing.Point(81, 90);
            this.dtpCardExpityDateMB.Name = "dtpCardExpityDateMB";
            this.dtpCardExpityDateMB.Size = new System.Drawing.Size(219, 20);
            this.dtpCardExpityDateMB.TabIndex = 16;
            // 
            // radioBtnMBSaveCustomerCardDetailsYES
            // 
            this.radioBtnMBSaveCustomerCardDetailsYES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnMBSaveCustomerCardDetailsYES.AutoSize = true;
            this.radioBtnMBSaveCustomerCardDetailsYES.Location = new System.Drawing.Point(152, 161);
            this.radioBtnMBSaveCustomerCardDetailsYES.Name = "radioBtnMBSaveCustomerCardDetailsYES";
            this.radioBtnMBSaveCustomerCardDetailsYES.Size = new System.Drawing.Size(43, 17);
            this.radioBtnMBSaveCustomerCardDetailsYES.TabIndex = 24;
            this.radioBtnMBSaveCustomerCardDetailsYES.TabStop = true;
            this.radioBtnMBSaveCustomerCardDetailsYES.Text = "Yes";
            this.radioBtnMBSaveCustomerCardDetailsYES.UseVisualStyleBackColor = true;
            // 
            // lblCustomerSavePaymentMB
            // 
            this.lblCustomerSavePaymentMB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerSavePaymentMB.AutoSize = true;
            this.lblCustomerSavePaymentMB.Location = new System.Drawing.Point(7, 164);
            this.lblCustomerSavePaymentMB.Name = "lblCustomerSavePaymentMB";
            this.lblCustomerSavePaymentMB.Size = new System.Drawing.Size(142, 13);
            this.lblCustomerSavePaymentMB.TabIndex = 23;
            this.lblCustomerSavePaymentMB.Text = "Save Customer Card Details:";
            // 
            // txtCardSecurityCodeMB
            // 
            this.txtCardSecurityCodeMB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardSecurityCodeMB.Location = new System.Drawing.Point(83, 127);
            this.txtCardSecurityCodeMB.Name = "txtCardSecurityCodeMB";
            this.txtCardSecurityCodeMB.Size = new System.Drawing.Size(57, 20);
            this.txtCardSecurityCodeMB.TabIndex = 15;
            // 
            // txtCustomerCardNumberMB
            // 
            this.txtCustomerCardNumberMB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerCardNumberMB.Location = new System.Drawing.Point(81, 57);
            this.txtCustomerCardNumberMB.Name = "txtCustomerCardNumberMB";
            this.txtCustomerCardNumberMB.Size = new System.Drawing.Size(219, 20);
            this.txtCustomerCardNumberMB.TabIndex = 14;
            // 
            // txtCustomerHolderNameMB
            // 
            this.txtCustomerHolderNameMB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerHolderNameMB.Location = new System.Drawing.Point(81, 22);
            this.txtCustomerHolderNameMB.Name = "txtCustomerHolderNameMB";
            this.txtCustomerHolderNameMB.Size = new System.Drawing.Size(219, 20);
            this.txtCustomerHolderNameMB.TabIndex = 13;
            // 
            // lblCustomerCardNumMB
            // 
            this.lblCustomerCardNumMB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerCardNumMB.AutoSize = true;
            this.lblCustomerCardNumMB.Location = new System.Drawing.Point(5, 64);
            this.lblCustomerCardNumMB.Name = "lblCustomerCardNumMB";
            this.lblCustomerCardNumMB.Size = new System.Drawing.Size(72, 13);
            this.lblCustomerCardNumMB.TabIndex = 4;
            this.lblCustomerCardNumMB.Text = "Card Number:";
            // 
            // lblCustomerSecurityCodeMB
            // 
            this.lblCustomerSecurityCodeMB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerSecurityCodeMB.AutoSize = true;
            this.lblCustomerSecurityCodeMB.Location = new System.Drawing.Point(7, 130);
            this.lblCustomerSecurityCodeMB.Name = "lblCustomerSecurityCodeMB";
            this.lblCustomerSecurityCodeMB.Size = new System.Drawing.Size(76, 13);
            this.lblCustomerSecurityCodeMB.TabIndex = 6;
            this.lblCustomerSecurityCodeMB.Text = "Security Code:";
            // 
            // lblCustomerHolderNameMB
            // 
            this.lblCustomerHolderNameMB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerHolderNameMB.AutoSize = true;
            this.lblCustomerHolderNameMB.Location = new System.Drawing.Point(7, 29);
            this.lblCustomerHolderNameMB.Name = "lblCustomerHolderNameMB";
            this.lblCustomerHolderNameMB.Size = new System.Drawing.Size(72, 13);
            this.lblCustomerHolderNameMB.TabIndex = 7;
            this.lblCustomerHolderNameMB.Text = "Holder Name:";
            // 
            // lblCustomerExpiryDateMB
            // 
            this.lblCustomerExpiryDateMB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerExpiryDateMB.AutoSize = true;
            this.lblCustomerExpiryDateMB.Location = new System.Drawing.Point(7, 98);
            this.lblCustomerExpiryDateMB.Name = "lblCustomerExpiryDateMB";
            this.lblCustomerExpiryDateMB.Size = new System.Drawing.Size(64, 13);
            this.lblCustomerExpiryDateMB.TabIndex = 5;
            this.lblCustomerExpiryDateMB.Text = "Expiry Date:";
            // 
            // groupBoxCustomerBookingMB
            // 
            this.groupBoxCustomerBookingMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxCustomerBookingMB.Controls.Add(this.btnSeachForBookingMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.groupBoxRoomaAvailabilityTypeMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.txtBookingIdMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.lblBookingIdMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.txtCustomerAdditionalNotesMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.lblCustomerAdditionalNotesMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.btnCustomerTwinRoomIncreaseMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.btnCustomerTwinRoomDecreaseMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.lblCustomerTwinRoomNumberMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.btnCustomerDoubleRoomIncreaseMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.btnCustomerDoubleRoomDecreaseMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.lblCustomerDoubleRoomNumberMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.btnCustomerSingleRoomIncreaseMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.btnCustomerSingleRoomDecreaseMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.lblCustomerSingleRoomNumberMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.lblCustomerTwinRoomMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.lblCustomerDoubleRoomMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.lblCustomerSingleRoomMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.dtpCustomerCheckOutMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.dtpCustomerCheckInMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.lblCustomerCheckInMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.txtCustomerGuestNamesMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.lblCustomerGuestNamesMB);
            this.groupBoxCustomerBookingMB.Controls.Add(this.lblCustomerCheckOutMB);
            this.groupBoxCustomerBookingMB.Location = new System.Drawing.Point(290, 135);
            this.groupBoxCustomerBookingMB.Name = "groupBoxCustomerBookingMB";
            this.groupBoxCustomerBookingMB.Size = new System.Drawing.Size(373, 404);
            this.groupBoxCustomerBookingMB.TabIndex = 21;
            this.groupBoxCustomerBookingMB.TabStop = false;
            this.groupBoxCustomerBookingMB.Text = "Booking Details";
            // 
            // btnSeachForBookingMB
            // 
            this.btnSeachForBookingMB.BackColor = System.Drawing.Color.Maroon;
            this.btnSeachForBookingMB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeachForBookingMB.ForeColor = System.Drawing.Color.White;
            this.btnSeachForBookingMB.Location = new System.Drawing.Point(282, 113);
            this.btnSeachForBookingMB.Name = "btnSeachForBookingMB";
            this.btnSeachForBookingMB.Size = new System.Drawing.Size(86, 51);
            this.btnSeachForBookingMB.TabIndex = 38;
            this.btnSeachForBookingMB.Text = "Search";
            this.btnSeachForBookingMB.UseVisualStyleBackColor = false;
            this.btnSeachForBookingMB.Click += new System.EventHandler(this.btnSeachForBookingMB_Click);
            // 
            // groupBoxRoomaAvailabilityTypeMB
            // 
            this.groupBoxRoomaAvailabilityTypeMB.Controls.Add(this.lblTwinRoomAvailabilityNumMB);
            this.groupBoxRoomaAvailabilityTypeMB.Controls.Add(this.lblDoubleRoomAvailabilityNumMB);
            this.groupBoxRoomaAvailabilityTypeMB.Controls.Add(this.lblSingleRoomAvailabilityNumMB);
            this.groupBoxRoomaAvailabilityTypeMB.Controls.Add(this.lblTwinRoomAvailabilityMB);
            this.groupBoxRoomaAvailabilityTypeMB.Controls.Add(this.lblDoubleRoomAvailabilityMB);
            this.groupBoxRoomaAvailabilityTypeMB.Controls.Add(this.lblSingleRoomAvailabilityMB);
            this.groupBoxRoomaAvailabilityTypeMB.Location = new System.Drawing.Point(10, 107);
            this.groupBoxRoomaAvailabilityTypeMB.Name = "groupBoxRoomaAvailabilityTypeMB";
            this.groupBoxRoomaAvailabilityTypeMB.Size = new System.Drawing.Size(265, 57);
            this.groupBoxRoomaAvailabilityTypeMB.TabIndex = 37;
            this.groupBoxRoomaAvailabilityTypeMB.TabStop = false;
            this.groupBoxRoomaAvailabilityTypeMB.Text = "Rooms Availability";
            // 
            // lblTwinRoomAvailabilityNumMB
            // 
            this.lblTwinRoomAvailabilityNumMB.AutoSize = true;
            this.lblTwinRoomAvailabilityNumMB.Location = new System.Drawing.Point(214, 25);
            this.lblTwinRoomAvailabilityNumMB.Name = "lblTwinRoomAvailabilityNumMB";
            this.lblTwinRoomAvailabilityNumMB.Size = new System.Drawing.Size(13, 13);
            this.lblTwinRoomAvailabilityNumMB.TabIndex = 37;
            this.lblTwinRoomAvailabilityNumMB.Text = "0";
            // 
            // lblDoubleRoomAvailabilityNumMB
            // 
            this.lblDoubleRoomAvailabilityNumMB.AutoSize = true;
            this.lblDoubleRoomAvailabilityNumMB.Location = new System.Drawing.Point(144, 26);
            this.lblDoubleRoomAvailabilityNumMB.Name = "lblDoubleRoomAvailabilityNumMB";
            this.lblDoubleRoomAvailabilityNumMB.Size = new System.Drawing.Size(13, 13);
            this.lblDoubleRoomAvailabilityNumMB.TabIndex = 36;
            this.lblDoubleRoomAvailabilityNumMB.Text = "0";
            // 
            // lblSingleRoomAvailabilityNumMB
            // 
            this.lblSingleRoomAvailabilityNumMB.AutoSize = true;
            this.lblSingleRoomAvailabilityNumMB.Location = new System.Drawing.Point(68, 26);
            this.lblSingleRoomAvailabilityNumMB.Name = "lblSingleRoomAvailabilityNumMB";
            this.lblSingleRoomAvailabilityNumMB.Size = new System.Drawing.Size(13, 13);
            this.lblSingleRoomAvailabilityNumMB.TabIndex = 35;
            this.lblSingleRoomAvailabilityNumMB.Text = "0";
            // 
            // lblTwinRoomAvailabilityMB
            // 
            this.lblTwinRoomAvailabilityMB.AutoSize = true;
            this.lblTwinRoomAvailabilityMB.Location = new System.Drawing.Point(171, 26);
            this.lblTwinRoomAvailabilityMB.Name = "lblTwinRoomAvailabilityMB";
            this.lblTwinRoomAvailabilityMB.Size = new System.Drawing.Size(33, 13);
            this.lblTwinRoomAvailabilityMB.TabIndex = 35;
            this.lblTwinRoomAvailabilityMB.Text = "Twin:";
            // 
            // lblDoubleRoomAvailabilityMB
            // 
            this.lblDoubleRoomAvailabilityMB.AutoSize = true;
            this.lblDoubleRoomAvailabilityMB.Location = new System.Drawing.Point(94, 26);
            this.lblDoubleRoomAvailabilityMB.Name = "lblDoubleRoomAvailabilityMB";
            this.lblDoubleRoomAvailabilityMB.Size = new System.Drawing.Size(44, 13);
            this.lblDoubleRoomAvailabilityMB.TabIndex = 35;
            this.lblDoubleRoomAvailabilityMB.Text = "Double:";
            // 
            // lblSingleRoomAvailabilityMB
            // 
            this.lblSingleRoomAvailabilityMB.AutoSize = true;
            this.lblSingleRoomAvailabilityMB.Location = new System.Drawing.Point(23, 26);
            this.lblSingleRoomAvailabilityMB.Name = "lblSingleRoomAvailabilityMB";
            this.lblSingleRoomAvailabilityMB.Size = new System.Drawing.Size(39, 13);
            this.lblSingleRoomAvailabilityMB.TabIndex = 35;
            this.lblSingleRoomAvailabilityMB.Text = "Single:";
            // 
            // txtBookingIdMB
            // 
            this.txtBookingIdMB.Enabled = false;
            this.txtBookingIdMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingIdMB.Location = new System.Drawing.Point(88, 19);
            this.txtBookingIdMB.Name = "txtBookingIdMB";
            this.txtBookingIdMB.Size = new System.Drawing.Size(279, 20);
            this.txtBookingIdMB.TabIndex = 36;
            // 
            // lblBookingIdMB
            // 
            this.lblBookingIdMB.AutoSize = true;
            this.lblBookingIdMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingIdMB.Location = new System.Drawing.Point(7, 22);
            this.lblBookingIdMB.Name = "lblBookingIdMB";
            this.lblBookingIdMB.Size = new System.Drawing.Size(60, 13);
            this.lblBookingIdMB.TabIndex = 35;
            this.lblBookingIdMB.Text = "Booking ID";
            // 
            // txtCustomerAdditionalNotesMB
            // 
            this.txtCustomerAdditionalNotesMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAdditionalNotesMB.Location = new System.Drawing.Point(94, 241);
            this.txtCustomerAdditionalNotesMB.Multiline = true;
            this.txtCustomerAdditionalNotesMB.Name = "txtCustomerAdditionalNotesMB";
            this.txtCustomerAdditionalNotesMB.Size = new System.Drawing.Size(274, 66);
            this.txtCustomerAdditionalNotesMB.TabIndex = 34;
            // 
            // lblCustomerAdditionalNotesMB
            // 
            this.lblCustomerAdditionalNotesMB.AutoSize = true;
            this.lblCustomerAdditionalNotesMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAdditionalNotesMB.Location = new System.Drawing.Point(7, 244);
            this.lblCustomerAdditionalNotesMB.Name = "lblCustomerAdditionalNotesMB";
            this.lblCustomerAdditionalNotesMB.Size = new System.Drawing.Size(87, 13);
            this.lblCustomerAdditionalNotesMB.TabIndex = 33;
            this.lblCustomerAdditionalNotesMB.Text = "Additional Notes:";
            // 
            // btnCustomerTwinRoomIncreaseMB
            // 
            this.btnCustomerTwinRoomIncreaseMB.BackColor = System.Drawing.Color.Maroon;
            this.btnCustomerTwinRoomIncreaseMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerTwinRoomIncreaseMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerTwinRoomIncreaseMB.ForeColor = System.Drawing.Color.White;
            this.btnCustomerTwinRoomIncreaseMB.Location = new System.Drawing.Point(112, 378);
            this.btnCustomerTwinRoomIncreaseMB.Name = "btnCustomerTwinRoomIncreaseMB";
            this.btnCustomerTwinRoomIncreaseMB.Size = new System.Drawing.Size(20, 20);
            this.btnCustomerTwinRoomIncreaseMB.TabIndex = 32;
            this.btnCustomerTwinRoomIncreaseMB.Text = "+";
            this.btnCustomerTwinRoomIncreaseMB.UseVisualStyleBackColor = false;
            this.btnCustomerTwinRoomIncreaseMB.Click += new System.EventHandler(this.btnCustomerTwinRoomIncreaseMB_Click);
            // 
            // btnCustomerTwinRoomDecreaseMB
            // 
            this.btnCustomerTwinRoomDecreaseMB.BackColor = System.Drawing.Color.Maroon;
            this.btnCustomerTwinRoomDecreaseMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerTwinRoomDecreaseMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerTwinRoomDecreaseMB.ForeColor = System.Drawing.Color.White;
            this.btnCustomerTwinRoomDecreaseMB.Location = new System.Drawing.Point(60, 378);
            this.btnCustomerTwinRoomDecreaseMB.Name = "btnCustomerTwinRoomDecreaseMB";
            this.btnCustomerTwinRoomDecreaseMB.Size = new System.Drawing.Size(20, 20);
            this.btnCustomerTwinRoomDecreaseMB.TabIndex = 31;
            this.btnCustomerTwinRoomDecreaseMB.Text = "-";
            this.btnCustomerTwinRoomDecreaseMB.UseVisualStyleBackColor = false;
            this.btnCustomerTwinRoomDecreaseMB.Click += new System.EventHandler(this.btnCustomerTwinRoomDecreaseMB_Click);
            // 
            // lblCustomerTwinRoomNumberMB
            // 
            this.lblCustomerTwinRoomNumberMB.AutoSize = true;
            this.lblCustomerTwinRoomNumberMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTwinRoomNumberMB.Location = new System.Drawing.Point(90, 381);
            this.lblCustomerTwinRoomNumberMB.Name = "lblCustomerTwinRoomNumberMB";
            this.lblCustomerTwinRoomNumberMB.Size = new System.Drawing.Size(13, 13);
            this.lblCustomerTwinRoomNumberMB.TabIndex = 30;
            this.lblCustomerTwinRoomNumberMB.Text = "0";
            // 
            // btnCustomerDoubleRoomIncreaseMB
            // 
            this.btnCustomerDoubleRoomIncreaseMB.BackColor = System.Drawing.Color.Maroon;
            this.btnCustomerDoubleRoomIncreaseMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerDoubleRoomIncreaseMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDoubleRoomIncreaseMB.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDoubleRoomIncreaseMB.Location = new System.Drawing.Point(112, 349);
            this.btnCustomerDoubleRoomIncreaseMB.Name = "btnCustomerDoubleRoomIncreaseMB";
            this.btnCustomerDoubleRoomIncreaseMB.Size = new System.Drawing.Size(20, 20);
            this.btnCustomerDoubleRoomIncreaseMB.TabIndex = 29;
            this.btnCustomerDoubleRoomIncreaseMB.Text = "+";
            this.btnCustomerDoubleRoomIncreaseMB.UseVisualStyleBackColor = false;
            this.btnCustomerDoubleRoomIncreaseMB.Click += new System.EventHandler(this.btnCustomerDoubleRoomIncreaseMB_Click);
            // 
            // btnCustomerDoubleRoomDecreaseMB
            // 
            this.btnCustomerDoubleRoomDecreaseMB.BackColor = System.Drawing.Color.Maroon;
            this.btnCustomerDoubleRoomDecreaseMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerDoubleRoomDecreaseMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDoubleRoomDecreaseMB.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDoubleRoomDecreaseMB.Location = new System.Drawing.Point(60, 349);
            this.btnCustomerDoubleRoomDecreaseMB.Name = "btnCustomerDoubleRoomDecreaseMB";
            this.btnCustomerDoubleRoomDecreaseMB.Size = new System.Drawing.Size(20, 20);
            this.btnCustomerDoubleRoomDecreaseMB.TabIndex = 28;
            this.btnCustomerDoubleRoomDecreaseMB.Text = "-";
            this.btnCustomerDoubleRoomDecreaseMB.UseVisualStyleBackColor = false;
            this.btnCustomerDoubleRoomDecreaseMB.Click += new System.EventHandler(this.btnCustomerDoubleRoomDecreaseMB_Click);
            // 
            // lblCustomerDoubleRoomNumberMB
            // 
            this.lblCustomerDoubleRoomNumberMB.AutoSize = true;
            this.lblCustomerDoubleRoomNumberMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDoubleRoomNumberMB.Location = new System.Drawing.Point(90, 353);
            this.lblCustomerDoubleRoomNumberMB.Name = "lblCustomerDoubleRoomNumberMB";
            this.lblCustomerDoubleRoomNumberMB.Size = new System.Drawing.Size(13, 13);
            this.lblCustomerDoubleRoomNumberMB.TabIndex = 27;
            this.lblCustomerDoubleRoomNumberMB.Text = "0";
            // 
            // btnCustomerSingleRoomIncreaseMB
            // 
            this.btnCustomerSingleRoomIncreaseMB.BackColor = System.Drawing.Color.Maroon;
            this.btnCustomerSingleRoomIncreaseMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSingleRoomIncreaseMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerSingleRoomIncreaseMB.ForeColor = System.Drawing.Color.White;
            this.btnCustomerSingleRoomIncreaseMB.Location = new System.Drawing.Point(112, 320);
            this.btnCustomerSingleRoomIncreaseMB.Name = "btnCustomerSingleRoomIncreaseMB";
            this.btnCustomerSingleRoomIncreaseMB.Size = new System.Drawing.Size(20, 20);
            this.btnCustomerSingleRoomIncreaseMB.TabIndex = 26;
            this.btnCustomerSingleRoomIncreaseMB.Text = "+";
            this.btnCustomerSingleRoomIncreaseMB.UseVisualStyleBackColor = false;
            this.btnCustomerSingleRoomIncreaseMB.Click += new System.EventHandler(this.btnCustomerSingleRoomIncreaseMB_Click);
            // 
            // btnCustomerSingleRoomDecreaseMB
            // 
            this.btnCustomerSingleRoomDecreaseMB.BackColor = System.Drawing.Color.Maroon;
            this.btnCustomerSingleRoomDecreaseMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSingleRoomDecreaseMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerSingleRoomDecreaseMB.ForeColor = System.Drawing.Color.White;
            this.btnCustomerSingleRoomDecreaseMB.Location = new System.Drawing.Point(60, 320);
            this.btnCustomerSingleRoomDecreaseMB.Name = "btnCustomerSingleRoomDecreaseMB";
            this.btnCustomerSingleRoomDecreaseMB.Size = new System.Drawing.Size(20, 20);
            this.btnCustomerSingleRoomDecreaseMB.TabIndex = 25;
            this.btnCustomerSingleRoomDecreaseMB.Text = "-";
            this.btnCustomerSingleRoomDecreaseMB.UseVisualStyleBackColor = false;
            this.btnCustomerSingleRoomDecreaseMB.Click += new System.EventHandler(this.btnCustomerSingleRoomDecreaseMB_Click);
            // 
            // lblCustomerSingleRoomNumberMB
            // 
            this.lblCustomerSingleRoomNumberMB.AutoSize = true;
            this.lblCustomerSingleRoomNumberMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerSingleRoomNumberMB.Location = new System.Drawing.Point(90, 324);
            this.lblCustomerSingleRoomNumberMB.Name = "lblCustomerSingleRoomNumberMB";
            this.lblCustomerSingleRoomNumberMB.Size = new System.Drawing.Size(13, 13);
            this.lblCustomerSingleRoomNumberMB.TabIndex = 24;
            this.lblCustomerSingleRoomNumberMB.Text = "0";
            // 
            // lblCustomerTwinRoomMB
            // 
            this.lblCustomerTwinRoomMB.AutoSize = true;
            this.lblCustomerTwinRoomMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTwinRoomMB.Location = new System.Drawing.Point(13, 381);
            this.lblCustomerTwinRoomMB.Name = "lblCustomerTwinRoomMB";
            this.lblCustomerTwinRoomMB.Size = new System.Drawing.Size(33, 13);
            this.lblCustomerTwinRoomMB.TabIndex = 23;
            this.lblCustomerTwinRoomMB.Text = "Twin:";
            // 
            // lblCustomerDoubleRoomMB
            // 
            this.lblCustomerDoubleRoomMB.AutoSize = true;
            this.lblCustomerDoubleRoomMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDoubleRoomMB.Location = new System.Drawing.Point(13, 355);
            this.lblCustomerDoubleRoomMB.Name = "lblCustomerDoubleRoomMB";
            this.lblCustomerDoubleRoomMB.Size = new System.Drawing.Size(44, 13);
            this.lblCustomerDoubleRoomMB.TabIndex = 22;
            this.lblCustomerDoubleRoomMB.Text = "Double:";
            // 
            // lblCustomerSingleRoomMB
            // 
            this.lblCustomerSingleRoomMB.AutoSize = true;
            this.lblCustomerSingleRoomMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerSingleRoomMB.Location = new System.Drawing.Point(13, 324);
            this.lblCustomerSingleRoomMB.Name = "lblCustomerSingleRoomMB";
            this.lblCustomerSingleRoomMB.Size = new System.Drawing.Size(39, 13);
            this.lblCustomerSingleRoomMB.TabIndex = 21;
            this.lblCustomerSingleRoomMB.Text = "Single:";
            // 
            // dtpCustomerCheckOutMB
            // 
            this.dtpCustomerCheckOutMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCustomerCheckOutMB.Location = new System.Drawing.Point(88, 79);
            this.dtpCustomerCheckOutMB.Name = "dtpCustomerCheckOutMB";
            this.dtpCustomerCheckOutMB.Size = new System.Drawing.Size(279, 20);
            this.dtpCustomerCheckOutMB.TabIndex = 20;
            // 
            // dtpCustomerCheckInMB
            // 
            this.dtpCustomerCheckInMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCustomerCheckInMB.Location = new System.Drawing.Point(88, 45);
            this.dtpCustomerCheckInMB.Name = "dtpCustomerCheckInMB";
            this.dtpCustomerCheckInMB.Size = new System.Drawing.Size(280, 20);
            this.dtpCustomerCheckInMB.TabIndex = 17;
            // 
            // lblCustomerCheckInMB
            // 
            this.lblCustomerCheckInMB.AutoSize = true;
            this.lblCustomerCheckInMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCheckInMB.Location = new System.Drawing.Point(7, 50);
            this.lblCustomerCheckInMB.Name = "lblCustomerCheckInMB";
            this.lblCustomerCheckInMB.Size = new System.Drawing.Size(78, 13);
            this.lblCustomerCheckInMB.TabIndex = 0;
            this.lblCustomerCheckInMB.Text = "Check-in Date:";
            // 
            // txtCustomerGuestNamesMB
            // 
            this.txtCustomerGuestNamesMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerGuestNamesMB.Location = new System.Drawing.Point(88, 182);
            this.txtCustomerGuestNamesMB.Multiline = true;
            this.txtCustomerGuestNamesMB.Name = "txtCustomerGuestNamesMB";
            this.txtCustomerGuestNamesMB.Size = new System.Drawing.Size(279, 43);
            this.txtCustomerGuestNamesMB.TabIndex = 11;
            // 
            // lblCustomerGuestNamesMB
            // 
            this.lblCustomerGuestNamesMB.AutoSize = true;
            this.lblCustomerGuestNamesMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerGuestNamesMB.Location = new System.Drawing.Point(7, 185);
            this.lblCustomerGuestNamesMB.Name = "lblCustomerGuestNamesMB";
            this.lblCustomerGuestNamesMB.Size = new System.Drawing.Size(72, 13);
            this.lblCustomerGuestNamesMB.TabIndex = 1;
            this.lblCustomerGuestNamesMB.Text = "Guest names:";
            // 
            // lblCustomerCheckOutMB
            // 
            this.lblCustomerCheckOutMB.AutoSize = true;
            this.lblCustomerCheckOutMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCheckOutMB.Location = new System.Drawing.Point(7, 84);
            this.lblCustomerCheckOutMB.Name = "lblCustomerCheckOutMB";
            this.lblCustomerCheckOutMB.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerCheckOutMB.TabIndex = 2;
            this.lblCustomerCheckOutMB.Text = "Check-out Date:";
            // 
            // groupBoxCustomerdetailsMB
            // 
            this.groupBoxCustomerdetailsMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxCustomerdetailsMB.Controls.Add(this.txtGuestIdMB);
            this.groupBoxCustomerdetailsMB.Controls.Add(this.lblGuestIdMB);
            this.groupBoxCustomerdetailsMB.Controls.Add(this.groupBoxSaveCustomerDetailsMB);
            this.groupBoxCustomerdetailsMB.Controls.Add(this.groupBoxMarketingConsentMB);
            this.groupBoxCustomerdetailsMB.Controls.Add(this.txtCustomerNameMB);
            this.groupBoxCustomerdetailsMB.Controls.Add(this.txtCustomerEmailMB);
            this.groupBoxCustomerdetailsMB.Controls.Add(this.lblCustomerNameMB);
            this.groupBoxCustomerdetailsMB.Controls.Add(this.txtCustomerPhoneNumMB);
            this.groupBoxCustomerdetailsMB.Controls.Add(this.lblCutomerPhoneNumMB);
            this.groupBoxCustomerdetailsMB.Controls.Add(this.txtCutomerAddressMB);
            this.groupBoxCustomerdetailsMB.Controls.Add(this.lblCustomerAddressMB);
            this.groupBoxCustomerdetailsMB.Controls.Add(this.lblCustomerEmailMB);
            this.groupBoxCustomerdetailsMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomerdetailsMB.Location = new System.Drawing.Point(3, 135);
            this.groupBoxCustomerdetailsMB.Name = "groupBoxCustomerdetailsMB";
            this.groupBoxCustomerdetailsMB.Size = new System.Drawing.Size(281, 328);
            this.groupBoxCustomerdetailsMB.TabIndex = 16;
            this.groupBoxCustomerdetailsMB.TabStop = false;
            this.groupBoxCustomerdetailsMB.Text = "Customer Details";
            // 
            // txtGuestIdMB
            // 
            this.txtGuestIdMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGuestIdMB.Enabled = false;
            this.txtGuestIdMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtGuestIdMB.Location = new System.Drawing.Point(58, 26);
            this.txtGuestIdMB.Name = "txtGuestIdMB";
            this.txtGuestIdMB.Size = new System.Drawing.Size(215, 20);
            this.txtGuestIdMB.TabIndex = 26;
            // 
            // lblGuestIdMB
            // 
            this.lblGuestIdMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGuestIdMB.AutoSize = true;
            this.lblGuestIdMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblGuestIdMB.Location = new System.Drawing.Point(7, 29);
            this.lblGuestIdMB.Name = "lblGuestIdMB";
            this.lblGuestIdMB.Size = new System.Drawing.Size(49, 13);
            this.lblGuestIdMB.TabIndex = 25;
            this.lblGuestIdMB.Text = "Guest ID";
            // 
            // groupBoxSaveCustomerDetailsMB
            // 
            this.groupBoxSaveCustomerDetailsMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSaveCustomerDetailsMB.Controls.Add(this.radioBtnMBCustomerSaveDetailsNO);
            this.groupBoxSaveCustomerDetailsMB.Controls.Add(this.radioBtnMBCustomerSaveDetailsYES);
            this.groupBoxSaveCustomerDetailsMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBoxSaveCustomerDetailsMB.Location = new System.Drawing.Point(139, 249);
            this.groupBoxSaveCustomerDetailsMB.Name = "groupBoxSaveCustomerDetailsMB";
            this.groupBoxSaveCustomerDetailsMB.Size = new System.Drawing.Size(136, 65);
            this.groupBoxSaveCustomerDetailsMB.TabIndex = 24;
            this.groupBoxSaveCustomerDetailsMB.TabStop = false;
            this.groupBoxSaveCustomerDetailsMB.Text = "Save Customer Details";
            // 
            // radioBtnMBCustomerSaveDetailsNO
            // 
            this.radioBtnMBCustomerSaveDetailsNO.AutoSize = true;
            this.radioBtnMBCustomerSaveDetailsNO.Location = new System.Drawing.Point(77, 31);
            this.radioBtnMBCustomerSaveDetailsNO.Name = "radioBtnMBCustomerSaveDetailsNO";
            this.radioBtnMBCustomerSaveDetailsNO.Size = new System.Drawing.Size(39, 17);
            this.radioBtnMBCustomerSaveDetailsNO.TabIndex = 22;
            this.radioBtnMBCustomerSaveDetailsNO.TabStop = true;
            this.radioBtnMBCustomerSaveDetailsNO.Text = "No";
            this.radioBtnMBCustomerSaveDetailsNO.UseVisualStyleBackColor = true;
            // 
            // radioBtnMBCustomerSaveDetailsYES
            // 
            this.radioBtnMBCustomerSaveDetailsYES.AutoSize = true;
            this.radioBtnMBCustomerSaveDetailsYES.Location = new System.Drawing.Point(14, 31);
            this.radioBtnMBCustomerSaveDetailsYES.Name = "radioBtnMBCustomerSaveDetailsYES";
            this.radioBtnMBCustomerSaveDetailsYES.Size = new System.Drawing.Size(43, 17);
            this.radioBtnMBCustomerSaveDetailsYES.TabIndex = 21;
            this.radioBtnMBCustomerSaveDetailsYES.TabStop = true;
            this.radioBtnMBCustomerSaveDetailsYES.Text = "Yes";
            this.radioBtnMBCustomerSaveDetailsYES.UseVisualStyleBackColor = true;
            // 
            // groupBoxMarketingConsentMB
            // 
            this.groupBoxMarketingConsentMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxMarketingConsentMB.Controls.Add(this.radioBtnMBCustomerMarketingConsentNO);
            this.groupBoxMarketingConsentMB.Controls.Add(this.radioBtnMBCustomerMarketingConsentYES);
            this.groupBoxMarketingConsentMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBoxMarketingConsentMB.Location = new System.Drawing.Point(9, 249);
            this.groupBoxMarketingConsentMB.Name = "groupBoxMarketingConsentMB";
            this.groupBoxMarketingConsentMB.Size = new System.Drawing.Size(117, 65);
            this.groupBoxMarketingConsentMB.TabIndex = 23;
            this.groupBoxMarketingConsentMB.TabStop = false;
            this.groupBoxMarketingConsentMB.Text = "Marketing Consent";
            // 
            // radioBtnMBCustomerMarketingConsentNO
            // 
            this.radioBtnMBCustomerMarketingConsentNO.AutoSize = true;
            this.radioBtnMBCustomerMarketingConsentNO.Location = new System.Drawing.Point(63, 31);
            this.radioBtnMBCustomerMarketingConsentNO.Name = "radioBtnMBCustomerMarketingConsentNO";
            this.radioBtnMBCustomerMarketingConsentNO.Size = new System.Drawing.Size(39, 17);
            this.radioBtnMBCustomerMarketingConsentNO.TabIndex = 19;
            this.radioBtnMBCustomerMarketingConsentNO.TabStop = true;
            this.radioBtnMBCustomerMarketingConsentNO.Text = "No";
            this.radioBtnMBCustomerMarketingConsentNO.UseVisualStyleBackColor = true;
            // 
            // radioBtnMBCustomerMarketingConsentYES
            // 
            this.radioBtnMBCustomerMarketingConsentYES.AutoSize = true;
            this.radioBtnMBCustomerMarketingConsentYES.Location = new System.Drawing.Point(9, 31);
            this.radioBtnMBCustomerMarketingConsentYES.Name = "radioBtnMBCustomerMarketingConsentYES";
            this.radioBtnMBCustomerMarketingConsentYES.Size = new System.Drawing.Size(43, 17);
            this.radioBtnMBCustomerMarketingConsentYES.TabIndex = 17;
            this.radioBtnMBCustomerMarketingConsentYES.TabStop = true;
            this.radioBtnMBCustomerMarketingConsentYES.Text = "Yes";
            this.radioBtnMBCustomerMarketingConsentYES.UseVisualStyleBackColor = true;
            // 
            // txtCustomerNameMB
            // 
            this.txtCustomerNameMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCustomerNameMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCustomerNameMB.Location = new System.Drawing.Point(46, 58);
            this.txtCustomerNameMB.Name = "txtCustomerNameMB";
            this.txtCustomerNameMB.Size = new System.Drawing.Size(227, 20);
            this.txtCustomerNameMB.TabIndex = 9;
            // 
            // txtCustomerEmailMB
            // 
            this.txtCustomerEmailMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCustomerEmailMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCustomerEmailMB.Location = new System.Drawing.Point(46, 214);
            this.txtCustomerEmailMB.Name = "txtCustomerEmailMB";
            this.txtCustomerEmailMB.Size = new System.Drawing.Size(227, 20);
            this.txtCustomerEmailMB.TabIndex = 12;
            // 
            // lblCustomerNameMB
            // 
            this.lblCustomerNameMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCustomerNameMB.AutoSize = true;
            this.lblCustomerNameMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCustomerNameMB.Location = new System.Drawing.Point(7, 61);
            this.lblCustomerNameMB.Name = "lblCustomerNameMB";
            this.lblCustomerNameMB.Size = new System.Drawing.Size(41, 13);
            this.lblCustomerNameMB.TabIndex = 0;
            this.lblCustomerNameMB.Text = "Name: ";
            // 
            // txtCustomerPhoneNumMB
            // 
            this.txtCustomerPhoneNumMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCustomerPhoneNumMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCustomerPhoneNumMB.Location = new System.Drawing.Point(106, 180);
            this.txtCustomerPhoneNumMB.Name = "txtCustomerPhoneNumMB";
            this.txtCustomerPhoneNumMB.Size = new System.Drawing.Size(167, 20);
            this.txtCustomerPhoneNumMB.TabIndex = 11;
            // 
            // lblCutomerPhoneNumMB
            // 
            this.lblCutomerPhoneNumMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCutomerPhoneNumMB.AutoSize = true;
            this.lblCutomerPhoneNumMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCutomerPhoneNumMB.Location = new System.Drawing.Point(7, 187);
            this.lblCutomerPhoneNumMB.Name = "lblCutomerPhoneNumMB";
            this.lblCutomerPhoneNumMB.Size = new System.Drawing.Size(81, 13);
            this.lblCutomerPhoneNumMB.TabIndex = 1;
            this.lblCutomerPhoneNumMB.Text = "Phone Number:";
            // 
            // txtCutomerAddressMB
            // 
            this.txtCutomerAddressMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCutomerAddressMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCutomerAddressMB.Location = new System.Drawing.Point(58, 89);
            this.txtCutomerAddressMB.Multiline = true;
            this.txtCutomerAddressMB.Name = "txtCutomerAddressMB";
            this.txtCutomerAddressMB.Size = new System.Drawing.Size(215, 81);
            this.txtCutomerAddressMB.TabIndex = 10;
            // 
            // lblCustomerAddressMB
            // 
            this.lblCustomerAddressMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCustomerAddressMB.AutoSize = true;
            this.lblCustomerAddressMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCustomerAddressMB.Location = new System.Drawing.Point(7, 91);
            this.lblCustomerAddressMB.Name = "lblCustomerAddressMB";
            this.lblCustomerAddressMB.Size = new System.Drawing.Size(48, 13);
            this.lblCustomerAddressMB.TabIndex = 2;
            this.lblCustomerAddressMB.Text = "Address:";
            // 
            // lblCustomerEmailMB
            // 
            this.lblCustomerEmailMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCustomerEmailMB.AutoSize = true;
            this.lblCustomerEmailMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCustomerEmailMB.Location = new System.Drawing.Point(7, 217);
            this.lblCustomerEmailMB.Name = "lblCustomerEmailMB";
            this.lblCustomerEmailMB.Size = new System.Drawing.Size(38, 13);
            this.lblCustomerEmailMB.TabIndex = 3;
            this.lblCustomerEmailMB.Text = "Email: ";
            // 
            // listViewManageBooking
            // 
            this.listViewManageBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewManageBooking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderManageName,
            this.columnHeaderManageAddress,
            this.columnHeaderManagePhoneNum,
            this.columnHeaderManageEmail,
            this.columnHeaderManageMarktingConsent,
            this.columnHeaderManageSaveCusDetails,
            this.columnHeaderPaymentHolderName,
            this.columnHeaderPaymentCardNum,
            this.columnHeaderPaymentExpiryDate,
            this.columnHeaderPaymentSecurityCode,
            this.columnHeaderPaymentSaveDetails,
            this.columnHeaderBookingCheckIn,
            this.columnHeaderBookingCheckOut,
            this.columnHeaderBookingGusetNames,
            this.columnHeaderBookingAdditionalNotes,
            this.columnHeaderBookingSingleRoom,
            this.columnHeaderBookingDoubleRoom,
            this.columnHeaderBookingTwinRoom,
            this.columnHeaderBookingID,
            this.columnHeaderBookingTotal,
            this.columnHeaderGuestID});
            this.listViewManageBooking.FullRowSelect = true;
            this.listViewManageBooking.GridLines = true;
            this.listViewManageBooking.HideSelection = false;
            this.listViewManageBooking.Location = new System.Drawing.Point(-4, 0);
            this.listViewManageBooking.MultiSelect = false;
            this.listViewManageBooking.Name = "listViewManageBooking";
            this.listViewManageBooking.Size = new System.Drawing.Size(987, 130);
            this.listViewManageBooking.TabIndex = 0;
            this.listViewManageBooking.UseCompatibleStateImageBehavior = false;
            this.listViewManageBooking.View = System.Windows.Forms.View.Details;
            this.listViewManageBooking.SelectedIndexChanged += new System.EventHandler(this.listViewManageBooking_SelectedIndexChanged);
            // 
            // columnHeaderManageName
            // 
            this.columnHeaderManageName.Text = "Name";
            this.columnHeaderManageName.Width = 150;
            // 
            // columnHeaderManageAddress
            // 
            this.columnHeaderManageAddress.Text = "Address";
            this.columnHeaderManageAddress.Width = 200;
            // 
            // columnHeaderManagePhoneNum
            // 
            this.columnHeaderManagePhoneNum.Text = "Phone Number";
            this.columnHeaderManagePhoneNum.Width = 100;
            // 
            // columnHeaderManageEmail
            // 
            this.columnHeaderManageEmail.Text = "Email";
            this.columnHeaderManageEmail.Width = 200;
            // 
            // columnHeaderManageMarktingConsent
            // 
            this.columnHeaderManageMarktingConsent.Text = "Markting Consent";
            this.columnHeaderManageMarktingConsent.Width = 110;
            // 
            // columnHeaderManageSaveCusDetails
            // 
            this.columnHeaderManageSaveCusDetails.Text = "Save Customer Details";
            this.columnHeaderManageSaveCusDetails.Width = 130;
            // 
            // columnHeaderPaymentHolderName
            // 
            this.columnHeaderPaymentHolderName.Text = "Holder Name";
            this.columnHeaderPaymentHolderName.Width = 150;
            // 
            // columnHeaderPaymentCardNum
            // 
            this.columnHeaderPaymentCardNum.Text = "Card Number";
            this.columnHeaderPaymentCardNum.Width = 100;
            // 
            // columnHeaderPaymentExpiryDate
            // 
            this.columnHeaderPaymentExpiryDate.Text = "ExpiryDate";
            this.columnHeaderPaymentExpiryDate.Width = 100;
            // 
            // columnHeaderPaymentSecurityCode
            // 
            this.columnHeaderPaymentSecurityCode.Text = "Security Code";
            this.columnHeaderPaymentSecurityCode.Width = 100;
            // 
            // columnHeaderPaymentSaveDetails
            // 
            this.columnHeaderPaymentSaveDetails.Text = "Save Payment Details";
            this.columnHeaderPaymentSaveDetails.Width = 200;
            // 
            // columnHeaderBookingCheckIn
            // 
            this.columnHeaderBookingCheckIn.Text = "Check-in";
            this.columnHeaderBookingCheckIn.Width = 150;
            // 
            // columnHeaderBookingCheckOut
            // 
            this.columnHeaderBookingCheckOut.Text = "Check-out";
            this.columnHeaderBookingCheckOut.Width = 150;
            // 
            // columnHeaderBookingGusetNames
            // 
            this.columnHeaderBookingGusetNames.Text = "Guset Names";
            this.columnHeaderBookingGusetNames.Width = 300;
            // 
            // columnHeaderBookingAdditionalNotes
            // 
            this.columnHeaderBookingAdditionalNotes.Text = "Additional Notes";
            this.columnHeaderBookingAdditionalNotes.Width = 300;
            // 
            // columnHeaderBookingSingleRoom
            // 
            this.columnHeaderBookingSingleRoom.Text = "Single Room";
            this.columnHeaderBookingSingleRoom.Width = 80;
            // 
            // columnHeaderBookingDoubleRoom
            // 
            this.columnHeaderBookingDoubleRoom.Text = "Double Room";
            this.columnHeaderBookingDoubleRoom.Width = 90;
            // 
            // columnHeaderBookingTwinRoom
            // 
            this.columnHeaderBookingTwinRoom.Text = "Twin Room";
            this.columnHeaderBookingTwinRoom.Width = 80;
            // 
            // columnHeaderBookingTotal
            // 
            this.columnHeaderBookingTotal.Text = "Total";
            // 
            // columnHeaderGuestID
            // 
            this.columnHeaderGuestID.Text = "Guest ID";
            this.columnHeaderGuestID.Width = 0;
            // 
            // tabPageLogOut
            // 
            this.tabPageLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageLogOut.Controls.Add(this.btnLock);
            this.tabPageLogOut.Controls.Add(this.btnLogOut);
            this.tabPageLogOut.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogOut.Name = "tabPageLogOut";
            this.tabPageLogOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogOut.Size = new System.Drawing.Size(984, 548);
            this.tabPageLogOut.TabIndex = 6;
            this.tabPageLogOut.Text = "Log-out";
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.Maroon;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLock.Font = new System.Drawing.Font("Segoe UI", 38F);
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.Location = new System.Drawing.Point(528, 186);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(219, 121);
            this.btnLock.TabIndex = 5;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Maroon;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 38F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(217, 186);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(219, 121);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 575);
            this.ControlBox = false;
            this.Controls.Add(this.tabControlReceptionist);
            this.Name = "ReceptionistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReceptionistForm_Load);
            this.tabControlReceptionist.ResumeLayout(false);
            this.tabPageCheckIn.ResumeLayout(false);
            this.tabPageCheckOut.ResumeLayout(false);
            this.tabPageCheckOut.PerformLayout();
            this.tabPageBook.ResumeLayout(false);
            this.groupBoxBookingDetails.ResumeLayout(false);
            this.groupBoxBookingDetails.PerformLayout();
            this.groupBoxRoomaAvailabilityType.ResumeLayout(false);
            this.groupBoxRoomaAvailabilityType.PerformLayout();
            this.groupBoxPaymentDetails.ResumeLayout(false);
            this.groupBoxPaymentDetails.PerformLayout();
            this.groupBoxCustomerDetails.ResumeLayout(false);
            this.groupBoxCustomerDetails.PerformLayout();
            this.groupBoxSaveCustomerDetails.ResumeLayout(false);
            this.groupBoxSaveCustomerDetails.PerformLayout();
            this.groupBoxMarketingConsent.ResumeLayout(false);
            this.groupBoxMarketingConsent.PerformLayout();
            this.tabPageViewBooking.ResumeLayout(false);
            this.groupBoxSearchVB.ResumeLayout(false);
            this.groupBoxSearchVB.PerformLayout();
            this.tabPageCancelBooking.ResumeLayout(false);
            this.tabPageCancelBooking.PerformLayout();
            this.groupBoxCustomerPaymentMB.ResumeLayout(false);
            this.groupBoxCustomerPaymentMB.PerformLayout();
            this.groupBoxCustomerBookingMB.ResumeLayout(false);
            this.groupBoxCustomerBookingMB.PerformLayout();
            this.groupBoxRoomaAvailabilityTypeMB.ResumeLayout(false);
            this.groupBoxRoomaAvailabilityTypeMB.PerformLayout();
            this.groupBoxCustomerdetailsMB.ResumeLayout(false);
            this.groupBoxCustomerdetailsMB.PerformLayout();
            this.groupBoxSaveCustomerDetailsMB.ResumeLayout(false);
            this.groupBoxSaveCustomerDetailsMB.PerformLayout();
            this.groupBoxMarketingConsentMB.ResumeLayout(false);
            this.groupBoxMarketingConsentMB.PerformLayout();
            this.tabPageLogOut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReceptionist;
        private System.Windows.Forms.TabPage tabPageCheckIn;
        private System.Windows.Forms.TabPage tabPageCheckOut;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.TabPage tabPageViewBooking;
        private System.Windows.Forms.TabPage tabPageCancelBooking;
        private System.Windows.Forms.GroupBox groupBoxPaymentDetails;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.TextBox txtSecurityCode;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtHolderName;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblSecurityCode;
        private System.Windows.Forms.Label lblHolderName;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.GroupBox groupBoxCustomerDetails;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton radioBtnMarketingConsentNO;
        private System.Windows.Forms.RadioButton radioBtnMarketingConsentYES;
        private System.Windows.Forms.GroupBox groupBoxBookingDetails;
        private System.Windows.Forms.Button btnTwinRoomIncrease;
        private System.Windows.Forms.Button btnTwinRoomDecrease;
        private System.Windows.Forms.Label lblTwinRoomNumber;
        private System.Windows.Forms.Button btnDoubleRoomIncrease;
        private System.Windows.Forms.Button btnDoubleRoomDecrease;
        private System.Windows.Forms.Label lblDoubleRoomNumber;
        private System.Windows.Forms.Button btnSingleRoomIncrease;
        private System.Windows.Forms.Button btnSingleRoomDecrease;
        private System.Windows.Forms.Label lblSingleRoomNumber;
        private System.Windows.Forms.Label lblTwinRoom;
        private System.Windows.Forms.Label lblDoubleRoom;
        private System.Windows.Forms.Label lblSingleRoom;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.TextBox txtGuestNames;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Button btnExistingCustomer;
        private System.Windows.Forms.TextBox txtAdditionalNotes;
        private System.Windows.Forms.Label lblAdditionalNotes;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.ListView listViewSingleRooms;
        private System.Windows.Forms.ColumnHeader columnHeaderSingleRooms;
        private System.Windows.Forms.ListView listViewDoubleRooms;
        private System.Windows.Forms.ColumnHeader columnHeaderDoubleRooms;
        private System.Windows.Forms.ListView listViewTwinRooms;
        private System.Windows.Forms.ColumnHeader columnHeaderTwinRooms;
        private System.Windows.Forms.ListView listViewSelectedRooms;
        private System.Windows.Forms.ColumnHeader columnHeaderSelectedRooms;
        private System.Windows.Forms.Button btnAddTwinRoom;
        private System.Windows.Forms.Button btnAddDoubleRoom;
        private System.Windows.Forms.Button btnAddSingleRoom;
        private System.Windows.Forms.Button btnRemoveSelectedRoom;
        private System.Windows.Forms.TabPage tabPageLogOut;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.RadioButton radioBtnSaveCustomerDetailsNO;
        private System.Windows.Forms.RadioButton radioBtnSaveCustomerDetailsYES;
        private System.Windows.Forms.RadioButton radioBtnSaveCustomerCardDetailsNO;
        private System.Windows.Forms.RadioButton radioBtnSaveCustomerCardDetailsYES;
        private System.Windows.Forms.Label lblSaveCustomerCardDetails;
        private System.Windows.Forms.ListView listViewManageBooking;
        private System.Windows.Forms.ColumnHeader columnHeaderManageAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderManagePhoneNum;
        private System.Windows.Forms.ColumnHeader columnHeaderManageEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderManageMarktingConsent;
        private System.Windows.Forms.ColumnHeader columnHeaderManageSaveCusDetails;
        private System.Windows.Forms.ColumnHeader columnHeaderPaymentHolderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPaymentCardNum;
        private System.Windows.Forms.ColumnHeader columnHeaderPaymentExpiryDate;
        private System.Windows.Forms.ColumnHeader columnHeaderPaymentSecurityCode;
        private System.Windows.Forms.ColumnHeader columnHeaderPaymentSaveDetails;
        private System.Windows.Forms.ColumnHeader columnHeaderBookingCheckIn;
        private System.Windows.Forms.ColumnHeader columnHeaderBookingCheckOut;
        private System.Windows.Forms.ColumnHeader columnHeaderBookingGusetNames;
        private System.Windows.Forms.ColumnHeader columnHeaderBookingAdditionalNotes;
        private System.Windows.Forms.ColumnHeader columnHeaderBookingSingleRoom;
        private System.Windows.Forms.ColumnHeader columnHeaderBookingDoubleRoom;
        private System.Windows.Forms.ColumnHeader columnHeaderBookingTwinRoom;
        private System.Windows.Forms.GroupBox groupBoxCustomerdetailsMB;
        private System.Windows.Forms.RadioButton radioBtnMBCustomerSaveDetailsNO;
        private System.Windows.Forms.RadioButton radioBtnMBCustomerSaveDetailsYES;
        private System.Windows.Forms.RadioButton radioBtnMBCustomerMarketingConsentNO;
        private System.Windows.Forms.RadioButton radioBtnMBCustomerMarketingConsentYES;
        private System.Windows.Forms.TextBox txtCustomerNameMB;
        private System.Windows.Forms.TextBox txtCustomerEmailMB;
        private System.Windows.Forms.Label lblCustomerNameMB;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumMB;
        private System.Windows.Forms.Label lblCutomerPhoneNumMB;
        private System.Windows.Forms.TextBox txtCutomerAddressMB;
        private System.Windows.Forms.Label lblCustomerAddressMB;
        private System.Windows.Forms.Label lblCustomerEmailMB;
        private System.Windows.Forms.GroupBox groupBoxCustomerPaymentMB;
        private System.Windows.Forms.RadioButton radioBtnMBSaveCustomerCardDetailsNO;
        private System.Windows.Forms.DateTimePicker dtpCardExpityDateMB;
        private System.Windows.Forms.RadioButton radioBtnMBSaveCustomerCardDetailsYES;
        private System.Windows.Forms.Label lblCustomerSavePaymentMB;
        private System.Windows.Forms.TextBox txtCardSecurityCodeMB;
        private System.Windows.Forms.TextBox txtCustomerCardNumberMB;
        private System.Windows.Forms.TextBox txtCustomerHolderNameMB;
        private System.Windows.Forms.Label lblCustomerCardNumMB;
        private System.Windows.Forms.Label lblCustomerSecurityCodeMB;
        private System.Windows.Forms.Label lblCustomerHolderNameMB;
        private System.Windows.Forms.Label lblCustomerExpiryDateMB;
        private System.Windows.Forms.GroupBox groupBoxCustomerBookingMB;
        private System.Windows.Forms.TextBox txtCustomerAdditionalNotesMB;
        private System.Windows.Forms.Label lblCustomerAdditionalNotesMB;
        private System.Windows.Forms.Button btnCustomerTwinRoomIncreaseMB;
        private System.Windows.Forms.Button btnCustomerTwinRoomDecreaseMB;
        private System.Windows.Forms.Label lblCustomerTwinRoomNumberMB;
        private System.Windows.Forms.Button btnCustomerDoubleRoomIncreaseMB;
        private System.Windows.Forms.Button btnCustomerDoubleRoomDecreaseMB;
        private System.Windows.Forms.Label lblCustomerDoubleRoomNumberMB;
        private System.Windows.Forms.Button btnCustomerSingleRoomIncreaseMB;
        private System.Windows.Forms.Button btnCustomerSingleRoomDecreaseMB;
        private System.Windows.Forms.Label lblCustomerSingleRoomNumberMB;
        private System.Windows.Forms.Label lblCustomerTwinRoomMB;
        private System.Windows.Forms.Label lblCustomerDoubleRoomMB;
        private System.Windows.Forms.Label lblCustomerSingleRoomMB;
        private System.Windows.Forms.DateTimePicker dtpCustomerCheckOutMB;
        private System.Windows.Forms.DateTimePicker dtpCustomerCheckInMB;
        private System.Windows.Forms.Label lblCustomerCheckInMB;
        private System.Windows.Forms.TextBox txtCustomerGuestNamesMB;
        private System.Windows.Forms.Label lblCustomerGuestNamesMB;
        private System.Windows.Forms.Label lblCustomerCheckOutMB;
        private System.Windows.Forms.Button btnCancelBookingMB;
        private System.Windows.Forms.Button btnEditMB;
        private System.Windows.Forms.Label lblPhoneNumberOrBookingiDSearchMB;
        private System.Windows.Forms.TextBox txtPhoneNumOrBookingIDSearchMB;
        private System.Windows.Forms.Button btnSearchMB;
        private System.Windows.Forms.GroupBox groupBoxRoomaAvailabilityType;
        private System.Windows.Forms.Label lblTwinRoomAvailabilityNum;
        private System.Windows.Forms.Label lblDoubleRoomAvailabilityNum;
        private System.Windows.Forms.Label lblSingleRoomAvailabilityNum;
        private System.Windows.Forms.Label lblTwinRoomAvailability;
        private System.Windows.Forms.Label lblDoubleRoomAvailability;
        private System.Windows.Forms.Label lblSingleRoomAvailability;
        private System.Windows.Forms.GroupBox groupBoxSaveCustomerDetails;
        private System.Windows.Forms.GroupBox groupBoxMarketingConsent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSeachForBooking;
        private System.Windows.Forms.GroupBox groupBoxMarketingConsentMB;
        private System.Windows.Forms.GroupBox groupBoxSaveCustomerDetailsMB;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Button btncancelModificationMB;
        private System.Windows.Forms.Button btnClearMB;
        private System.Windows.Forms.TextBox txtBookingIdMB;
        private System.Windows.Forms.Label lblBookingIdMB;
        private System.Windows.Forms.ColumnHeader columnHeaderManageName;
        private System.Windows.Forms.Button btnSeachForBookingMB;
        private System.Windows.Forms.GroupBox groupBoxRoomaAvailabilityTypeMB;
        private System.Windows.Forms.Label lblTwinRoomAvailabilityNumMB;
        private System.Windows.Forms.Label lblDoubleRoomAvailabilityNumMB;
        private System.Windows.Forms.Label lblSingleRoomAvailabilityNumMB;
        private System.Windows.Forms.Label lblTwinRoomAvailabilityMB;
        private System.Windows.Forms.Label lblDoubleRoomAvailabilityMB;
        private System.Windows.Forms.Label lblSingleRoomAvailabilityMB;
        private System.Windows.Forms.ColumnHeader columnHeaderBookingTotal;
        private System.Windows.Forms.TextBox txtGuestId;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.TextBox txtGuestIdMB;
        private System.Windows.Forms.Label lblGuestIdMB;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestID;
        private System.Windows.Forms.ColumnHeader columnHeaderBookingID;
        private System.Windows.Forms.ListView listViewCheckIn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderPhoneNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderCheckOut;
        private System.Windows.Forms.ColumnHeader columnHeaderRoomType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.ListView listViewCheckOut;
        private System.Windows.Forms.ColumnHeader columnHeaderCheckOutGuestID;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeaderNameCheckOut;
        private System.Windows.Forms.ColumnHeader columnHeaderAddressCheckOut;
        private System.Windows.Forms.ColumnHeader columnHeaderPhoneNumberCheckOut;
        private System.Windows.Forms.ColumnHeader columnHeaderRoomTypeCheckOut;
        private System.Windows.Forms.ListView listView_ViewBooking;
        private System.Windows.Forms.ColumnHeader columnHeaderBookingIdVB;
        private System.Windows.Forms.ColumnHeader columnHeaderCheckInVB;
        private System.Windows.Forms.ColumnHeader columnHeaderCheckOutVB;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestNamesVB;
        private System.Windows.Forms.ColumnHeader columnHeaderAdditionalNotesVB;
        private System.Windows.Forms.ColumnHeader columnHeaderNumSingleVB;
        private System.Windows.Forms.ColumnHeader columnHeaderDoubleRoomVB;
        private System.Windows.Forms.ColumnHeader columnHeaderTwinRoom;
        private System.Windows.Forms.ColumnHeader columnHeaderRoomListVB;
        private System.Windows.Forms.ColumnHeader columnHeaderTotalVB;
        private System.Windows.Forms.ColumnHeader columnHeaderCheckedInVB;
        private System.Windows.Forms.ColumnHeader columnHeaderCheckedOutVB;
        private System.Windows.Forms.ColumnHeader columnHeaderEmpty;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestIDVB;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestNameVB;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestAddressVB;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestPhoneVB;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestEmailVB;
        private System.Windows.Forms.GroupBox groupBoxSearchVB;
        private System.Windows.Forms.Button btnSearchVB;
        private System.Windows.Forms.Label lblToVB;
        private System.Windows.Forms.DateTimePicker dtpToVB;
        private System.Windows.Forms.Label lblFromVB;
        private System.Windows.Forms.DateTimePicker dtpFromVB;
        private System.Windows.Forms.Button btnResetVB;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestMarketingConsentVB;
        private System.Windows.Forms.ColumnHeader columnHeaderGuestSaveDetailsVB;
    }
}