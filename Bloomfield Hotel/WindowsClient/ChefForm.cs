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
    public partial class ChefForm : Form
    {
        private formContainer fc;
        private IModel Model;
        private List<IOrderItem> orderItems = new List<IOrderItem>();
        private List<IOrderItem> receiveOrderItems = new List<IOrderItem>();
        private int id;
        private IOrder order = new Order();
        private IOrderItem oEdit = new OrderItem();
        int orderID;
        string decription;
        double unitCost;
        double lineCost;
        double quantity;
        int index;
        bool UpdateBtnClicked = false;
        public ChefForm(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            LoginForm.isLockClicked = false;
            id = 1;
            PopulateSuppliers();
            PopulateItems();
            SetNewOrderID();
            PopulateChefTable();
            PopulateExpDatesTable();
            updateDailyMeal();
            PopulateRicipes();
        }

        private void LogoutBtn(object sender, EventArgs e)
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
        private void PopulateSuppliers()
        {
            List<string> suppliers = Model.getSuppliers();
            foreach (string s in suppliers)
            {
                comboBoxOrderSupplier.Items.Add(s);
            }
        }

        private void PopulateItems()
        {
            comboBoxOrderItem.Items.Clear();
            List<IStockItem> items = Model.getAllStockItems();
            string supplier = comboBoxOrderSupplier.Text;
            if (supplier == "")
            {
                foreach (IStockItem s in items)
                {
                    if (Model.CheckIfStockItemIsFood(s))
                        comboBoxOrderItem.Items.Add(s.description);
                }
            }
            else
            {
                foreach (IStockItem s in items)
                {
                    if (s.supplier == supplier)
                    {
                        if (Model.CheckIfStockItemIsFood(s))
                            comboBoxOrderItem.Items.Add(s.description);
                    }
                }
            }
        }

        private void comboBoxOrderSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateItems();
        }

        private void buttonAddOrderItem_Click(object sender, EventArgs e)
        {
            if (comboBoxOrderSupplier.Text == "")
            {
                MessageBox.Show("Please select a supplier before adding any items to the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                comboBoxOrderSupplier.Enabled = false;
                textBoxOrderID.ReadOnly = true;

                IStockItem item = Model.getStockItem(comboBoxOrderItem.Text, comboBoxOrderSupplier.Text);
                IOrderItem oi = OrderItemFactory.GetOrderItem(id, Convert.ToInt32(textBoxOrderID.Text), item, Convert.ToInt32(textBoxItemQuantity.Text));
                orderItems.Add(oi);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = id.ToString();

                ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = oi.item.description; lvi.SubItems.Add(lvsi);
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = oi.item.unit; lvi.SubItems.Add(lvsi);
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = oi.quantity.ToString(); lvi.SubItems.Add(lvsi);
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = oi.item.unitCost.ToString(); lvi.SubItems.Add(lvsi);
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = oi.lineCost.ToString(); lvi.SubItems.Add(lvsi);
                listViewMakeOrder.Items.Add(lvi);

                id++;
            }
        }

        private void buttonRemoveOrderItem_Click(object sender, EventArgs e)
        {
            List<int> id = new List<int>();
            foreach (ListViewItem l in listViewMakeOrder.SelectedItems)
            {
                id.Add(Convert.ToInt32(l.SubItems[0].Text));
                l.Remove();
            }
            foreach (int i in id)
            {
                foreach (IOrderItem o in orderItems)
                {
                    if (o.orderID == i)
                        orderItems.Remove(o);
                }
            }
        }

        private void buttonClearOrder_Click(object sender, EventArgs e)
        {
            ResetMakeOrder();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            if (orderItems.Count == 0)
            {
                MessageBox.Show("Please add items to the order before creating it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string orderType = "Food";
                IOrder order = OrderFactory.GetOrder(Convert.ToInt32(textBoxOrderID.Text), DateTime.Now, orderItems, orderType, comboBoxOrderSupplier.Text, checkBoxMakeOrderPartial.Checked);
                Model.MakeNewOrder(order);
                ResetMakeOrder();
            }
        }

        private void ResetMakeOrder()
        {
            comboBoxOrderSupplier.Enabled = true;
            listViewMakeOrder.Items.Clear();
            orderItems.Clear();
            SetNewOrderID();
            id = 1;

            textBoxItemQuantity.Text = "";
            textBoxMakeOrderUnit.Text = "";
            comboBoxOrderItem.Text = "";
            comboBoxOrderSupplier.Text = "";
            checkBoxMakeOrderPartial.Checked = false;
        }

        private void comboBoxOrderItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string unit = "";
            foreach (StockItem i in Model.StockList)
            {
                if (comboBoxOrderItem.Text == i.description)
                {
                    unit = i.unit;
                    break;
                }
            }
            textBoxMakeOrderUnit.Text = unit;
        }

        private void SetNewOrderID()
        {
            int id = Model.GetNewOrderID();
            textBoxOrderID.Text = id.ToString();
        }
        private void btnCheckAndReceive_Click(object sender, EventArgs e)
        {
            if (btnCheckAndReceive.Text == "Check")
            {
                if (txtOrderID.Text != "")
                {
                    orderID = Convert.ToInt32(txtOrderID.Text);
                    order = Model.getOrder(orderID);


                    if (order.received == true)
                    {
                        MessageBox.Show("Order is already received.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtOrderID.Focus();

                    }
                    else if (order.orderID.Equals(orderID) && order.received == false)
                    {
                        btnPartial.Enabled = true;
                        btnCheckAndReceive.Text = "Receive";
                        btnCancelOrder.Enabled = true;
                        txtOrderID.Enabled = false;
                        receiveOrderItems = Model.getOrderItemByOrderID(orderID);
                        PopulateReceiveStockOrder();
                    }
                    else
                    {
                        MessageBox.Show("Order does not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtOrderID.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("OrderID is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOrderID.Focus();
                }
            }
            else
            {
                IOrder o = OrderFactory.GetOrder(orderID, DateTime.Now, receiveOrderItems, order.orderType, order.supplier, order.acceptPartial, true);
                if (Model.editOrder(o))
                {
                    Model.UpdateStock(o);
                    Model.editOrderItem(oEdit);
                    MessageBox.Show("Order Received.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCheckAndReceive.Text = "Check";
                    txtOrderID.Enabled = true;
                    ResetReceiveStockOrderTab();
                }
                else
                    MessageBox.Show("Order is NOT Received.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPartial_Click(object sender, EventArgs e)
        {

            if (order.acceptPartial)
            {
                btnQuantityUpdate.Enabled = true;
                txtQuantity.Enabled = true;
                btnPartial.Enabled = false;
            }
            else
            {
                MessageBox.Show("Order is not a 'Partial Order'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnPartial.Enabled = false;
            }
        }
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to cancel the order?";
            const string caption = "Warning";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ResetReceiveStockOrderTab();
                MessageBox.Show("The Order has been cancelled.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void ResetReceiveStockOrderTab()
        {
            txtOrderID.Text = "";
            txtDateReceived.Text = "";
            txtTotal.Text = "";
            txtQuantity.Text = "";

            btnQuantityUpdate.Enabled = false;
            txtQuantity.Enabled = false;
            btnPartial.Enabled = false;
            btnCheckAndReceive.Enabled = true;
            btnCancelOrder.Enabled = false;
            btnCheckAndReceive.Text = "Check";
            listViewReceiveStockOrder.Items.Clear();
            txtOrderID.Enabled = true;
        }
        private void listViewReceiveStockOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewReceiveStockOrder.SelectedItems)
            {
                decription = item.SubItems[1].Text;
                quantity = Convert.ToDouble(item.SubItems[3].Text);
                txtQuantity.Text = item.SubItems[3].Text;
                unitCost = Convert.ToDouble(item.SubItems[4].Text);
                lineCost = Convert.ToDouble(item.SubItems[5].Text);
                index = item.Index;
            }
            
        }
        private void btnQuantityUpdate_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                if (quantity >= Convert.ToDouble(txtQuantity.Text))
                {
                    foreach (OrderItem orderItem in receiveOrderItems)
                    {
                        if (orderItem.orderID == orderID)
                        {
                            IStockItem item = Model.getStockItemByDesAndUnitCost(decription, unitCost);
                            oEdit = OrderItemFactory.GetOrderItem(index + 1, orderID, item, Convert.ToInt32(txtQuantity.Text));
                            receiveOrderItems.Add(oEdit);
                            receiveOrderItems.RemoveAt(index);
                            UpdateBtnClicked = true;
                            PopulateReceiveStockOrder();
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Quantity must be less than the actual Quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantity.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a Quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
            }
        }
        private void PopulateReceiveStockOrder()
        {
            listViewReceiveStockOrder.Items.Clear();
            receiveOrderItems = receiveOrderItems.OrderBy(oi => oi.lineID).ToList();
            foreach (OrderItem orderItem in receiveOrderItems)
            {
                listViewReceiveStockOrder.Items.Add(new ListViewItem(new string[]
                {
                    orderItem.lineID.ToString(), orderItem.item.description, orderItem.item.unit, orderItem.quantity.ToString(),
                    orderItem.item.unitCost.ToString(), orderItem.lineCost.ToString()
                }));
            }
            txtDateReceived.Text = DateTime.Now.ToShortDateString();
            if (UpdateBtnClicked)
            {
                if (txtQuantity.Text != "")
                {
                    double quantity = Convert.ToDouble(txtQuantity.Text);
                    order.total -= lineCost;
                    lineCost = unitCost * quantity;
                    txtTotal.Text = (order.total + lineCost).ToString();
                }
            }
            else
            {
                txtTotal.Text = order.total.ToString();
            }
            UpdateBtnClicked = false;
        }

        private void PopulateChefTable()
        {
            List<ICustomerSale> listOfChefOrders = Model.PopulateKitchenOrdersList();
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi1;
            listViewChefOrders.Items.Clear();
            listViewChefOrders.BeginUpdate();

            foreach (ICustomerSale sale in listOfChefOrders)
            {
                foreach (ISaleLineItem sli in sale.saleLineItems)
                {
                    if (Model.CheckIfSaleLineItemIsMeal(sli))
                    {
                        if (!sli.cooked)
                        {
                            lvi = new ListViewItem();
                            lvi.Text = sale.saleID.ToString();

                            lvsi1 = new ListViewItem.ListViewSubItem();
                            lvsi1.Text = sli.item.description;
                            lvi.SubItems.Add(lvsi1);

                            lvsi1 = new ListViewItem.ListViewSubItem();
                            lvsi1.Text = sale.tableNumber.ToString();
                            lvi.SubItems.Add(lvsi1);

                            lvsi1 = new ListViewItem.ListViewSubItem();
                            lvsi1.Text = sli.item.quantity.ToString();
                            lvi.SubItems.Add(lvsi1);

                            listViewChefOrders.Items.Add(lvi);
                        }
                    }
                }
            }

            listViewChefOrders.EndUpdate();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            int saleID = 0;
            String description = "";
            int amount = 0;

            foreach (ListViewItem li in listViewChefOrders.SelectedItems)
            {
                saleID = Convert.ToInt32(li.SubItems[0].Text);
                description = li.SubItems[1].Text;
                amount = Convert.ToInt32(li.SubItems[3].Text);
            }

            if (description.Equals(lblMeal1.Text))
            {
                int quantiy = Convert.ToInt32(txtAmount1.Text) - amount;
                txtAmount1.Text = quantiy.ToString();
            }

            else
            {
                int quantiy = Convert.ToInt32(txtAmount2.Text) - amount;
                txtAmount2.Text = quantiy.ToString();
            }

            Model.CookOrder(saleID, description);
            PopulateChefTable();
        }

        private void updateDailyMeal()
        {
            String meal1 = Model.DailySelectedMeals.ElementAt(0).description;
            String meal2 = Model.DailySelectedMeals.ElementAt(1).description;
            int amount1 = Model.DailySelectedMeals.ElementAt(0).quantity;
            int amount2 = Model.DailySelectedMeals.ElementAt(1).quantity;

            lblMeal1.Text = meal1;
            lblMeal2.Text = meal2;
            txtAmount1.Text = amount1.ToString();
            txtAmount2.Text = amount2.ToString();
        }

        private void PopulateRicipes()
        {
            foreach (IRecipe recipe in Model.RecipeList)
            {
                cbSelectRecipes1.Items.Add(recipe.name);
                cbSelectRecipes2.Items.Add(recipe.name);
            }
        }

        private void btnConfirmRecipes_Click(object sender, EventArgs e)
        {
            Model.DailySelectedMeals.Clear();

            foreach (ISaleItem si in Model.SaleItemsList)
            {
                if (si.description.Equals(cbSelectRecipes1.Text))
                {
                    si.quantity = Convert.ToInt32(txtSelectRecipeAmount1.Text);
                    Model.DailySelectedMeals.Add(si);
                }

                else if (si.description.Equals(cbSelectRecipes2.Text))
                {
                    si.quantity = Convert.ToInt32(txtSelectRecipeAmount2.Text);
                    Model.DailySelectedMeals.Add(si);
                }
            }

            MessageBox.Show("Selected Recipes:\n\n" + Model.DailySelectedMeals.ElementAt(0).description + ": " + Model.DailySelectedMeals.ElementAt(0).quantity
                + "\n" + Model.DailySelectedMeals.ElementAt(1).description + ": " + Model.DailySelectedMeals.ElementAt(1).quantity);
        }

        private void cbSelectRecipes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string note = "Ingredients:\n";

            foreach (IRecipe recipe in Model.RecipeList)
            {
                if (recipe.name.Equals(cbSelectRecipes1.Text))
                {
                    foreach (IStockItem item in recipe.ingredients)
                    {
                        note += item.description + ": " + item.quantity + ", ";
                    }

                    note += "\n\nInstructions:\n" +
                        recipe.instructions;

                    break;
                }
            }

            rtbSelectRecipes1.Text = note;
        }
        private void cbSelectRecipes2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string note = "Ingredients:\n";

            foreach (IRecipe recipe in Model.RecipeList)
            {
                if (recipe.name.Equals(cbSelectRecipes2.Text))
                {
                    foreach (IStockItem item in recipe.ingredients)
                    {
                        note += item.description + ": " + item.quantity + ", ";
                    }

                    note += "\n\nInstructions:\n" +
                        recipe.instructions;

                    break;
                }
            }

            rtbSelectRecipes2.Text = note;
        }

        private void PopulateExpDatesTable()
        {
            List<IStockItem> listOfExpDates = Model.getAllStockItems();
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi1;
            lvViewExpDates.Items.Clear();
            lvViewExpDates.BeginUpdate();

            foreach (IStockItem item in listOfExpDates)
            {
                if (Model.CheckIfStockItemIsFood(item))
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.itemID.ToString();

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.description;
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.unit;
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.quantity.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.supplier;
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.unitCost.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.shelfLifeInDays.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.currentUseByDate.ToShortDateString();
                    lvi.SubItems.Add(lvsi1);

                    lvViewExpDates.Items.Add(lvi);
                }
            }

            lvViewExpDates.EndUpdate();
        }
        private void btnViewExpDates_Click(object sender, EventArgs e)
        {
            if (txtViewExpDates.Text == "")
            {
                MessageBox.Show("Please enter a description to see his expiration date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                String description = txtViewExpDates.Text;
                List<IStockItem> items = Model.getStockItemByDescription(description);

                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi1;
                lvViewExpDates.Items.Clear();
                lvViewExpDates.BeginUpdate();

                foreach (IStockItem item in items)
                {
                    if (Model.CheckIfStockItemIsFood(item))
                    {
                        lvi = new ListViewItem();
                        lvi.Text = item.itemID.ToString();

                        lvsi1 = new ListViewItem.ListViewSubItem();
                        lvsi1.Text = item.description;
                        lvi.SubItems.Add(lvsi1);

                        lvsi1 = new ListViewItem.ListViewSubItem();
                        lvsi1.Text = item.unit;
                        lvi.SubItems.Add(lvsi1);

                        lvsi1 = new ListViewItem.ListViewSubItem();
                        lvsi1.Text = item.quantity.ToString();
                        lvi.SubItems.Add(lvsi1);

                        lvsi1 = new ListViewItem.ListViewSubItem();
                        lvsi1.Text = item.supplier;
                        lvi.SubItems.Add(lvsi1);

                        lvsi1 = new ListViewItem.ListViewSubItem();
                        lvsi1.Text = item.unitCost.ToString();
                        lvi.SubItems.Add(lvsi1);

                        lvsi1 = new ListViewItem.ListViewSubItem();
                        lvsi1.Text = item.shelfLifeInDays.ToString();
                        lvi.SubItems.Add(lvsi1);

                        lvsi1 = new ListViewItem.ListViewSubItem();
                        lvsi1.Text = item.currentUseByDate.ToShortDateString();
                        lvi.SubItems.Add(lvsi1);

                        lvViewExpDates.Items.Add(lvi);
                    }
                }

                lvViewExpDates.EndUpdate();
            }
        }

        private void btnResetExpDates_Click(object sender, EventArgs e)
        {
            PopulateExpDatesTable();
        }
    }
}
