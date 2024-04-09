using BusinessEntities;
using System;
using System.Collections;
using System.Collections.Generic;
namespace DataAccessLayer
{
    public interface IDataLayer
    {
        void closeConnection();
        List<IUser> getAllUsers();
        List<IStockItem> getAllStockItems();
        List<ICleaningAssignment> getAllCleaningAssignments(List<IRoom> rooms, List<IUser> users);
        List<IOrderItem> getAllOrderItems(List<IStockItem> stockItems);
        List<IOrder> getAllOrders(List<IOrderItem> orderItems);
        List<IRecipe> getAllRecipes(List<IStockItem> stockItems);
        List<ISaleItem> getAllSaleItems(List<IRecipe> recipes);
        List<ISaleLineItem> getAllSaleLineItems(List<ISaleItem> saleItems);
        List<ICustomerSale> getAllCustomerSales(List<ISaleLineItem> saleLineItems, List<IUser> users);
        List<IRoom> getAllRooms();
        void addNewUserToDB(BusinessEntities.IUser theUser);
        bool deleteUserFromDB(BusinessEntities.IUser user);
        bool editUserInDB(BusinessEntities.IUser user);
        System.Data.SqlClient.SqlConnection getConnection();
        void openConnection();
        bool UpdateStockItem(IStockItem stockItem);
        void addNewOrderToDB(IOrder theOrder);
        void addNewOrderItemsToDB(IOrder theOrder);
        bool editOrderInDB(IOrder order);
        bool editOrderItemInDB(IOrderItem orderitem);
        bool MarkSaleLineItemAsCooked(ISaleLineItem line);
        void addNewCustomerSale(ICustomerSale sale);
        void addSaleLineRecordsToDB(ICustomerSale sale);
        void addNewCleaningAssignment(ICleaningAssignment assignment);
        bool cancelCleaningAssignment(ICleaningAssignment assignment);
        bool editRoomInDB(IRoom room);
        bool UpdateSaleItem(ISaleItem item);
        //IMAD
        void addNewBookingToDB(IBooking booking);
        bool editBookingInDB(IBooking booking);
        void moveBookingToCancelledBookingDB(ICancelledBooking cancelledBooking);
        List<ICancelledBooking> getAllCancelledBooking();
        bool deleteBookingFromDB(IBooking booking);
        void addNewGuestToDB(IGuest guest);
        bool editGuestInDB(IGuest guest);
        bool deleteGuestFromDB(IGuest guest);
        void addNewCreditCardToDB(ICreditCard creditCard);
        bool editCreditCardInDB(ICreditCard creditCard);
        bool deleteCreditCardFromDB(ICreditCard creditCard);
        List<IGuest> getAllGuests(List<ICreditCard> creditCardList);
        List<IBooking> getAllBooking(List<IRoom> roomList, List<IGuest> guestList);
        List<ICreditCard> getAllCreditCards();
        List<IBooking> getBookingWithRangeFromDB(string from, string to, List<IRoom> roomList, List<IGuest> guestList);
        List<ICustomerSale> getCustomerSalesWithRangeFromDB(string from, string to, List<ISaleLineItem> saleLineItems, List<IUser> userList, IUser user);
        void updateCheckOut(IBooking booking);
        void updateCheckIn(IBooking booking);
    }
}
