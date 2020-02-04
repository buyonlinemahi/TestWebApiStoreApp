using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineStore.Domain.Model
{
    public class Coupon
    {
        [Key]
        public int CouponID { get; set; }
        public string CouponCode { get; set; }
        public string CouponComment { get; set; }
        public bool IsEnable { get; set; }
        public int DiscountTypeID { get; set; }
        public int DiscountAmount { get; set; }
        public string ActiveFromDate { get; set; }
        public string ActiveTillDate { get; set; }
        public int SubtotalRangeBegin { get; set; }
        public int SubtotalRangeEnd { get; set; }
        public int NumberOfUsers { get; set; }
        public string Message { get; set; }
    }
}
