
namespace WindowsClient
{
    partial class BarManagerForm
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
            this.tabMakeOrder = new System.Windows.Forms.TabPage();
            this.textBoxMakeOrderType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMakeOrderUnit = new System.Windows.Forms.TextBox();
            this.labelMakeOrderUnit = new System.Windows.Forms.Label();
            this.checkBoxMakeOrderPartial = new System.Windows.Forms.CheckBox();
            this.buttonClearOrder = new System.Windows.Forms.Button();
            this.comboBoxOrderSupplier = new System.Windows.Forms.ComboBox();
            this.comboBoxOrderItem = new System.Windows.Forms.ComboBox();
            this.textBoxItemQuantity = new System.Windows.Forms.TextBox();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.labelMakeOrderOrderID = new System.Windows.Forms.Label();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonRemoveOrderItem = new System.Windows.Forms.Button();
            this.buttonAddOrderItem = new System.Windows.Forms.Button();
            this.labelMakeOrderSupplier = new System.Windows.Forms.Label();
            this.labelMakeOrderQuantity = new System.Windows.Forms.Label();
            this.labelMakeOrderItem = new System.Windows.Forms.Label();
            this.listViewMakeOrder = new System.Windows.Forms.ListView();
            this.columnHeaderOrderLineNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnitCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLineCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabReceiveOrder = new System.Windows.Forms.TabPage();
            this.groupBoxPartial = new System.Windows.Forms.GroupBox();
            this.btnQuantityUpdate = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnPartial = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnCheckAndReceive = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDateReceived = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDateReceived = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.listViewReceiveStockOrder = new System.Windows.Forms.ListView();
            this.columnHeaderOrderLineNoRSO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescriptionRSO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnitRSO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantityRSO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnitCostRSO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLineCostRSO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMoveStock = new System.Windows.Forms.TabPage();
            this.tabLogout = new System.Windows.Forms.TabPage();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabAdmin.SuspendLayout();
            this.tabMakeOrder.SuspendLayout();
            this.tabReceiveOrder.SuspendLayout();
            this.groupBoxPartial.SuspendLayout();
            this.tabLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabMakeOrder);
            this.tabAdmin.Controls.Add(this.tabReceiveOrder);
            this.tabAdmin.Controls.Add(this.tabMoveStock);
            this.tabAdmin.Controls.Add(this.tabLogout);
            this.tabAdmin.Location = new System.Drawing.Point(-1, 0);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(997, 579);
            this.tabAdmin.TabIndex = 1;
            // 
            // tabMakeOrder
            // 
            this.tabMakeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabMakeOrder.Controls.Add(this.textBoxMakeOrderType);
            this.tabMakeOrder.Controls.Add(this.label1);
            this.tabMakeOrder.Controls.Add(this.textBoxMakeOrderUnit);
            this.tabMakeOrder.Controls.Add(this.labelMakeOrderUnit);
            this.tabMakeOrder.Controls.Add(this.checkBoxMakeOrderPartial);
            this.tabMakeOrder.Controls.Add(this.buttonClearOrder);
            this.tabMakeOrder.Controls.Add(this.comboBoxOrderSupplier);
            this.tabMakeOrder.Controls.Add(this.comboBoxOrderItem);
            this.tabMakeOrder.Controls.Add(this.textBoxItemQuantity);
            this.tabMakeOrder.Controls.Add(this.textBoxOrderID);
            this.tabMakeOrder.Controls.Add(this.labelMakeOrderOrderID);
            this.tabMakeOrder.Controls.Add(this.buttonCreateOrder);
            this.tabMakeOrder.Controls.Add(this.buttonRemoveOrderItem);
            this.tabMakeOrder.Controls.Add(this.buttonAddOrderItem);
            this.tabMakeOrder.Controls.Add(this.labelMakeOrderSupplier);
            this.tabMakeOrder.Controls.Add(this.labelMakeOrderQuantity);
            this.tabMakeOrder.Controls.Add(this.labelMakeOrderItem);
            this.tabMakeOrder.Controls.Add(this.listViewMakeOrder);
            this.tabMakeOrder.Location = new System.Drawing.Point(4, 22);
            this.tabMakeOrder.Name = "tabMakeOrder";
            this.tabMakeOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabMakeOrder.Size = new System.Drawing.Size(989, 553);
            this.tabMakeOrder.TabIndex = 0;
            this.tabMakeOrder.Text = "Make Order";
            // 
            // textBoxMakeOrderType
            // 
            this.textBoxMakeOrderType.Location = new System.Drawing.Point(688, 188);
            this.textBoxMakeOrderType.Name = "textBoxMakeOrderType";
            this.textBoxMakeOrderType.ReadOnly = true;
            this.textBoxMakeOrderType.Size = new System.Drawing.Size(172, 20);
            this.textBoxMakeOrderType.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Type:";
            // 
            // textBoxMakeOrderUnit
            // 
            this.textBoxMakeOrderUnit.Location = new System.Drawing.Point(688, 227);
            this.textBoxMakeOrderUnit.Name = "textBoxMakeOrderUnit";
            this.textBoxMakeOrderUnit.ReadOnly = true;
            this.textBoxMakeOrderUnit.Size = new System.Drawing.Size(172, 20);
            this.textBoxMakeOrderUnit.TabIndex = 37;
            // 
            // labelMakeOrderUnit
            // 
            this.labelMakeOrderUnit.AutoSize = true;
            this.labelMakeOrderUnit.Location = new System.Drawing.Point(557, 230);
            this.labelMakeOrderUnit.Name = "labelMakeOrderUnit";
            this.labelMakeOrderUnit.Size = new System.Drawing.Size(29, 13);
            this.labelMakeOrderUnit.TabIndex = 36;
            this.labelMakeOrderUnit.Text = "Unit:";
            // 
            // checkBoxMakeOrderPartial
            // 
            this.checkBoxMakeOrderPartial.AutoSize = true;
            this.checkBoxMakeOrderPartial.Location = new System.Drawing.Point(664, 306);
            this.checkBoxMakeOrderPartial.Name = "checkBoxMakeOrderPartial";
            this.checkBoxMakeOrderPartial.Size = new System.Drawing.Size(98, 17);
            this.checkBoxMakeOrderPartial.TabIndex = 35;
            this.checkBoxMakeOrderPartial.Text = "Accept Partial?";
            this.checkBoxMakeOrderPartial.UseVisualStyleBackColor = true;
            // 
            // buttonClearOrder
            // 
            this.buttonClearOrder.BackColor = System.Drawing.Color.Maroon;
            this.buttonClearOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClearOrder.ForeColor = System.Drawing.Color.White;
            this.buttonClearOrder.Location = new System.Drawing.Point(738, 416);
            this.buttonClearOrder.Name = "buttonClearOrder";
            this.buttonClearOrder.Size = new System.Drawing.Size(111, 33);
            this.buttonClearOrder.TabIndex = 34;
            this.buttonClearOrder.Text = "Clear Order";
            this.buttonClearOrder.UseVisualStyleBackColor = false;
            this.buttonClearOrder.Click += new System.EventHandler(this.buttonClearOrder_Click);
            // 
            // comboBoxOrderSupplier
            // 
            this.comboBoxOrderSupplier.FormattingEnabled = true;
            this.comboBoxOrderSupplier.Location = new System.Drawing.Point(688, 106);
            this.comboBoxOrderSupplier.Name = "comboBoxOrderSupplier";
            this.comboBoxOrderSupplier.Size = new System.Drawing.Size(172, 21);
            this.comboBoxOrderSupplier.TabIndex = 33;
            this.comboBoxOrderSupplier.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderSupplier_SelectedIndexChanged);
            // 
            // comboBoxOrderItem
            // 
            this.comboBoxOrderItem.FormattingEnabled = true;
            this.comboBoxOrderItem.Location = new System.Drawing.Point(688, 147);
            this.comboBoxOrderItem.Name = "comboBoxOrderItem";
            this.comboBoxOrderItem.Size = new System.Drawing.Size(172, 21);
            this.comboBoxOrderItem.TabIndex = 32;
            this.comboBoxOrderItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderItem_SelectedIndexChanged);
            // 
            // textBoxItemQuantity
            // 
            this.textBoxItemQuantity.Location = new System.Drawing.Point(688, 270);
            this.textBoxItemQuantity.Name = "textBoxItemQuantity";
            this.textBoxItemQuantity.Size = new System.Drawing.Size(172, 20);
            this.textBoxItemQuantity.TabIndex = 31;
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(688, 67);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.ReadOnly = true;
            this.textBoxOrderID.Size = new System.Drawing.Size(172, 20);
            this.textBoxOrderID.TabIndex = 30;
            // 
            // labelMakeOrderOrderID
            // 
            this.labelMakeOrderOrderID.AutoSize = true;
            this.labelMakeOrderOrderID.Location = new System.Drawing.Point(557, 70);
            this.labelMakeOrderOrderID.Name = "labelMakeOrderOrderID";
            this.labelMakeOrderOrderID.Size = new System.Drawing.Size(50, 13);
            this.labelMakeOrderOrderID.TabIndex = 29;
            this.labelMakeOrderOrderID.Text = "Order ID:";
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.BackColor = System.Drawing.Color.Maroon;
            this.buttonCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateOrder.ForeColor = System.Drawing.Color.White;
            this.buttonCreateOrder.Location = new System.Drawing.Point(589, 416);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(104, 33);
            this.buttonCreateOrder.TabIndex = 28;
            this.buttonCreateOrder.Text = "Create Order";
            this.buttonCreateOrder.UseVisualStyleBackColor = false;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonRemoveOrderItem
            // 
            this.buttonRemoveOrderItem.BackColor = System.Drawing.Color.Maroon;
            this.buttonRemoveOrderItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveOrderItem.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveOrderItem.Location = new System.Drawing.Point(742, 362);
            this.buttonRemoveOrderItem.Name = "buttonRemoveOrderItem";
            this.buttonRemoveOrderItem.Size = new System.Drawing.Size(100, 32);
            this.buttonRemoveOrderItem.TabIndex = 27;
            this.buttonRemoveOrderItem.Text = "Remove Item";
            this.buttonRemoveOrderItem.UseVisualStyleBackColor = false;
            this.buttonRemoveOrderItem.Click += new System.EventHandler(this.buttonRemoveOrderItem_Click);
            // 
            // buttonAddOrderItem
            // 
            this.buttonAddOrderItem.BackColor = System.Drawing.Color.Maroon;
            this.buttonAddOrderItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddOrderItem.ForeColor = System.Drawing.Color.White;
            this.buttonAddOrderItem.Location = new System.Drawing.Point(598, 362);
            this.buttonAddOrderItem.Name = "buttonAddOrderItem";
            this.buttonAddOrderItem.Size = new System.Drawing.Size(86, 32);
            this.buttonAddOrderItem.TabIndex = 26;
            this.buttonAddOrderItem.Text = "Add Item";
            this.buttonAddOrderItem.UseVisualStyleBackColor = false;
            this.buttonAddOrderItem.Click += new System.EventHandler(this.buttonAddOrderItem_Click);
            // 
            // labelMakeOrderSupplier
            // 
            this.labelMakeOrderSupplier.AutoSize = true;
            this.labelMakeOrderSupplier.Location = new System.Drawing.Point(557, 109);
            this.labelMakeOrderSupplier.Name = "labelMakeOrderSupplier";
            this.labelMakeOrderSupplier.Size = new System.Drawing.Size(48, 13);
            this.labelMakeOrderSupplier.TabIndex = 25;
            this.labelMakeOrderSupplier.Text = "Supplier:";
            // 
            // labelMakeOrderQuantity
            // 
            this.labelMakeOrderQuantity.AutoSize = true;
            this.labelMakeOrderQuantity.Location = new System.Drawing.Point(557, 273);
            this.labelMakeOrderQuantity.Name = "labelMakeOrderQuantity";
            this.labelMakeOrderQuantity.Size = new System.Drawing.Size(49, 13);
            this.labelMakeOrderQuantity.TabIndex = 24;
            this.labelMakeOrderQuantity.Text = "Quantity:";
            // 
            // labelMakeOrderItem
            // 
            this.labelMakeOrderItem.AutoSize = true;
            this.labelMakeOrderItem.Location = new System.Drawing.Point(557, 150);
            this.labelMakeOrderItem.Name = "labelMakeOrderItem";
            this.labelMakeOrderItem.Size = new System.Drawing.Size(30, 13);
            this.labelMakeOrderItem.TabIndex = 23;
            this.labelMakeOrderItem.Text = "Item:";
            // 
            // listViewMakeOrder
            // 
            this.listViewMakeOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOrderLineNum,
            this.columnHeaderDescription,
            this.columnHeaderUnit,
            this.columnHeaderQuantity,
            this.columnHeaderUnitCost,
            this.columnHeaderLineCost});
            this.listViewMakeOrder.FullRowSelect = true;
            this.listViewMakeOrder.GridLines = true;
            this.listViewMakeOrder.HideSelection = false;
            this.listViewMakeOrder.Location = new System.Drawing.Point(-1, -1);
            this.listViewMakeOrder.Name = "listViewMakeOrder";
            this.listViewMakeOrder.Size = new System.Drawing.Size(410, 554);
            this.listViewMakeOrder.TabIndex = 22;
            this.listViewMakeOrder.UseCompatibleStateImageBehavior = false;
            this.listViewMakeOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderOrderLineNum
            // 
            this.columnHeaderOrderLineNum.Text = "Order Line No.";
            this.columnHeaderOrderLineNum.Width = 83;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 76;
            // 
            // columnHeaderUnit
            // 
            this.columnHeaderUnit.Text = "Unit";
            // 
            // columnHeaderQuantity
            // 
            this.columnHeaderQuantity.Text = "Quantity";
            // 
            // columnHeaderUnitCost
            // 
            this.columnHeaderUnitCost.Text = "Unit Cost";
            // 
            // columnHeaderLineCost
            // 
            this.columnHeaderLineCost.Text = "Line Cost";
            // 
            // tabReceiveOrder
            // 
            this.tabReceiveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabReceiveOrder.Controls.Add(this.groupBoxPartial);
            this.tabReceiveOrder.Controls.Add(this.btnCancelOrder);
            this.tabReceiveOrder.Controls.Add(this.btnCheckAndReceive);
            this.tabReceiveOrder.Controls.Add(this.txtTotal);
            this.tabReceiveOrder.Controls.Add(this.txtDateReceived);
            this.tabReceiveOrder.Controls.Add(this.txtOrderID);
            this.tabReceiveOrder.Controls.Add(this.lblTotal);
            this.tabReceiveOrder.Controls.Add(this.lblDateReceived);
            this.tabReceiveOrder.Controls.Add(this.lblOrderID);
            this.tabReceiveOrder.Controls.Add(this.listViewReceiveStockOrder);
            this.tabReceiveOrder.Location = new System.Drawing.Point(4, 22);
            this.tabReceiveOrder.Name = "tabReceiveOrder";
            this.tabReceiveOrder.Size = new System.Drawing.Size(989, 553);
            this.tabReceiveOrder.TabIndex = 2;
            this.tabReceiveOrder.Text = "ReceiveOrder";
            // 
            // groupBoxPartial
            // 
            this.groupBoxPartial.Controls.Add(this.btnQuantityUpdate);
            this.groupBoxPartial.Controls.Add(this.txtQuantity);
            this.groupBoxPartial.Controls.Add(this.lblQuantity);
            this.groupBoxPartial.Controls.Add(this.btnPartial);
            this.groupBoxPartial.Location = new System.Drawing.Point(556, 226);
            this.groupBoxPartial.Name = "groupBoxPartial";
            this.groupBoxPartial.Size = new System.Drawing.Size(302, 125);
            this.groupBoxPartial.TabIndex = 25;
            this.groupBoxPartial.TabStop = false;
            this.groupBoxPartial.Text = "Partial";
            // 
            // btnQuantityUpdate
            // 
            this.btnQuantityUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnQuantityUpdate.Enabled = false;
            this.btnQuantityUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuantityUpdate.ForeColor = System.Drawing.Color.White;
            this.btnQuantityUpdate.Location = new System.Drawing.Point(206, 19);
            this.btnQuantityUpdate.Name = "btnQuantityUpdate";
            this.btnQuantityUpdate.Size = new System.Drawing.Size(90, 29);
            this.btnQuantityUpdate.TabIndex = 13;
            this.btnQuantityUpdate.Text = "Update";
            this.btnQuantityUpdate.UseMnemonic = false;
            this.btnQuantityUpdate.UseVisualStyleBackColor = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(62, 24);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(132, 20);
            this.txtQuantity.TabIndex = 12;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 27);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnPartial
            // 
            this.btnPartial.BackColor = System.Drawing.Color.Maroon;
            this.btnPartial.Enabled = false;
            this.btnPartial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPartial.ForeColor = System.Drawing.Color.White;
            this.btnPartial.Location = new System.Drawing.Point(96, 64);
            this.btnPartial.Name = "btnPartial";
            this.btnPartial.Size = new System.Drawing.Size(111, 49);
            this.btnPartial.TabIndex = 10;
            this.btnPartial.Text = "Partial";
            this.btnPartial.UseVisualStyleBackColor = false;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelOrder.Enabled = false;
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrder.Location = new System.Drawing.Point(747, 383);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(111, 56);
            this.btnCancelOrder.TabIndex = 24;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            // 
            // btnCheckAndReceive
            // 
            this.btnCheckAndReceive.BackColor = System.Drawing.Color.Maroon;
            this.btnCheckAndReceive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckAndReceive.ForeColor = System.Drawing.Color.White;
            this.btnCheckAndReceive.Location = new System.Drawing.Point(556, 383);
            this.btnCheckAndReceive.Name = "btnCheckAndReceive";
            this.btnCheckAndReceive.Size = new System.Drawing.Size(111, 56);
            this.btnCheckAndReceive.TabIndex = 23;
            this.btnCheckAndReceive.Text = "Check";
            this.btnCheckAndReceive.UseVisualStyleBackColor = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(653, 166);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(205, 20);
            this.txtTotal.TabIndex = 22;
            // 
            // txtDateReceived
            // 
            this.txtDateReceived.Location = new System.Drawing.Point(653, 112);
            this.txtDateReceived.Name = "txtDateReceived";
            this.txtDateReceived.ReadOnly = true;
            this.txtDateReceived.Size = new System.Drawing.Size(205, 20);
            this.txtDateReceived.TabIndex = 21;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(653, 57);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(205, 20);
            this.txtOrderID.TabIndex = 20;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(553, 169);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total:";
            // 
            // lblDateReceived
            // 
            this.lblDateReceived.AutoSize = true;
            this.lblDateReceived.Location = new System.Drawing.Point(553, 115);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(82, 13);
            this.lblDateReceived.TabIndex = 18;
            this.lblDateReceived.Text = "Date Received:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(553, 60);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(50, 13);
            this.lblOrderID.TabIndex = 17;
            this.lblOrderID.Text = "Order ID:";
            // 
            // listViewReceiveStockOrder
            // 
            this.listViewReceiveStockOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOrderLineNoRSO,
            this.columnHeaderDescriptionRSO,
            this.columnHeaderUnitRSO,
            this.columnHeaderQuantityRSO,
            this.columnHeaderUnitCostRSO,
            this.columnHeaderLineCostRSO});
            this.listViewReceiveStockOrder.FullRowSelect = true;
            this.listViewReceiveStockOrder.GridLines = true;
            this.listViewReceiveStockOrder.HideSelection = false;
            this.listViewReceiveStockOrder.Location = new System.Drawing.Point(0, 0);
            this.listViewReceiveStockOrder.Name = "listViewReceiveStockOrder";
            this.listViewReceiveStockOrder.Size = new System.Drawing.Size(416, 550);
            this.listViewReceiveStockOrder.TabIndex = 16;
            this.listViewReceiveStockOrder.UseCompatibleStateImageBehavior = false;
            this.listViewReceiveStockOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderOrderLineNoRSO
            // 
            this.columnHeaderOrderLineNoRSO.Text = "Order Line No.";
            this.columnHeaderOrderLineNoRSO.Width = 83;
            // 
            // columnHeaderDescriptionRSO
            // 
            this.columnHeaderDescriptionRSO.Text = "Description";
            this.columnHeaderDescriptionRSO.Width = 76;
            // 
            // columnHeaderUnitRSO
            // 
            this.columnHeaderUnitRSO.Text = "Unit";
            // 
            // columnHeaderQuantityRSO
            // 
            this.columnHeaderQuantityRSO.Text = "Quantity";
            // 
            // columnHeaderUnitCostRSO
            // 
            this.columnHeaderUnitCostRSO.Text = "Unit Cost";
            // 
            // columnHeaderLineCostRSO
            // 
            this.columnHeaderLineCostRSO.Text = "Line Cost";
            // 
            // tabMoveStock
            // 
            this.tabMoveStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabMoveStock.Location = new System.Drawing.Point(4, 22);
            this.tabMoveStock.Name = "tabMoveStock";
            this.tabMoveStock.Size = new System.Drawing.Size(989, 553);
            this.tabMoveStock.TabIndex = 3;
            this.tabMoveStock.Text = "Move Stock";
            // 
            // tabLogout
            // 
            this.tabLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabLogout.Controls.Add(this.btnLock);
            this.tabLogout.Controls.Add(this.btnLogout);
            this.tabLogout.Location = new System.Drawing.Point(4, 22);
            this.tabLogout.Name = "tabLogout";
            this.tabLogout.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogout.Size = new System.Drawing.Size(989, 553);
            this.tabLogout.TabIndex = 1;
            this.tabLogout.Text = "Logout";
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.Maroon;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.Location = new System.Drawing.Point(518, 212);
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
            this.btnLogout.Location = new System.Drawing.Point(218, 212);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(256, 140);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // BarManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 575);
            this.ControlBox = false;
            this.Controls.Add(this.tabAdmin);
            this.DoubleBuffered = true;
            this.Name = "BarManagerForm";
            this.tabAdmin.ResumeLayout(false);
            this.tabMakeOrder.ResumeLayout(false);
            this.tabMakeOrder.PerformLayout();
            this.tabReceiveOrder.ResumeLayout(false);
            this.tabReceiveOrder.PerformLayout();
            this.groupBoxPartial.ResumeLayout(false);
            this.groupBoxPartial.PerformLayout();
            this.tabLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabMakeOrder;
        private System.Windows.Forms.TabPage tabLogout;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tabReceiveOrder;
        private System.Windows.Forms.TabPage tabMoveStock;
        private System.Windows.Forms.TextBox textBoxMakeOrderUnit;
        private System.Windows.Forms.Label labelMakeOrderUnit;
        private System.Windows.Forms.CheckBox checkBoxMakeOrderPartial;
        private System.Windows.Forms.Button buttonClearOrder;
        private System.Windows.Forms.ComboBox comboBoxOrderSupplier;
        private System.Windows.Forms.ComboBox comboBoxOrderItem;
        private System.Windows.Forms.TextBox textBoxItemQuantity;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.Label labelMakeOrderOrderID;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonRemoveOrderItem;
        private System.Windows.Forms.Button buttonAddOrderItem;
        private System.Windows.Forms.Label labelMakeOrderSupplier;
        private System.Windows.Forms.Label labelMakeOrderQuantity;
        private System.Windows.Forms.Label labelMakeOrderItem;
        private System.Windows.Forms.ListView listViewMakeOrder;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderLineNum;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderUnit;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderUnitCost;
        private System.Windows.Forms.ColumnHeader columnHeaderLineCost;
        private System.Windows.Forms.GroupBox groupBoxPartial;
        private System.Windows.Forms.Button btnQuantityUpdate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnPartial;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnCheckAndReceive;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDateReceived;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDateReceived;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.ListView listViewReceiveStockOrder;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderLineNoRSO;
        private System.Windows.Forms.ColumnHeader columnHeaderDescriptionRSO;
        private System.Windows.Forms.ColumnHeader columnHeaderUnitRSO;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantityRSO;
        private System.Windows.Forms.ColumnHeader columnHeaderUnitCostRSO;
        private System.Windows.Forms.ColumnHeader columnHeaderLineCostRSO;
        private System.Windows.Forms.TextBox textBoxMakeOrderType;
        private System.Windows.Forms.Label label1;
    }
}