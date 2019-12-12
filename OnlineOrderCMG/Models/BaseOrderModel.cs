using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrderCMG.Models
{
    public class BaseOrderModel
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string OrderNumber { get; set; }
        public string Quantity { get; set; }
        public string Details { get; set; }
        public string Status { get; set; }
        public float Amount { get; set; }
        public string Currency { get; set; }
        public string ShippingMethod { get; set; }
        public string CustomerDebitDate { get; set; }
        public string PaymentWorkflow { get; set; }
        public string Channel { get; set; }
        public string StoreSKU { get; set; }
        public string Reason { get; set; }
        public string OfferSKU { get; set; }
        public string OfferState { get; set; }
        public string OrderLineNo { get; set; }
        public float UnitPrice { get; set; }
        public float ShippingPrice { get; set; }
        public float ShippingTotalAmount { get; set; }
        public float OrderTotalAmount { get; set; }
        public float Commission { get; set; }
        public float CommissionValue { get; set; }
        public float AmountReimbursedToStore { get; set; }
        public float PriceAdditionalInformation { get; set; }
        public float CommissionTaxRate { get; set; }
        public DateTime AcceptanceDate { get; set; }
        public DateTime ShippingDeadline { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string ShippingCompany { get; set; }
        public string TrackingNumber { get; set; }
        public string TrackingURL { get; set; }
        public string ShippingAddressCivility { get; set; }
        public string ShippingAddressFirstName { get; set; }
        public string ShippingAddressLastName { get; set; }
        public string ShippingAddressCompany { get; set; }
        public string ShippingAddressStreet1 { get; set; }
        public string ShippingAddressStreet2 { get; set; }
        public string ShippingAddressComplementary { get; set; }
        public string ShippingAddressZip { get; set; }
        public string ShippingAddressCity { get; set; }
        public string ShippingAddressState { get; set; }
        public string ShippingAddressCountry { get; set; }
        public string ShippingAddressPhone { get; set; }
        public string ShippingAddressPhone2 { get; set; }
        public string ShippingAddressAdditionalInformation { get; set; }
        public string ShippingAddressInternalAdditionalInformation { get; set; }
        public string BillingAddressCivility { get; set; }
        public string BillingAddressFirstName { get; set; }
        public string BillingAddressLastName { get; set; }
        public string BillingAddressCompany { get; set; }
        public string BillingAddressStreet1 { get; set; }
        public string BillingAddressStreet2 { get; set; }
        public string BillingAddressComplementary { get; set; }
        public string BillingAddressZip { get; set; }
        public string BillingAddressCity { get; set; }
        public string BillingAddressState { get; set; }
        public string BillingAddressCountry { get; set; }
        public string BillingAddressPhone { get; set; }
        public string BillingAddressPhone2 { get; set; }
        public string PaymentMethod { get; set; }
        public string LeadTimeToShip { get; set; }
        public string DropshipInvoiceNumber { get; set; }
        public string SubDistrict { get; set; }
        public int ShipmentWeight { get; set; }
        public string DeliveryInstruction { get; set; }
        public string CustomerReceiptAddress { get; set; }
        public string CustomerReceiptSubdistrict { get; set; }
        public string CustomerReceiptProvince { get; set; }
        public string CustomerReceiptCity { get; set; }
        public string CustomerReceiptPostal { get; set; }
        public string MarketplaceType { get; set; }
        public string DeliveryType { get; set; }
        public string Carrier { get; set; }
        public string PickUpInstruction { get; set; }
        public string PreferredPickUpTime { get; set; }
        public string OperatorInternalID { get; set; }
        public string SalesChannel { get; set; }
        public string OriginAddress { get; set; }
        public string OriginSubdistrict { get; set; }
        public string OriginationAddressDistrict { get; set; }
        public string OriginProvince { get; set; }
        public string OriginPostal { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string CustomerThe1 { get; set; }
        public string CustomerReceiptCompanyName { get; set; }
        public string CustomerReceiptTaxID { get; set; }
        public string CustomerReceiptBranchID { get; set; }
        public int ProductWeight { get; set; }
        public float CustomerPaidPrice { get; set; }
        public float CollectibleAmount { get; set; }
        public float ProductTaxAmount { get; set; }
        public float ShippingTaxAmount { get; set; }
        public float TotalOrderTaxes { get; set; }
        public float TotalShippingTaxes { get; set; }



        //CREATE TABLE ONLINE_ORDER(
        //    Id int ,
        //    DateCreated datetime,
        //    OrderNumber nvarchar(128),
        //   Quantity nvarchar(128),
        //   Details nvarchar(128),
        //   Status nvarchar(128),
        //   Amount float,
        //   Currency nvarchar(128),
        //   ShippingMethod nvarchar(128),
        //   CustomerDebitDate nvarchar(128),
        //   PaymentWorkflow nvarchar(128),
        //   Channel nvarchar(128),
        //   StoreSKU nvarchar(128),
        //   Reason nvarchar(128),
        //   OfferSKU nvarchar(128),
        //   OfferState nvarchar(128),
        //   OrderLineNo nvarchar(128),
        //   UnitPrice float,
        //   ShippingPrice float,
        //   ShippingTotalAmount float,
        //   OrderTotalAmount float,
        //   Commission float,
        //   CommissionValue float,
        //   AmountReimbursedToStore float,
        //   PriceAdditionalInformation float,
        //   CommissionTaxRate float,
        //   AcceptanceDate datetime,
        //   ShippingDeadline datetime,
        //   ShippingDate datetime,
        //   ReceivedDate datetime,
        //   ShippingCompany nvarchar(128),
        //   TrackingNumber nvarchar(128),
        //   TrackingURL nvarchar(MAX),
        //   ShippingAddressCivility nvarchar(128),
        //   ShippingAddressFirstName nvarchar(128),
        //   ShippingAddressLastName nvarchar(128),
        //   ShippingAddressCompany nvarchar(128),
        //   ShippingAddressStreet1 nvarchar(128),
        //   ShippingAddressStreet2 nvarchar(128),
        //   ShippingAddressComplementary nvarchar(128),
        //   ShippingAddressZip nvarchar(128),
        //   ShippingAddressCity nvarchar(128),
        //   ShippingAddressState nvarchar(128),
        //   ShippingAddressCountry nvarchar(128),
        //   ShippingAddressPhone nvarchar(128),
        //   ShippingAddressPhone2 nvarchar(128),
        //   ShippingAddressAdditionalInformation nvarchar(128),
        //   ShippingAddressInternalAdditionalInformation nvarchar(128),
        //   BillingAddressCivility nvarchar(128),
        //   BillingAddressFirstName nvarchar(128),
        //   BillingAddressLastName nvarchar(128),
        //   BillingAddressCompany nvarchar(128),
        //   BillingAddressStreet1 nvarchar(128),
        //   BillingAddressStreet2 nvarchar(128),
        //   BillingAddressComplementary nvarchar(128),
        //   BillingAddressZip nvarchar(128),
        //   BillingAddressCity nvarchar(128),
        //   BillingAddressState nvarchar(128),
        //   BillingAddressCountry nvarchar(128),
        //   BillingAddressPhone nvarchar(128),
        //   BillingAddressPhone2 nvarchar(128),
        //   PaymentMethod nvarchar(128),
        //   LeadTimeToShip nvarchar(128),
        //   DropshipInvoiceNumber nvarchar(128),
        //   SubDistrict nvarchar(128),
        //   ShipmentWeight int,
        //   DeliveryInstruction nvarchar(128),
        //   CustomerReceiptAddress nvarchar(128),
        //   CustomerReceiptSubdistrict nvarchar(128),
        //   CustomerReceiptProvince nvarchar(128),
        //   CustomerReceiptCity nvarchar(128),
        //   CustomerReceiptPostal nvarchar(128),
        //   MarketplaceType nvarchar(128),
        //   DeliveryType nvarchar(128),
        //   Carrier nvarchar(128),
        //   PickUpInstruction nvarchar(128),
        //   PreferredPickUpTime nvarchar(128),
        //   OperatorInternalID nvarchar(128),
        //   SalesChannel nvarchar(128),
        //   OriginAddress nvarchar(128),
        //   OriginSubdistrict nvarchar(128),
        //   OriginationAddressDistrict nvarchar(128),
        //   OriginProvince nvarchar(128),
        //   OriginPostal nvarchar(128),
        //   MobilePhoneNumber nvarchar(128),
        //   CustomerThe1 nvarchar(128),
        //   CustomerReceiptCompanyName nvarchar(128),
        //   CustomerReceiptTaxID nvarchar(128),
        //   CustomerReceiptBranchID nvarchar(128),
        //   ProductWeight int,
        //   CustomerPaidPrice float,
        //   CollectibleAmount float,
        //   ProductTaxAmount float,
        //   ShippingTaxAmount float,
        //   TotalOrderTaxes float,
        //   TotalShippingTaxes float
        //)



    }
}
