
namespace WindowsClient
{
    partial class BarStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarStaffForm));
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabProcessCustomerOrder = new System.Windows.Forms.TabPage();
            this.buttonFilterShots = new System.Windows.Forms.Button();
            this.buttonFilterBottles = new System.Windows.Forms.Button();
            this.buttonFilterPints = new System.Windows.Forms.Button();
            this.buttonFilterMeals = new System.Windows.Forms.Button();
            this.buttonResetFilter = new System.Windows.Forms.Button();
            this.buttonRemoveFromOrder = new System.Windows.Forms.Button();
            this.textBoxItemQuantity = new System.Windows.Forms.TextBox();
            this.textBoxOrderTotal = new System.Windows.Forms.TextBox();
            this.textBoxTableNumber = new System.Windows.Forms.TextBox();
            this.textBoxGuestName = new System.Windows.Forms.TextBox();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.buttonCompleteOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.listViewCustomerOrder = new System.Windows.Forms.ListView();
            this.columnHeaderOrderItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrderUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewOrderMenu = new System.Windows.Forms.ListView();
            this.columnHeaderItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonReturnStock = new System.Windows.Forms.Button();
            this.textBoxMoveStockQuantity = new System.Windows.Forms.TextBox();
            this.buttonMoveStockToBar = new System.Windows.Forms.Button();
            this.listViewMoveBar = new System.Windows.Forms.ListView();
            this.columnHeaderSaleItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSaleDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSaleUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSaleQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderSalePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewMoveStockRoom = new System.Windows.Forms.ListView();
            this.columnHeaderStockItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStockDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStockUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnitValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStockQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadeStockSupplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMoveStockRoom = new System.Windows.Forms.Label();
            this.labelMoveBar = new System.Windows.Forms.Label();
            this.tabLogout = new System.Windows.Forms.TabPage();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabAdmin.SuspendLayout();
            this.tabProcessCustomerOrder.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabProcessCustomerOrder);
            this.tabAdmin.Controls.Add(this.tabPage1);
            this.tabAdmin.Controls.Add(this.tabLogout);
            this.tabAdmin.Location = new System.Drawing.Point(-1, 0);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(996, 579);
            this.tabAdmin.TabIndex = 1;
            // 
            // tabProcessCustomerOrder
            // 
            this.tabProcessCustomerOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabProcessCustomerOrder.Controls.Add(this.buttonFilterShots);
            this.tabProcessCustomerOrder.Controls.Add(this.buttonFilterBottles);
            this.tabProcessCustomerOrder.Controls.Add(this.buttonFilterPints);
            this.tabProcessCustomerOrder.Controls.Add(this.buttonFilterMeals);
            this.tabProcessCustomerOrder.Controls.Add(this.buttonResetFilter);
            this.tabProcessCustomerOrder.Controls.Add(this.buttonRemoveFromOrder);
            this.tabProcessCustomerOrder.Controls.Add(this.textBoxItemQuantity);
            this.tabProcessCustomerOrder.Controls.Add(this.textBoxOrderTotal);
            this.tabProcessCustomerOrder.Controls.Add(this.textBoxTableNumber);
            this.tabProcessCustomerOrder.Controls.Add(this.textBoxGuestName);
            this.tabProcessCustomerOrder.Controls.Add(this.buttonCancelOrder);
            this.tabProcessCustomerOrder.Controls.Add(this.buttonCompleteOrder);
            this.tabProcessCustomerOrder.Controls.Add(this.label3);
            this.tabProcessCustomerOrder.Controls.Add(this.label2);
            this.tabProcessCustomerOrder.Controls.Add(this.label1);
            this.tabProcessCustomerOrder.Controls.Add(this.buttonAddToOrder);
            this.tabProcessCustomerOrder.Controls.Add(this.listViewCustomerOrder);
            this.tabProcessCustomerOrder.Controls.Add(this.listViewOrderMenu);
            this.tabProcessCustomerOrder.Location = new System.Drawing.Point(4, 22);
            this.tabProcessCustomerOrder.Name = "tabProcessCustomerOrder";
            this.tabProcessCustomerOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcessCustomerOrder.Size = new System.Drawing.Size(988, 553);
            this.tabProcessCustomerOrder.TabIndex = 0;
            this.tabProcessCustomerOrder.Text = "Process Customer Order";
            // 
            // buttonFilterShots
            // 
            this.buttonFilterShots.BackColor = System.Drawing.Color.Maroon;
            this.buttonFilterShots.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilterShots.ForeColor = System.Drawing.Color.White;
            this.buttonFilterShots.Location = new System.Drawing.Point(297, 455);
            this.buttonFilterShots.Name = "buttonFilterShots";
            this.buttonFilterShots.Size = new System.Drawing.Size(96, 34);
            this.buttonFilterShots.TabIndex = 19;
            this.buttonFilterShots.Text = "Shots";
            this.buttonFilterShots.UseVisualStyleBackColor = false;
            this.buttonFilterShots.Click += new System.EventHandler(this.buttonFilterShots_Click);
            // 
            // buttonFilterBottles
            // 
            this.buttonFilterBottles.BackColor = System.Drawing.Color.Maroon;
            this.buttonFilterBottles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilterBottles.ForeColor = System.Drawing.Color.White;
            this.buttonFilterBottles.Location = new System.Drawing.Point(158, 455);
            this.buttonFilterBottles.Name = "buttonFilterBottles";
            this.buttonFilterBottles.Size = new System.Drawing.Size(96, 34);
            this.buttonFilterBottles.TabIndex = 17;
            this.buttonFilterBottles.Text = "Bottles";
            this.buttonFilterBottles.UseVisualStyleBackColor = false;
            this.buttonFilterBottles.Click += new System.EventHandler(this.buttonFilterBottles_Click);
            // 
            // buttonFilterPints
            // 
            this.buttonFilterPints.BackColor = System.Drawing.Color.Maroon;
            this.buttonFilterPints.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilterPints.ForeColor = System.Drawing.Color.White;
            this.buttonFilterPints.Location = new System.Drawing.Point(21, 455);
            this.buttonFilterPints.Name = "buttonFilterPints";
            this.buttonFilterPints.Size = new System.Drawing.Size(96, 34);
            this.buttonFilterPints.TabIndex = 16;
            this.buttonFilterPints.Text = "Pints";
            this.buttonFilterPints.UseVisualStyleBackColor = false;
            this.buttonFilterPints.Click += new System.EventHandler(this.buttonFilterPints_Click);
            // 
            // buttonFilterMeals
            // 
            this.buttonFilterMeals.BackColor = System.Drawing.Color.Maroon;
            this.buttonFilterMeals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilterMeals.ForeColor = System.Drawing.Color.White;
            this.buttonFilterMeals.Location = new System.Drawing.Point(232, 397);
            this.buttonFilterMeals.Name = "buttonFilterMeals";
            this.buttonFilterMeals.Size = new System.Drawing.Size(96, 34);
            this.buttonFilterMeals.TabIndex = 15;
            this.buttonFilterMeals.Text = "Meals";
            this.buttonFilterMeals.UseVisualStyleBackColor = false;
            this.buttonFilterMeals.Click += new System.EventHandler(this.buttonFilterMeals_Click);
            // 
            // buttonResetFilter
            // 
            this.buttonResetFilter.BackColor = System.Drawing.Color.Maroon;
            this.buttonResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResetFilter.ForeColor = System.Drawing.Color.White;
            this.buttonResetFilter.Location = new System.Drawing.Point(92, 397);
            this.buttonResetFilter.Name = "buttonResetFilter";
            this.buttonResetFilter.Size = new System.Drawing.Size(96, 34);
            this.buttonResetFilter.TabIndex = 14;
            this.buttonResetFilter.Text = "Reset Filter";
            this.buttonResetFilter.UseVisualStyleBackColor = false;
            this.buttonResetFilter.Click += new System.EventHandler(this.buttonResetFilter_Click);
            // 
            // buttonRemoveFromOrder
            // 
            this.buttonRemoveFromOrder.BackColor = System.Drawing.Color.Maroon;
            this.buttonRemoveFromOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveFromOrder.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveFromOrder.Location = new System.Drawing.Point(484, 187);
            this.buttonRemoveFromOrder.Name = "buttonRemoveFromOrder";
            this.buttonRemoveFromOrder.Size = new System.Drawing.Size(58, 23);
            this.buttonRemoveFromOrder.TabIndex = 13;
            this.buttonRemoveFromOrder.Text = "<<<";
            this.buttonRemoveFromOrder.UseVisualStyleBackColor = false;
            this.buttonRemoveFromOrder.Click += new System.EventHandler(this.buttonRemoveFromOrder_Click);
            // 
            // textBoxItemQuantity
            // 
            this.textBoxItemQuantity.Location = new System.Drawing.Point(492, 141);
            this.textBoxItemQuantity.Name = "textBoxItemQuantity";
            this.textBoxItemQuantity.Size = new System.Drawing.Size(43, 20);
            this.textBoxItemQuantity.TabIndex = 12;
            // 
            // textBoxOrderTotal
            // 
            this.textBoxOrderTotal.Location = new System.Drawing.Point(676, 414);
            this.textBoxOrderTotal.Name = "textBoxOrderTotal";
            this.textBoxOrderTotal.ReadOnly = true;
            this.textBoxOrderTotal.Size = new System.Drawing.Size(247, 20);
            this.textBoxOrderTotal.TabIndex = 11;
            // 
            // textBoxTableNumber
            // 
            this.textBoxTableNumber.Location = new System.Drawing.Point(676, 386);
            this.textBoxTableNumber.Name = "textBoxTableNumber";
            this.textBoxTableNumber.Size = new System.Drawing.Size(247, 20);
            this.textBoxTableNumber.TabIndex = 10;
            // 
            // textBoxGuestName
            // 
            this.textBoxGuestName.Location = new System.Drawing.Point(676, 359);
            this.textBoxGuestName.Name = "textBoxGuestName";
            this.textBoxGuestName.Size = new System.Drawing.Size(247, 20);
            this.textBoxGuestName.TabIndex = 9;
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.BackColor = System.Drawing.Color.Maroon;
            this.buttonCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelOrder.ForeColor = System.Drawing.Color.White;
            this.buttonCancelOrder.Location = new System.Drawing.Point(825, 455);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(96, 34);
            this.buttonCancelOrder.TabIndex = 8;
            this.buttonCancelOrder.Text = "Cancel Order";
            this.buttonCancelOrder.UseVisualStyleBackColor = false;
            this.buttonCancelOrder.Click += new System.EventHandler(this.buttonCancelOrder_Click);
            // 
            // buttonCompleteOrder
            // 
            this.buttonCompleteOrder.BackColor = System.Drawing.Color.Maroon;
            this.buttonCompleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCompleteOrder.ForeColor = System.Drawing.Color.White;
            this.buttonCompleteOrder.Location = new System.Drawing.Point(676, 455);
            this.buttonCompleteOrder.Name = "buttonCompleteOrder";
            this.buttonCompleteOrder.Size = new System.Drawing.Size(96, 34);
            this.buttonCompleteOrder.TabIndex = 7;
            this.buttonCompleteOrder.Text = "Complete Order";
            this.buttonCompleteOrder.UseVisualStyleBackColor = false;
            this.buttonCompleteOrder.Click += new System.EventHandler(this.buttonCompleteOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Table:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Guest:";
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.BackColor = System.Drawing.Color.Maroon;
            this.buttonAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToOrder.ForeColor = System.Drawing.Color.White;
            this.buttonAddToOrder.Location = new System.Drawing.Point(484, 93);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(58, 23);
            this.buttonAddToOrder.TabIndex = 3;
            this.buttonAddToOrder.Text = ">>>";
            this.buttonAddToOrder.UseVisualStyleBackColor = false;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
            // 
            // listViewCustomerOrder
            // 
            this.listViewCustomerOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOrderItemID,
            this.columnHeaderOrderDescription,
            this.columnHeaderOrderPrice,
            this.columnHeaderOrderUnit,
            this.columnHeaderOrderQuantity});
            this.listViewCustomerOrder.FullRowSelect = true;
            this.listViewCustomerOrder.GridLines = true;
            this.listViewCustomerOrder.HideSelection = false;
            this.listViewCustomerOrder.Location = new System.Drawing.Point(586, 0);
            this.listViewCustomerOrder.MultiSelect = false;
            this.listViewCustomerOrder.Name = "listViewCustomerOrder";
            this.listViewCustomerOrder.Size = new System.Drawing.Size(401, 330);
            this.listViewCustomerOrder.TabIndex = 2;
            this.listViewCustomerOrder.UseCompatibleStateImageBehavior = false;
            this.listViewCustomerOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderOrderItemID
            // 
            this.columnHeaderOrderItemID.Text = "ItemID";
            // 
            // columnHeaderOrderDescription
            // 
            this.columnHeaderOrderDescription.Text = "Description";
            this.columnHeaderOrderDescription.Width = 148;
            // 
            // columnHeaderOrderPrice
            // 
            this.columnHeaderOrderPrice.Text = "Price";
            this.columnHeaderOrderPrice.Width = 76;
            // 
            // columnHeaderOrderUnit
            // 
            this.columnHeaderOrderUnit.Text = "Unit";
            // 
            // columnHeaderOrderQuantity
            // 
            this.columnHeaderOrderQuantity.Text = "Quantity";
            this.columnHeaderOrderQuantity.Width = 53;
            // 
            // listViewOrderMenu
            // 
            this.listViewOrderMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderItemID,
            this.columnHeaderDescription,
            this.columnHeaderPrice,
            this.columnHeaderUnit,
            this.columnHeaderQuantity});
            this.listViewOrderMenu.FullRowSelect = true;
            this.listViewOrderMenu.GridLines = true;
            this.listViewOrderMenu.HideSelection = false;
            this.listViewOrderMenu.Location = new System.Drawing.Point(0, 0);
            this.listViewOrderMenu.MultiSelect = false;
            this.listViewOrderMenu.Name = "listViewOrderMenu";
            this.listViewOrderMenu.Size = new System.Drawing.Size(433, 379);
            this.listViewOrderMenu.TabIndex = 1;
            this.listViewOrderMenu.UseCompatibleStateImageBehavior = false;
            this.listViewOrderMenu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderItemID
            // 
            this.columnHeaderItemID.Text = "Item ID";
            this.columnHeaderItemID.Width = 72;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 156;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 76;
            // 
            // columnHeaderUnit
            // 
            this.columnHeaderUnit.Text = "Unit";
            // 
            // columnHeaderQuantity
            // 
            this.columnHeaderQuantity.Text = "Quantity";
            this.columnHeaderQuantity.Width = 65;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.buttonReturnStock);
            this.tabPage1.Controls.Add(this.textBoxMoveStockQuantity);
            this.tabPage1.Controls.Add(this.buttonMoveStockToBar);
            this.tabPage1.Controls.Add(this.listViewMoveBar);
            this.tabPage1.Controls.Add(this.listViewMoveStockRoom);
            this.tabPage1.Controls.Add(this.labelMoveStockRoom);
            this.tabPage1.Controls.Add(this.labelMoveBar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(988, 553);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Move Stock";
            // 
            // buttonReturnStock
            // 
            this.buttonReturnStock.BackColor = System.Drawing.Color.Maroon;
            this.buttonReturnStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReturnStock.ForeColor = System.Drawing.Color.White;
            this.buttonReturnStock.Location = new System.Drawing.Point(448, 361);
            this.buttonReturnStock.Name = "buttonReturnStock";
            this.buttonReturnStock.Size = new System.Drawing.Size(76, 41);
            this.buttonReturnStock.TabIndex = 6;
            this.buttonReturnStock.Text = "<<<";
            this.buttonReturnStock.UseVisualStyleBackColor = false;
            this.buttonReturnStock.Click += new System.EventHandler(this.buttonReturnStock_Click);
            // 
            // textBoxMoveStockQuantity
            // 
            this.textBoxMoveStockQuantity.Location = new System.Drawing.Point(458, 307);
            this.textBoxMoveStockQuantity.Name = "textBoxMoveStockQuantity";
            this.textBoxMoveStockQuantity.Size = new System.Drawing.Size(56, 20);
            this.textBoxMoveStockQuantity.TabIndex = 5;
            // 
            // buttonMoveStockToBar
            // 
            this.buttonMoveStockToBar.BackColor = System.Drawing.Color.Maroon;
            this.buttonMoveStockToBar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveStockToBar.ForeColor = System.Drawing.Color.White;
            this.buttonMoveStockToBar.Location = new System.Drawing.Point(448, 231);
            this.buttonMoveStockToBar.Name = "buttonMoveStockToBar";
            this.buttonMoveStockToBar.Size = new System.Drawing.Size(76, 41);
            this.buttonMoveStockToBar.TabIndex = 4;
            this.buttonMoveStockToBar.Text = ">>>";
            this.buttonMoveStockToBar.UseVisualStyleBackColor = false;
            this.buttonMoveStockToBar.Click += new System.EventHandler(this.buttonMoveStockToBar_Click);
            // 
            // listViewMoveBar
            // 
            this.listViewMoveBar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSaleItemID,
            this.columnHeaderSaleDescription,
            this.columnHeaderSaleUnit,
            this.columnHeaderSaleQuantity,
            this.ColumnHeaderSalePrice});
            this.listViewMoveBar.FullRowSelect = true;
            this.listViewMoveBar.GridLines = true;
            this.listViewMoveBar.HideSelection = false;
            this.listViewMoveBar.Location = new System.Drawing.Point(582, 43);
            this.listViewMoveBar.MultiSelect = false;
            this.listViewMoveBar.Name = "listViewMoveBar";
            this.listViewMoveBar.Size = new System.Drawing.Size(403, 514);
            this.listViewMoveBar.TabIndex = 3;
            this.listViewMoveBar.UseCompatibleStateImageBehavior = false;
            this.listViewMoveBar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSaleItemID
            // 
            this.columnHeaderSaleItemID.Text = "Item ID";
            // 
            // columnHeaderSaleDescription
            // 
            this.columnHeaderSaleDescription.Text = "Description";
            this.columnHeaderSaleDescription.Width = 138;
            // 
            // columnHeaderSaleUnit
            // 
            this.columnHeaderSaleUnit.Text = "Unit";
            this.columnHeaderSaleUnit.Width = 67;
            // 
            // columnHeaderSaleQuantity
            // 
            this.columnHeaderSaleQuantity.Text = "Quantity";
            this.columnHeaderSaleQuantity.Width = 74;
            // 
            // ColumnHeaderSalePrice
            // 
            this.ColumnHeaderSalePrice.Text = "Price";
            // 
            // listViewMoveStockRoom
            // 
            this.listViewMoveStockRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderStockItemID,
            this.columnHeaderStockDescription,
            this.columnHeaderStockUnit,
            this.columnHeaderUnitValue,
            this.columnHeaderStockQuantity,
            this.columnHeadeStockSupplier});
            this.listViewMoveStockRoom.FullRowSelect = true;
            this.listViewMoveStockRoom.GridLines = true;
            this.listViewMoveStockRoom.HideSelection = false;
            this.listViewMoveStockRoom.Location = new System.Drawing.Point(1, 43);
            this.listViewMoveStockRoom.MultiSelect = false;
            this.listViewMoveStockRoom.Name = "listViewMoveStockRoom";
            this.listViewMoveStockRoom.Size = new System.Drawing.Size(394, 510);
            this.listViewMoveStockRoom.TabIndex = 2;
            this.listViewMoveStockRoom.UseCompatibleStateImageBehavior = false;
            this.listViewMoveStockRoom.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderStockItemID
            // 
            this.columnHeaderStockItemID.Text = "Item ID";
            this.columnHeaderStockItemID.Width = 46;
            // 
            // columnHeaderStockDescription
            // 
            this.columnHeaderStockDescription.Text = "Description";
            this.columnHeaderStockDescription.Width = 120;
            // 
            // columnHeaderStockUnit
            // 
            this.columnHeaderStockUnit.Text = "Unit";
            this.columnHeaderStockUnit.Width = 46;
            // 
            // columnHeaderUnitValue
            // 
            this.columnHeaderUnitValue.Text = "Unit Value";
            this.columnHeaderUnitValue.Width = 66;
            // 
            // columnHeaderStockQuantity
            // 
            this.columnHeaderStockQuantity.Text = "Quantity";
            this.columnHeaderStockQuantity.Width = 52;
            // 
            // columnHeadeStockSupplier
            // 
            this.columnHeadeStockSupplier.Text = "Supplier";
            // 
            // labelMoveStockRoom
            // 
            this.labelMoveStockRoom.AutoSize = true;
            this.labelMoveStockRoom.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.labelMoveStockRoom.Location = new System.Drawing.Point(139, 11);
            this.labelMoveStockRoom.Name = "labelMoveStockRoom";
            this.labelMoveStockRoom.Size = new System.Drawing.Size(103, 21);
            this.labelMoveStockRoom.TabIndex = 1;
            this.labelMoveStockRoom.Text = "Stock Room";
            // 
            // labelMoveBar
            // 
            this.labelMoveBar.AutoSize = true;
            this.labelMoveBar.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.labelMoveBar.Location = new System.Drawing.Point(718, 11);
            this.labelMoveBar.Name = "labelMoveBar";
            this.labelMoveBar.Size = new System.Drawing.Size(88, 21);
            this.labelMoveBar.TabIndex = 0;
            this.labelMoveBar.Text = "Bar Stock";
            // 
            // tabLogout
            // 
            this.tabLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabLogout.Controls.Add(this.btnLock);
            this.tabLogout.Controls.Add(this.btnLogout);
            this.tabLogout.Location = new System.Drawing.Point(4, 22);
            this.tabLogout.Name = "tabLogout";
            this.tabLogout.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogout.Size = new System.Drawing.Size(988, 553);
            this.tabLogout.TabIndex = 1;
            this.tabLogout.Text = "Logout";
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.Maroon;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.Location = new System.Drawing.Point(532, 210);
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
            this.btnLogout.Location = new System.Drawing.Point(232, 210);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(256, 140);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // BarStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 575);
            this.ControlBox = false;
            this.Controls.Add(this.tabAdmin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarStaffForm";
            this.tabAdmin.ResumeLayout(false);
            this.tabProcessCustomerOrder.ResumeLayout(false);
            this.tabProcessCustomerOrder.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabProcessCustomerOrder;
        private System.Windows.Forms.TabPage tabLogout;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.ListView listViewCustomerOrder;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderUnit;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderQuantity;
        private System.Windows.Forms.ListView listViewOrderMenu;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderUnit;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderItemID;
        private System.Windows.Forms.TextBox textBoxOrderTotal;
        private System.Windows.Forms.TextBox textBoxTableNumber;
        private System.Windows.Forms.TextBox textBoxGuestName;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.Button buttonCompleteOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelMoveStockRoom;
        private System.Windows.Forms.Label labelMoveBar;
        private System.Windows.Forms.TextBox textBoxMoveStockQuantity;
        private System.Windows.Forms.Button buttonMoveStockToBar;
        private System.Windows.Forms.ListView listViewMoveBar;
        private System.Windows.Forms.ColumnHeader columnHeaderSaleDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderSaleUnit;
        private System.Windows.Forms.ColumnHeader columnHeaderSaleQuantity;
        private System.Windows.Forms.ListView listViewMoveStockRoom;
        private System.Windows.Forms.ColumnHeader columnHeaderStockItemID;
        private System.Windows.Forms.ColumnHeader columnHeaderStockDescription;
        private System.Windows.Forms.ColumnHeader columnHeadeStockSupplier;
        private System.Windows.Forms.ColumnHeader columnHeaderStockUnit;
        private System.Windows.Forms.ColumnHeader columnHeaderStockQuantity;
        private System.Windows.Forms.Button buttonRemoveFromOrder;
        private System.Windows.Forms.TextBox textBoxItemQuantity;
        private System.Windows.Forms.Button buttonFilterShots;
        private System.Windows.Forms.Button buttonFilterBottles;
        private System.Windows.Forms.Button buttonFilterPints;
        private System.Windows.Forms.Button buttonFilterMeals;
        private System.Windows.Forms.Button buttonResetFilter;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderItemID;
        private System.Windows.Forms.ColumnHeader columnHeaderSaleItemID;
        private System.Windows.Forms.Button buttonReturnStock;
        private System.Windows.Forms.ColumnHeader columnHeaderUnitValue;
        private System.Windows.Forms.ColumnHeader ColumnHeaderSalePrice;
    }
}