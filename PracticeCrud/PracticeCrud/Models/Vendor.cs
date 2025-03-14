namespace PracticeCrud.Models
{
    public class Vendor
    {

        public required int BusinessEntityID { get; set; }
        public required String AcountNumber { get; set; }
        public required String Name { get; set; }
        public required int CreditRating { get; set; }
        public required int PreferredVendorStatus { get; set; }
        public required int ActiveFlag { get; set; }
        public required int PurchasingWebServiceURL { get; set; }
        public required DateTime ModifiedDate { get; set; }
        

    }
}
