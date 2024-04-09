using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient; 
using BusinessEntities;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class DataLayer : IDataLayer
    {
        #region Instance Attributes
        private SqlConnection con;   // DB Connection
        DataSet ds;                 //Declare the DataSet object
        SqlDataAdapter da;          //Declare the DataAdapter object
        int totUsers;
        int totOrders;
        int totOrderLineItems;
        int totStockItems;
        int totSaleItems;
        int totRecipes;
        int totSales;
        int totSaleLineItems;
        int totRooms;
        int totCleaningAssignments;
        int totBookings;
        int totGuests;
        SqlCommandBuilder cb;
        #endregion
        #region Static Attributes
        private static IDataLayer dataLayerSingletonInstance;  // DataLayer object is a singleton so only one instance allowed
        static readonly object padlock = new object(); // Need this for thread safety on the DataLayer singleton creation. ie in GetInstance () method
        #endregion
        #region Constructors
        public static IDataLayer GetInstance() // With Singleton pattern this method is used rather than constructor
        {
            lock (padlock) //   only one thread can entry this block of code
            {
                if (dataLayerSingletonInstance == null)
                {
                    dataLayerSingletonInstance = new DataLayer();
                }
                return dataLayerSingletonInstance;
            }
        }
        private DataLayer()  // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            openConnection();
        }
        #endregion
        public void openConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=SQL5.student.litdom.lit.ie\\TEAM1 ;Initial Catalog=Bloomfield_Hotel;User id=K00252722; Password=$QLT3AM01";
            //con.ConnectionString = "Data Source= bloomfield-hotel-project.database.windows.net ;Initial Catalog=BloomfieldHotel; User id=BloomfieldHotelDB; Password=$QLT3AM01";
            try
            {
                con.Open();
                //MessageBox.Show("Database Open");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                Environment.Exit(0); //Force the application to close
            }
        }

        public void closeConnection()
        {
            con.Close();
        }

        public SqlConnection getConnection()
        {
            return con;
        }       
        public List<IUser> getAllUsers()
        {
            List<IUser> UserList = new List<IUser>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                totUsers = ds.Tables["UsersData"].Rows.Count;
                for (int i = 0; i < totUsers; i++)
                {
                    IUser user;
                    string utype = "";
                    DataRow dRow = ds.Tables["UsersData"].Rows[i];
                    switch (dRow.ItemArray.GetValue(8).ToString())
                    {
                        case "Manager":
                            utype = "Manager"; break;
                        case "Admin":
                            utype = "Admin"; break;
                        case "BarManager":
                            utype = "BarManager"; break;
                        case "BarStaff":
                            utype = "BarStaff"; break;
                        case "Chef":
                            utype = "Chef"; break;
                        case "Cleaner":
                            utype = "Cleaner"; break;
                        case "CleaningSuper":
                            utype = "CleaningSuper"; break;
                        case "Receptionist":
                            utype = "Receptionist"; break;
                        default:
                            utype = "";
                            break;
                    }
                    user = UserFactory.GetUser(Convert.ToInt32(dRow.ItemArray.GetValue(0)), dRow.ItemArray.GetValue(1).ToString(),
                                                            dRow.ItemArray.GetValue(2).ToString(), dRow.ItemArray.GetValue(3).ToString(),
                                                            dRow.ItemArray.GetValue(4).ToString(), dRow.ItemArray.GetValue(5).ToString(),
                                                            dRow.ItemArray.GetValue(6).ToString(), Convert.ToDateTime(dRow.ItemArray.GetValue(7)), utype);
                    UserList.Add(user);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return UserList;
        }
        public List<IStockItem> getAllStockItems()
        {
            List<IStockItem> StockItemList = new List<IStockItem>(); 
            //string test = "";
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From stockitems";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "StockItemsData");
                totStockItems = ds.Tables["StockItemsData"].Rows.Count;
                for (int i = 0; i < totStockItems; i++)
                {
                    IStockItem stockItem;
                    DataRow dRow = ds.Tables["StockItemsData"].Rows[i];

                    stockItem = StockItemFactory.GetStockItem(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                            dRow.ItemArray.GetValue(1).ToString(), dRow.ItemArray.GetValue(2).ToString(), Convert.ToInt32(dRow.ItemArray.GetValue(10)),
                                                            Convert.ToDouble(dRow.ItemArray.GetValue(3)), dRow.ItemArray.GetValue(4).ToString(),
                                                            Convert.ToDouble(dRow.ItemArray.GetValue(5)), dRow.ItemArray.GetValue(6).ToString(),
                                                            dRow.ItemArray.GetValue(7).ToString(), Convert.ToInt32(dRow.ItemArray.GetValue(8)),
                                                            Convert.ToDateTime(dRow.ItemArray.GetValue(9)));
                    //test += stockItem.description + " ";
                    StockItemList.Add(stockItem);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            //MessageBox.Show(test);
            return StockItemList;
        }
        public List<ICleaningAssignment> getAllCleaningAssignments(List<IRoom> rooms, List<IUser> users)
        {
            List<ICleaningAssignment> cleaningAssignments = new List<ICleaningAssignment>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From cleaningassignments";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "CleaningAssignmentsData");
                totStockItems = ds.Tables["CleaningAssignmentsData"].Rows.Count;
                for (int i = 0; i < totCleaningAssignments; i++)
                {
                    ICleaningAssignment cleaningAssignment; IRoom room = new Room();
                    List<IUser> cleaners = new List<IUser>(); IUser super = new User();
                    DataRow dRow = ds.Tables["CleaningAssignmentsData"].Rows[i];
                    string cl = dRow.ItemArray.GetValue(2).ToString(); string[] temp = cl.Split(',');
                    int c1 = Convert.ToInt32(temp[0]), c2 = Convert.ToInt32(temp[1]);
                    foreach (IUser u in users)
                    {
                        if (u.userID == c1 || u.userID == c2)
                            cleaners.Add(u);
                        if (u.userID == Convert.ToInt32(dRow.ItemArray.GetValue(3)))
                            super = u;
                    }
                    foreach (IRoom r in rooms)
                    {
                        if (r.roomNumber == Convert.ToInt32(dRow.ItemArray.GetValue(1)))
                            room = r;
                    }

                    cleaningAssignment = CleaningAssignmentFactory.GetAssignment(Convert.ToDateTime(dRow.ItemArray.GetValue(0)), room, cleaners,
                                                                                    super, Convert.ToBoolean(dRow.ItemArray.GetValue(4)));
                    cleaningAssignments.Add(cleaningAssignment);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }
            return cleaningAssignments;
        }
        public bool UpdateStockItem(IStockItem stockItem)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From stockitems";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates                
                da.Fill(ds, "stockItemsData");
                DataRow findRow = ds.Tables["stockItemsData"].Rows.Find(stockItem.itemID);
                if (findRow != null)
                {
                    findRow[3] = stockItem.quantity;
                    findRow[9] = stockItem.currentUseByDate;
                }
                da.Update(ds, "stockItemsData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public List<IOrderItem> getAllOrderItems(List<IStockItem> stockItems)
        {
            List<IOrderItem> OrderItemList = new List<IOrderItem>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From orderitems";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "OrderItemsData");
                totOrderLineItems = ds.Tables["OrderItemsData"].Rows.Count;
                for (int i = 0; i < totOrderLineItems; i++)
                {
                    IOrderItem orderItem;
                    DataRow dRow = ds.Tables["OrderItemsData"].Rows[i];
                    IStockItem stockItem = new StockItem();
                    foreach (IStockItem si in stockItems)
                    {
                        if (si.itemID == Convert.ToInt32(dRow.ItemArray.GetValue(2)))
                            stockItem = si;
                    }
                    orderItem = OrderItemFactory.GetOrderItem(Convert.ToInt32(dRow.ItemArray.GetValue(0)), Convert.ToInt32(dRow.ItemArray.GetValue(1)),
                                                            stockItem, Convert.ToInt32(dRow.ItemArray.GetValue(3)));
                    OrderItemList.Add(orderItem);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return OrderItemList;
        }
        public List<IOrder> getAllOrders(List<IOrderItem> orderItems)
        {
            List<IOrder> orderList = new List<IOrder>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From orders";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "OrdersData");
                totOrders = ds.Tables["OrdersData"].Rows.Count;
                for (int i = 0; i < totOrders; i++)
                {
                    IOrder order;
                    bool acceptPartial = false;
                    bool received = false;
                    DataRow dRow = ds.Tables["OrdersData"].Rows[i];
                    List<IOrderItem> orderLines = new List<IOrderItem>();
                    foreach (IOrderItem oi in orderItems)
                    {
                        IOrderItem orderItem = new OrderItem();
                        if (oi.orderID == Convert.ToInt32(dRow.ItemArray.GetValue(0)))
                            orderItem = oi;
                        orderLines.Add(orderItem);
                    }
                    if (Convert.ToInt32(dRow.ItemArray.GetValue(4)) == 1)
                        acceptPartial = true;
                    if (Convert.ToInt32(dRow.ItemArray.GetValue(5)) == 1)
                        received = true;

                    order = OrderFactory.GetOrder(Convert.ToInt32(dRow.ItemArray.GetValue(0)), Convert.ToDateTime(dRow.ItemArray.GetValue(1)),
                                                            orderLines, dRow.ItemArray.GetValue(2).ToString(), dRow.ItemArray.GetValue(3).ToString(), 
                                                            acceptPartial, received);
                    orderList.Add(order);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return orderList;
        }
        public List<IRecipe> getAllRecipes(List<IStockItem> stockItems)
        {
            List<IRecipe> RecipeList = new List<IRecipe>();
            //string test = "";
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From recipes";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "RecipesData");
                totRecipes = ds.Tables["RecipesData"].Rows.Count;
                for (int i = 0; i < totRecipes; i++)
                {
                    DataRow dRow = ds.Tables["RecipesData"].Rows[i];
                    IRecipe recipe;
                    List<IStockItem> ingredients = new List<IStockItem>();
                    string[] ing = dRow.ItemArray.GetValue(2).ToString().Split(',');
                    for (int j = 0; j < ing.Length; j += 2)
                    {
                        IStockItem tempIngredient = new FoodItem();
                        foreach(IStockItem si in stockItems)
                        {
                            if (si.description == ing[j])
                            {
                                tempIngredient = StockItemFactory.GetStockItem(si.itemID, si.description, si.unit, si.unitValue, Convert.ToDouble(ing[j + 1]), si.supplier, si.unitCost, "", "Food", si.shelfLifeInDays, si.currentUseByDate);
                            }
                        }
                        //tempIngredient.quantity = Convert.ToDouble(ing[j + 1]);
                        ingredients.Add(tempIngredient);
                    }
                    string[] allergens = dRow.ItemArray.GetValue(5).ToString().Split(',');


                    recipe = RecipeFactory.GetRecipe(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                            dRow.ItemArray.GetValue(1).ToString(), ingredients,
                                                            dRow.ItemArray.GetValue(3).ToString(), Convert.ToInt32(dRow.ItemArray.GetValue(4)),
                                                            allergens);
                    //test += stockItem.description + " ";
                    RecipeList.Add(recipe);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            //MessageBox.Show(test);
            return RecipeList;
        }
        public List<ISaleItem> getAllSaleItems(List<IRecipe> recipes)
        {
            List<ISaleItem> saleItemList = new List<ISaleItem>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From saleitems";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "SaleItemsData");
                totSaleItems = ds.Tables["SaleItemsData"].Rows.Count;
                for (int i = 0; i < totSaleItems; i++)
                {
                    DataRow dRow = ds.Tables["SaleItemsData"].Rows[i];
                    ISaleItem saleItem;
                    IRecipe recipe = new Recipe();
                    string unit = dRow.ItemArray.GetValue(3).ToString();
                    if (unit == "Meal")
                    {
                        foreach (Recipe r in recipes)
                        {
                            if (r.recipeID == Convert.ToInt32(dRow.ItemArray.GetValue(5)))
                                recipe = r;
                        }
                        saleItem = SaleItemFactory.GetSaleItem(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                            dRow.ItemArray.GetValue(1).ToString(), Convert.ToDouble(dRow.ItemArray.GetValue(2)),
                                                            unit, Convert.ToInt32(dRow.ItemArray.GetValue(4)),
                                                            recipe);
                    }
                    else
                    {
                        saleItem = SaleItemFactory.GetSaleItem(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                            dRow.ItemArray.GetValue(1).ToString(), Convert.ToDouble(dRow.ItemArray.GetValue(2)),
                                                            unit, Convert.ToInt32(dRow.ItemArray.GetValue(4)));
                    }
                    saleItemList.Add(saleItem);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            //MessageBox.Show(test);
            return saleItemList;
        }
        public List<ISaleLineItem> getAllSaleLineItems(List<ISaleItem> saleItems)
        {
            List<ISaleLineItem> saleLineItemList = new List<ISaleLineItem>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From salelineitems";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "SaleLineItemsData");
                totSaleLineItems = ds.Tables["SaleLineItemsData"].Rows.Count;
                for (int i = 0; i < totSaleLineItems; i++)
                {
                    DataRow dRow = ds.Tables["SaleLineItemsData"].Rows[i];
                    int quantity = 0;
                    ISaleLineItem saleLineItem; ISaleItem item = new SaleItem();
                    bool cooked = Convert.ToBoolean(dRow.ItemArray.GetValue(2));
                    foreach (ISaleItem si in saleItems)
                    {
                        if (si.itemID == Convert.ToInt32(dRow.ItemArray.GetValue(1)))
                        {
                            item = si;
                            quantity = Convert.ToInt32(dRow.ItemArray.GetValue(3));
                        }
                    }

                    saleLineItem = SaleLineItemFactory.GetSaleLineItem(Convert.ToInt32(dRow.ItemArray.GetValue(0)), item, quantity, cooked);
                    saleLineItemList.Add(saleLineItem);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            //MessageBox.Show(test);
            return saleLineItemList;
        }
        public List<ICustomerSale> getAllCustomerSales(List<ISaleLineItem> saleLineItems, List<IUser> users)
        {
            List<ICustomerSale> customerSaleList = new List<ICustomerSale>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From customersales";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "CustomerSalesData");
                totSales = ds.Tables["CustomerSalesData"].Rows.Count;
                for (int i = 0; i < totSales; i++)
                {
                    DataRow dRow = ds.Tables["CustomerSalesData"].Rows[i];
                    int saleID = Convert.ToInt32(dRow.ItemArray.GetValue(0));
                    ICustomerSale cSale; IUser cashier = new User(); int cID = Convert.ToInt32(dRow.ItemArray.GetValue(5));
                    List<ISaleLineItem> soldItems = new List<ISaleLineItem>();
                    foreach (ISaleLineItem sli in saleLineItems)
                    {
                        if (sli.saleID == saleID)
                        {
                            ISaleLineItem line = new SaleLineItem();
                            line = sli;
                            soldItems.Add(line);
                        }
                    }
                    foreach (IUser u in users)
                    {
                        if (u.userID == cID)
                            cashier = u;
                    }

                    cSale = CustomerSaleFactory.GetCustomerSale(Convert.ToInt32(dRow.ItemArray.GetValue(0)), soldItems,
                                                                dRow.ItemArray.GetValue(1).ToString(), Convert.ToInt32(dRow.ItemArray.GetValue(2)),
                                                                Convert.ToDouble(dRow.ItemArray.GetValue(3)), Convert.ToDateTime(dRow.ItemArray.GetValue(4)),
                                                                cashier);
                    customerSaleList.Add(cSale);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            //MessageBox.Show(test);
            return customerSaleList;
        }
        public List<IRoom> getAllRooms()
        {
            List<IRoom> roomsList = new List<IRoom>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From rooms";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "RoomsData");
                totRooms = ds.Tables["RoomsData"].Rows.Count;
                for (int i = 0; i < totRooms; i++)
                {
                    DataRow dRow = ds.Tables["RoomsData"].Rows[i];
                    IRoom room;

                    room = RoomFactory.GetRoom(Convert.ToInt32(dRow.ItemArray.GetValue(0)), Convert.ToInt32(dRow.ItemArray.GetValue(1)),
                                                dRow.ItemArray.GetValue(2).ToString(), Convert.ToBoolean(dRow.ItemArray.GetValue(3)),
                                                Convert.ToBoolean(dRow.ItemArray.GetValue(4)), Convert.ToBoolean(dRow.ItemArray.GetValue(5)));
                    roomsList.Add(room);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            //MessageBox.Show(test);
            return roomsList;
        }
        public void addNewUserToDB(IUser theUser)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Users";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                totUsers = ds.Tables["UsersData"].Rows.Count;
                DataRow dRow = ds.Tables["UsersData"].NewRow();
                dRow[0] = theUser.userID;
                dRow[1] = theUser.username;
                dRow[2] = theUser.password;
                dRow[3] = theUser.firstName;
                dRow[4] = theUser.lastName;
                dRow[5] = theUser.email;
                dRow[6] = theUser.phone;
                dRow[7] = theUser.dob;
                string userType = theUser.GetType().ToString();
                userType = userType.Substring(userType.LastIndexOf('.') + 1);
                dRow[8] = userType;

                ds.Tables["UsersData"].Rows.Add(dRow);
                da.Update(ds, "UsersData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public bool deleteUserFromDB(BusinessEntities.IUser user)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.userID);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "UsersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public bool editUserInDB(IUser user)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.userID);
                if (findRow != null)
                {
                    findRow[0] = user.userID;
                    findRow[1] = user.username;
                    findRow[2] = user.password;
                    findRow[3] = user.firstName;
                    findRow[4] = user.lastName;
                    findRow[5] = user.email;
                    findRow[6] = user.phone;
                    findRow[7] = user.dob;
                    string userType = user.GetType().ToString();
                    userType = userType.Substring(userType.LastIndexOf('.') + 1);
                    findRow[8] = userType;
                }
                da.Update(ds, "UsersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public void addNewOrderToDB(IOrder theOrder)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From orders";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ordersData");
                totOrders = ds.Tables["ordersData"].Rows.Count;
                DataRow dRow = ds.Tables["ordersData"].NewRow();
                dRow[0] = theOrder.orderID;
                dRow[1] = theOrder.date;
                dRow[2] = theOrder.orderType;
                dRow[3] = theOrder.supplier;
                dRow[4] = theOrder.acceptPartial;
                dRow[5] = theOrder.received;
                dRow[6] = theOrder.total;

                ds.Tables["ordersData"].Rows.Add(dRow);
                da.Update(ds, "ordersData");
                MessageBox.Show("Order Added");
                this.addNewOrderItemsToDB(theOrder);
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewOrderItemsToDB(IOrder theOrder)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From orderitems";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "orderItemsData");
                totOrderLineItems = ds.Tables["orderItemsData"].Rows.Count;
                foreach (OrderItem oi in theOrder.orderItems)
                {
                    DataRow dRow = ds.Tables["orderItemsData"].NewRow();
                    dRow[0] = oi.lineID;
                    dRow[1] = theOrder.orderID;
                    dRow[2] = oi.item.itemID;
                    dRow[3] = oi.quantity;
                    dRow[4] = oi.lineCost;

                    ds.Tables["orderItemsData"].Rows.Add(dRow);
                }
                da.Update(ds, "orderItemsData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public bool editOrderInDB(IOrder order)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From orders";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "OrdersData");
                DataRow findRow = ds.Tables["OrdersData"].Rows.Find(order.orderID);
                if (findRow != null)
                {
                    findRow[0] = order.orderID;
                    findRow[1] = order.date;
                    findRow[2] = order.orderType;
                    findRow[3] = order.supplier;
                    findRow[4] = order.acceptPartial;
                    findRow[5] = order.received;
                    findRow[6] = order.total;
                }
                da.Update(ds, "OrdersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public bool editOrderItemInDB(IOrderItem orderitem)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From orderitems";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates                
                da.Fill(ds, "orderItemsData");
                object[] keys = new object[2];
                keys[0] = orderitem.lineID;
                keys[1] = orderitem.orderID;
                DataRow findRow = ds.Tables["orderItemsData"].Rows.Find(keys);
                if (findRow != null)
                {
                    findRow[0] = orderitem.lineID;
                    findRow[1] = orderitem.orderID;
                    findRow[2] = orderitem.item.itemID;
                    findRow[3] = orderitem.quantity;
                    findRow[4] = orderitem.lineCost;
                }
                da.Update(ds, "orderItemsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public bool MarkSaleLineItemAsCooked(ISaleLineItem line)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From salelineitems";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "SaleLineItemsData");
                int[] keys = { line.saleID, line.item.itemID };
                DataRow findRow = ds.Tables["SaleLineItemsData"].Rows.Find(keys);
                if (findRow != null)
                {
                    findRow[2] = line.cooked;
                }
                da.Update(ds, "SaleLineItemsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public void addNewCustomerSale(ICustomerSale sale)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From customersales";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "CustomerSalesData");
                totOrders = ds.Tables["CustomerSalesData"].Rows.Count;
                DataRow dRow = ds.Tables["CustomerSalesData"].NewRow();
                dRow[0] = sale.saleID;
                dRow[1] = sale.guest;
                dRow[2] = sale.tableNumber;
                dRow[3] = sale.total;
                dRow[4] = sale.date;
                dRow[5] = sale.cashier.userID;

                ds.Tables["CustomerSalesData"].Rows.Add(dRow);
                da.Update(ds, "CustomerSalesData");
                MessageBox.Show("Sale Recorded");
                this.addSaleLineRecordsToDB(sale);
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addSaleLineRecordsToDB(ICustomerSale sale)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From salelineitems";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "SaleLineItemsData");
                totSaleLineItems = ds.Tables["SaleLineItemsData"].Rows.Count;
                foreach (ISaleLineItem sli in sale.saleLineItems)
                {
                    DataRow dRow = ds.Tables["SaleLineItemsData"].NewRow();
                    dRow[0] = sli.saleID;
                    dRow[1] = sli.item.itemID;
                    dRow[2] = sli.cooked;
                    dRow[3] = sli.item.quantity;
                    dRow[4] = sli.lineCost;

                    ds.Tables["SaleLineItemsData"].Rows.Add(dRow);
                }
                da.Update(ds, "SaleLineItemsData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewCleaningAssignment(ICleaningAssignment assignment)
        {
            string cleaners = assignment.cleaners.ElementAt(0).userID + "," + assignment.cleaners.ElementAt(1).userID;
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From cleaningassignments";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "CleaningAssignmentsData");
                totCleaningAssignments = ds.Tables["CleaningAssignmentsData"].Rows.Count;
                DataRow dRow = ds.Tables["CleaningAssignmentsData"].NewRow();
                dRow[0] = assignment.assignedOn;
                dRow[1] = assignment.room.roomNumber;
                dRow[2] = cleaners;
                dRow[3] = assignment.assignedBy.userID;
                dRow[4] = assignment.complete;

                ds.Tables["CleaningAssignmentsData"].Rows.Add(dRow);
                da.Update(ds, "CleaningAssignmentsData");
                MessageBox.Show("Assignment Made");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public bool cancelCleaningAssignment(ICleaningAssignment assignment)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From cleaningassignments";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "CleaningAssignmentsData");
                object[] keys = new object[2];
                keys[0] = assignment.assignedOn;
                keys[1] = assignment.room.roomNumber;
                DataRow findRow = ds.Tables["CleaningAssignmentsData"].Rows.Find(keys);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "CleaningAssignmentsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public bool editRoomInDB(IRoom room)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From rooms";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "RoomsData");
                DataRow findRow = ds.Tables["RoomsData"].Rows.Find(room.roomNumber);
                if (findRow != null)
                {
                    findRow[0] = room.roomNumber;
                    findRow[1] = room.floor;
                    findRow[2] = room.roomType;
                    findRow[3] = room.available;
                    findRow[4] = room.clean;
                    findRow[5] = room.assigned;
                }
                da.Update(ds, "RoomsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public bool UpdateSaleItem(ISaleItem item)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From saleitems";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates                
                da.Fill(ds, "saleItemsData");
                DataRow findRow = ds.Tables["saleItemsData"].Rows.Find(item.itemID);
                if (findRow != null)
                {
                    findRow[4] = item.quantity;
                }
                da.Update(ds, "saleItemsData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public void addNewBookingToDB(IBooking booking)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Booking";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "BookingsData");
                totBookings = ds.Tables["BookingsData"].Rows.Count;
                DataRow dRow = ds.Tables["BookingsData"].NewRow();

                dRow[0] = booking.BookingID;
                dRow[1] = booking.CheckIn.ToShortDateString();
                dRow[2] = booking.CheckOut.ToShortDateString();
                dRow[3] = booking.GuestNames;
                dRow[4] = booking.AdditionalNotes;
                dRow[5] = booking.NumSingleRooms;
                dRow[6] = booking.NumDoubleRooms;
                dRow[7] = booking.NumTwinRooms;
                foreach (IRoom item in booking.RoomList)
                    dRow[8] += item.roomNumber.ToString() + " ";
                dRow[9] = booking.CheckedIn;
                dRow[10] = booking.CheckedOut;
                dRow[11] = booking.Total;
                dRow[12] = booking.Guest.GuestID;


                ds.Tables["BookingsData"].Rows.Add(dRow);
                da.Update(ds, "BookingsData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public bool editBookingInDB(IBooking booking)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Booking";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "BookingsData");
                DataRow findRow = ds.Tables["BookingsData"].Rows.Find(booking.BookingID);
                if (findRow != null)
                {
                    findRow[0] = booking.BookingID;
                    findRow[1] = booking.CheckIn.ToShortDateString();
                    findRow[2] = booking.CheckOut.ToShortDateString();
                    findRow[3] = booking.GuestNames;
                    findRow[4] = booking.AdditionalNotes;
                    findRow[5] = booking.NumSingleRooms;
                    findRow[6] = booking.NumDoubleRooms;
                    findRow[7] = booking.NumTwinRooms;
                    foreach (IRoom item in booking.RoomList)
                        findRow[8] += item.roomNumber.ToString() + " ";
                    findRow[9] = booking.CheckedIn;
                    findRow[10] = booking.CheckedOut;
                    findRow[11] = booking.Total;
                    findRow[12] = booking.Guest.GuestID;
                }
                da.Update(ds, "BookingsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public bool deleteBookingFromDB(IBooking booking)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Booking";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "BookingsData");
                DataRow findRow = ds.Tables["BookingsData"].Rows.Find(booking.BookingID);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "BookingsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public void moveBookingToCancelledBookingDB(ICancelledBooking cancelledBooking)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From CancelledBookings";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "CancelledBookingsData");
                totBookings = ds.Tables["CancelledBookingsData"].Rows.Count;
                DataRow dRow = ds.Tables["CancelledBookingsData"].NewRow();

                dRow[0] = cancelledBooking.CancelledBookingID;
                dRow[1] = cancelledBooking.BookingID;
                dRow[2] = cancelledBooking.GuestName;
                dRow[3] = cancelledBooking.NumSingleRooms;
                dRow[4] = cancelledBooking.NumDoubleRooms;
                dRow[5] = cancelledBooking.NumTwinRooms;
                dRow[6] = cancelledBooking.Total;
                dRow[7] = cancelledBooking.TotalRefund;

                ds.Tables["CancelledBookingsData"].Rows.Add(dRow);
                da.Update(ds, "CancelledBookingsData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void addNewCreditCardToDB(ICreditCard creditCard)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From CreditCard";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "CreditCardData");
                totBookings = ds.Tables["CreditCardData"].Rows.Count;
                DataRow dRow = ds.Tables["CreditCardData"].NewRow();

                dRow[0] = creditCard.HolderName;
                dRow[1] = creditCard.ExpirDate.ToShortDateString();
                dRow[2] = creditCard.CardNumber;
                dRow[3] = creditCard.SecurityCode;
                dRow[4] = creditCard.SaveCardDetails;

                ds.Tables["CreditCardData"].Rows.Add(dRow);
                da.Update(ds, "CreditCardData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message + "HERE");
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public bool editCreditCardInDB(ICreditCard creditCard)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From CreditCard";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "CreditCardData");
                DataRow findRow = ds.Tables["CreditCardData"].Rows.Find(creditCard.CardNumber);
                if (findRow != null)
                {
                    findRow[0] = creditCard.HolderName;
                    findRow[1] = creditCard.ExpirDate.ToShortDateString();
                    findRow[2] = creditCard.CardNumber;
                    findRow[3] = creditCard.SecurityCode;
                    findRow[4] = creditCard.SaveCardDetails;
                }
                da.Update(ds, "CreditCardData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public bool deleteCreditCardFromDB(ICreditCard creditCard)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From CreditCard";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "CreditCardData");
                DataRow findRow = ds.Tables["CreditCardData"].Rows.Find(creditCard.CardNumber);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "CreditCardData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public void addNewGuestToDB(IGuest guest)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Guest";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "GuestsData");
                totBookings = ds.Tables["GuestsData"].Rows.Count;
                DataRow dRow = ds.Tables["GuestsData"].NewRow();

                dRow[0] = guest.GuestID;
                dRow[1] = guest.Name;
                dRow[2] = guest.Address;
                dRow[3] = guest.PhoneNumber;
                dRow[4] = guest.Email;
                dRow[5] = guest.MarketingConsent;
                dRow[6] = guest.SaveCustomerDetails;
                dRow[7] = guest.CreditCard.CardNumber;

                ds.Tables["GuestsData"].Rows.Add(dRow);
                da.Update(ds, "GuestsData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public bool editGuestInDB(IGuest guest)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Guest";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "GuestsData");

                DataRow findRow = ds.Tables["GuestsData"].Rows.Find(guest.GuestID);
                if (findRow != null)
                {
                    findRow[0] = guest.GuestID;
                    findRow[1] = guest.Name;
                    findRow[2] = guest.Address;
                    findRow[3] = guest.PhoneNumber;
                    findRow[4] = guest.Email;
                    findRow[5] = guest.MarketingConsent;
                    findRow[6] = guest.SaveCustomerDetails;
                    findRow[7] = guest.CreditCard.CardNumber;
                }
                da.Update(ds, "GuestsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public bool deleteGuestFromDB(IGuest guest)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Guest";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "GuestsData");
                DataRow findRow = ds.Tables["GuestsData"].Rows.Find(guest.GuestID);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "GuestsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public List<IGuest> getAllGuests(List<ICreditCard> creditCardList)
        {
            List<IGuest> guestList = new List<IGuest>();
            ICreditCard creditCard = new CreditCard();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From guest";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "GuestData");
                totGuests = ds.Tables["GuestData"].Rows.Count;
                for (int i = 0; i < totGuests; i++)
                {
                    DataRow dRow = ds.Tables["GuestData"].Rows[i];
                    foreach (ICreditCard cc in creditCardList)
                    {
                        if (cc.CardNumber == dRow.ItemArray.GetValue(7).ToString())
                            creditCard = cc;
                    }

                    IGuest guest = GuestFactory.GetGuest(
                                                Convert.ToInt32(dRow.ItemArray.GetValue(0).ToString()),
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        dRow.ItemArray.GetValue(4).ToString(),
                                                        Convert.ToBoolean(dRow.ItemArray.GetValue(5).ToString()),
                                                        Convert.ToBoolean(dRow.ItemArray.GetValue(6).ToString()),
                                                        creditCard);
                    guestList.Add(guest);
                    // MessageBox.Show(guest.MarketingConsent.ToString() + " " + guest.SaveCustomerDetails);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return guestList;
        }
        public List<IBooking> getAllBooking(List<IRoom> roomList, List<IGuest> guestList)
        {
            List<IBooking> bookingList = new List<IBooking>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From booking";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "BookingData");
                totBookings = ds.Tables["BookingData"].Rows.Count;
                for (int i = 0; i < totBookings; i++)
                {
                    List<IRoom> rooms = new List<IRoom>();
                    IGuest guest = new Guest();

                    DataRow dRow = ds.Tables["BookingData"].Rows[i];

                    string roomIds = dRow.ItemArray.GetValue(8).ToString();
                    List<string> roomIdList = new List<string>(roomIds.Split(' ').ToList());

                    foreach (IRoom r in roomList)
                    {
                        foreach (string item in roomIdList)
                        {
                            if (r.roomNumber.ToString() == item)
                                rooms.Add(r);
                        }
                    }

                    foreach (IGuest g in guestList)
                    {
                        if (g.GuestID == Convert.ToInt32(dRow.ItemArray.GetValue(12).ToString()))
                            guest = g;
                    }
                    IBooking booking = BookingFactory.GetBooking(
                                                        Convert.ToInt32(dRow.ItemArray.GetValue(0).ToString()),
                                                        Convert.ToDateTime(dRow.ItemArray.GetValue(1).ToString()),
                                                        Convert.ToDateTime(dRow.ItemArray.GetValue(2).ToString()),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        dRow.ItemArray.GetValue(4).ToString(),
                                                        Convert.ToInt32(dRow.ItemArray.GetValue(5).ToString()),
                                                        Convert.ToInt32(dRow.ItemArray.GetValue(6).ToString()),
                                                        Convert.ToInt32(dRow.ItemArray.GetValue(7).ToString()),
                                                        rooms,
                                                        Convert.ToBoolean(dRow.ItemArray.GetValue(9).ToString()),
                                                        Convert.ToBoolean(dRow.ItemArray.GetValue(10).ToString()),
                                                        guest);
                    bookingList.Add(booking);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return bookingList;
        }
        public List<ICancelledBooking> getAllCancelledBooking()
        {
            List<ICancelledBooking> cancelledBookings = new List<ICancelledBooking>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From CancelledBookings";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "CancelledBookingsData");
                totBookings = ds.Tables["CancelledBookingsData"].Rows.Count;
                for (int i = 0; i < totBookings; i++)
                {
                    DataRow dRow = ds.Tables["CancelledBookingsData"].Rows[i];

                    ICancelledBooking cancelledBooking = CancelledBookingFactory.GetCancelledBooking(
                                                        Convert.ToInt32(dRow.ItemArray.GetValue(0).ToString()),
                                                        Convert.ToInt32(dRow.ItemArray.GetValue(1).ToString()),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        Convert.ToInt32(dRow.ItemArray.GetValue(3).ToString()),
                                                        Convert.ToInt32(dRow.ItemArray.GetValue(4).ToString()),
                                                        Convert.ToInt32(dRow.ItemArray.GetValue(5).ToString()),
                                                        Convert.ToDouble(dRow.ItemArray.GetValue(6).ToString()),
                                                        Convert.ToDouble(dRow.ItemArray.GetValue(7).ToString()));
                    cancelledBookings.Add(cancelledBooking);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return cancelledBookings;
        }
        public List<ICreditCard> getAllCreditCards()
        {
            List<ICreditCard> creditCardList = new List<ICreditCard>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From CreditCard";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "CreditCardData");
                totGuests = ds.Tables["CreditCardData"].Rows.Count;
                for (int i = 0; i < totGuests; i++)
                {
                    DataRow dRow = ds.Tables["CreditCardData"].Rows[i];

                    ICreditCard creditCard = CreditCardFactory.GetCreditCard(dRow.ItemArray.GetValue(0).ToString(),
                                                        Convert.ToDateTime(dRow.ItemArray.GetValue(1).ToString()),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        Convert.ToBoolean(dRow.ItemArray.GetValue(4).ToString()));
                    creditCardList.Add(creditCard);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return creditCardList;
        }
        public List<IBooking> getBookingWithRangeFromDB(string from, string to, List<IRoom> roomList, List<IGuest> guestList)
        {
            List<IBooking> bookingList = new List<IBooking>();
            try
            {
                List<IRoom> rooms = new List<IRoom>();
                IGuest guest = new Guest();
                ds = new DataSet();
                string sql = "SELECT * FROM Booking WHERE [check-in] BETWEEN '" + from + "' AND '" + to + "'";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "BookingData");
                totBookings = ds.Tables["BookingData"].Rows.Count;
                for (int i = 0; i < totBookings; i++)
                {
                    DataRow dRow = ds.Tables["BookingData"].Rows[i];

                    string roomIds = dRow.ItemArray.GetValue(8).ToString();
                    List<string> roomIdList = new List<string>(roomIds.Split(' ').ToList());

                    foreach (IRoom r in roomList)
                    {
                        foreach (string item in roomIdList)
                        {
                            if (r.roomNumber.ToString() == item)
                                rooms.Add(r);
                        }
                    }

                    foreach (IGuest g in guestList)
                    {
                        if (g.GuestID == Convert.ToInt32(dRow.ItemArray.GetValue(12).ToString()))
                            guest = g;
                    }
                    IBooking booking = BookingFactory.GetBooking(
                                                        Convert.ToInt32(dRow.ItemArray.GetValue(0).ToString()),
                                                        Convert.ToDateTime(dRow.ItemArray.GetValue(1).ToString()),
                                                        Convert.ToDateTime(dRow.ItemArray.GetValue(2).ToString()),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        dRow.ItemArray.GetValue(4).ToString(),
                                                        Convert.ToInt32(dRow.ItemArray.GetValue(5).ToString()),
                                                        Convert.ToInt32(dRow.ItemArray.GetValue(6).ToString()),
                                                        Convert.ToInt32(dRow.ItemArray.GetValue(7).ToString()),
                                                        rooms,
                                                        Convert.ToBoolean(dRow.ItemArray.GetValue(9).ToString()),
                                                        Convert.ToBoolean(dRow.ItemArray.GetValue(10).ToString()),
                                                        guest);
                    bookingList.Add(booking);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return bookingList;
        }
        public List<ICustomerSale> getCustomerSalesWithRangeFromDB(string from, string to, List<ISaleLineItem> saleLineItems, List<IUser> userList, IUser user)
        {
            List<ICustomerSale> customerSaleList = new List<ICustomerSale>();
            try
            {
                ds = new DataSet();
                //string sql = "SELECT * FROM customersales c INNER JOIN salelineitems s ON c.SaleID = s.SaleID " +
                //    "WHERE c.Date BETWEEN '2021-12-01' AND '2021-12-31' AND c.Cashier = 5 AND s.SaleID = 0";
                string sql = "SELECT * FROM customersales WHERE date BETWEEN '" + from + "' AND '" + to + "' AND Cashier = " + user.userID;
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "CustomerSalesData");
                totSales = ds.Tables["CustomerSalesData"].Rows.Count;
                for (int i = 0; i < totSales; i++)
                {
                    DataRow dRow = ds.Tables["CustomerSalesData"].Rows[i];

                    int saleID = Convert.ToInt32(dRow.ItemArray.GetValue(0));
                    int cID = Convert.ToInt32(dRow.ItemArray.GetValue(5));
                    List<ISaleLineItem> soldItems = new List<ISaleLineItem>();
                    IUser cashier = user;

                    foreach (ISaleLineItem sli in saleLineItems)
                    {
                        if (sli.saleID == saleID)
                        {
                            ISaleLineItem line = new SaleLineItem();
                            line = sli;
                            soldItems.Add(line);
                        }
                    }

                    ICustomerSale customerSale = CustomerSaleFactory.GetCustomerSale(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                                                                                    soldItems,
                                                                                    dRow.ItemArray.GetValue(1).ToString(),
                                                                                    Convert.ToInt32(dRow.ItemArray.GetValue(2)),
                                                                                    Convert.ToDouble(dRow.ItemArray.GetValue(3)),
                                                                                    Convert.ToDateTime(dRow.ItemArray.GetValue(4)),
                                                                                    cashier);
                    customerSaleList.Add(customerSale);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return customerSaleList;
        }
        ////////////////////////MARTIN//////////////////////
        public void updateCheckOut(IBooking booking)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From booking";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "RoomData");
                DataRow findRow = ds.Tables["RoomData"].Rows.Find(booking.BookingID);
                if (findRow != null)
                {
                    List<string> rooms = new List<string>();

                    findRow[0] = booking.BookingID;
                    findRow[1] = booking.CheckIn;
                    findRow[2] = booking.CheckOut;
                    findRow[3] = booking.GuestNames;
                    findRow[4] = booking.AdditionalNotes;
                    findRow[5] = booking.NumSingleRooms;
                    findRow[6] = booking.NumDoubleRooms;
                    findRow[7] = booking.NumTwinRooms;
                    foreach (IRoom room in booking.RoomList)
                    {
                        rooms.Add(room.roomNumber.ToString());
                    }
                    findRow[8] = string.Join(" ", rooms);
                    findRow[9] = booking.CheckedIn;
                    findRow[10] = booking.CheckedOut = true;
                    findRow[11] = booking.Total;
                    findRow[12] = booking.Guest.GuestID;
                }
                da.Update(ds, "RoomData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public void updateCheckIn(IBooking booking)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From booking";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "RoomData");
                DataRow findRow = ds.Tables["RoomData"].Rows.Find(booking.BookingID);
                if (findRow != null)
                {
                    List<string> rooms = new List<string>();

                    findRow[0] = booking.BookingID;
                    findRow[1] = booking.CheckIn;
                    findRow[2] = booking.CheckOut;
                    findRow[3] = booking.GuestNames;
                    findRow[4] = booking.AdditionalNotes;
                    findRow[5] = booking.NumSingleRooms;
                    findRow[6] = booking.NumDoubleRooms;
                    findRow[7] = booking.NumTwinRooms;
                    foreach (IRoom room in booking.RoomList)
                    {
                        rooms.Add(room.roomNumber.ToString());
                    }
                    findRow[8] = string.Join(" ", rooms);
                    findRow[9] = booking.CheckedIn = true;
                    findRow[10] = booking.CheckedOut;
                    findRow[11] = booking.Total;
                    findRow[12] = booking.Guest.GuestID;
                }
                da.Update(ds, "RoomData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
    }
}
