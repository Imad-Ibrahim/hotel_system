
namespace WindowsClient
{
    partial class CleaningSuperForm
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
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCancelAssignment = new System.Windows.Forms.Button();
            this.comboBoxCleaner2 = new System.Windows.Forms.ComboBox();
            this.comboBoxCleaner1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAssignRoom = new System.Windows.Forms.Button();
            this.listViewAssignedRooms = new System.Windows.Forms.ListView();
            this.columnHeaderAssignedEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAssignedRoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAssignedTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAssignedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRoomsToClean = new System.Windows.Forms.ListView();
            this.columnHeaderRoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRoomFloor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonMoreInformation = new System.Windows.Forms.Button();
            this.listViewViewRoomsToClean = new System.Windows.Forms.ListView();
            this.columnHeaderViewRoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderViewRoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderViewRoomFloor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonMoveToCleaningStock = new System.Windows.Forms.Button();
            this.listViewCleaningStock = new System.Windows.Forms.ListView();
            this.columnHeaderCleaninfStockID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCleaninfStockName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCleaninfStockQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCleaninfStockUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCleaninfStockLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewStockItems = new System.Windows.Forms.ListView();
            this.columnHeaderStockItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStockItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStockItemQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStockItemUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStockItemLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabLogout = new System.Windows.Forms.TabPage();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabAdmin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabPage1);
            this.tabAdmin.Controls.Add(this.tabPage2);
            this.tabAdmin.Controls.Add(this.tabPage3);
            this.tabAdmin.Controls.Add(this.tabLogout);
            this.tabAdmin.Location = new System.Drawing.Point(-1, 0);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(996, 577);
            this.tabAdmin.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.buttonCancelAssignment);
            this.tabPage1.Controls.Add(this.comboBoxCleaner2);
            this.tabPage1.Controls.Add(this.comboBoxCleaner1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonAssignRoom);
            this.tabPage1.Controls.Add(this.listViewAssignedRooms);
            this.tabPage1.Controls.Add(this.listViewRoomsToClean);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(988, 551);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Assign Rooms";
            // 
            // buttonCancelAssignment
            // 
            this.buttonCancelAssignment.BackColor = System.Drawing.Color.Maroon;
            this.buttonCancelAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelAssignment.ForeColor = System.Drawing.Color.White;
            this.buttonCancelAssignment.Location = new System.Drawing.Point(479, 267);
            this.buttonCancelAssignment.Name = "buttonCancelAssignment";
            this.buttonCancelAssignment.Size = new System.Drawing.Size(119, 30);
            this.buttonCancelAssignment.TabIndex = 8;
            this.buttonCancelAssignment.Text = "Cancel";
            this.buttonCancelAssignment.UseVisualStyleBackColor = false;
            this.buttonCancelAssignment.Click += new System.EventHandler(this.buttonCancelAssignment_Click);
            // 
            // comboBoxCleaner2
            // 
            this.comboBoxCleaner2.FormattingEnabled = true;
            this.comboBoxCleaner2.Location = new System.Drawing.Point(430, 198);
            this.comboBoxCleaner2.Name = "comboBoxCleaner2";
            this.comboBoxCleaner2.Size = new System.Drawing.Size(161, 21);
            this.comboBoxCleaner2.TabIndex = 7;
            // 
            // comboBoxCleaner1
            // 
            this.comboBoxCleaner1.FormattingEnabled = true;
            this.comboBoxCleaner1.Location = new System.Drawing.Point(430, 156);
            this.comboBoxCleaner1.Name = "comboBoxCleaner1";
            this.comboBoxCleaner1.Size = new System.Drawing.Size(161, 21);
            this.comboBoxCleaner1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cleaner 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cleaner 1:";
            // 
            // buttonAssignRoom
            // 
            this.buttonAssignRoom.BackColor = System.Drawing.Color.Maroon;
            this.buttonAssignRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAssignRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssignRoom.ForeColor = System.Drawing.Color.White;
            this.buttonAssignRoom.Location = new System.Drawing.Point(341, 267);
            this.buttonAssignRoom.Name = "buttonAssignRoom";
            this.buttonAssignRoom.Size = new System.Drawing.Size(119, 30);
            this.buttonAssignRoom.TabIndex = 3;
            this.buttonAssignRoom.Text = "Assign";
            this.buttonAssignRoom.UseVisualStyleBackColor = false;
            this.buttonAssignRoom.Click += new System.EventHandler(this.buttonAssignRoom_Click);
            // 
            // listViewAssignedRooms
            // 
            this.listViewAssignedRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAssignedEmp,
            this.columnHeaderAssignedRoomNumber,
            this.columnHeaderAssignedTime,
            this.columnHeaderAssignedBy});
            this.listViewAssignedRooms.FullRowSelect = true;
            this.listViewAssignedRooms.GridLines = true;
            this.listViewAssignedRooms.HideSelection = false;
            this.listViewAssignedRooms.Location = new System.Drawing.Point(661, 0);
            this.listViewAssignedRooms.MultiSelect = false;
            this.listViewAssignedRooms.Name = "listViewAssignedRooms";
            this.listViewAssignedRooms.Size = new System.Drawing.Size(327, 555);
            this.listViewAssignedRooms.TabIndex = 2;
            this.listViewAssignedRooms.UseCompatibleStateImageBehavior = false;
            this.listViewAssignedRooms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderAssignedEmp
            // 
            this.columnHeaderAssignedEmp.Text = "Employees";
            this.columnHeaderAssignedEmp.Width = 163;
            // 
            // columnHeaderAssignedRoomNumber
            // 
            this.columnHeaderAssignedRoomNumber.Text = "Room Number";
            this.columnHeaderAssignedRoomNumber.Width = 90;
            // 
            // columnHeaderAssignedTime
            // 
            this.columnHeaderAssignedTime.Text = "Assigned On";
            this.columnHeaderAssignedTime.Width = 90;
            // 
            // columnHeaderAssignedBy
            // 
            this.columnHeaderAssignedBy.Text = "Assigned By";
            this.columnHeaderAssignedBy.Width = 113;
            // 
            // listViewRoomsToClean
            // 
            this.listViewRoomsToClean.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderRoomNumber,
            this.columnHeaderRoomFloor,
            this.columnHeaderRoomType});
            this.listViewRoomsToClean.FullRowSelect = true;
            this.listViewRoomsToClean.GridLines = true;
            this.listViewRoomsToClean.HideSelection = false;
            this.listViewRoomsToClean.Location = new System.Drawing.Point(-1, -1);
            this.listViewRoomsToClean.MultiSelect = false;
            this.listViewRoomsToClean.Name = "listViewRoomsToClean";
            this.listViewRoomsToClean.Size = new System.Drawing.Size(276, 552);
            this.listViewRoomsToClean.TabIndex = 1;
            this.listViewRoomsToClean.UseCompatibleStateImageBehavior = false;
            this.listViewRoomsToClean.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderRoomNumber
            // 
            this.columnHeaderRoomNumber.Text = "Room Number";
            this.columnHeaderRoomNumber.Width = 90;
            // 
            // columnHeaderRoomFloor
            // 
            this.columnHeaderRoomFloor.Text = "Floor";
            this.columnHeaderRoomFloor.Width = 90;
            // 
            // columnHeaderRoomType
            // 
            this.columnHeaderRoomType.Text = "Room Type";
            this.columnHeaderRoomType.Width = 90;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.buttonMoreInformation);
            this.tabPage2.Controls.Add(this.listViewViewRoomsToClean);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(988, 551);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "View Rooms To Clean";
            // 
            // buttonMoreInformation
            // 
            this.buttonMoreInformation.BackColor = System.Drawing.Color.Maroon;
            this.buttonMoreInformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoreInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoreInformation.ForeColor = System.Drawing.Color.White;
            this.buttonMoreInformation.Location = new System.Drawing.Point(378, 457);
            this.buttonMoreInformation.Name = "buttonMoreInformation";
            this.buttonMoreInformation.Size = new System.Drawing.Size(177, 35);
            this.buttonMoreInformation.TabIndex = 1;
            this.buttonMoreInformation.Text = "More Information";
            this.buttonMoreInformation.UseVisualStyleBackColor = false;
            // 
            // listViewViewRoomsToClean
            // 
            this.listViewViewRoomsToClean.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderViewRoomNumber,
            this.columnHeaderViewRoomType,
            this.columnHeaderViewRoomFloor});
            this.listViewViewRoomsToClean.GridLines = true;
            this.listViewViewRoomsToClean.HideSelection = false;
            this.listViewViewRoomsToClean.Location = new System.Drawing.Point(-2, -1);
            this.listViewViewRoomsToClean.Name = "listViewViewRoomsToClean";
            this.listViewViewRoomsToClean.Size = new System.Drawing.Size(994, 394);
            this.listViewViewRoomsToClean.TabIndex = 0;
            this.listViewViewRoomsToClean.UseCompatibleStateImageBehavior = false;
            this.listViewViewRoomsToClean.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderViewRoomNumber
            // 
            this.columnHeaderViewRoomNumber.Text = "Room Number";
            this.columnHeaderViewRoomNumber.Width = 120;
            // 
            // columnHeaderViewRoomType
            // 
            this.columnHeaderViewRoomType.Text = "Type";
            this.columnHeaderViewRoomType.Width = 120;
            // 
            // columnHeaderViewRoomFloor
            // 
            this.columnHeaderViewRoomFloor.Text = "Floor";
            this.columnHeaderViewRoomFloor.Width = 120;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage3.Controls.Add(this.buttonMoveToCleaningStock);
            this.tabPage3.Controls.Add(this.listViewCleaningStock);
            this.tabPage3.Controls.Add(this.textBoxQuantity);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.listViewStockItems);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage3.Size = new System.Drawing.Size(988, 551);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Move Stock Item";
            // 
            // buttonMoveToCleaningStock
            // 
            this.buttonMoveToCleaningStock.BackColor = System.Drawing.Color.Maroon;
            this.buttonMoveToCleaningStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveToCleaningStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveToCleaningStock.ForeColor = System.Drawing.Color.White;
            this.buttonMoveToCleaningStock.Location = new System.Drawing.Point(391, 233);
            this.buttonMoveToCleaningStock.Name = "buttonMoveToCleaningStock";
            this.buttonMoveToCleaningStock.Size = new System.Drawing.Size(206, 31);
            this.buttonMoveToCleaningStock.TabIndex = 5;
            this.buttonMoveToCleaningStock.Text = "Move";
            this.buttonMoveToCleaningStock.UseVisualStyleBackColor = false;
            // 
            // listViewCleaningStock
            // 
            this.listViewCleaningStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCleaninfStockID,
            this.columnHeaderCleaninfStockName,
            this.columnHeaderCleaninfStockQuantity,
            this.columnHeaderCleaninfStockUnit,
            this.columnHeaderCleaninfStockLocation});
            this.listViewCleaningStock.GridLines = true;
            this.listViewCleaningStock.HideSelection = false;
            this.listViewCleaningStock.Location = new System.Drawing.Point(659, 0);
            this.listViewCleaningStock.Name = "listViewCleaningStock";
            this.listViewCleaningStock.Size = new System.Drawing.Size(329, 551);
            this.listViewCleaningStock.TabIndex = 4;
            this.listViewCleaningStock.UseCompatibleStateImageBehavior = false;
            this.listViewCleaningStock.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCleaninfStockID
            // 
            this.columnHeaderCleaninfStockID.Text = "ID";
            this.columnHeaderCleaninfStockID.Width = 40;
            // 
            // columnHeaderCleaninfStockName
            // 
            this.columnHeaderCleaninfStockName.Text = "Name";
            // 
            // columnHeaderCleaninfStockQuantity
            // 
            this.columnHeaderCleaninfStockQuantity.Text = "Quantity";
            // 
            // columnHeaderCleaninfStockUnit
            // 
            this.columnHeaderCleaninfStockUnit.Text = "Unit";
            // 
            // columnHeaderCleaninfStockLocation
            // 
            this.columnHeaderCleaninfStockLocation.Text = "Location";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(391, 189);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(206, 24);
            this.textBoxQuantity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.label1.Location = new System.Drawing.Point(459, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantity";
            // 
            // listViewStockItems
            // 
            this.listViewStockItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderStockItemID,
            this.columnHeaderStockItemName,
            this.columnHeaderStockItemQuantity,
            this.columnHeaderStockItemUnit,
            this.columnHeaderStockItemLocation});
            this.listViewStockItems.GridLines = true;
            this.listViewStockItems.HideSelection = false;
            this.listViewStockItems.Location = new System.Drawing.Point(-1, -1);
            this.listViewStockItems.Name = "listViewStockItems";
            this.listViewStockItems.Size = new System.Drawing.Size(304, 556);
            this.listViewStockItems.TabIndex = 0;
            this.listViewStockItems.UseCompatibleStateImageBehavior = false;
            this.listViewStockItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderStockItemID
            // 
            this.columnHeaderStockItemID.Text = "ID";
            this.columnHeaderStockItemID.Width = 40;
            // 
            // columnHeaderStockItemName
            // 
            this.columnHeaderStockItemName.Text = "Name";
            // 
            // columnHeaderStockItemQuantity
            // 
            this.columnHeaderStockItemQuantity.Text = "Quantity";
            // 
            // columnHeaderStockItemUnit
            // 
            this.columnHeaderStockItemUnit.Text = "Unit";
            // 
            // columnHeaderStockItemLocation
            // 
            this.columnHeaderStockItemLocation.Text = "Location";
            // 
            // tabLogout
            // 
            this.tabLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabLogout.Controls.Add(this.btnLock);
            this.tabLogout.Controls.Add(this.btnLogout);
            this.tabLogout.Location = new System.Drawing.Point(4, 22);
            this.tabLogout.Name = "tabLogout";
            this.tabLogout.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogout.Size = new System.Drawing.Size(988, 551);
            this.tabLogout.TabIndex = 1;
            this.tabLogout.Text = "Logout";
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.Maroon;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.Location = new System.Drawing.Point(509, 183);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(256, 140);
            this.btnLock.TabIndex = 3;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(209, 183);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(256, 140);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // CleaningSuperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 575);
            this.ControlBox = false;
            this.Controls.Add(this.tabAdmin);
            this.DoubleBuffered = true;
            this.Name = "CleaningSuperForm";
            this.tabAdmin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabLogout;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonAssignRoom;
        private System.Windows.Forms.ListView listViewAssignedRooms;
        private System.Windows.Forms.ColumnHeader columnHeaderAssignedEmp;
        private System.Windows.Forms.ColumnHeader columnHeaderAssignedRoomNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderAssignedTime;
        private System.Windows.Forms.ColumnHeader columnHeaderAssignedBy;
        private System.Windows.Forms.ListView listViewRoomsToClean;
        private System.Windows.Forms.ColumnHeader columnHeaderRoomNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderRoomType;
        private System.Windows.Forms.ColumnHeader columnHeaderRoomFloor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonMoreInformation;
        private System.Windows.Forms.ListView listViewViewRoomsToClean;
        private System.Windows.Forms.ColumnHeader columnHeaderViewRoomNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderViewRoomType;
        private System.Windows.Forms.ColumnHeader columnHeaderViewRoomFloor;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonMoveToCleaningStock;
        private System.Windows.Forms.ListView listViewCleaningStock;
        private System.Windows.Forms.ColumnHeader columnHeaderCleaninfStockID;
        private System.Windows.Forms.ColumnHeader columnHeaderCleaninfStockName;
        private System.Windows.Forms.ColumnHeader columnHeaderCleaninfStockQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderCleaninfStockUnit;
        private System.Windows.Forms.ColumnHeader columnHeaderCleaninfStockLocation;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewStockItems;
        private System.Windows.Forms.ColumnHeader columnHeaderStockItemID;
        private System.Windows.Forms.ColumnHeader columnHeaderStockItemName;
        private System.Windows.Forms.ColumnHeader columnHeaderStockItemQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderStockItemUnit;
        private System.Windows.Forms.ColumnHeader columnHeaderStockItemLocation;
        private System.Windows.Forms.ComboBox comboBoxCleaner2;
        private System.Windows.Forms.ComboBox comboBoxCleaner1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancelAssignment;
    }
}