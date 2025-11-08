using System.Net.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.Configuration;

namespace QCLorence.Common
{
    public class ConstantMessage
    {
        //User
        public const string UserLoginSuccess = "User Logged In Successfully!";
        public const string UserUnauthorized = "User is unauthorized to access this!";

        //Dashboard
        public const string DashboardFetchedSuccessfully = "User dashboard fetched successfully!";

        //Items
        public const string ItemsListSuccess = "Items list returned successfully!";
        public const string ItemsDropdownListSuccess = "Items dropdown list returned successfully!";
        public const string ItemsWiseColorList = "Item wise color list returned successfully!";

        //Cart
        public const string ColorAddedToCartSuccess = "Color added to cart successfully!";
        public const string CartWiseColorIdInvalid = "Invald cart Id!";
        public const string CartIdInvalid = "Invald cart Id!";
        public const string CartWiseColorNotFound = "Cart wise color not found!";
        public const string CartNotFound = "Cart not found!";
        public const string AllOrdersAreNotOfSameDealer = "To dispatch multiple orders, select orders placed by same dealer only!";
        public const string CartAlreadyOrdered = "Already ordered cart id found!";
        public const string CartUpdatedSuccessfully = "Cart updated successfully!";
        public const string CartRemarkUpdatedSuccessfully = "Cart remark updated successfully!";
        public const string ColorAlreadyExistsInCart = "Color already exists in cart";
        public const string ColorIdInvalid = "Invalid color id provided!";
        public const string ColorEditedToCartSuccess = "Color edited successfully!";
        public const string RemarksAddedToCartSuccess = "Remarks added to cart successfully!";
        public const string ColorRemoveFromCartSuccess = "Color removed from cart successfully!";
        public const string ItemRemoveFromCartSuccess = "Item removed from cart successfully!";
        public const string UserCartFetchedSuccess = "User cart fetched successfully!";
        public const string UserCartEmpty = "User Cart is empty!";

        //Order
        public const string OrderPlacedSuccess = "Order placed successfully!";
        public const string OrderListEmpty = "Order list is empty!";
        public const string OrderListFetchedSuccess = "Order List returned successfully!";
        public const string OutstandingInvoiceListFetchedSuccessfully = "Outstanding order list returned successfully!";
        public const string PaymentLedgerAddedSuccessfully = "Payment ledger added successfully";
        public const string PaymentLedgerDeletedSuccessfully = "Payment ledger deleted successfully";
        public const string PaymentAgainstInvoiceSuccess = "Payment against invoice added successfully";
        public const string InvoiceOrderNotFound = "Invoice or order not found";
        public const string PaymentLedgerNotFound = "Payment Ledger not found";
        public const string OrderCancelSuccess = "Order cancelled successfully!";
        public const string OrderConfirmSuccess = "Order confirmed successfully!";
        public const string OrderDetailSuccess = "Order details returned successfully!";
        public const string OrderDeliverSuccess = "Order delivered successfully!";
        public const string OrderDispatchSuccess = "Order dispatched  successfully!";
        public const string OrderConfirmSave = "Order confirmed successfully! Remaining order in pending.";
        public const string ColorNotFound = "No colors found for this order.";
        public const string OrderNotFound = "Order Not Found";
        public const string AmountGreaterThanOutstandingAmount = "Credit amount cannot be greater than outstanding amount";
        public const string ErrorMessage = "An error occurred while Canceling the Order.";
        public const string CourierPartnerSaveSuccess = "Courier Partner Details Save Successfully!";
        public const string OrderDeliveredSuccess = "Order marked as delivered successfully!";
        public const string OrderDispatchFail = "Cannot dispatch Order.because stock is not removed for all colors.";
        //Order
        public const string ColorStockListSuccess = "Color stock list fetched successfully!";
        public const string CorierPartnerSaveSuccess = "Courier Partner saved successfully.";

        //Profile
        public const string ProfileBasicInfoAddSuccess = "Basic information added successfully.";
        public const string ProfileContactInfoAddSuccess = "Contact information added successfully.";
        public const string ProfileBillingInfoAddSuccess = "Billing information added successfully.";
        public const string ProfileStaticLinksReturnedSuccessfully = "Profile static links returned successfully.";

        //Distributor
        public const string DealerProfileGetSuccess = "Dealer data returned successfully.";
        public const string DistributorNotFound = "Distributor not found.";
        public const string DealerNotFound = "Dealer not found.";
        public const string DistributorWiseDealerListGetSuccess = "Distributor wise dealer list returned successfully.";

        //Dealer
        public const string DealerCreatedSuccess = "Dealer has been created successfully.";
        public const string DealerInvalid = "Invalid dealer selected by distributor.";
        public const string UserAlreadyExists = "A user with same credentials already exists.";

        //Invoice
        public const string InvoiceListSuccess = "Invoice List returned successfully.";
        public const string InvoiceDetailSuccess = "Invoice detail returned successfully";

        public const string ItemExist = "Item is allready exists.";
        public const string ItemAdded = "Item is Added Successfully.";
        public const string ItemEdit = "Item is Edited Successfully.";
        public const string ItemDeleteUnSuccess = "Item Deleted UnSuccessfully.";
        public const string ItemDeleteSuccess = "Item deleted successfully.";

        public const string Colorxist = "Color is already exists.";
        public const string ColorAdded = "color is Added Successfully.";
        public const string ColorEdit = "Color is Edited Successfully.";
        public const string ColorDeleteUnSuccess = "Color Deleted UnSuccessfully.";
        public const string ColorDeleteSuccess = "Color deleted successfully.";

        //TeamMember
        public const string TeamMemberAdded = "A New Team Member Has Been Added.";
        public const string TeamMemberEditSuccess = "The Team Member Has Been Successfully Edited.";
        public const string TeamMemberAddOrEditUnSuccess = "Failed To Add Or Edit The Team Member.";
        public const string TeamMemberAlreadyExist = "The Team Member Already Exists.";
        public const string TeamMemberDetailsAlreadyExist = "The Team Member GST and Email Exists";
        public const string TeamMemberDeleteSuccess = "The Team Member Has Been Successfully Deleted.";
        public const string TeamMemberDeleteUnSuccess = "The Team Member Could Not Be Deleted.";
        public const string TeamMemberNotExist = "The Team Member Does Not Exist.";

        //Vendor
        public const string VendorAdded = "Your Vendor added sucessfully.";
        public const string VendorEditSuccessful = "Your Vendor edit sucessfully.";
        public const string VendorDeleteUnSuccess = "Your Vendor is not Deleted.";
        public const string VendorDeleteSuccess = "Your Vendor is Deleted.";

        //Stock
        public const string StockReturnSuccessfull = "Stock returned Successfully.";
        public const string StockAdded = "Your Stock added sucessfully.";
        public const string StockEditSuccessful = "Your Stock edit sucessfully.";
        public const string StockDeleteUnSuccess = "Your Stock is not Deleted.";
        public const string StockDeleteSuccess = "Your Stock is Deleted.";

        //Rack
        public const string LocationAdded = "Your Location added sucessfully.";
        public const string LocationEditSuccessful = "Your Location edit sucessfully.";
        public const string LocationDeleteUnSuccess = "Your Location is not Deleted.";
        public const string LocationDeleteSuccess = "Your Location is Deleted.";
        public const string RackFetchSuccess = "Rack Fetch Successfully.";

        //PurchaseBill
        public const string PurchaseBillAddOrEditUnsuccessful = "Failed to add or update the PurchaseBill.";
        public const string PurchaseBillAdded = "PurchaseBill has been added successfully.";
        public const string PurchaseBillNotExists = "The specified PurchaseBill does not exist.";
        public const string PurchaseBillEditSuccessful = "PurchaseBill details have been updated successfully.";


        //Distributor
        public const string DistributorExist = "Distributor is not exists.";
        public const string DistributorAdded = "Distributor is Added Successfully.";
        public const string DistributorEdit = "Distributor is Edited Successfully.";
        public const string CreditSetSuccess = "Credit set is  Successfully.";
        public const string CreditSetEditSuccess = "Credit Update is  Successfully.";
        public const string CreditSetUnSuccess = "Credit set is  UnSuccessfully.";
        public const string DistributorDeleteUnSuccess = "Distributor Deleted UnSuccessfully.";
        public const string DistributorDeleteSuccess = "Distributor deleted successfully.";
        public const string DistributorAddOrEditUnSuccess = "Failed To Add Or Edit The Distributor.";

        //payment       
        public const string PaymentAdded = "Payment is Added Successfully.";
        public const string PaymnetUnSuccess = "Payment is  UnSuccessfully.";
        public const string PaymentDeleteUnSuccess = "Payment Deleted UnSuccessfully.";
        public const string PaymentDeleteSuccess = "Payment deleted successfully.";
        public const string PaymentAddOrEditUnSuccess = "Failed To Add Or Edit  Payment.";

        //priceset for distributor       
        public const string DistributorPriceSaveSuccess = "Distributor price saved successfully.";
        public const string DistributorPriceSaveFailed = "Failed to save distributor price.";
        public const string DistributorPriceNotFound = "Distributor price record not found.";
        public const string DistributorPriceSetNotFound = "Please Enter Price";


        //dealer approve
        public const string ApproveSaveSuccess = "Dealer Approve saved successfully.";
        public const string ApproveSaveFailed = "Failed to save dealer approve.";

        //dealer approve
        public const string RejectSaveSuccess = "Dealer Reject saved successfully.";
        public const string RejectSaveFailed = "Failed to save Dealer Reject.";


        public const string SomeError = "Somthing went wrong";

        //Stock remove 
        public const string StockRemoveSuccess = "Stock removed successfully.";
        public const string StockNotFound = "Stock Not Found.";
        public const string EnterValidData = "Please Enter ValidData.";
        //invoice
        public const string InvoiceUpdateSuccess = "Invoice is Update Successfully.";
        public const string InvoiceUpdateUnSuccess = "Invoice is Update UnSuccessfully.";
        public const string InvoiceDownloadSuccess = "Invoice Download Successfully.";
        public const string InvoiceNotExist = "Invoice Not Found.";
        public const string InvoiceDownloadUnSuccess = "Invoice Download UnSuccessfully.";

        //CommonImageURLPrefix
        public const string CommonImageURLPrefix = "https://drive.google.com/thumbnail?id=";

        public const string DealerProfileBillingDetailsUpdatedSuccess = "Dealer Billing Details updated successfully!";
        public const string DealerProfileContactInfoSuccess = "Dealer Profile contact details updated successfully";

    }

}
