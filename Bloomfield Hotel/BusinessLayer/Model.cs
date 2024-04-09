using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities;
using System.Windows;

namespace BusinessLayer
{
    public class Model : IModel
    {
        #region Static Attributes
        private static IModel modelSingletonInstance;  // Model object is a singleton so only one instance allowed
        static readonly object padlock = new object(); // Need this for thread safety on the Model singleton creation. ie in GetInstance () method
        #endregion
        #region Instance Attribures
        private IDataLayer dataLayer;
        private IUser currentUser;
        private List<IUser> userList;
        
        private List<IUser> managerList;

        private List<IStockItem> stockList;
        private List<IOrderItem> orderItemList;
        private List<IOrder> orderList;
        private List<ICustomerSale> customerSalesList;
        private List<ISaleLineItem> saleLineItemsList;
        private List<ISaleItem> saleItemsList;
        private List<IRecipe> recipeList;
        private List<ICustomerSale> ordersForKitchen;
        private List<ISaleItem> dailySelectedMeals;
        private List<IRoom> roomsList;
        private List<ICleaningAssignment> cleaningAssignmentsList;
        private List<IGuest> guestList;
        private List<IBooking> bookingList;
        private List<ICancelledBooking> cancelledBookingList;
        private List<ICreditCard> creditCardList;

        private const int maxSingleRooms = 25;
        private const int maxDoubleRooms = 25;
        private const int maxTwinRooms = 25;
        #endregion
        #region Instance Properties
        public IDataLayer DataLayer
        {
            get { return dataLayer; }
            set { dataLayer = value; }
        }
        public IUser CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
            }
        }
        public List<IUser> UserList
        {
            get
            {
                return userList;
            }
        }
        public List<IStockItem> StockList
        {
            get
            {
                return stockList;
            }
        }
        public List<IOrderItem> OrderItemList
        {
            get
            {
                return orderItemList;
            }
        }
        public List<ISaleItem> SaleItemsList
        {
            get
            {
                return saleItemsList;
            }
        }
        public List<IRecipe> RecipeList
        {
            get
            {
                return recipeList;
            }
        }
        public List<ISaleLineItem> SaleLineItemsList
        {
            get { return saleLineItemsList; }
        }
        public List<ICustomerSale> CustomerSalesList
        {
            get { return customerSalesList; }
        }
        public List<ICustomerSale> OrdersForKitchen
        {
            get { return ordersForKitchen; }
        }
        public List<ISaleItem> DailySelectedMeals
        {
            get { return dailySelectedMeals; }
        }
        public List<IRoom> RoomsList
        {
            get { return roomsList; }
        }
        public List<IGuest> GuestList
        {
            get
            {
                return guestList;
            }
        }
        public List<ICreditCard> CreditCardList
        {
            get
            {
                return creditCardList;
            }
        }
        public List<IBooking> BookingList
        {
            get
            {
                return bookingList;
            }
        }
        public List<ICancelledBooking> CancelledBookingList
        {
            get
            {
                return cancelledBookingList;
            }
        }
        public List<ICleaningAssignment> CleaningAssignmentsList
        { get { return cleaningAssignmentsList; } }
        #endregion
        #region Constructors/Destructors
        public static IModel GetInstance(IDataLayer _DataLayer) // With Singleton pattern this method is used rather than constructor
        {
            lock (padlock) //   only one thread can entry this block of code
            {
                if (modelSingletonInstance == null)
                {
                    modelSingletonInstance = new Model(_DataLayer);
                }
                return modelSingletonInstance;
            }
        }
        private Model(IDataLayer _DataLayer)  // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            userList = new List<IUser>();
            dataLayer = _DataLayer;
            userList = dataLayer.getAllUsers();             // setup Models userList so we can login

            managerList = new List<IUser>();
            GetALlManagers();

            stockList = dataLayer.getAllStockItems();
            orderItemList = dataLayer.getAllOrderItems(stockList);
            orderList = dataLayer.getAllOrders(orderItemList);
            recipeList = dataLayer.getAllRecipes(stockList);
            saleItemsList = dataLayer.getAllSaleItems(recipeList);
            saleLineItemsList = dataLayer.getAllSaleLineItems(saleItemsList);
            customerSalesList = dataLayer.getAllCustomerSales(saleLineItemsList, userList);
            ordersForKitchen = PopulateKitchenOrdersList();
            roomsList = DataLayer.getAllRooms();
            cleaningAssignmentsList = DataLayer.getAllCleaningAssignments(RoomsList, UserList);

            creditCardList = dataLayer.getAllCreditCards();
            guestList = dataLayer.getAllGuests(creditCardList);
            bookingList = dataLayer.getAllBooking(roomsList, guestList);
            cancelledBookingList = dataLayer.getAllCancelledBooking();

            dailySelectedMeals = new List<ISaleItem>();
            ISaleItem m1 = new SaleItem(); m1 = saleItemsList.ElementAt(2); dailySelectedMeals.Add(m1);
            ISaleItem m2 = new SaleItem(); m2 = saleItemsList.ElementAt(3); dailySelectedMeals.Add(m2);
        }

        ~Model()
        {
            tearDown();
        }
        #endregion
        public Boolean login(String name, String password)
        {
            foreach (User user in userList) // now using template so can simplify this code as shown below
            {
                if (name == user.username && password == user.password)
                {

                    CurrentUser = user;
                    return true;
                }
            }
            return false;
        }
        public Boolean loginAfterLock(String name, String password)
        {
            if (getUserType(CurrentUser).Equals("Manager"))
            {
                foreach (User user in userList)
                {
                    if (name == user.username && password == user.password)
                    {
                        return true;
                    }
                }
            }
            else
            {
                foreach (User user in userList)
                {
                    if (name == user.username && password == user.password)
                    {
                        return true;
                    }
                    foreach (User manager in managerList)
                    {
                        if (password == manager.password)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private void GetALlManagers()
        {
            foreach (User user in userList)
            {
                string userType = getUserType(user);

                if (userType.Equals("Manager") || userType.Equals("Admin") || userType.Equals("CleaningSuper") ||
                    userType.Equals("BarManager"))
                {
                    managerList.Add(user);
                }
            }
        }
        public Boolean addNewUser(string password, string firstName, string lastName, string email, string phone, DateTime dob, string userType)
        {
            try
            {
                int maxId = 0;
                
                //if (password.Length < 8)
                //{
                //    MessageBox.Show("Password Too Short");
                //    return false;
                //}
                foreach (User user in UserList)
                {
                    if (user.userID > maxId)
                        maxId = user.userID;
                }
                IUser theUser = UserFactory.CreateUser(maxId + 1, password, firstName, lastName, email, phone, dob, userType);
                int dupeCount = 1;
                IUser duplicateUser = this.UserList.FirstOrDefault(user => user.username == theUser.username);
                while (duplicateUser != null && dupeCount < theUser.firstName.Length)
                {
                    theUser.ExtendUsername(dupeCount);
                    duplicateUser = this.UserList.FirstOrDefault(user => user.username == theUser.username);
                    dupeCount++;
                }
                if (duplicateUser != null)
                {
                    MessageBox.Show("User Already Exists");
                    return false;
                }
                UserList.Add(theUser);                              // Add a reference to the newly created object to the Models UserList
                DataLayer.addNewUserToDB(theUser);                  //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        public bool deleteUser(IUser user)
        {

            DataLayer.deleteUserFromDB(user);
            UserList.Remove(user); //remove object from collection
            return true;

        }
        public bool editUser(IUser user)
        {
            DataLayer.editUserInDB(user);
            int index = 0;
            foreach (User u in userList)
            {
                if (u.userID == user.userID)
                {
                    index = userList.IndexOf(u);
                }
            }
            userList[index] = user;
            return true;
        }
        public String getUserTypeForCurrentuser()
        {
            string userType = currentUser.GetType().ToString();
            userType = userType.Substring(userType.LastIndexOf('.') + 1);
            return userType;
        }
        public string getUserType(IUser user)
        {
            string userType = user.GetType().ToString();
            userType = userType.Substring(userType.LastIndexOf('.') + 1);
            return userType;
        }
        public void tearDown()
        {
            DataLayer.closeConnection();
        }
        public List<string> getSuppliers()
        {
            List<string> suppliers = new List<string>();
            foreach (IStockItem si in stockList)
            {
                if (!suppliers.Contains(si.supplier))
                    suppliers.Add(si.supplier);
            }
            return suppliers;
        }
        public List<IStockItem> getAllStockItems()
        {
            return stockList;
        }
        public List<ISaleItem> GetAllSaleItems()
        {
            return saleItemsList;
        }
        public List<IRecipe> GetAllRecipes()
        {
            return recipeList;
        }
        public IStockItem getStockItem(string decription, string supplier)
        {
            IStockItem item = new StockItem();
            foreach(IStockItem si in stockList)
            {
                if (si.supplier == supplier && si.description == decription)
                    item = si;
            }
            return item;
        }
        public IStockItem getStockItemByID(int ID)
        {
            IStockItem item = new StockItem();
            foreach (IStockItem si in stockList)
            {
                if (si.itemID == ID)
                    item = si;
            }
            return item;
        }
        public IStockItem getStockItemBySaleItem(ISaleItem saleItem)
        {
            IStockItem item = new StockItem();
            foreach (IStockItem si in stockList)
            {
                if (si.description.Equals(saleItem.description) && GetDrinkStockItemType(si).Equals(saleItem.unit))
                    item = si;
            }
            return item;
        }
        public IUser getUserByUsername(string username)
        {
            IUser user = new User();
            foreach (IUser u in UserList)
            {
                if (u.username.Equals(username))
                {
                    user = u;
                }
            }
            return user;
        }
        public IRoom GetRoomByNumber(int number)
        {
            IRoom room = new Room();
            foreach (IRoom r in RoomsList)
            {
                if (r.roomNumber == number)
                {
                    room = r;
                }
            }
            return room;
        }
        public ICleaningAssignment GetCleaningAssignment(DateTime date, int roomNumber)
        {
            ICleaningAssignment ca = new CleaningAssignment();
            foreach (ICleaningAssignment c in CleaningAssignmentsList)
            {
                if (c.assignedOn == date && c.room.roomNumber == roomNumber)
                    ca = c;
            }
            return ca;
        }
        public Boolean MakeNewCleaningAssignment(ICleaningAssignment ca)
        {
            cleaningAssignmentsList.Add(ca);
            ca.room.Assign();
            UpdateRoomStatus(ca.room);
            DataLayer.addNewCleaningAssignment(ca);
            return true;
        }
        public bool CancelCleaningAssignment(ICleaningAssignment ca)
        {
            ca.room.CancelAssignment();
            UpdateRoomStatus(ca.room);
            bool check = DataLayer.cancelCleaningAssignment(ca);
            CleaningAssignmentsList.Remove(ca);
            return check;
        }
        public Boolean MakeNewOrder(IOrder order)
        {
            try
            {
                IOrder duplicateOrder = this.orderList.FirstOrDefault(o => o.orderID == order.orderID);
                if (duplicateOrder != null)
                {
                    MessageBox.Show("Order Already Exists");
                    return false;
                }
                orderList.Add(order);
                foreach (IOrderItem oi in order.orderItems)
                    orderItemList.Add(oi);
                dataLayer.addNewOrderToDB(order);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        public int GetNewOrderID()
        {
            if (orderList.Count == 0)
            {
                return 1;
            }
            else
            {
                int id = (orderList.ElementAt(orderList.Count - 1).orderID) + 1;
                return id;
            }
        }
        public int GetNewSaleID()
        {
            if (customerSalesList.Count == 0)
            {
                return 1;
            }
            else
            {
                int id = (customerSalesList.ElementAt(customerSalesList.Count - 1).saleID) + 1;
                return id;
            }
        }
        public void CookOrder(ISaleLineItem line)
        {
            foreach (ISaleLineItem sli in saleLineItemsList)
            {
                if (sli.saleID == line.saleID && sli.item.itemID == line.item.itemID)
                {
                    sli.cooked = true;
                    DataLayer.MarkSaleLineItemAsCooked(sli);
                }
            }
        }
        public bool MakeCustomerSale(ICustomerSale sale)
        {
            bool complete = false;
            customerSalesList.Add(sale);
            foreach (ISaleLineItem sli in sale.saleLineItems)
            {
                saleLineItemsList.Add(sli);
            }
            DataLayer.addNewCustomerSale(sale);
            SendOrderToKitchen(sale);
            return complete;
        }
        public List<ICustomerSale> PopulateKitchenOrdersList()
        {
            List<ICustomerSale> kitchen = new List<ICustomerSale>();
            bool notCooked = false;
            foreach (ICustomerSale c in customerSalesList)
            {
                foreach (ISaleLineItem sli in c.saleLineItems)
                {
                    if (!sli.cooked)
                        notCooked = true;
                }
                if (notCooked)
                    kitchen.Add(c);
                notCooked = false;
            }
            return kitchen;
        }
        public void SendOrderToKitchen(ICustomerSale sale)
        {
            ordersForKitchen.Add(sale);
        }
        public bool CheckIfSaleLineItemIsMeal(ISaleLineItem line)
        {
            bool check = false;
            if (line.item.unit.Equals("Meal"))
                check = true;
            return check;
        }
        public ISaleItem GetSaleItem(int id)
        {
            ISaleItem item = new SaleItem();
            foreach (ISaleItem si in saleItemsList)
            {
                if (si.itemID == id)
                {
                    item = si;
                }
            }
            return item;
        }
        public ISaleItem GetSaleItemByDrinkStockItem(IStockItem stockItem)
        {
            ISaleItem item = new SaleItem();
            foreach (ISaleItem si in saleItemsList)
            {
                if (si.description.ToLower().Equals(stockItem.description.ToLower()) && si.unit.Equals(GetDrinkStockItemType(stockItem)))
                {
                    item = si;
                }
            }
            return item;
        }
        public bool CheckIfItemIsAlreadyInOrder(List<ISaleLineItem> order, ISaleItem item)
        {
            bool check = false;
            foreach (ISaleLineItem sli in order)
            {
                if (sli.item.itemID == item.itemID)
                    check = true;
            }
            return check;
        }
        public IOrder getOrder(int orderID)
        {
            IOrder order = new Order();
            foreach (IOrder o in orderList)
            {
                if (o.orderID == orderID)
                    order = o;
            }
            return order;
        }
        public List<IOrderItem> getOrderItemByOrderID(int orderID)
        {
            List<IOrderItem> item = new List<IOrderItem>();
            foreach (IOrderItem si in orderItemList)
            {
                if (si.orderID == orderID)
                    item.Add(si);
            }
            return item;
        }
        public bool editOrder(IOrder order)
        {
            DataLayer.editOrderInDB(order);

            int index = 0;
            foreach (Order o in orderList)
            {
                if (o.orderID == order.orderID)
                {
                    index = orderList.IndexOf(o);
                }
            }
            orderList[index] = order;
            return true;
        }
        public bool editOrderItem(IOrderItem orderItem)
        {
            DataLayer.editOrderItemInDB(orderItem);
            int index = 0;
            foreach (OrderItem oi in orderItemList)
            {
                if (oi.orderID == orderItem.orderID)
                {
                    index = orderItemList.IndexOf(oi);
                }
            }
            orderItemList[index] = orderItem;
            return true;
        }
        public bool UpdateStock(IOrder order)
        {
            bool update = false;
            foreach (IOrderItem oi in order.orderItems)
            {
                if (CheckIfStockItemIsFood(oi.item))
                {
                    foreach (IStockItem fi in stockList)
                    {
                        if (fi.itemID == oi.item.itemID)
                        {
                            fi.quantity = fi.quantity + oi.quantity;
                            fi.UpdateUseByDate();
                            DataLayer.UpdateStockItem(fi);
                        }
                    }
                }
            }
            return update;
        }
        public IStockItem getStockItemByDesAndUnitCost(string decription, double unitCost)
        {
            IStockItem item = new StockItem();
            foreach (IStockItem si in stockList)
            {
                if (si.description == decription && si.unitCost == unitCost)
                    item = si;
            }
            return item;
        }
        public bool CheckIfStockItemIsFood(IStockItem item)
        {
            bool check = false;
            string itemType = item.GetType().ToString();
            itemType = itemType.Substring(itemType.LastIndexOf('.') + 1);
            if (itemType.Equals("FoodItem"))
                check = true;
            return check;
        }
        public bool CheckIfStockItemIsDrink(IStockItem item)
        {
            bool check = false;
            string itemType = item.GetType().ToString();
            itemType = itemType.Substring(itemType.LastIndexOf('.') + 1);
            if (itemType.Equals("StockBottle") || itemType.Equals("StockPint") || itemType.Equals("StockShot"))
                check = true;
            return check;
        }
        public string GetDrinkStockItemType(IStockItem item)
        {
            string type = item.GetType().ToString();
            type = type.Substring(type.LastIndexOf('.') + 1);
            type = type.Substring(type.IndexOf('k') + 1);
            return type;
        }
        public bool UpdateRoomStatus(IRoom room)
        {
            DataLayer.editRoomInDB(room);
            return true;
        }
        public bool UpdateBarAndStockValues(ISaleItem saleItem, IStockItem stockItem)
        {
            DataLayer.UpdateSaleItem(saleItem);
            return DataLayer.UpdateStockItem(stockItem);
        }
        /////////////////////////////////////////IMAD//////////////////////////////////////////
        public Boolean addNewBooking(IBooking booking)
        {
            try
            {
                BookingList.Add(booking);
                DataLayer.addNewBookingToDB(booking);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        public bool editBooking(IBooking booking)
        {
            DataLayer.editBookingInDB(booking);

            int index = 0;
            foreach (Booking b in bookingList)
            {
                if (b.BookingID == booking.BookingID)
                {
                    index = bookingList.IndexOf(b);
                }
            }
            bookingList[index] = booking;
            return true;
        }
        public Boolean cancelBooking(ICancelledBooking cancelledBooking)
        {
            try
            {
                CancelledBookingList.Add(cancelledBooking);
                DataLayer.moveBookingToCancelledBookingDB(cancelledBooking);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        public bool deleteBooking(IBooking booking)
        {
            DataLayer.deleteBookingFromDB(booking);
            int index = 0;
            foreach (Booking b in BookingList)
            {
                if (b.BookingID == booking.BookingID)
                {
                    index = BookingList.IndexOf(b);
                }
            }
            BookingList.RemoveAt(index); //remove object from collection
            return true;
        }
        public Boolean addNewGuest(IGuest guest)
        {
            try
            {
                GuestList.Add(guest);
                DataLayer.addNewGuestToDB(guest);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }
        public bool editGuest(IGuest guest)
        {
            DataLayer.editGuestInDB(guest);

            int index = 0;
            foreach (Guest g in guestList)
            {
                if (g.PhoneNumber == guest.PhoneNumber)
                {
                    index = guestList.IndexOf(g);
                }
            }
            guestList[index] = guest;
            return true;
        }
        public bool deleteGuest(IGuest guest)
        {
            int index = 0;
            DataLayer.deleteGuestFromDB(guest);

            foreach (Guest g in GuestList)
            {
                if (g.CreditCard.CardNumber == guest.CreditCard.CardNumber)
                {
                    index = GuestList.IndexOf(g);
                }
            }
            GuestList.RemoveAt(index); //remove object from collection
            return true;
        }
        public Boolean addNewCreditCard(ICreditCard creditCard)
        {
            try
            {
                CreditCardList.Add(creditCard);
                DataLayer.addNewCreditCardToDB(creditCard);
                return true;
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                return false;
            }
        }
        public bool editCreditCard(ICreditCard creditCard)
        {
            DataLayer.editCreditCardInDB(creditCard);

            int index = 0;
            foreach (CreditCard cc in creditCardList)
            {
                if (cc.CardNumber == creditCard.CardNumber)
                {
                    index = creditCardList.IndexOf(cc);
                }
            }
            creditCardList[index] = creditCard;
            return true;
        }
        public bool deleteCreditCard(ICreditCard creditCard)
        {
            DataLayer.deleteCreditCardFromDB(creditCard);
            int index = 0;
            foreach (CreditCard cc in CreditCardList)
            {
                if (cc.CardNumber == creditCard.CardNumber)
                {
                    index = CreditCardList.IndexOf(cc);
                }
            }
            CreditCardList.RemoveAt(index); //remove object from collection
            return true;
        }
        public IGuest CheckForExistingCustomer(String name, String phoneNum)
        {
            IGuest guestObject = new Guest();
            foreach (Guest guest in guestList)
            {
                if (name.ToLower().Equals(guest.Name.ToLower()) && phoneNum.Equals(guest.PhoneNumber))
                {
                    guestObject = guest;
                }
            }
            return guestObject;
        }
        public List<int> CheckForRoomAvailability(DateTime from, DateTime to)
        {
            List<int> roomTypeList = new List<int>();
            int single = 0,
                doubleRoom = 0,
                twin = 0,
                maxSingle = maxSingleRooms,
                maxDouble = maxDoubleRooms,
                maxTwin = maxTwinRooms;

            foreach (Booking booking in bookingList)
            {
                if (((from >= booking.CheckIn && from <= booking.CheckOut) || (to >= booking.CheckIn && to <= booking.CheckOut)))
                {
                    single += booking.NumSingleRooms;
                    doubleRoom += booking.NumDoubleRooms;
                    twin += booking.NumTwinRooms;
                }
            }

            if (single > 0)
                maxSingle -= single;
            if (doubleRoom > 0)
                maxDouble -= doubleRoom;
            if (twin > 0)
                maxTwin -= twin;

            roomTypeList.Add(maxSingle);
            roomTypeList.Add(maxDouble);
            roomTypeList.Add(maxTwin);

            return roomTypeList;
        }
        public List<IBooking> GetBookingWithRange(string from, string to)
        {
            return DataLayer.getBookingWithRangeFromDB(from, to, roomsList, GuestList);
        }
        public IGuest GetCustomerBookingByPhone(String phoneNum)
        {
            IGuest guestObject = new Guest();
            foreach (Guest guest in guestList)
            {
                if (phoneNum == guest.PhoneNumber)
                {
                    guestObject = guest;
                }
            }
            return guestObject;
        }
        public int GetNewBookingID()
        {
            if (bookingList.Count == 0)
            {
                return 1;
            }
            else
            {
                int id = (bookingList.ElementAt(bookingList.Count - 1).BookingID) + 1;
                return id;
            }
        }
        public int GetNewGuestID()
        {
            if (guestList.Count == 0)
            {
                return 1;
            }
            else
            {
                int id = (guestList.ElementAt(guestList.Count - 1).GuestID) + 1;
                return id;
            }
        }
        public List<ICustomerSale> GetCustomerSalesWithRange(string from, string to, IUser user)
        {
            return DataLayer.getCustomerSalesWithRangeFromDB(from, to, saleLineItemsList, userList, user);
        }
        ////////////////////////////////MARCELLO/////////////////////////////////
        public void CookOrder(int saleID, String description)
        {
            foreach (ICustomerSale cs in customerSalesList)
            {
                if (cs.saleID == saleID)
                {
                    foreach (ISaleLineItem sli in cs.saleLineItems)
                    {
                        if (sli.item.description.Equals(description))
                        {
                            sli.cook();
                        }
                    }
                }
            }
        }
        public List<IStockItem> getStockItemByDescription(string description)
        {
            List<IStockItem> items = new List<IStockItem>();

            foreach (IStockItem si in stockList)
            {
                if (si.description.ToLower().Contains(description.ToLower()))
                {
                    items.Add(si);
                }
            }

            return items;
        }
        ///////////////////////////////MARTIN/////////////////////////////////
        public void updateCheckIn(IBooking booking)
        {
            dataLayer.updateCheckIn(booking);
        }
        public void updateCheckOut(IBooking booking)
        {
            dataLayer.updateCheckOut(booking);
        }
    }
}
