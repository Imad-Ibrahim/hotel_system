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
    public partial class BarStaffForm : Form
    {
        private formContainer fc;
        private IModel Model;
        private List<ISaleLineItem> order;
        private int saleID;
        public BarStaffForm(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            LoginForm.isLockClicked = false;
            order = new List<ISaleLineItem>();
            PopulateMenu();
            saleID = GetSaleID();
            PopulateStockRoom();
            PopulateBarStock();
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
        private int GetSaleID()
        {
            return Model.GetNewSaleID();
        }

        public void ResetProcessOrder()
        {
            order.Clear();
            listViewCustomerOrder.Items.Clear();
            textBoxGuestName.Text = "";
            textBoxTableNumber.Text = "";
            textBoxOrderTotal.Text = "";
            saleID = GetSaleID();
        }

        private void buttonResetFilter_Click(object sender, EventArgs e)
        {
            PopulateMenu();
        }
        private void UpdateTotal()
        {
            double total = 0;
            foreach (ISaleLineItem sli in order)
            {
                total += sli.lineCost;
            }
            textBoxOrderTotal.Text = total.ToString();
        }
        private void PopulateMenu()
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi1;
            listViewOrderMenu.Items.Clear();
            listViewOrderMenu.BeginUpdate();

            foreach (ISaleItem meal in Model.DailySelectedMeals)
            {
                lvi = new ListViewItem();
                lvi.Text = meal.itemID.ToString();

                lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = meal.description;
                lvi.SubItems.Add(lvsi1);

                lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = meal.price.ToString();
                lvi.SubItems.Add(lvsi1);

                lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = meal.unit;
                lvi.SubItems.Add(lvsi1);

                lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = meal.quantity.ToString();
                lvi.SubItems.Add(lvsi1);

                listViewOrderMenu.Items.Add(lvi);
            }

            foreach (ISaleItem item in Model.SaleItemsList)
            {
                string typeCheck = item.GetType().ToString();
                typeCheck = typeCheck.Substring(typeCheck.LastIndexOf('.') + 1);

                if (typeCheck != "Meal")
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.itemID.ToString();

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.description;
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.price.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.unit;
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.quantity.ToString();
                    lvi.SubItems.Add(lvsi1);

                    listViewOrderMenu.Items.Add(lvi);
                }
            }
            listViewOrderMenu.EndUpdate();
            listViewOrderMenu.Enabled = true;
            listViewOrderMenu.FullRowSelect = true;
        }
        private void PopulateOrder()
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi1;
            listViewCustomerOrder.Items.Clear();
            listViewCustomerOrder.BeginUpdate();

            foreach (ISaleLineItem sli in order)
            {
                lvi = new ListViewItem();
                lvi.Text = sli.item.itemID.ToString();

                lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = sli.item.description;
                lvi.SubItems.Add(lvsi1);

                lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = sli.item.price.ToString();
                lvi.SubItems.Add(lvsi1);

                lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = sli.item.unit;
                lvi.SubItems.Add(lvsi1);

                lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = sli.item.quantity.ToString();
                lvi.SubItems.Add(lvsi1);

                listViewCustomerOrder.Items.Add(lvi);
            }
            listViewCustomerOrder.EndUpdate();
            listViewCustomerOrder.Enabled = true;
            listViewCustomerOrder.FullRowSelect = true;
        }

        private void FilterMenu(string filter)
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi1;
            listViewOrderMenu.Items.Clear();
            listViewOrderMenu.BeginUpdate();

            foreach (ISaleItem item in Model.SaleItemsList)
            {
                string typeCheck = item.GetType().ToString();
                typeCheck = typeCheck.Substring(typeCheck.LastIndexOf('.') + 1);

                if (typeCheck == filter)
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.itemID.ToString();

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.description;
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.price.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.unit;
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.quantity.ToString();
                    lvi.SubItems.Add(lvsi1);

                    listViewOrderMenu.Items.Add(lvi);
                }
            }
            listViewOrderMenu.EndUpdate();
            listViewOrderMenu.Enabled = true;
            listViewOrderMenu.FullRowSelect = true;
            listViewOrderMenu.MultiSelect = false;
        }

        private void buttonFilterMeals_Click(object sender, EventArgs e)
        {
            FilterMenu("Meal");
        }

        private void buttonFilterPints_Click(object sender, EventArgs e)
        {
            FilterMenu("Pint");
        }

        private void buttonFilterBottles_Click(object sender, EventArgs e)
        {
            FilterMenu("Bottle");
        }

        private void buttonFilterShots_Click(object sender, EventArgs e)
        {
            FilterMenu("Shot");
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            if (listViewOrderMenu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an item to add to the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = 0, quantity = 1;
                if (textBoxItemQuantity.Text != "")
                    quantity = Convert.ToInt32(textBoxItemQuantity.Text);
                foreach (ListViewItem l in listViewOrderMenu.SelectedItems)
                {
                    id = Convert.ToInt32(l.Text);
                }
                ISaleItem item = Model.GetSaleItem(id);

                if (quantity > item.quantity)
                {
                    MessageBox.Show("Not enough items available, get more from stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Model.CheckIfItemIsAlreadyInOrder(order, item))
                    {
                        foreach (ISaleLineItem lineItem in order)
                        {
                            if (lineItem.item.itemID == item.itemID)
                            {
                                //MessageBox.Show(lineItem.item.quantity + " " + item.quantity);
                                lineItem.item.quantity += quantity;
                                lineItem.updateLineCost();
                            }
                        }
                    }
                    else
                    {
                        ISaleLineItem sli = SaleLineItemFactory.GetSaleLineItem(saleID, item, quantity);
                        order.Add(sli);
                    }
                    item.quantity -= quantity;
                    PopulateOrder();
                    PopulateMenu();
                    textBoxItemQuantity.Text = "";
                    UpdateTotal();
                }
            }
        }

        private void buttonCompleteOrder_Click(object sender, EventArgs e)
        {
            if (textBoxGuestName.Text == "" || textBoxTableNumber.Text == "")
            {
                MessageBox.Show("Please enter the guest's name and table number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ICustomerSale cSale = CustomerSaleFactory.GetCustomerSale(saleID, order, textBoxGuestName.Text, Convert.ToInt32(textBoxTableNumber.Text), Model.CurrentUser);
                if (Model.MakeCustomerSale(cSale))
                    MessageBox.Show("Transaction Processed");
                ResetProcessOrder();
            }
        }

        private void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            ResetProcessOrder();
        }

        private void buttonRemoveFromOrder_Click(object sender, EventArgs e)
        {
            if (listViewCustomerOrder.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an item to remove from the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = 0, quantity = 1, iID = 0; bool equal = false; int orderQuantity = 0;
                if (textBoxItemQuantity.Text != "")
                    quantity = Convert.ToInt32(textBoxItemQuantity.Text);
                foreach (ListViewItem l in listViewCustomerOrder.SelectedItems)
                {
                    id = Convert.ToInt32(l.Text);
                    orderQuantity = Convert.ToInt32(l.SubItems[4].Text);
                }
                ISaleItem item = Model.GetSaleItem(id);

                if (quantity > orderQuantity)
                {
                    quantity = orderQuantity;
                }
                foreach (ISaleLineItem lineItem in order)
                {
                    if (lineItem.item.itemID == item.itemID)
                    {
                        if (lineItem.item.quantity == quantity)
                        {
                            equal = true;
                            iID = order.IndexOf(lineItem);
                        }
                        else
                        {
                            lineItem.item.quantity -= quantity;
                            lineItem.updateLineCost();
                        }
                    }
                }
                if (equal)
                    order.RemoveAt(iID);
                item.quantity += quantity;
                PopulateOrder();
                PopulateMenu();
                textBoxItemQuantity.Text = "";
                UpdateTotal();
            }
        }
        private void PopulateStockRoom()
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi1;
            listViewMoveStockRoom.Items.Clear();
            listViewMoveStockRoom.BeginUpdate();

            foreach (IStockItem item in Model.StockList)
            {
                if (!Model.CheckIfStockItemIsFood(item))
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.itemID.ToString();

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.description;
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.unit.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.unitValue.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.quantity.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.supplier;
                    lvi.SubItems.Add(lvsi1);

                    listViewMoveStockRoom.Items.Add(lvi);
                }
            }
            listViewMoveStockRoom.EndUpdate();
        }
        private void PopulateBarStock()
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi1;
            listViewMoveBar.Items.Clear();
            listViewMoveBar.BeginUpdate();

            foreach (ISaleItem item in Model.SaleItemsList)
            {
                if (!item.unit.Equals("Meal"))
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.itemID.ToString();

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.description;
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.unit.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.quantity.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = item.price.ToString();
                    lvi.SubItems.Add(lvsi1);

                    listViewMoveBar.Items.Add(lvi);
                }
            }
            listViewMoveBar.EndUpdate();
        }
        private void buttonMoveStockToBar_Click(object sender, EventArgs e)
        {
            if (listViewMoveStockRoom.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an item to move from the stock room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double quantity = 1;
                if (textBoxMoveStockQuantity.Text != "")
                    quantity = Convert.ToInt32(textBoxMoveStockQuantity.Text);
                IStockItem stock = Model.getStockItemByID(Convert.ToInt32(listViewMoveStockRoom.SelectedItems[0].Text));
                ISaleItem saleItem = Model.GetSaleItemByDrinkStockItem(stock);

                if (saleItem.unit.Equals("Pint"))
                {
                    stock.quantity -= quantity;
                    saleItem.quantity += (int)quantity * 124;
                }
                else if (saleItem.unit.Equals("Bottle"))
                {
                    double stockQ = quantity / stock.unitValue;
                    stock.quantity -= stockQ;
                    saleItem.quantity += (int)quantity;
                }
                else if(saleItem.unit.Equals("Shot"))
                {
                    string[] temp = stock.unit.Split(' '); string capacity = temp[1];
                    double stockQ = quantity / stock.unitValue;
                    stock.quantity -= stockQ;
                    quantity *= GetNumberOfShots(capacity);
                    saleItem.quantity += (int)quantity;
                }

                textBoxMoveStockQuantity.Text = "";
                Model.UpdateBarAndStockValues(saleItem, stock);
                PopulateBarStock();
                PopulateStockRoom();
            }
        }
        private int GetNumberOfShots(string capacity)
        {
            switch (capacity)
            {
                case "50cl": return 14;
                case "70cl": return 20;
                case "1ltr": return 28;
                case "1.5ltr": return 42;
                default: return 1;
            }
        }

        private void buttonReturnStock_Click(object sender, EventArgs e)
        {
            if (listViewMoveBar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an item to move back to the stock room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double quantity = 1;
                if (textBoxMoveStockQuantity.Text != "")
                    quantity = Convert.ToInt32(textBoxMoveStockQuantity.Text);
                ISaleItem saleItem = Model.GetSaleItem(Convert.ToInt32(listViewMoveBar.SelectedItems[0].Text));
                IStockItem stockItem = Model.getStockItemBySaleItem(saleItem);

                if (saleItem.unit.Equals("Pint"))
                {
                    stockItem.quantity += quantity;
                    saleItem.quantity -= (int)quantity * 124;
                }
                else if (saleItem.unit.Equals("Bottle"))
                {
                    double stockQ = quantity / stockItem.unitValue;
                    stockItem.quantity += stockQ;
                    saleItem.quantity -= (int)quantity;
                }
                else if (saleItem.unit.Equals("Shot"))
                {
                    string[] temp = stockItem.unit.Split(' '); string capacity = temp[1];
                    double stockQ = quantity / stockItem.unitValue;
                    stockItem.quantity += stockQ;
                    quantity *= GetNumberOfShots(capacity);
                    saleItem.quantity -= (int)quantity;
                }

                textBoxMoveStockQuantity.Text = "";
                Model.UpdateBarAndStockValues(saleItem, stockItem);
                PopulateBarStock();
                PopulateStockRoom();
            }
        }

        
    }
}
