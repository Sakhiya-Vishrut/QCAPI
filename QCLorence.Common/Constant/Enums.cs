using System.ComponentModel;
using System.Reflection;

namespace QCLorence.Common
{
    public static class EnumExtensions
    {
        public static string GetEnumDescription(this Enum enumValue)
        {
            FieldInfo? fi = enumValue.GetType().GetField(enumValue.ToString());

            if (fi == null)
                return enumValue.ToString();

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return enumValue.ToString();
        }
    }

    public class Enums
    {
        public static string GetStatusCodeString(Enums.StatusCode code)
        {
            if (code == Enums.StatusCode.Ok)
                return "Ok";
            else if (code == Enums.StatusCode.BadRequest)
                return "Bad Request";
            else if (code == Enums.StatusCode.NotFound)
                return "Not Found";
            else if (code == Enums.StatusCode.ServerError)
                return "Server Error";
            else if (code == Enums.StatusCode.AccessDenied)
                return "Access Denied";
            else if (code == Enums.StatusCode.NotAllowed)
                return "Not Allowed";
            else if (code == Enums.StatusCode.Conflict)
                return "Conflict";
            else if (code == Enums.StatusCode.Unauthorized)
                return "Token Expired";

            return "";
        }
        public static string GetEnumDescription(Enum value)
        {
            try
            {
                if (value.GetHashCode() == 0)
                    return "";

                FieldInfo fi = value.GetType().GetField(value.ToString());

                DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes != null && attributes.Length > 0)
                    return attributes[0].Description;
                else
                    return value.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string GetEnumDescription<TEnum>(int value)
        {
            return GetEnumDescription((Enum)(object)((TEnum)(object)value));
        }


        public enum TicketCode
        {
            [Description("KD")]
            KD = 1
        }

        public enum ComplainType
        {
            WorkingComplain = 1,
            CompleteComplain = 2
        }

        public enum ComplainStatus
        {
            Created = 1,
            ChangePlumber = 2,
            Completed = 3
        }
        public enum flag
        {
            purchase = 1,
            order = 2
        }
        public enum PasswordChanges
        {
            forgotpasswordafterupdate = 1,
            changepasswordafterupdate = 2
        }
        public enum DetectedBy
        {
            [Description("WordPress")]
            WordPress = 1,
            [Description("API")]
            API = 2,
            [Description("Web Scraping")]
            WebScraping = 3,
            [Description("Admin Created")]
            AdminCreated = 4
        }

        public enum LogBy
        {
            [Description("DomainByApi")]
            DomainByApi = 1,
            [Description("ErrorByApi")]
            ErrorByApi = 2,
            [Description("ErrorByScrapping")]
            ErrorByScrapping = 3,
            [Description("RebotError")]
            RebotError = 4
        }
        public enum DomainStatus
        {
            [Description("Pending")]
            Pending = 1,
            [Description("Completed")]
            Completed = 2
        }

        public enum TicketStatus
        {
            [Description("Pending")]
            Pending = 1,
            [Description("Working")]
            Working = 2,
            [Description("Completed")]
            Completed = 3,
            [Description("Reject")]
            Reject = 4,
            [Description("Revert")]
            Revert = 5
        }

        public enum ErrorDetectedBy
        {
            [Description("Web")]
            Web = 1,
            [Description("API")]
            API = 2
        }

        public enum ErrorStatus
        {
            [Description("Solved")]
            Solved = 1,
            [Description("NotSolved")]
            NotSolved =2
        }
        public enum ChangeFrequency
        {
            Always,
            Hourly,
            Daily,
            Weekly,
            Monthly,
            Yearly,
            Never
        }

        public enum StatusCode
        {
            Ok = 200,
            BadRequest = 400,
            NotFound = 404, // also use for data not found
            ServerError = 500,
            AccessDenied = 403,
            NotAllowed = 405,
            Conflict = 409,
            Unauthorized = 401
        }

        public enum QCLorenceScheduleType
        {
            SendNow = 1,
            ScehduledDate = 2
        }

        public enum UserCachingTime
        {
            VeryShort = 2,
            SemiShort = 5,
            Short = 10,
            Medium = 30,
            Long = 60,
            SemiLong = 90,
            VeryLong = 180
        }

        public enum UserType
        {
            [Description("Admin")]
            Admin = 1,
            [Description("Distributor")]
            Distributor = 2,
            [Description("Dealer")]
            Dealer = 3
        }

        
        public enum UserStatus
        {
            [Description("Active")]
            Active = 1,
            [Description("InActive")]
            InActive = 2,
            [Description("Suspended")]
            Suspended = 3
        }

        public enum EmailSmsTemplate
        {
            Login = 1,
            Registartion = 2,
            ForgotPassword = 3,
            RedeemAmountOtp = 4,
            AdminCreateNewShopKeeper = 5,
            PurchasedQCLorenceReceiver = 6,
            PurchasedQCLorenceSender = 7,
            SupportPhysicalCardPurchase = 8,
            SupportQCLorenceCheckBalance = 9,
            SupportPhysicalCardLessInventory = 10,
            PartnerCreateVirtualCard = 11,
            VirtualCreditCardRequest = 12,
            SupportQCLorencePurchase = 13,
            SupportActivateQCLorence = 14,
            ApiRegistration = 15,
            ApiTokenChange = 16
        }
        public enum GridPageSize
        {
            [Description("10")]
            Ten = 10,
            [Description("20")]
            Twenty = 20,
            [Description("30")]
            Thirty = 30,
            [Description("50")]
            Fifty = 50,
            [Description("100")]
            Hundred = 100
        }

        public enum ResizeType
        {
            LongestSide,
            Width,
            Height
        }

        public enum MailType
        {
            DispatchDate = 1,
            DeliveredDate = 2
        }

        public enum CardStatus
        {
            [Description("Active")]
            Active = 1,
            [Description("InActive")]
            InActive = 2,
            [Description("Suspended")]
            Suspended = 3,
            [Description("PaymentInProgress")]
            PaymentInProgress = 4,
            [Description("PaymentCancelled")]
            PaymentCancelled = 5
        }

        public enum BulkCardRequestStatus
        {
            [Description("Requested")]
            Requested = 1,
            [Description("Acknowledge By Admin")]
            AcknowledgeByAdmin = 2,
            [Description("Preparing Gift Card")]
            PreparingQCLorence = 3,
            [Description("Shipped")]
            Shipped = 4,
            [Description("Completed")]
            Completed = 5,
            [Description("Rejected")]
            Rejected = 6,
            [Description("Cancelled")]
            Cancelled = 7,
        }

        public enum ShopKeeperBalanceWithdrawalRequestStatus
        {
            [Description("Requested")]
            Requested = 1,
            [Description("Cancel")]
            Cancel = 2,
            [Description("Approve")]
            Approve = 3,
            [Description("Reject")]
            Reject = 4
        }

        public enum TransactionType
        {
            [Description("Purchase")]
            Purchase = 1,
            [Description("Credit")]
            Credit = 2,
            [Description("Debit")]
            Debit = 3,
            [Description("Credit For Activation")]
            CreditForActivation = 4,
            [Description("Credit For Sell Card")]
            CreditForSellCard = 5
        }

        public enum OrderStatusType
        {
            [Description("NewOrders")]
            NewOrders = 1,
            [Description("ConfirmedOrders")]
            ConfirmedOrders = 2,
            [Description("DispatchedOrders")]
            DispatchedOrders = 3,
            [Description("DeliveredOrders")]
            DeliveredOrders = 4,
            [Description("PendingOrders")]
            PendingOrders = 5,
            [Description("CancelOrders")]
            CancelOrders = 6
        }

        public enum QCLorenceType
        {
            Digital = 1,
            Physical = 2
        }

        public enum QCLorenceSendMethod
        {
            ByEmail = 1,
            ByPhone = 2
        }

        public enum PhysicalQCLorenceType
        {
            Anonymous = 1,
            AddReceipient = 2
        }

        public enum PaymentMethod
        {
            Stripe = 1
        }

        public enum PaymentStatus
        {
            [Description("Unpaid")]
            Unpaid = 1,
            [Description("Partially Paid")]
            PartiallyPaid = 2,
            [Description("Paid")]
            Paid = 3
        }

        public enum CardHistoryOperation
        {
            Insert = 1,
            Update = 2,
            Delete = 3,
            PaymentApproved = 4,
            PaymentCanceled = 5
        }

        public enum BankAccountType
        {
            [Description("CHECKING")]
            Checking = 1,
            [Description("BUSINESS")]
            Business = 2,
            [Description("SAVINGS")]
            Savings = 3
        }

        public enum QCLorenceBatchDetailLogStatus
        {
            [Description("New Generated")]
            NewGenerated = 1,
            [Description("Assigned To Partner")]
            AssignedToPartner = 2,
            [Description("Assigned To Customer")]
            AssignedToCustomer = 3
        }

        public enum Access
        {
            [Description("No Access")]
            NoAccess = 1,
            [Description("View Only")]
            isView = 2,
            [Description("Full Access")]
            All = 3
        }
        public enum PageValueById
        {
            Manage_QCLorence=1,
            Manage_Partner=2,
            Manage_User=3,
            Report=4,
            Statistics= 5,
            Physical_QCLorence_Request = 6,
            Partner_Bulk_Buy_Request = 7,
            Partner_Balance_Withdrawal_Request = 8,
            Manage_VirtualVisaCard = 9
        }

        public enum VirtualCreditCardRequestStatus
        {
            [Description("Requested")]
            Requested = 1,
            [Description("Approved")]
            Approved = 2,
            [Description("Rejected")]
            Rejected = 3
        }

        public enum ManageCalculation
        {
            [Description("CreateVCCDeduction")]
            CreateVCCDeduction = 1,
        }

        //API Project - Status Code
        public enum QCLorenceStatusCode
        {
            ModelStateError = -1,
            Ok = 200,
            BadRequest = 400,
            NotFound = 404, // also use for data not found
            ServerError = 500,
            UnAuthorized = 401,
            AccessDenied = 403,
            NotAllowed = 405,
            Conflict = 409
        }
    }
}
