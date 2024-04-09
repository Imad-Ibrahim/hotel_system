using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLayer
{
    public interface IModel
    {
        BusinessEntities.IUser CurrentUser { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        bool login(string name, string password);
        bool loginAfterLock(string name, string password);
        bool addNewUser(string password, string firstName, string lastName, string email, string phone, DateTime dob, string userType);
        bool deleteUser(IUser user);
        bool editUser(BusinessEntities.IUser user);
        void tearDown();
        List<IUser> UserList { get; }
        List<IStockItem> StockList { get; }
        List<IOrderItem> OrderItemList { get; }
        List<ISaleItem> SaleItemsList { get; }
        List<IRecipe> RecipeList { get; }
        List<ISaleLineItem> SaleLineItemsList { get; }
        List<ICustomerSale> CustomerSalesList { get; }
        List<ICustomerSale> OrdersForKitchen { get; }
        List<ISaleItem> DailySelectedMeals { get; }
        List<IRoom> RoomsList { get; }
        List<ICleaningAssignment> CleaningAssignmentsList { get; }
        List<IGuest> GuestList { get; }
        List<IBooking> BookingList { get; }
        List<ICreditCard> CreditCardList { get; }
        List<ICancelledBooking> CancelledBookingList { get; }
        string getUserTypeForCurrentuser();
        string getUserType(IUser user);
        List<string> getSuppliers();
        List<IStockItem> getAllStockItems();
        IStockItem getStockItem(string decription, string supplier);
        IStockItem getStockItemByID(int ID);
        IStockItem getStockItemBySaleItem(ISaleItem saleItem);
        IUser getUserByUsername(string username);
        IRoom GetRoomByNumber(int number);
        ICleaningAssignment GetCleaningAssignment(DateTime date, int roomNumber);
        Boolean MakeNewCleaningAssignment(ICleaningAssignment ca);
        bool CancelCleaningAssignment(ICleaningAssignment ca);
        Boolean MakeNewOrder(IOrder order);
        int GetNewOrderID();
        int GetNewSaleID();
        void CookOrder(ISaleLineItem line);
        bool MakeCustomerSale(ICustomerSale sale);
        List<ICustomerSale> PopulateKitchenOrdersList();
        void SendOrderToKitchen(ICustomerSale sale);
        bool CheckIfSaleLineItemIsMeal(ISaleLineItem line);
        ISaleItem GetSaleItem(int id);
        ISaleItem GetSaleItemByDrinkStockItem(IStockItem stockItem);
        bool CheckIfItemIsAlreadyInOrder(List<ISaleLineItem> order, ISaleItem item);
        IOrder getOrder(int orderID);
        List<IOrderItem> getOrderItemByOrderID(int orderID);
        bool editOrder(IOrder order);
        bool editOrderItem(BusinessEntities.IOrderItem orderItem);
        bool UpdateStock(IOrder order);
        IStockItem getStockItemByDesAndUnitCost(string decription, double unitCost);
        bool CheckIfStockItemIsFood(IStockItem item);
        bool CheckIfStockItemIsDrink(IStockItem item);
        string GetDrinkStockItemType(IStockItem item);
        bool UpdateRoomStatus(IRoom room);
        bool UpdateBarAndStockValues(ISaleItem saleItem, IStockItem stockItem);
        //IMAD
        Boolean addNewBooking(IBooking booking);
        bool editBooking(IBooking booking);
        Boolean cancelBooking(ICancelledBooking cancelledBooking);
        bool deleteBooking(IBooking booking);
        List<IBooking> GetBookingWithRange(string from, string to);
        Boolean addNewGuest(IGuest guest);
        bool editGuest(IGuest guest);
        bool deleteGuest(IGuest guest);
        Boolean addNewCreditCard(ICreditCard creditCard);
        bool editCreditCard(ICreditCard creditCard);
        bool deleteCreditCard(ICreditCard creditCard);
        IGuest CheckForExistingCustomer(String name, String phoneNum);
        List<int> CheckForRoomAvailability(DateTime from, DateTime to);
        IGuest GetCustomerBookingByPhone(String phoneNum);
        int GetNewBookingID();
        int GetNewGuestID();
        List<ICustomerSale> GetCustomerSalesWithRange(string from, string to, IUser user);
        //MARCELLO
        void CookOrder(int saleID, String description);
        List<IStockItem> getStockItemByDescription(string description);
        //MARTIN
        void updateCheckIn(IBooking booking);
        void updateCheckOut(IBooking booking);
    }
}
