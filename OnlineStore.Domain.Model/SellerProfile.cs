using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineStore.Domain.Model
{
    public class SellerProfile
    {
        [Key]
        public int SellerProfileID { get; set; }
        public string BusinessTitle { get; set; }
        public string CompanyName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public int NumberOfProducts { get; set; }
        public string BrandName { get; set; }
        public Int64 MerchantID { get; set; }
        public int UserID { get; set; }
        public string EmailID { get; set; }
        public string Message { get; set; }
    }
}
