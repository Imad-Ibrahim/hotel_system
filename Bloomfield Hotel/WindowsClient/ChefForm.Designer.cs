
namespace WindowsClient
{
    partial class ChefForm
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
            this.ChefTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtbSelectRecipes2 = new System.Windows.Forms.RichTextBox();
            this.rtbSelectRecipes1 = new System.Windows.Forms.RichTextBox();
            this.txtSelectRecipeAmount2 = new System.Windows.Forms.TextBox();
            this.txtSelectRecipeAmount1 = new System.Windows.Forms.TextBox();
            this.btnConfirmRecipes = new System.Windows.Forms.Button();
            this.cbSelectRecipes2 = new System.Windows.Forms.ComboBox();
            this.cbSelectRecipes1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPageViewExpirationDates = new System.Windows.Forms.TabPage();
            this.btnResetExpDates = new System.Windows.Forms.Button();
            this.lblViewExpDates = new System.Windows.Forms.Label();
            this.btnViewExpDates = new System.Windows.Forms.Button();
            this.txtViewExpDates = new System.Windows.Forms.TextBox();
            this.lvViewExpDates = new System.Windows.Forms.ListView();
            this.ViewExpDatesItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewExpDatesDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewExpDatesUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewExpDatesQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewExpDatesSupplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewExpDatesUnitCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewExpDatesShelfLifeInDays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewExpDatesCurrentUseByDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtAmount2 = new System.Windows.Forms.TextBox();
            this.txtAmount1 = new System.Windows.Forms.TextBox();
            this.lblMeal2 = new System.Windows.Forms.Label();
            this.lblMeal1 = new System.Windows.Forms.Label();
            this.btnManageOrders = new System.Windows.Forms.Button();
            this.listViewChefOrders = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPageMakeOrder = new System.Windows.Forms.TabPage();
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
            this.tabPageReceiveStockOrder = new System.Windows.Forms.TabPage();
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
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.ChefTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageViewExpirationDates.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPageMakeOrder.SuspendLayout();
            this.tabPageReceiveStockOrder.SuspendLayout();
            this.groupBoxPartial.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChefTabs
            // 
            this.ChefTabs.Controls.Add(this.tabPage1);
            this.ChefTabs.Controls.Add(this.tabPage2);
            this.ChefTabs.Controls.Add(this.tabPageViewExpirationDates);
            this.ChefTabs.Controls.Add(this.tabPage3);
            this.ChefTabs.Controls.Add(this.tabPage4);
            this.ChefTabs.Controls.Add(this.tabPage5);
            this.ChefTabs.Controls.Add(this.tabPageMakeOrder);
            this.ChefTabs.Controls.Add(this.tabPageReceiveStockOrder);
            this.ChefTabs.Controls.Add(this.tabPage8);
            this.ChefTabs.Location = new System.Drawing.Point(2, 1);
            this.ChefTabs.Name = "ChefTabs";
            this.ChefTabs.SelectedIndex = 0;
            this.ChefTabs.Size = new System.Drawing.Size(992, 575);
            this.ChefTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.rtbSelectRecipes2);
            this.tabPage1.Controls.Add(this.rtbSelectRecipes1);
            this.tabPage1.Controls.Add(this.txtSelectRecipeAmount2);
            this.tabPage1.Controls.Add(this.txtSelectRecipeAmount1);
            this.tabPage1.Controls.Add(this.btnConfirmRecipes);
            this.tabPage1.Controls.Add(this.cbSelectRecipes2);
            this.tabPage1.Controls.Add(this.cbSelectRecipes1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select Recipes";
            // 
            // rtbSelectRecipes2
            // 
            this.rtbSelectRecipes2.Location = new System.Drawing.Point(57, 308);
            this.rtbSelectRecipes2.Name = "rtbSelectRecipes2";
            this.rtbSelectRecipes2.Size = new System.Drawing.Size(862, 96);
            this.rtbSelectRecipes2.TabIndex = 13;
            this.rtbSelectRecipes2.Text = "";
            // 
            // rtbSelectRecipes1
            // 
            this.rtbSelectRecipes1.Location = new System.Drawing.Point(57, 107);
            this.rtbSelectRecipes1.Name = "rtbSelectRecipes1";
            this.rtbSelectRecipes1.Size = new System.Drawing.Size(862, 96);
            this.rtbSelectRecipes1.TabIndex = 12;
            this.rtbSelectRecipes1.Text = "";
            // 
            // txtSelectRecipeAmount2
            // 
            this.txtSelectRecipeAmount2.Location = new System.Drawing.Point(512, 239);
            this.txtSelectRecipeAmount2.Name = "txtSelectRecipeAmount2";
            this.txtSelectRecipeAmount2.Size = new System.Drawing.Size(100, 20);
            this.txtSelectRecipeAmount2.TabIndex = 11;
            // 
            // txtSelectRecipeAmount1
            // 
            this.txtSelectRecipeAmount1.Location = new System.Drawing.Point(512, 63);
            this.txtSelectRecipeAmount1.Name = "txtSelectRecipeAmount1";
            this.txtSelectRecipeAmount1.Size = new System.Drawing.Size(100, 20);
            this.txtSelectRecipeAmount1.TabIndex = 10;
            // 
            // btnConfirmRecipes
            // 
            this.btnConfirmRecipes.BackColor = System.Drawing.Color.Maroon;
            this.btnConfirmRecipes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmRecipes.ForeColor = System.Drawing.Color.White;
            this.btnConfirmRecipes.Location = new System.Drawing.Point(371, 434);
            this.btnConfirmRecipes.Name = "btnConfirmRecipes";
            this.btnConfirmRecipes.Size = new System.Drawing.Size(191, 60);
            this.btnConfirmRecipes.TabIndex = 9;
            this.btnConfirmRecipes.Text = "Confirm Recipes";
            this.btnConfirmRecipes.UseVisualStyleBackColor = false;
            this.btnConfirmRecipes.Click += new System.EventHandler(this.btnConfirmRecipes_Click);
            // 
            // cbSelectRecipes2
            // 
            this.cbSelectRecipes2.FormattingEnabled = true;
            this.cbSelectRecipes2.Location = new System.Drawing.Point(371, 238);
            this.cbSelectRecipes2.Name = "cbSelectRecipes2";
            this.cbSelectRecipes2.Size = new System.Drawing.Size(121, 21);
            this.cbSelectRecipes2.TabIndex = 8;
            this.cbSelectRecipes2.SelectedIndexChanged += new System.EventHandler(this.cbSelectRecipes2_SelectedIndexChanged);
            // 
            // cbSelectRecipes1
            // 
            this.cbSelectRecipes1.FormattingEnabled = true;
            this.cbSelectRecipes1.Location = new System.Drawing.Point(371, 62);
            this.cbSelectRecipes1.Name = "cbSelectRecipes1";
            this.cbSelectRecipes1.Size = new System.Drawing.Size(121, 21);
            this.cbSelectRecipes1.TabIndex = 7;
            this.cbSelectRecipes1.SelectedIndexChanged += new System.EventHandler(this.cbSelectRecipes1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Breakfast Buffet Food";
            // 
            // tabPageViewExpirationDates
            // 
            this.tabPageViewExpirationDates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageViewExpirationDates.Controls.Add(this.btnResetExpDates);
            this.tabPageViewExpirationDates.Controls.Add(this.lblViewExpDates);
            this.tabPageViewExpirationDates.Controls.Add(this.btnViewExpDates);
            this.tabPageViewExpirationDates.Controls.Add(this.txtViewExpDates);
            this.tabPageViewExpirationDates.Controls.Add(this.lvViewExpDates);
            this.tabPageViewExpirationDates.Location = new System.Drawing.Point(4, 22);
            this.tabPageViewExpirationDates.Name = "tabPageViewExpirationDates";
            this.tabPageViewExpirationDates.Size = new System.Drawing.Size(984, 549);
            this.tabPageViewExpirationDates.TabIndex = 8;
            this.tabPageViewExpirationDates.Text = "View Exp. Dates";
            // 
            // btnResetExpDates
            // 
            this.btnResetExpDates.BackColor = System.Drawing.Color.Maroon;
            this.btnResetExpDates.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetExpDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetExpDates.ForeColor = System.Drawing.Color.White;
            this.btnResetExpDates.Location = new System.Drawing.Point(717, 233);
            this.btnResetExpDates.Name = "btnResetExpDates";
            this.btnResetExpDates.Size = new System.Drawing.Size(131, 37);
            this.btnResetExpDates.TabIndex = 9;
            this.btnResetExpDates.Text = "Reset";
            this.btnResetExpDates.UseVisualStyleBackColor = false;
            this.btnResetExpDates.Click += new System.EventHandler(this.btnResetExpDates_Click);
            // 
            // lblViewExpDates
            // 
            this.lblViewExpDates.AutoSize = true;
            this.lblViewExpDates.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.lblViewExpDates.Location = new System.Drawing.Point(674, 87);
            this.lblViewExpDates.Name = "lblViewExpDates";
            this.lblViewExpDates.Size = new System.Drawing.Size(219, 21);
            this.lblViewExpDates.TabIndex = 8;
            this.lblViewExpDates.Text = "Search item by description:";
            // 
            // btnViewExpDates
            // 
            this.btnViewExpDates.BackColor = System.Drawing.Color.Maroon;
            this.btnViewExpDates.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewExpDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewExpDates.ForeColor = System.Drawing.Color.White;
            this.btnViewExpDates.Location = new System.Drawing.Point(717, 174);
            this.btnViewExpDates.Name = "btnViewExpDates";
            this.btnViewExpDates.Size = new System.Drawing.Size(131, 37);
            this.btnViewExpDates.TabIndex = 7;
            this.btnViewExpDates.Text = "Search";
            this.btnViewExpDates.UseVisualStyleBackColor = false;
            this.btnViewExpDates.Click += new System.EventHandler(this.btnViewExpDates_Click);
            // 
            // txtViewExpDates
            // 
            this.txtViewExpDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewExpDates.Location = new System.Drawing.Point(695, 118);
            this.txtViewExpDates.Multiline = true;
            this.txtViewExpDates.Name = "txtViewExpDates";
            this.txtViewExpDates.Size = new System.Drawing.Size(175, 35);
            this.txtViewExpDates.TabIndex = 6;
            // 
            // lvViewExpDates
            // 
            this.lvViewExpDates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ViewExpDatesItemID,
            this.ViewExpDatesDescription,
            this.ViewExpDatesUnit,
            this.ViewExpDatesQuantity,
            this.ViewExpDatesSupplier,
            this.ViewExpDatesUnitCost,
            this.ViewExpDatesShelfLifeInDays,
            this.ViewExpDatesCurrentUseByDate});
            this.lvViewExpDates.FullRowSelect = true;
            this.lvViewExpDates.GridLines = true;
            this.lvViewExpDates.HideSelection = false;
            this.lvViewExpDates.Location = new System.Drawing.Point(-1, -1);
            this.lvViewExpDates.MultiSelect = false;
            this.lvViewExpDates.Name = "lvViewExpDates";
            this.lvViewExpDates.Size = new System.Drawing.Size(588, 554);
            this.lvViewExpDates.TabIndex = 5;
            this.lvViewExpDates.UseCompatibleStateImageBehavior = false;
            this.lvViewExpDates.View = System.Windows.Forms.View.Details;
            // 
            // ViewExpDatesItemID
            // 
            this.ViewExpDatesItemID.Text = "Item ID";
            // 
            // ViewExpDatesDescription
            // 
            this.ViewExpDatesDescription.Text = "Description";
            this.ViewExpDatesDescription.Width = 65;
            // 
            // ViewExpDatesUnit
            // 
            this.ViewExpDatesUnit.Text = "Unit";
            // 
            // ViewExpDatesQuantity
            // 
            this.ViewExpDatesQuantity.Text = "Quantity";
            // 
            // ViewExpDatesSupplier
            // 
            this.ViewExpDatesSupplier.Text = "Supplier";
            // 
            // ViewExpDatesUnitCost
            // 
            this.ViewExpDatesUnitCost.Text = "Unit Cost";
            // 
            // ViewExpDatesShelfLifeInDays
            // 
            this.ViewExpDatesShelfLifeInDays.Text = "Shelf Life In Days";
            this.ViewExpDatesShelfLifeInDays.Width = 100;
            // 
            // ViewExpDatesCurrentUseByDate
            // 
            this.ViewExpDatesCurrentUseByDate.Text = "Current Use By Date";
            this.ViewExpDatesCurrentUseByDate.Width = 110;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage3.Controls.Add(this.txtAmount2);
            this.tabPage3.Controls.Add(this.txtAmount1);
            this.tabPage3.Controls.Add(this.lblMeal2);
            this.tabPage3.Controls.Add(this.lblMeal1);
            this.tabPage3.Controls.Add(this.btnManageOrders);
            this.tabPage3.Controls.Add(this.listViewChefOrders);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(984, 549);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Orders";
            // 
            // txtAmount2
            // 
            this.txtAmount2.Location = new System.Drawing.Point(753, 328);
            this.txtAmount2.Name = "txtAmount2";
            this.txtAmount2.ReadOnly = true;
            this.txtAmount2.Size = new System.Drawing.Size(50, 20);
            this.txtAmount2.TabIndex = 6;
            // 
            // txtAmount1
            // 
            this.txtAmount1.Location = new System.Drawing.Point(753, 286);
            this.txtAmount1.Name = "txtAmount1";
            this.txtAmount1.ReadOnly = true;
            this.txtAmount1.Size = new System.Drawing.Size(50, 20);
            this.txtAmount1.TabIndex = 5;
            // 
            // lblMeal2
            // 
            this.lblMeal2.AutoSize = true;
            this.lblMeal2.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.lblMeal2.Location = new System.Drawing.Point(601, 325);
            this.lblMeal2.Name = "lblMeal2";
            this.lblMeal2.Size = new System.Drawing.Size(127, 21);
            this.lblMeal2.TabIndex = 4;
            this.lblMeal2.Text = "Beef Casserole:";
            // 
            // lblMeal1
            // 
            this.lblMeal1.AutoSize = true;
            this.lblMeal1.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.lblMeal1.Location = new System.Drawing.Point(601, 283);
            this.lblMeal1.Name = "lblMeal1";
            this.lblMeal1.Size = new System.Drawing.Size(125, 21);
            this.lblMeal1.TabIndex = 3;
            this.lblMeal1.Text = "Chicken Curry:";
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.BackColor = System.Drawing.Color.Maroon;
            this.btnManageOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageOrders.ForeColor = System.Drawing.Color.White;
            this.btnManageOrders.Location = new System.Drawing.Point(605, 126);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Size = new System.Drawing.Size(214, 111);
            this.btnManageOrders.TabIndex = 2;
            this.btnManageOrders.Text = "Complete";
            this.btnManageOrders.UseVisualStyleBackColor = false;
            this.btnManageOrders.Click += new System.EventHandler(this.btnManageOrders_Click);
            // 
            // listViewChefOrders
            // 
            this.listViewChefOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader13});
            this.listViewChefOrders.FullRowSelect = true;
            this.listViewChefOrders.GridLines = true;
            this.listViewChefOrders.HideSelection = false;
            this.listViewChefOrders.Location = new System.Drawing.Point(-4, -1);
            this.listViewChefOrders.Name = "listViewChefOrders";
            this.listViewChefOrders.Size = new System.Drawing.Size(414, 554);
            this.listViewChefOrders.TabIndex = 1;
            this.listViewChefOrders.UseCompatibleStateImageBehavior = false;
            this.listViewChefOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Order ID";
            this.columnHeader7.Width = 83;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Description";
            this.columnHeader8.Width = 203;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Table";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Amount";
            this.columnHeader13.Width = 61;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(984, 549);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add Recipe";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(984, 549);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Manage Recipe ";
            // 
            // tabPageMakeOrder
            // 
            this.tabPageMakeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageMakeOrder.Controls.Add(this.textBoxMakeOrderUnit);
            this.tabPageMakeOrder.Controls.Add(this.labelMakeOrderUnit);
            this.tabPageMakeOrder.Controls.Add(this.checkBoxMakeOrderPartial);
            this.tabPageMakeOrder.Controls.Add(this.buttonClearOrder);
            this.tabPageMakeOrder.Controls.Add(this.comboBoxOrderSupplier);
            this.tabPageMakeOrder.Controls.Add(this.comboBoxOrderItem);
            this.tabPageMakeOrder.Controls.Add(this.textBoxItemQuantity);
            this.tabPageMakeOrder.Controls.Add(this.textBoxOrderID);
            this.tabPageMakeOrder.Controls.Add(this.labelMakeOrderOrderID);
            this.tabPageMakeOrder.Controls.Add(this.buttonCreateOrder);
            this.tabPageMakeOrder.Controls.Add(this.buttonRemoveOrderItem);
            this.tabPageMakeOrder.Controls.Add(this.buttonAddOrderItem);
            this.tabPageMakeOrder.Controls.Add(this.labelMakeOrderSupplier);
            this.tabPageMakeOrder.Controls.Add(this.labelMakeOrderQuantity);
            this.tabPageMakeOrder.Controls.Add(this.labelMakeOrderItem);
            this.tabPageMakeOrder.Controls.Add(this.listViewMakeOrder);
            this.tabPageMakeOrder.Location = new System.Drawing.Point(4, 22);
            this.tabPageMakeOrder.Name = "tabPageMakeOrder";
            this.tabPageMakeOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMakeOrder.Size = new System.Drawing.Size(984, 549);
            this.tabPageMakeOrder.TabIndex = 5;
            this.tabPageMakeOrder.Text = "Make Order";
            // 
            // textBoxMakeOrderUnit
            // 
            this.textBoxMakeOrderUnit.Location = new System.Drawing.Point(681, 171);
            this.textBoxMakeOrderUnit.Name = "textBoxMakeOrderUnit";
            this.textBoxMakeOrderUnit.ReadOnly = true;
            this.textBoxMakeOrderUnit.Size = new System.Drawing.Size(172, 20);
            this.textBoxMakeOrderUnit.TabIndex = 21;
            // 
            // labelMakeOrderUnit
            // 
            this.labelMakeOrderUnit.AutoSize = true;
            this.labelMakeOrderUnit.Location = new System.Drawing.Point(550, 174);
            this.labelMakeOrderUnit.Name = "labelMakeOrderUnit";
            this.labelMakeOrderUnit.Size = new System.Drawing.Size(29, 13);
            this.labelMakeOrderUnit.TabIndex = 20;
            this.labelMakeOrderUnit.Text = "Unit:";
            // 
            // checkBoxMakeOrderPartial
            // 
            this.checkBoxMakeOrderPartial.AutoSize = true;
            this.checkBoxMakeOrderPartial.Location = new System.Drawing.Point(657, 277);
            this.checkBoxMakeOrderPartial.Name = "checkBoxMakeOrderPartial";
            this.checkBoxMakeOrderPartial.Size = new System.Drawing.Size(98, 17);
            this.checkBoxMakeOrderPartial.TabIndex = 19;
            this.checkBoxMakeOrderPartial.Text = "Accept Partial?";
            this.checkBoxMakeOrderPartial.UseVisualStyleBackColor = true;
            // 
            // buttonClearOrder
            // 
            this.buttonClearOrder.BackColor = System.Drawing.Color.Maroon;
            this.buttonClearOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClearOrder.ForeColor = System.Drawing.Color.White;
            this.buttonClearOrder.Location = new System.Drawing.Point(731, 397);
            this.buttonClearOrder.Name = "buttonClearOrder";
            this.buttonClearOrder.Size = new System.Drawing.Size(111, 33);
            this.buttonClearOrder.TabIndex = 14;
            this.buttonClearOrder.Text = "Clear Order";
            this.buttonClearOrder.UseVisualStyleBackColor = false;
            this.buttonClearOrder.Click += new System.EventHandler(this.buttonClearOrder_Click);
            // 
            // comboBoxOrderSupplier
            // 
            this.comboBoxOrderSupplier.FormattingEnabled = true;
            this.comboBoxOrderSupplier.Location = new System.Drawing.Point(681, 87);
            this.comboBoxOrderSupplier.Name = "comboBoxOrderSupplier";
            this.comboBoxOrderSupplier.Size = new System.Drawing.Size(172, 21);
            this.comboBoxOrderSupplier.TabIndex = 13;
            this.comboBoxOrderSupplier.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderSupplier_SelectedIndexChanged);
            // 
            // comboBoxOrderItem
            // 
            this.comboBoxOrderItem.FormattingEnabled = true;
            this.comboBoxOrderItem.Location = new System.Drawing.Point(681, 128);
            this.comboBoxOrderItem.Name = "comboBoxOrderItem";
            this.comboBoxOrderItem.Size = new System.Drawing.Size(172, 21);
            this.comboBoxOrderItem.TabIndex = 12;
            this.comboBoxOrderItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderItem_SelectedIndexChanged);
            // 
            // textBoxItemQuantity
            // 
            this.textBoxItemQuantity.Location = new System.Drawing.Point(681, 214);
            this.textBoxItemQuantity.Name = "textBoxItemQuantity";
            this.textBoxItemQuantity.Size = new System.Drawing.Size(172, 20);
            this.textBoxItemQuantity.TabIndex = 11;
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(681, 48);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.ReadOnly = true;
            this.textBoxOrderID.Size = new System.Drawing.Size(172, 20);
            this.textBoxOrderID.TabIndex = 9;
            // 
            // labelMakeOrderOrderID
            // 
            this.labelMakeOrderOrderID.AutoSize = true;
            this.labelMakeOrderOrderID.Location = new System.Drawing.Point(550, 51);
            this.labelMakeOrderOrderID.Name = "labelMakeOrderOrderID";
            this.labelMakeOrderOrderID.Size = new System.Drawing.Size(50, 13);
            this.labelMakeOrderOrderID.TabIndex = 8;
            this.labelMakeOrderOrderID.Text = "Order ID:";
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.BackColor = System.Drawing.Color.Maroon;
            this.buttonCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateOrder.ForeColor = System.Drawing.Color.White;
            this.buttonCreateOrder.Location = new System.Drawing.Point(582, 397);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(104, 33);
            this.buttonCreateOrder.TabIndex = 6;
            this.buttonCreateOrder.Text = "Create Order";
            this.buttonCreateOrder.UseVisualStyleBackColor = false;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonRemoveOrderItem
            // 
            this.buttonRemoveOrderItem.BackColor = System.Drawing.Color.Maroon;
            this.buttonRemoveOrderItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveOrderItem.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveOrderItem.Location = new System.Drawing.Point(735, 343);
            this.buttonRemoveOrderItem.Name = "buttonRemoveOrderItem";
            this.buttonRemoveOrderItem.Size = new System.Drawing.Size(100, 32);
            this.buttonRemoveOrderItem.TabIndex = 5;
            this.buttonRemoveOrderItem.Text = "Remove Item";
            this.buttonRemoveOrderItem.UseVisualStyleBackColor = false;
            this.buttonRemoveOrderItem.Click += new System.EventHandler(this.buttonRemoveOrderItem_Click);
            // 
            // buttonAddOrderItem
            // 
            this.buttonAddOrderItem.BackColor = System.Drawing.Color.Maroon;
            this.buttonAddOrderItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddOrderItem.ForeColor = System.Drawing.Color.White;
            this.buttonAddOrderItem.Location = new System.Drawing.Point(591, 343);
            this.buttonAddOrderItem.Name = "buttonAddOrderItem";
            this.buttonAddOrderItem.Size = new System.Drawing.Size(86, 32);
            this.buttonAddOrderItem.TabIndex = 4;
            this.buttonAddOrderItem.Text = "Add Item";
            this.buttonAddOrderItem.UseVisualStyleBackColor = false;
            this.buttonAddOrderItem.Click += new System.EventHandler(this.buttonAddOrderItem_Click);
            // 
            // labelMakeOrderSupplier
            // 
            this.labelMakeOrderSupplier.AutoSize = true;
            this.labelMakeOrderSupplier.Location = new System.Drawing.Point(550, 90);
            this.labelMakeOrderSupplier.Name = "labelMakeOrderSupplier";
            this.labelMakeOrderSupplier.Size = new System.Drawing.Size(48, 13);
            this.labelMakeOrderSupplier.TabIndex = 3;
            this.labelMakeOrderSupplier.Text = "Supplier:";
            // 
            // labelMakeOrderQuantity
            // 
            this.labelMakeOrderQuantity.AutoSize = true;
            this.labelMakeOrderQuantity.Location = new System.Drawing.Point(550, 217);
            this.labelMakeOrderQuantity.Name = "labelMakeOrderQuantity";
            this.labelMakeOrderQuantity.Size = new System.Drawing.Size(49, 13);
            this.labelMakeOrderQuantity.TabIndex = 2;
            this.labelMakeOrderQuantity.Text = "Quantity:";
            // 
            // labelMakeOrderItem
            // 
            this.labelMakeOrderItem.AutoSize = true;
            this.labelMakeOrderItem.Location = new System.Drawing.Point(550, 131);
            this.labelMakeOrderItem.Name = "labelMakeOrderItem";
            this.labelMakeOrderItem.Size = new System.Drawing.Size(30, 13);
            this.labelMakeOrderItem.TabIndex = 1;
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
            this.listViewMakeOrder.Location = new System.Drawing.Point(-2, -1);
            this.listViewMakeOrder.Name = "listViewMakeOrder";
            this.listViewMakeOrder.Size = new System.Drawing.Size(488, 554);
            this.listViewMakeOrder.TabIndex = 0;
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
            // tabPageReceiveStockOrder
            // 
            this.tabPageReceiveStockOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageReceiveStockOrder.Controls.Add(this.groupBoxPartial);
            this.tabPageReceiveStockOrder.Controls.Add(this.btnCancelOrder);
            this.tabPageReceiveStockOrder.Controls.Add(this.btnCheckAndReceive);
            this.tabPageReceiveStockOrder.Controls.Add(this.txtTotal);
            this.tabPageReceiveStockOrder.Controls.Add(this.txtDateReceived);
            this.tabPageReceiveStockOrder.Controls.Add(this.txtOrderID);
            this.tabPageReceiveStockOrder.Controls.Add(this.lblTotal);
            this.tabPageReceiveStockOrder.Controls.Add(this.lblDateReceived);
            this.tabPageReceiveStockOrder.Controls.Add(this.lblOrderID);
            this.tabPageReceiveStockOrder.Controls.Add(this.listViewReceiveStockOrder);
            this.tabPageReceiveStockOrder.Location = new System.Drawing.Point(4, 22);
            this.tabPageReceiveStockOrder.Name = "tabPageReceiveStockOrder";
            this.tabPageReceiveStockOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReceiveStockOrder.Size = new System.Drawing.Size(984, 549);
            this.tabPageReceiveStockOrder.TabIndex = 6;
            this.tabPageReceiveStockOrder.Text = "Receive Stock Order";
            // 
            // groupBoxPartial
            // 
            this.groupBoxPartial.Controls.Add(this.btnQuantityUpdate);
            this.groupBoxPartial.Controls.Add(this.txtQuantity);
            this.groupBoxPartial.Controls.Add(this.lblQuantity);
            this.groupBoxPartial.Controls.Add(this.btnPartial);
            this.groupBoxPartial.Location = new System.Drawing.Point(570, 243);
            this.groupBoxPartial.Name = "groupBoxPartial";
            this.groupBoxPartial.Size = new System.Drawing.Size(302, 125);
            this.groupBoxPartial.TabIndex = 15;
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
            this.btnQuantityUpdate.Click += new System.EventHandler(this.btnQuantityUpdate_Click);
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
            this.btnPartial.Click += new System.EventHandler(this.btnPartial_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelOrder.Enabled = false;
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrder.Location = new System.Drawing.Point(761, 400);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(111, 56);
            this.btnCancelOrder.TabIndex = 9;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnCheckAndReceive
            // 
            this.btnCheckAndReceive.BackColor = System.Drawing.Color.Maroon;
            this.btnCheckAndReceive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckAndReceive.ForeColor = System.Drawing.Color.White;
            this.btnCheckAndReceive.Location = new System.Drawing.Point(570, 400);
            this.btnCheckAndReceive.Name = "btnCheckAndReceive";
            this.btnCheckAndReceive.Size = new System.Drawing.Size(111, 56);
            this.btnCheckAndReceive.TabIndex = 8;
            this.btnCheckAndReceive.Text = "Check";
            this.btnCheckAndReceive.UseVisualStyleBackColor = false;
            this.btnCheckAndReceive.Click += new System.EventHandler(this.btnCheckAndReceive_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(667, 183);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(205, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // txtDateReceived
            // 
            this.txtDateReceived.Location = new System.Drawing.Point(667, 129);
            this.txtDateReceived.Name = "txtDateReceived";
            this.txtDateReceived.ReadOnly = true;
            this.txtDateReceived.Size = new System.Drawing.Size(205, 20);
            this.txtDateReceived.TabIndex = 6;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(667, 74);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(205, 20);
            this.txtOrderID.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(567, 186);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // lblDateReceived
            // 
            this.lblDateReceived.AutoSize = true;
            this.lblDateReceived.Location = new System.Drawing.Point(567, 132);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(82, 13);
            this.lblDateReceived.TabIndex = 3;
            this.lblDateReceived.Text = "Date Received:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(567, 77);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(50, 13);
            this.lblOrderID.TabIndex = 2;
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
            this.listViewReceiveStockOrder.Location = new System.Drawing.Point(-6, -1);
            this.listViewReceiveStockOrder.MultiSelect = false;
            this.listViewReceiveStockOrder.Name = "listViewReceiveStockOrder";
            this.listViewReceiveStockOrder.Size = new System.Drawing.Size(409, 554);
            this.listViewReceiveStockOrder.TabIndex = 1;
            this.listViewReceiveStockOrder.UseCompatibleStateImageBehavior = false;
            this.listViewReceiveStockOrder.View = System.Windows.Forms.View.Details;
            this.listViewReceiveStockOrder.SelectedIndexChanged += new System.EventHandler(this.listViewReceiveStockOrder_SelectedIndexChanged);
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
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage8.Controls.Add(this.btnLock);
            this.tabPage8.Controls.Add(this.btnLogout);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(984, 549);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Logout";
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.Maroon;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.Location = new System.Drawing.Point(511, 179);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(256, 140);
            this.btnLock.TabIndex = 1;
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
            this.btnLogout.Location = new System.Drawing.Point(211, 179);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(256, 140);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.LogoutBtn);
            // 
            // ChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 575);
            this.ControlBox = false;
            this.Controls.Add(this.ChefTabs);
            this.DoubleBuffered = true;
            this.Name = "ChefForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ChefTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageViewExpirationDates.ResumeLayout(false);
            this.tabPageViewExpirationDates.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPageMakeOrder.ResumeLayout(false);
            this.tabPageMakeOrder.PerformLayout();
            this.tabPageReceiveStockOrder.ResumeLayout(false);
            this.tabPageReceiveStockOrder.PerformLayout();
            this.groupBoxPartial.ResumeLayout(false);
            this.groupBoxPartial.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ChefTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPageMakeOrder;
        private System.Windows.Forms.TabPage tabPageReceiveStockOrder;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnLogout;
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
        private System.Windows.Forms.ColumnHeader columnHeaderQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderUnitCost;
        private System.Windows.Forms.ColumnHeader columnHeaderLineCost;
        private System.Windows.Forms.Button buttonClearOrder;
        private System.Windows.Forms.ComboBox comboBoxOrderSupplier;
        private System.Windows.Forms.ComboBox comboBoxOrderItem;
        private System.Windows.Forms.TextBox textBoxItemQuantity;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.ColumnHeader columnHeaderUnit;
        private System.Windows.Forms.CheckBox checkBoxMakeOrderPartial;
        private System.Windows.Forms.Label labelMakeOrderUnit;
        private System.Windows.Forms.TextBox textBoxMakeOrderUnit;
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
        private System.Windows.Forms.ListView listViewChefOrders;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.TextBox txtAmount2;
        private System.Windows.Forms.TextBox txtAmount1;
        private System.Windows.Forms.Label lblMeal2;
        private System.Windows.Forms.Label lblMeal1;
        private System.Windows.Forms.Button btnManageOrders;
        private System.Windows.Forms.GroupBox groupBoxPartial;
        private System.Windows.Forms.Button btnQuantityUpdate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnPartial;
        private System.Windows.Forms.RichTextBox rtbSelectRecipes2;
        private System.Windows.Forms.RichTextBox rtbSelectRecipes1;
        private System.Windows.Forms.TextBox txtSelectRecipeAmount2;
        private System.Windows.Forms.TextBox txtSelectRecipeAmount1;
        private System.Windows.Forms.Button btnConfirmRecipes;
        private System.Windows.Forms.ComboBox cbSelectRecipes2;
        private System.Windows.Forms.ComboBox cbSelectRecipes1;
        private System.Windows.Forms.TabPage tabPageViewExpirationDates;
        private System.Windows.Forms.Button btnResetExpDates;
        private System.Windows.Forms.Label lblViewExpDates;
        private System.Windows.Forms.Button btnViewExpDates;
        private System.Windows.Forms.TextBox txtViewExpDates;
        private System.Windows.Forms.ListView lvViewExpDates;
        private System.Windows.Forms.ColumnHeader ViewExpDatesItemID;
        private System.Windows.Forms.ColumnHeader ViewExpDatesDescription;
        private System.Windows.Forms.ColumnHeader ViewExpDatesUnit;
        private System.Windows.Forms.ColumnHeader ViewExpDatesQuantity;
        private System.Windows.Forms.ColumnHeader ViewExpDatesSupplier;
        private System.Windows.Forms.ColumnHeader ViewExpDatesUnitCost;
        private System.Windows.Forms.ColumnHeader ViewExpDatesShelfLifeInDays;
        private System.Windows.Forms.ColumnHeader ViewExpDatesCurrentUseByDate;
    }
}